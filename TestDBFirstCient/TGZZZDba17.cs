// <要約>
/// プロジェクト: お客さまポータルサイト
/// 機能       : 共通処理
/// クラス名    : ENEDO店舗情報取得（組織番号）													
/// 作成日      : 2023/03/14
/// Copyright 2015 FUJITSU LIMITED
/// </要約>

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDBFirstCient;
/*using Tohogas.DataService;
using Tohogas.Framework.Constants;*/

namespace TestDBFirstCient
{
    public class TGZZZDba17 : TGZZZDba
    {
        public TGZZZDba17(TohogasDataContext context) : base(context)
        {
        }
        public class Dba17Accept1
        {
            // 組織番号
            public string SSK_NO { get; set; }
            // 適用開始年月日
            public string TYK_YMD { get; set; }
            // 適用終了年月日
            public string TYS_YMD { get; set; }
            // 申込開始年月日
            public string MSM_KNG_H { get; set; }
            // 申込終了年月日
            public string MSM_SYRY_YMD { get; set; }
            // マイショップ名
            public string MISYP_ME { get; set; }
            // ソート用マイショップ名かな
            public string ST_YU_MISYP_ME_KN { get; set; }
            // 行政区コード
            public string GSK_CD { get; set; }
            // 表示用マイショップ郵便番号
            public string HYUZYU_MISYP_YUBN_NO { get; set; }
            // 表示用マイショップ住所
            public string HYUZYU_MISYP_ZYUSY { get; set; }
            // 表示用マイショップ電話番号
            public string HYUZYU_MISYP_DWNO { get; set; }
            // 表示用マイショップURL
            public string HYUZYU_MISYP_URL { get; set; }
            // 独自特典有無
            public string DKZ_TKTN_UM { get; set; }
            // 行政区名称
            public string GSK_MS { get; set; }

        }
        /// <summary>
        /// ENEDO店舗情報取得（組織番号）
        /// </summary>
        /// <param name="sskNo">組織番号</param>
        /// <param name="systemDate">システム日付</param>
        /// <param name="listFlag">リストフラグ</param>
        /// <param name="storeInformationList">店舗情報</param>
        /// <returns>正常／異常</returns>
        public int GetENEDOStoreInformationWithOrganizationNumber(string sskNo, DateTime dateTime, bool listFlag, out List<Dba17Accept1> storeInformationList)
        {
            storeInformationList = new List<Dba17Accept1>();
            try
            {
                TGZZZLog.StartLog();
                string dateTimeYMD = dateTime.ToString("yyyyMMdd");
                int result = 0;
                // 1）ENEDO店舗情報取得(１件)
                result = GetENEDOStoreInformation(sskNo, dateTimeYMD, listFlag, out List<Dba17Accept1> storeInformation);
                if (result != TGZZZConstants.SUCCEESS)
                    return result;
                return TGZZZConstants.SUCCEESS;
            }
            catch (Exception e)
            {
                return TGZZZConstants.ABNORMAL;
            }
            finally
            {
                TGZZZLog.EndLog();
            }
        }

        /// <summary>
        /// ENEDO店舗情報取得(１件)
        /// </summary>
        /// <param name="sskNo">組織番号</param>
        /// <param name="systemDate">システム日付</param>
        /// <param name="listFlag">リストフラグ</param>
        /// <param name="storeInformationList">店舗情報</param>
        /// <returns>正常／異常</returns>
        public int GetENEDOStoreInformation(string sskNo, string dateTimeYMD, bool listFlag, out List<Dba17Accept1> storeInformationList)
        {
            storeInformationList = new List<Dba17Accept1>();
            StringBuilder sbSql1 = new StringBuilder();
            int result = 0;

            sbSql1.Append("select ");
            sbSql1.Append(" a.SSK_NO ");
            sbSql1.Append(" , a.TYK_YMD ");
            sbSql1.Append(" , a.TYS_YMD ");
            sbSql1.Append(" , a.MSM_KNG_H ");
            sbSql1.Append(" , a.MSM_SYRY_YMD ");
            sbSql1.Append(" , a.MISYP_ME ");
            sbSql1.Append(" , a.ST_YU_MISYP_ME_KN ");
            sbSql1.Append(" , a.GSK_CD ");
            sbSql1.Append(" , a.HYUZYU_MISYP_YUBN_NO ");
            sbSql1.Append(" , a.HYUZYU_MISYP_ZYUSY ");
            sbSql1.Append(" , a.HYUZYU_MISYP_DWNO ");
            sbSql1.Append(" , a.HYUZYU_MISYP_URL ");
            sbSql1.Append(" , a.DKZ_TKTN_UM ");
            sbSql1.Append(" , b.GSK_MS ");
            sbSql1.Append(" from C_MISYP_KNR_MST a");
            sbSql1.Append(" inner join C_GSK_MST b");
            sbSql1.Append(" on a.GSK_CD = b.GSK_CD");
            sbSql1.Append(" where a.SSK_NO = @p0");
            sbSql1.Append(" and a.TYS_YMD > @p1");
            sbSql1.Append(" and a.MSM_KNG_H <= @p1");
            sbSql1.Append(" and a.MSM_SYRY_YMD >= @p1");
            sbSql1.Append(" and b.TYK_YMD <= @p1");
            sbSql1.Append(" and b.TYS_YMD > @p1");
            sbSql1.Append(" and a.RNR_SKZY_FLG = '0'");
            sbSql1.Append(" and b.RNR_SKZY_FLG = '0'");

            SqlParameter p0 = new SqlParameter("@p0", System.Data.SqlDbType.Char);
            SqlParameter p1 = new SqlParameter("@p1", System.Data.SqlDbType.Char);

            p0.Value = sskNo;
            p1.Value = dateTimeYMD;

            var recs1 = context.Database.SqlQuery<Dba17Accept1>
                (sbSql1.ToString()
                , p0, p1).ToList();

            if (!listFlag)
            {
                if (recs1.Count == 0)
                    return TGZZZConstants.NOTFOUND;
                else
                {
                    storeInformationList = recs1;
                    return TGZZZConstants.SUCCEESS;
                }
            }
            else // リストフラグがtrueの場合、
            {
                List<string> sskNoList = new List<string>();

                if (recs1.Count == 0)
                {
                    // 2) ENEDOストア情報リスト取得
                    result = GetENEDOStoreInformationList(sskNoList, dateTimeYMD, out storeInformationList);
                    if (result != TGZZZConstants.SUCCEESS)
                        return result;
                }
                else
                {
                    // 2) ENEDOストア情報リスト取得
                    sskNoList = recs1.Select(x => x.SSK_NO).ToList();

                    result = GetENEDOStoreInformationList(sskNoList, dateTimeYMD, out storeInformationList);
                    if (result != TGZZZConstants.SUCCEESS)
                        return result;

                    storeInformationList.AddRange(recs1);
                }
            }

            if (storeInformationList.Count == 0)
                return TGZZZConstants.NOTFOUND;
            else
                return TGZZZConstants.SUCCEESS;

        }

