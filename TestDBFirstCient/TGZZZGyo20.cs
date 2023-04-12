/// <summary>
/// プロジェクト:お客さまポータルサイト
/// 機能        :共通処理
/// クラス名    : 安心サービス加入状態判定（契約単位）
/// 作成日      :2023/03/15
/// Copyright 2021 TOGIS LIMITED
/// </summary>

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDBFirstCient
{
    public class TGZZZGyo20 : TGZZZGyo
    {
        public TGZZZGyo20(TohogasDataContext context) : base(context)
        {
        }
        public class Gyo20Accept1
        {
            // 適用終了年月日          End date of application
            public string TYS_YMD { get; set; }
            // サービス種別           Service type
            public string SBS_SYBT { get; set; }
            // 契約種別               Service type
            public string KIYK_SYBT { get; set; }
            // 料金種別               Charge type
            public string RYSYT { get; set; }
            // 契約状態              Contract Status
            public string KIYK_ZYUTI { get; set; }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contractNumber">契約番号</param>
        /// <param name="memberId">会員ID</param>
        /// <param name="contractCheckFlag">約款チェックフラグ</param>
        /// <param name="contractSafetyServiceSubscriptionStatus">契約の安心サービス加入状態</param>
        /// <returns>正常／異常</returns>
        public int DeterminationOfSafetyServiceSubscriptionStatus(string contractNumber, string memberId, bool contractCheckFlag, out int contractSafetyServiceSubscriptionStatus)
        {

            contractSafetyServiceSubscriptionStatus = 0;

            try
            {
                // 開始ログを出力
                TGZZZLog.StartLog();
                Gyo20Accept1 gyo20Accept1;
                P_ANSN_SBS_MSKM_UKTK p_ANSN_SBS_MSKM_UKTK;
                C_ANSN_SBS_KIYK c_ANSN_SBS_KIYK;
                P_ANSN_SBS_KIIN_KIYK_HMTK p_ANSN_SBS_KIIN_KIYK_HMTK;

                string nowDateYMD = DateTime.Now.ToString("yyyyMMdd");

                string recordDate;
                int result;
                string safeServiceContractPossibleFlag;
                // 1）契約情報を取得する。
                result = DeterminationOfSafetyServiceSubscriptionStatus(contractNumber, nowDateYMD, out gyo20Accept1);
                if (result != TGZZZConstants.SUCCEESS)
                    return result;

                if (gyo20Accept1.KIYK_ZYUTI == "1")
                    recordDate = nowDateYMD;
                else
                    recordDate = gyo20Accept1.TYS_YMD;

                TGZZZLog.ZacLog("Result :" + result + ", baseDate : " + recordDate);


                // 2)「対象外」のチェックを行う。
                if (contractCheckFlag)
                {
                    // ②安心サービス対象契約判定処理を行う。 ②To perform safety service object contract determination processing.
                    result = ContractDeterminationProcessingForSecurityServices(gyo20Accept1.SBS_SYBT, gyo20Accept1.KIYK_SYBT,
                            gyo20Accept1.RYSYT, nowDateYMD, recordDate, out safeServiceContractPossibleFlag);
                    if (result == TGZZZConstants.ABNORMAL || result == TGZZZConstants.NOTFOUND)
                        return TGZZZConstants.ABNORMAL;

                    if (safeServiceContractPossibleFlag == "0")
                    {
                        contractSafetyServiceSubscriptionStatus = 0;
                        return TGZZZConstants.SUCCEESS;
                    }
                }
                // 1338. 引数の約款チェックフラグが"false"の場合 処理を継続する。

                // result = DetermineASafetyServiceSubscriptionState(contractNumber, nowDateYMD, out p_ANSN_SBS_MSKM_UKTK, out c_ANSN_SBS_KIYK, out p_ANSN_SBS_KIIN_KIYK_HMTK, out contractSafetyServiceSubscriptionStatus);
                TGZZZLog.ZacLog("安心サービス加入状態の判定を行う。To determine a safety service subscription state.");

                contractSafetyServiceSubscriptionStatus = 0;
                result = GetInformationOnReceivingApplicationsForSafetyService(contractNumber, out p_ANSN_SBS_MSKM_UKTK);
                result = GetSafetyServiceContractInformation(contractNumber, nowDateYMD, out c_ANSN_SBS_KIYK);
                result = GetSafetyServiceMemberContractLinkingInformation(contractNumber, out p_ANSN_SBS_KIIN_KIYK_HMTK);
                int subscriptionStatus; // 0 not Subscribe, 1, in Progress
                                        //1350. ★3-1) When the safety service member contract linking information acquired in is null
                if (p_ANSN_SBS_KIIN_KIYK_HMTK == null)
                {
                    // 1351. Judgment is performed based on the safety service contract information.
                    // 1352a & 1355a. ★3 - 1) The safety service contract information obtained in is not null and is also safety service contract information.
                    if (c_ANSN_SBS_KIYK != null)
                    {
                        if (c_ANSN_SBS_KIYK.MUSKMZCTGKIINID == contractNumber) // 1352b. When the CTG member ID matches the member ID of the argument at the time of application
                        {
                            // 1353. It is determined that the subscription is in progress, and the processing of 3-3）is performed.
                            subscriptionStatus = 1;
                            result = DetermineWhetherAnApplicationForASafetyServiceContractIsBeingAccepted(subscriptionStatus, p_ANSN_SBS_MSKM_UKTK, c_ANSN_SBS_KIYK, out contractSafetyServiceSubscriptionStatus);
                        }
                        else // 1355b. When the CTG member ID does not match the member ID of the argument at the time of application
                        {
                            contractSafetyServiceSubscriptionStatus = 1; // 1356. Set the safety service subscription status to 「"1"：In process」and return the normal value (0).
                            return TGZZZConstants.SUCCEESS;
                        }
                    }
                    else // 1358. ★3-1) If the safety service contract information obtained in is null
                    {
                        // 1359. It is determined that it is not subscribed, and the processing of 3-3）is performed.
                        subscriptionStatus = 0;
                        result = DetermineWhetherAnApplicationForASafetyServiceContractIsBeingAccepted(subscriptionStatus, p_ANSN_SBS_MSKM_UKTK, c_ANSN_SBS_KIYK, out contractSafetyServiceSubscriptionStatus);
                    }
                }
                else // 1361a && 1364a. ★3-1) The safety service member contract linking information acquired in is not null, and the safety service member contract linking information.
                {
                    if (p_ANSN_SBS_KIIN_KIYK_HMTK.KIIN_ID == contractNumber) // 1361b. When the member ID matches the member ID of the argument
                    {
                        // 1362. It is determined that the subscription is in progress, and the processing of 3-3） is performed.
                        subscriptionStatus = 1;
                        result = DetermineWhetherAnApplicationForASafetyServiceContractIsBeingAccepted(subscriptionStatus, p_ANSN_SBS_MSKM_UKTK, c_ANSN_SBS_KIYK, out contractSafetyServiceSubscriptionStatus);
                    }
                    else // 1364b. When the member ID does not match the member ID of the argument
                    {
                        contractSafetyServiceSubscriptionStatus = 1; // 1365. Set the safety service subscription status to 「"1"：In process」and return the normal value (0).
                        return TGZZZConstants.SUCCEESS;
                    }

                    //
                }
                return TGZZZConstants.SUCCEESS;
            }
            catch (Exception e)
            {
                // 汎用ログ、イベントログに出力して、異常復帰する
                TGZZZLog.WriteLogFile_ERR(TGZZZConstants.LOG_ERROR, "", "", e);
                TGZZZLog.WriteEventLog_ERR(TGZZZConstants.EVENT_LOG_ERROR);
                TGZZZLog.ZacLog("error: " + e.Message);

                return TGZZZConstants.ABNORMAL;
            }
            finally
            {
                // 終了ログを出力
                TGZZZLog.EndLog();
            }

            // 正常復帰
            return TGZZZConstants.SUCCEESS;
        }
        // 1299. 安心サービス加入状態判定（契約単位）Determination of safety service subscription status (per contract)
        public int DeterminationOfSafetyServiceSubscriptionStatus(string contractNumber, string nowDateYMD, out Gyo20Accept1 gyo20Accept1)
        {
            gyo20Accept1 = new Gyo20Accept1();
            TGZZZLog.ZacLog("(1) DeterminationOfSafetyServiceSubscriptionStatus");

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("select ");
            sbSql.Append(" TYS_YMD");
            sbSql.Append(" , SBS_SYBT ");
            sbSql.Append(" , KIYK_SYBT");
            sbSql.Append(" , RYSYT");
            sbSql.Append(" , KIYK_ZYUTI ");
            sbSql.Append(" from C_KIYK");
            sbSql.Append(" with (nolock)");
            sbSql.Append(" where KIYK_NO = @p0");
            sbSql.Append(" and TYK_YMD <= @p1");
            sbSql.Append(" and RNR_SKZY_FLG = '0'");
            sbSql.Append(" order by");
            sbSql.Append(" TYK_YMD desc");
            sbSql.Append(" , KIYK_RNBN desc");
            sbSql.Append(" option(maxdop 1);");
            SqlParameter p0 = new SqlParameter("@p0", System.Data.SqlDbType.Char);
            SqlParameter p1 = new SqlParameter("@p1", System.Data.SqlDbType.Char);

            p0.Value = contractNumber;
            p1.Value = nowDateYMD;

            var rec = context.Database.SqlQuery<Gyo20Accept1>
            (sbSql.ToString()
            , p0, p1).ToList();

            // 取得件数が0件の場合
            if (rec.Count == 0)
                return TGZZZConstants.NOTFOUND;
            else
                gyo20Accept1 = rec[0];

            foreach (Gyo20Accept1 gyo20Accept in rec)
            {
                TGZZZLog.ZacLog(gyo20Accept.TYS_YMD + "-" + gyo20Accept.SBS_SYBT + "-" +
                    gyo20Accept.KIYK_SYBT + "-" + gyo20Accept.RYSYT + "-" + gyo20Accept.KIYK_ZYUTI);
            }

            return TGZZZConstants.SUCCEESS;

        }

        //②安心S契約可能判定フラグ取得処理
        public int ContractDeterminationProcessingForSecurityServices(string serviceType, string contractType, string rateType, string nowDateYMD, string recordDate, out string safeServiceContractPossibleFlag)
        {
            TGZZZLog.ZacLog("(2) ContractDeterminationProcessingForSecurityServices - ②安心S契約可能判定フラグ取得処理");

            StringBuilder sbSql = new StringBuilder();
            safeServiceContractPossibleFlag = string.Empty;
            sbSql.Append("select ");
            sbSql.Append(" ANSN_SBS_KIYK_KNU_FLG");
            sbSql.Append(" from C_SBS_CD_MST");
            sbSql.Append(" with (nolock)");
            sbSql.Append(" where SBS_SYBT = @p0");
            sbSql.Append(" and KIYK_SYBT = @p1");
            sbSql.Append(" and RYSYT = @p2");
            sbSql.Append(" and TYK_YMD <= @p3");
            sbSql.Append(" and TYS_YMD > @p4");
            sbSql.Append(" and RNR_SKZY_FLG = '0'");
            sbSql.Append(" option(maxdop 1);");

            SqlParameter p0 = new SqlParameter("@p0", System.Data.SqlDbType.Char);
            SqlParameter p1 = new SqlParameter("@p1", System.Data.SqlDbType.Char);
            SqlParameter p2 = new SqlParameter("@p2", System.Data.SqlDbType.Char);
            SqlParameter p3 = new SqlParameter("@p3", System.Data.SqlDbType.Char);
            SqlParameter p4 = new SqlParameter("@p4", System.Data.SqlDbType.Char);

            p0.Value = serviceType;
            p1.Value = contractType;
            p2.Value = rateType;
            p3.Value = nowDateYMD;
            p4.Value = recordDate;

            var rec = context.Database.SqlQuery<string>
            (sbSql.ToString()
            , p0, p1, p2, p3, p4).ToList();

            // 取得件数が0件の場合
            if (rec.Count == 0)
                return TGZZZConstants.NOTFOUND;
            else
                safeServiceContractPossibleFlag = rec[0];
            TGZZZLog.ZacLog("safeServiceContractPossibleFlag :  " + safeServiceContractPossibleFlag);

            return TGZZZConstants.SUCCEESS;
        }

        // 安心サービス加入状態の判定を行う。To determine a safety service subscription state.
        /*public int DetermineASafetyServiceSubscriptionState(string contractNumber, string nowDateYMD, 
            out P_ANSN_SBS_MSKM_UKTK p_ANSN_SBS_MSKM_UKTK, out C_ANSN_SBS_KIYK c_ANSN_SBS_KIYK, out P_ANSN_SBS_KIIN_KIYK_HMTK p_ANSN_SBS_KIIN_KIYK_HMTK, out int contractSafetyServiceSubscriptionStatus)
        {
            
        }*/
        // (3) 安心サービス申込受付情報取得DB処理 DB processing for obtaining information on receiving applications for safety service
        public int GetInformationOnReceivingApplicationsForSafetyService(string contractNumber, out P_ANSN_SBS_MSKM_UKTK pAnsnSbsMskmUktk)
        {
            TGZZZLog.ZacLog("(3) GetInformationOnReceivingApplicationsForSafetyService");

            pAnsnSbsMskmUktk = new P_ANSN_SBS_MSKM_UKTK();
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("select *");
            sbSql.Append(" from P_ANSN_SBS_MSKM_UKTK");
            sbSql.Append(" with (nolock)");
            sbSql.Append(" where KIYK_NO = @p0");
            sbSql.Append(" and RNR_SKZY_FLG = '0'");
            sbSql.Append(" order by MSM_YMD desc");
            sbSql.Append(" option(maxdop 1);");

            SqlParameter p0 = new SqlParameter("@p0", System.Data.SqlDbType.Char);
            p0.Value = contractNumber;

            var rec = context.Database.SqlQuery<P_ANSN_SBS_MSKM_UKTK>
            (sbSql.ToString()
            , p0).ToList();

            if (rec.Count>0)
            {
                pAnsnSbsMskmUktk = rec.First();
            }

            foreach (P_ANSN_SBS_MSKM_UKTK p_ANSN_SBS_MSKM_UKTK in rec)
            {
                TGZZZLog.ZacLog("P_ANSN_SBS_MSKM_UKTK.KIYK_NO : " + p_ANSN_SBS_MSKM_UKTK.KIYK_NO + ", RNR_SKZY_FLG : " + p_ANSN_SBS_MSKM_UKTK.RNKE_KYK_FLG + ", MSM_YMD" +
                    p_ANSN_SBS_MSKM_UKTK.MSM_YMD);
            }
            return TGZZZConstants.SUCCEESS;
        }

        // (4)安心サービス契約情報取得DB処理 Safety Service Contract Information Acquisition DB Processing
        public int GetSafetyServiceContractInformation(string contractNumber, string nowDateYMD, out C_ANSN_SBS_KIYK cAnsnSbsKiyk)
        {
            TGZZZLog.ZacLog("(4) GetSafetyServiceContractInformation");

            cAnsnSbsKiyk = new C_ANSN_SBS_KIYK();
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("select *");
            sbSql.Append(" from C_ANSN_SBS_KIYK");
            sbSql.Append(" with (nolock)");
            sbSql.Append(" where ANSN_SBS_KIYK_NO = @p0");
            sbSql.Append(" and TYK_YMD <= @p1");
            sbSql.Append(" and TYS_YMD >= @p1");
            sbSql.Append(" and RNR_SKZY_FLG = '0'");
            sbSql.Append(" order by TYK_YMD desc");
            sbSql.Append(" option(maxdop 1);");

            SqlParameter p0 = new SqlParameter("@p0", System.Data.SqlDbType.Char);
            SqlParameter p1 = new SqlParameter("@p1", System.Data.SqlDbType.Char);

            p0.Value = contractNumber;
            p1.Value = nowDateYMD;

            var rec = context.Database.SqlQuery<C_ANSN_SBS_KIYK>
            (sbSql.ToString()
            , p0, p1).ToList();

            if (rec.Count > 0)
            {
                cAnsnSbsKiyk = rec.First();

                foreach (C_ANSN_SBS_KIYK c_ANSN_SBS_KIYK in rec)
                {
                    TGZZZLog.ZacLog("C_ANSN_SBS_KIYK.ANSN_SBS_KIYK_NO : " + c_ANSN_SBS_KIYK.ANSN_SBS_KIYK_NO + ", TYK_YMD : " + c_ANSN_SBS_KIYK.TYK_YMD
                        + ", TYS_YMD : " + c_ANSN_SBS_KIYK.TYS_YMD + ", RNR_SKZY_FLG : " + c_ANSN_SBS_KIYK.RNR_SKZY_FLG);
                }
            }
            else
            {
                TGZZZLog.ZacLog("No result");
            }

            return TGZZZConstants.SUCCEESS;
        }
        // (5) 安心サービス会員契約紐づけ情報取得DB処理 Safety service member contract linking information acquisition DB processing
        public int GetSafetyServiceMemberContractLinkingInformation(string contractNumber, out P_ANSN_SBS_KIIN_KIYK_HMTK pAnsnSbsKiinKiykHmtk)
        {
            TGZZZLog.ZacLog("(5) GetSafetyServiceMemberContractLinkingInformation");

            pAnsnSbsKiinKiykHmtk = new P_ANSN_SBS_KIIN_KIYK_HMTK();
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("select * ");
            sbSql.Append(" from P_ANSN_SBS_KIIN_KIYK_HMTK");
            sbSql.Append(" with (nolock)");
            sbSql.Append(" where KIYK_NO = @p0");
            sbSql.Append(" and HMTK_JYTI = '1'");
            sbSql.Append(" and RNR_SKZY_FLG = '0'");
            sbSql.Append(" option(maxdop 1);");

            SqlParameter p0 = new SqlParameter("@p0", System.Data.SqlDbType.Char);

            p0.Value = contractNumber;

            var rec = context.Database.SqlQuery<P_ANSN_SBS_KIIN_KIYK_HMTK>
            (sbSql.ToString()
            , p0).ToList();

            // 取得件数が0件の場合
            if (rec.Count > 0)
            { 
                pAnsnSbsKiinKiykHmtk = rec[0];

                foreach (P_ANSN_SBS_KIIN_KIYK_HMTK p_ANSN_SBS_KIIN_KIYK_HMTK in rec)
                {
                    TGZZZLog.ZacLog("P_ANSN_SBS_KIIN_KIYK_HMTK.KIYK_NO : " + p_ANSN_SBS_KIIN_KIYK_HMTK.KIYK_NO + ", HMTK_JYTI : " + p_ANSN_SBS_KIIN_KIYK_HMTK.HMTK_JYTI
                        + ", RNR_SKZY_FLG : " + p_ANSN_SBS_KIIN_KIYK_HMTK.RNR_SKZY_FLG);
                }
            }
            else
            {
                TGZZZLog.ZacLog("No result");
            }
            return TGZZZConstants.SUCCEESS;
        }
        
        // 3-3）To determine whether an application for a safety service contract is being accepted.
        public int DetermineWhetherAnApplicationForASafetyServiceContractIsBeingAccepted(int subscriptionStatus, P_ANSN_SBS_MSKM_UKTK pAnsnSbsMskmUktk, 
            C_ANSN_SBS_KIYK cAnsnSbsKiyk, out int contractSafetyServiceSubscriptionStatus)
        {
            TGZZZLog.ZacLog("DetermineWhetherAnApplicationForASafetyServiceContractIsBeingAccepted");

            DateTime applicationDate, startDate, endDate;
            DateTime.TryParseExact(pAnsnSbsMskmUktk.MSM_YMD, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out applicationDate);
            DateTime.TryParseExact(cAnsnSbsKiyk.TYK_YMD, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out startDate);
            DateTime.TryParseExact(cAnsnSbsKiyk.TYS_YMD, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out endDate);
            if (subscriptionStatus == 1) // 1368. ★3-2) If the system determines that the subscriber is subscribed to the service
            {
                if (pAnsnSbsMskmUktk != null && pAnsnSbsMskmUktk.MSM_KBN=="1") // 1369. ★3-1) The safety service application acceptance information obtained in is null, or safety service application acceptance information is obtained. When the application category is "1" (New)
                {
                    contractSafetyServiceSubscriptionStatus = 4;    // 1370. The safety service subscription status of the contract is set to「"4"：Joining」 and the normal value (“0 ”) is returned.
                    return TGZZZConstants.SUCCEESS;
                } 
                if (pAnsnSbsMskmUktk.ERR_CD == "0" && applicationDate>=startDate) // 1876 & 1877
                {
                    contractSafetyServiceSubscriptionStatus = 5;    // 1373. Set the safety service subscription status to「"5"：Cancellation accepted」and return the normal value (“0 ”).
                    return TGZZZConstants.SUCCEESS;
                }
                contractSafetyServiceSubscriptionStatus = 4; // 1370. The safety service subscription status of the contract is set to「"4"：Joining」 and the normal value (“0 ”) is returned.
                return TGZZZConstants.SUCCEESS;
            }
            else // 1382. ★3-2)If it is determined that the user is not subscribed to the service
            {
                if (pAnsnSbsMskmUktk != null && pAnsnSbsMskmUktk.MSM_KBN == "2") // 1383. ★3-1) The safety service application acceptance information obtained in is null, or safety service application acceptance information is obtained. When the application category is "2" (Cancellation)
                {
                    contractSafetyServiceSubscriptionStatus = 2;    // 1385. The safety service subscription status of the contract is set to「"2"：Not Joined」and the normal value (“0 ”) is returned.=
                    return TGZZZConstants.SUCCEESS;
                }
                if (pAnsnSbsMskmUktk.RNKE_KYK_FLG == "0" 
                    || (pAnsnSbsMskmUktk.RNKE_KYK_FLG == "1" && pAnsnSbsMskmUktk.ERR_CD=="0" && 
                    (applicationDate > endDate || cAnsnSbsKiyk==null)))
                {
                    contractSafetyServiceSubscriptionStatus = 3;    // 1387. The safety service subscription status of the contract is set to「"3"：Registration accepted」and the normal value (“0 ”) is returned.
                    return TGZZZConstants.SUCCEESS;
                }
                contractSafetyServiceSubscriptionStatus = 2;    // 1403. The safety service subscription status of the contract is set to 「"2"：Not Joined」and the normal value (“0 ”) is returned.
                return TGZZZConstants.SUCCEESS;
            }
        }
    }
}
