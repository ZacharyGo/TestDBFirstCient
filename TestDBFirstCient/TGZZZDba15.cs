using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDBFirstCient
{
    public class TGZZZDba15
    {
        TohogasDataContext context;
        public void Start()
        {
            TohogasDataContext TohogasDataContext = new TohogasDataContext();
            Console.WriteLine("Result is {0}", SetP_ANSN_SBS_MSKM_UKTK());
            Console.ReadLine();
        }
        public int SetP_PINT_HYRRK_KIIN()
        {
            P_PINT_HYRRK_KIIN p_PINT_HYRRK_KIIN = new P_PINT_HYRRK_KIIN()
            {
                KIIN_ID = "ZachTest001",
                POINTHY_ID = "20230301",
                HY_YM = "202303",
                HY_KY = "88",
                HY_POINT_CNT = 1,
                HY_TIMSTNP = DateTime.Now,
                RNR_SKZY_FLG = "0",
                TURK_TIMSTNP = DateTime.Now,
                SHOP_TRAN_ID = "",
                FORM_ENTRY_ID = "",
                VF_STATUS = ""
            };

            return TemporaryAddPointGrantHistry(p_PINT_HYRRK_KIIN);
        }
        public int TemporaryAddPointGrantHistry(P_PINT_HYRRK_KIIN p_PINT_HYRRK_KIIN)
        {
            try
            {
                StringBuilder sbSql = new StringBuilder();
                sbSql.Append("INSERT INTO ");
                sbSql.Append("P_PINT_HYRRK_KIIN( ");
                sbSql.Append("KIIN_ID");
                sbSql.Append(", POINTHY_ID");
                sbSql.Append(", HY_YM");
                sbSql.Append(", HY_KY");
                sbSql.Append(", HY_POINT_CNT");
                sbSql.Append(", HY_TIMSTNP");
                sbSql.Append(", RNR_SKZY_FLG");
                sbSql.Append(", TURK_TIMSTNP");
                sbSql.Append(", SHOP_TRAN_ID");
                sbSql.Append(", FORM_ENTRY_ID");
                sbSql.Append(", VF_STATUS) ");
                sbSql.Append("VALUES (");
                sbSql.Append("@p0, ");
                sbSql.Append("@p1, ");
                sbSql.Append("@p2, ");
                sbSql.Append("@p3, ");
                sbSql.Append("@p4, ");
                sbSql.Append("@p5, ");
                sbSql.Append("@p6, ");
                sbSql.Append("@p7, ");
                sbSql.Append("@p8, ");
                sbSql.Append("@p9, ");
                sbSql.Append("@p10) OPTION(MAXDOP 1);");

                SqlParameter p0 = new SqlParameter("@p0", System.Data.SqlDbType.VarChar);
                SqlParameter p1 = new SqlParameter("@p1", System.Data.SqlDbType.Char);
                SqlParameter p2 = new SqlParameter("@p2", System.Data.SqlDbType.Char);
                SqlParameter p3 = new SqlParameter("@p3", System.Data.SqlDbType.VarChar);
                SqlParameter p4 = new SqlParameter("@p4", System.Data.SqlDbType.Int);
                SqlParameter p5 = new SqlParameter("@p5", System.Data.SqlDbType.DateTime2);
                SqlParameter p6 = new SqlParameter("@p6", System.Data.SqlDbType.Char);
                SqlParameter p7 = new SqlParameter("@p7", System.Data.SqlDbType.DateTime2);
                SqlParameter p8 = new SqlParameter("@p8", System.Data.SqlDbType.VarChar);
                SqlParameter p9 = new SqlParameter("@p9", System.Data.SqlDbType.VarChar);
                SqlParameter p10 = new SqlParameter("@p10", System.Data.SqlDbType.Char);

                // 会員ID
                p0.Value = p_PINT_HYRRK_KIIN.KIIN_ID;
                // ポイント付与ID
                p1.Value = p_PINT_HYRRK_KIIN.POINTHY_ID;
                // 付与年月
                p2.Value = p_PINT_HYRRK_KIIN.HY_YM;
                // 付与キー
                p3.Value = p_PINT_HYRRK_KIIN.HY_KY;
                // 付与ポイント数
                p4.Value = p_PINT_HYRRK_KIIN.HY_POINT_CNT;
                // 付与日時
                p5.Value = p_PINT_HYRRK_KIIN.HY_TIMSTNP;
                // 論理削除フラグ
                p6.Value = p_PINT_HYRRK_KIIN.RNR_SKZY_FLG;
                // 登録タイムスタンプ
                p7.Value = p_PINT_HYRRK_KIIN.TURK_TIMSTNP;
                // 加盟店トランザクションID
                p8.Value = p_PINT_HYRRK_KIIN.SHOP_TRAN_ID;
                // フォームエントリーID
                p9.Value = p_PINT_HYRRK_KIIN.FORM_ENTRY_ID;
                // ValueFrontステータス
                p10.Value = p_PINT_HYRRK_KIIN.VF_STATUS;

                context.Database.ExecuteSqlCommand
                (sbSql.ToString()
                        , p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }

        public long SetP_ANSN_SBS_MSKM_UKTK()
        {
            P_ANSN_SBS_MSKM_UKTK p_ANSN_SBS_MSKM_UKTK = new P_ANSN_SBS_MSKM_UKTK()
            {
                MSM_YMD = "Test",
                MSM_KBN = "",
                KIYK_NO = "TestInsert",
                ANSN_SBS_KIYK_NO = "TestInsert",
                ANSN_SBS_PLN = "",
                MYSHOP_SSK_NO = "Test",
                TM_KBN = "",
                KIIN_ID = "TestInsert",
                SGYUSY_CD = "Test",
                SGYUSY_SSK_NO = "Test",
                MSM_KBN_SYUSI = "",
                KIYK_MUSKM_RYU = "",
                MLMG_HISN_KBN = "",
                SGODR_NO = "TestInsert",
                RNKE_KYK_FLG = "",
                RNKE_KYK_FLG_TIMSTNP = DateTime.Now,
                CTG_ERR_IRI_FLG = "",
                ERR_CD = "",
                RNR_SKZY_FLG = "",
                TURK_TIMSTNP = DateTime.Now,
                KUSN_TIMSTNP = DateTime.Now
            };

            long msm_No;
            Console.WriteLine(AddReceivingApplicationsForSafetyServices(p_ANSN_SBS_MSKM_UKTK, out msm_No));
            Console.Write("MSM_No:");
            Console.WriteLine(msm_No);
            return msm_No;
        }
        public int TemporaryAddPointGrantHistry(P_ANSN_SBS_MSKM_UKTK p_ANSN_SBS_MSKM_UKTK, out long MSM_NO)
        {
            try
            {
                var context = new TohogasDataContext();
                context.P_ANSN_SBS_MSKM_UKTK.Add(p_ANSN_SBS_MSKM_UKTK);
                context.SaveChanges();
                MSM_NO = p_ANSN_SBS_MSKM_UKTK.MSM_NO;
                return 1;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.InnerException.Message);
                MSM_NO = p_ANSN_SBS_MSKM_UKTK.MSM_NO;
                return -1;
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }


        public int AddReceivingApplicationsForSafetyServices(P_ANSN_SBS_MSKM_UKTK p_ANSN_SBS_MSKM_UKTK, out long msm_No)
        {
            try
            {
                /*TGZZZLog.StartLog();*/
                StringBuilder sbSql = new StringBuilder();
                sbSql.Append("INSERT INTO ");
                sbSql.Append("P_ANSN_SBS_MSKM_UKTK ( ");
                sbSql.Append("MSM_YMD");
                sbSql.Append(", MSM_KBN");
                sbSql.Append(", KIYK_NO");
                sbSql.Append(", ANSN_SBS_KIYK_NO");
                sbSql.Append(", ANSN_SBS_PLN");
                sbSql.Append(", MYSHOP_SSK_NO");
                sbSql.Append(", TM_KBN");
                sbSql.Append(", KIIN_ID");
                sbSql.Append(", SGYUSY_CD");
                sbSql.Append(", SGYUSY_SSK_NO");
                sbSql.Append(", MSM_KBN_SYUSI");
                sbSql.Append(", KIYK_MUSKM_RYU");
                sbSql.Append(", MLMG_HISN_KBN");
                sbSql.Append(", SGODR_NO");
                sbSql.Append(", RNKE_KYK_FLG");
                sbSql.Append(", RNKE_KYK_FLG_TIMSTNP");
                sbSql.Append(", CTG_ERR_IRI_FLG");
                sbSql.Append(", ERR_CD");
                sbSql.Append(", RNR_SKZY_FLG");
                sbSql.Append(", TURK_TIMSTNP");
                sbSql.Append(", KUSN_TIMSTNP) ");
                sbSql.Append("VALUES (");
                sbSql.Append("@p0, ");
                sbSql.Append("@p1, ");
                sbSql.Append("@p2, ");
                sbSql.Append("@p3, ");
                sbSql.Append("@p4, ");
                sbSql.Append("@p5, ");
                sbSql.Append("@p6, ");
                sbSql.Append("@p7, ");
                sbSql.Append("@p8, ");
                sbSql.Append("@p9, ");
                sbSql.Append("@p10, ");
                sbSql.Append("@p11, ");
                sbSql.Append("@p12, ");
                sbSql.Append("@p13, ");
                sbSql.Append("@p14, ");
                sbSql.Append("@p15, ");
                sbSql.Append("@p16, ");
                sbSql.Append("@p17, ");
                sbSql.Append("@p18, ");
                sbSql.Append("@p19, ");
                sbSql.Append("@p20);");

                SqlParameter p0 = new SqlParameter("@p0", System.Data.SqlDbType.Char);
                SqlParameter p1 = new SqlParameter("@p1", System.Data.SqlDbType.Char);
                SqlParameter p2 = new SqlParameter("@p2", System.Data.SqlDbType.Char);
                SqlParameter p3 = new SqlParameter("@p3", System.Data.SqlDbType.Char);
                SqlParameter p4 = new SqlParameter("@p4", System.Data.SqlDbType.Char);
                SqlParameter p5 = new SqlParameter("@p5", System.Data.SqlDbType.VarChar);
                SqlParameter p6 = new SqlParameter("@p6", System.Data.SqlDbType.Char);
                SqlParameter p7 = new SqlParameter("@p7", System.Data.SqlDbType.VarChar);
                SqlParameter p8 = new SqlParameter("@p8", System.Data.SqlDbType.Char);
                SqlParameter p9 = new SqlParameter("@p9", System.Data.SqlDbType.VarChar);
                SqlParameter p10 = new SqlParameter("@p10", System.Data.SqlDbType.Char);
                SqlParameter p11 = new SqlParameter("@p11", System.Data.SqlDbType.Char);
                SqlParameter p12 = new SqlParameter("@p12", System.Data.SqlDbType.Char);
                SqlParameter p13 = new SqlParameter("@p13", System.Data.SqlDbType.Char);
                SqlParameter p14 = new SqlParameter("@p14", System.Data.SqlDbType.Char);
                SqlParameter p15 = new SqlParameter("@p15", System.Data.SqlDbType.DateTime2);
                SqlParameter p16 = new SqlParameter("@p16", System.Data.SqlDbType.Char);
                SqlParameter p17 = new SqlParameter("@p17", System.Data.SqlDbType.Char);
                SqlParameter p18 = new SqlParameter("@p18", System.Data.SqlDbType.Char);
                SqlParameter p19 = new SqlParameter("@p19", System.Data.SqlDbType.DateTime2);
                SqlParameter p20 = new SqlParameter("@p20", System.Data.SqlDbType.DateTime2);

                // 申込年月日
                p0.Value = p_ANSN_SBS_MSKM_UKTK.MSM_YMD;
                // 申込区分
                p1.Value = p_ANSN_SBS_MSKM_UKTK.MSM_KBN;
                // ガス契約番号
                p2.Value = p_ANSN_SBS_MSKM_UKTK.KIYK_NO;
                // 安心サービス契約番号
                p3.Value = p_ANSN_SBS_MSKM_UKTK.ANSN_SBS_KIYK_NO;
                // 安心サービスプラン
                p4.Value = p_ANSN_SBS_MSKM_UKTK.ANSN_SBS_PLN;
                // マイショップ
                p5.Value = p_ANSN_SBS_MSKM_UKTK.MYSHOP_SSK_NO;
                // 住居区分
                p6.Value = p_ANSN_SBS_MSKM_UKTK.TM_KBN;
                // 申込時CTG会員ID
                p7.Value = p_ANSN_SBS_MSKM_UKTK.KIIN_ID;
                // 獲得作業者
                p8.Value = p_ANSN_SBS_MSKM_UKTK.SGYUSY_CD;
                // 獲得作業者組織番号
                p9.Value = p_ANSN_SBS_MSKM_UKTK.SGYUSY_SSK_NO;
                // 申込区分詳細
                p10.Value = p_ANSN_SBS_MSKM_UKTK.MSM_KBN_SYUSI;
                // CTG解約申込理由
                p11.Value = p_ANSN_SBS_MSKM_UKTK.KIYK_MUSKM_RYU;
                // 申込時メルマガ配信区分
                p12.Value = p_ANSN_SBS_MSKM_UKTK.MLMG_HISN_KBN;
                // 作業オーダー番号
                p13.Value = p_ANSN_SBS_MSKM_UKTK.SGODR_NO;
                // CusTo-net連携許可フラグ
                p14.Value = p_ANSN_SBS_MSKM_UKTK.RNKE_KYK_FLG;
                // CusTo-net連携許可フラグ設定タイムスタンプ
                p15.Value = p_ANSN_SBS_MSKM_UKTK.RNKE_KYK_FLG_TIMSTNP;
                // CTGエラー依頼フラグ
                p16.Value = p_ANSN_SBS_MSKM_UKTK.CTG_ERR_IRI_FLG;
                // エラー理由コード
                p17.Value = p_ANSN_SBS_MSKM_UKTK.ERR_CD;
                // 論理削除フラグ
                p18.Value = p_ANSN_SBS_MSKM_UKTK.RNR_SKZY_FLG;
                // 登録タイムスタンプ
                p19.Value = p_ANSN_SBS_MSKM_UKTK.TURK_TIMSTNP;
                // 更新タイムスタンプ
                p20.Value = p_ANSN_SBS_MSKM_UKTK.KUSN_TIMSTNP;

                context.Database.ExecuteSqlCommand
                (sbSql.ToString()
                        , p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20);

                sbSql = new StringBuilder();
                sbSql.Append("select MAX([MSM_NO]) as MSM_NO ");
                sbSql.Append("from [P_ANSN_SBS_MSKM_UKTK] ");
                var recs = context.Database.SqlQuery<long>(sbSql.ToString()).ToList();
                msm_No = recs[0];
                return /*TGZZZConstants.SUCCEESS*/ 0;
            }
            catch (Exception e)
            {
                /*TGZZZLog.WriteLogFile_ERR(TGZZZConstants.LOG_ERROR, "", "", e);
                TGZZZLog.WriteEventLog_ERR(TGZZZConstants.EVENT_LOG_ERROR);
                return TGZZZConstants.ABNORMAL;*/
                Console.WriteLine("Error :{0}", e.Message);
                msm_No = 0;
                return -11;
            }
            finally
            {
                /*TGZZZLog.EndLog();*/
                Console.WriteLine("End");
            }
        }
    }
}