        /// <summary>
        /// ENEDO店舗情リスト取得
        /// </summary>
        /// <param name="sskNoList">組織番号リスト (organization number list)</param>
        /// <param name="dateTimeYMD">system date and time (yyyymmdd) </param>
        /// <param name="storeInformationList">店舗情リスト (Store information list)</param>
        /// <returns>正常／異常</returns>
        public int GetENEDOStoreInformationList(List<string> sskNoList, string dateTimeYMD, out List<Dba17Accept1> storeInformationList)
        {
            storeInformationList = new List<Dba17Accept1>();

            StringBuilder sbSql2 = new StringBuilder();
            StringBuilder sbSql2List = new StringBuilder();

            sbSql2.Append("select a.SSK_NO");
            sbSql2.Append(" , a.TYK_YMD");
            sbSql2.Append(" , a.TYS_YMD");
            sbSql2.Append(" , a.MSM_KNG_H");
            sbSql2.Append(" , a.MSM_SYRY_YMD");
            sbSql2.Append(" , a.MISYP_ME");
            sbSql2.Append(" , a.ST_YU_MISYP_ME_KN");
            sbSql2.Append(" , a.GSK_CD");
            sbSql2.Append(" , a.HYUZYU_MISYP_YUBN_NO");
            sbSql2.Append(" , a.HYUZYU_MISYP_ZYUSY");
            sbSql2.Append(" , a.HYUZYU_MISYP_DWNO");
            sbSql2.Append(" , a.HYUZYU_MISYP_URL");
            sbSql2.Append(" , a.DKZ_TKTN_UM");
            sbSql2.Append(" , b.GSK_MS");
            sbSql2.Append(" from C_MISYP_KNR_MST a");
            sbSql2.Append(" inner join C_GSK_MST b");
            sbSql2.Append(" on a.GSK_CD = b.GSK_CD");

            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter($"@p0", dateTimeYMD));

            if (sskNoList.Count == 0)
            {
                sbSql2.Append(" where a.TYS_YMD > @p0");
            }
            else
            {
                sbSql2.Append(" where a.SSK_NO not in (");

                int index = 1;
                foreach (string sskNo in sskNoList)
                {
                    if (index > 1)
                    {
                        sbSql2List.Append(", ");
                    }
                    sbSql2List.Append($"@p{index}");
                    paramList.Add(new SqlParameter($"@p{index}", sskNo));
                    index++;
                }
                sbSql2.Append(sbSql2List);
                sbSql2.Append(")");

                sbSql2.Append(" and a.TYS_YMD > @p0");

            }
            sbSql2.Append(" and a.MSM_KNG_H <= @p0");
            sbSql2.Append(" and a.MSM_SYRY_YMD >= @p0");
            sbSql2.Append(" and b.TYK_YMD <= @p0");
            sbSql2.Append(" and b.TYS_YMD > @p0");
            sbSql2.Append(" and a.RNR_SKZY_FLG = '0'");
            sbSql2.Append(" and b.RNR_SKZY_FLG = '0'");

            storeInformationList = context.Database.SqlQuery<Dba17Accept1>
                (sbSql2.ToString(), paramList.ToArray()).ToList();

            return TGZZZConstants.SUCCEESS;
        }

    }
}
