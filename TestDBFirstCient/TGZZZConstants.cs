using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDBFirstCient
{
    public class TGZZZConstants
    {
        #region 共通

        /// <summary>
        /// 公開Webサーバーフラグ
        /// </summary>
        public const string SERVER_TYPE_WEB = "1";

        /// <summary>
        /// URLリライト時のパス
        /// </summary>
        public const string ROOTPATH = "";

        /// <summary>
        /// コンテンツのルートフォルダ
        /// </summary>
        public const string CONTENT_ROOT = @"\Content\";

        /// <summary>
        /// 正常
        /// </summary>
        public const int SUCCEESS = 0;

        /// <summary>
        /// 異常
        /// </summary>
        public const int ABNORMAL = -11;

        /// <summary>
        /// 該当データなし
        /// </summary>
        public const int NOTFOUND = -12;

        /// <summary>
        /// パラメーター数不足
        /// </summary>
        public const int ERR_PRMNUM = -1;

        /// <summary>
        /// パラメーター桁数不正
        /// </summary>
        public const int ERR_PRMLEN = -2;

        /// <summary>
        /// パラメーター範囲不正
        /// </summary>
        public const int ERR_PRMRNG = -3;

        /// <summary>
        /// パラメーター属性不正
        /// </summary>
        public const int ERR_PRMATR = -4;

        /// <summary>
        /// パラメーター書式不正
        /// </summary>
        public const int ERR_PRMFRM = -5;

        /// <summary>
        /// ゼロ
        /// </summary>
        public const int ZERO = 0;

        /// <summary>
        /// true
        /// </summary>
        public const string COM_TRUE = "true";

        /// <summary>
        /// false
        /// </summary>
        public const string COM_FALSE = "false";

        /// <summary>
        /// UA_COUNT_INIT
        /// </summary>
        public const int UA_COUNT_INIT = 1;

        /// <summary>
        /// UA_COUNT_MAX
        /// </summary>
        public const int UA_COUNT_MAX = 100;

        /// <summary>
        /// 文字 - 全角スペース
        /// </summary>
        public const string FULL_BLANK = "　";

        /// <summary>
        /// 文字 - 半角スペース
        /// </summary>
        public const string HALF_BLANK = " ";

        /// <summary>
        /// 文字 - 半角カンマ
        /// </summary>
        public const string HALF_COMMA = ",";

        /// <summary>
        /// 文字 - 半角スラッシュ
        /// </summary>
        public const string HALF_SLASH = "/";

        /// <summary>
        /// CHAR - 半角カンマ
        /// </summary>
        public const char CHAR_HALF_COMMA = ',';

        /// <summary>
        /// 会員種別 - 本会員(ポイント利用・取得)
        /// </summary>
        public const string MEMBER_KIND_POINT_USE_GET = "1";

        /// <summary>
        /// 会員種別 - 本会員(ポイント利用)
        /// </summary>
        public const string MEMBER_KIND_POINT_USE = "2";

        /// <summary>
        /// 会員種別 - 本会員(非ポイント)
        /// </summary>
        public const string MEMBER_KIND_NOT_POINT = "3";

        /// <summary>
        /// 会員種別 - ライト会員
        /// </summary>
        public const string MEMBER_KIND_LIGHT = "4";

        /// <summary>
        /// 有効契約可否 - 有効
        /// </summary>
        public const string AVAILABLE_CONTRACT_YES = "0";

        /// <summary>
        /// 有効契約可否 - 非有効
        /// </summary>
        public const string AVAILABLE_CONTRACT_NO = "1";

        /// <summary>
        /// サービス可能な契約有無 - 有
        /// </summary>
        public const string AVAILABLE_SERVICE_CONTRACT_YES = "1";

        /// <summary>
        /// サービス可能な契約有無 - 無
        /// </summary>
        public const string AVAILABLE_SERVICE_CONTRACT_NO = "0";

        /// <summary>
        /// SmarP動作状況 - 稼働中
        /// </summary>
        public const string SMARP_MODE_ON = "0";

        /// <summary>
        /// SmarP動作状況 - 非稼働
        /// </summary>
        public const string SMARP_MODE_OFF = "1";

        /// <summary>
        /// 文字型チェック - 半角数字
        /// </summary>
        public const string CHECK_STRING_TYPE_HALFNUM = "10";

        /// <summary>
        /// 文字型チェック - 半角英数字
        /// </summary>
        public const string CHECK_STRING_TYPE_HALFALPHNUM = "11";

        /// <summary>
        /// 文字型チェック - 半角英数字記号
        /// </summary>
        public const string CHECK_STRING_TYPE_HALFALPHNUMSYMBOL = "12";

        /// <summary>
        /// 文字型チェック - 半角
        /// </summary>
        public const string CHECK_STRING_TYPE_HALFALL = "13";

        /// <summary>
        /// 文字型チェック - 全角
        /// </summary>
        public const string CHECK_STRING_TYPE_FULLALL = "20";

        /// <summary>
        /// 文字型チェック - 全角カナ
        /// </summary>
        public const string CHECK_STRING_TYPE_FULLKANA = "21";

        /// <summary>
        /// 文字型チェック - 整数値
        /// </summary>
        public const string CHECK_STRING_TYPE_INT32 = "30";

        /// <summary>
        /// 文字型チェック - 半角大文字英数字
        /// </summary>
        public const string CHECK_STRING_TYPE_HALFUPPERALPHNUM = "40";

        /// <summary>
        /// 都道府県名プルダウン - 未選択時の都道府県コード
        /// </summary>
        public const string UNSELECTED_TDHK_CD = "00";

        /// <summary>
        /// 都道府県名プルダウン - 未選択時の都道府県名のリスト
        /// </summary>
        public const string UNSELECTED_TDHK_NM = "都道府県を選択";

        /// <summary>
        /// 警告メッセージ - ログ出力(警告)
        /// </summary>
        public const string LOG_WARN_TIKI = "セッション管理テーブルにレコードが存在しません。";

        /// <summary>
        /// 警告メッセージ - ログ出力(警告)
        /// </summary>
        public const string LOG_WARN_LOGOUT = "セッション管理テーブルにレコードが存在しません。";

        /// <summary>
        /// エラーメッセージ - ログ出力(例外)
        /// </summary>
        public const string LOG_ERROR = "異常が発生しました。";

        /// <summary>
        /// エラーメッセージ - ログ出力(Tohogas.Environments.config)
        /// </summary>
        public const string LOG_WEBCONF_ERR = "指定されたキーが環境変数定義に存在しません。[{0}]";

        /// <summary>
        /// ログメッセージ - ログ出力(Tohogas.Environments.config)
        /// </summary>
        public const string LOG_WFFM_INFO = "アンケートアイテムが割り当てられていません。";

        /// <summary>
        /// エラーメッセージ - イベントログ出力(例外)
        /// </summary>
        public const string EVENT_LOG_ERROR = "異常が発生しました。";

        /// <summary>
        /// パーソナルお知らせ - カーボンニュートラル都市ガスがない場合のお知らせ
        /// </summary>
        public const string EVENT_COMMENT_CARBON = "カーボンニュートラル都市ガスの利用契約が存在しません。マイページにて対象契約を紐づけていただくと自動的に利用対象となります。";

        /// <summary>
        /// パーソナルお知らせ - カーボンニュートラル都市ガスがない場合のお知らせ
        /// </summary>
        public const string EVENT_COMMENT_LOTTERY = "抽せん前のがすてきくじがあります";

        /// <summary>
        /// 「新規会員登録メールアドレス確認画面」のパス
        /// </summary>
        public static string REGIST_CONFIRM_PATH = "TGZZZUtil.GetLinkUrl(TGZZZContentItems.RegistMemberMailAddConfirm)";

        /// <summary>
        /// 「新規会員登録会員情報確認画面」のパス
        /// </summary>
        public static string MEMBER_REGIST_CONFIRM_PATH = "TGZZZUtil.GetLinkUrl(TGZZZContentItems.RegistMemberInfoConfirm)";

        /// <summary>
        /// 「新規会員登録契約情報確認画面」のパス
        /// </summary>
        public static string MEMBER_CONTRACT_CONFIRM_PATH = "TGZZZUtil.GetLinkUrl(TGZZZContentItems.RegistMemberContractConfirm)";

        /// <summary>
        /// 「契約情報確認画面」のパス
        /// </summary>
        public static string CONTRACT_CONFIRM_PATH = "TGZZZUtil.GetLinkUrl(TGZZZContentItems.ContractConfirm)";

        /// <summary>
        /// 「よくあるお問い合わせ画面」のパス
        /// </summary>
        public const string FAQ = "/Faq.aspx";

        /// <summary>
        /// 「お問い合わせ内容入力画面」のパス
        /// </summary>
        public static string CONTACT_REGIST_PATH = "TGZZZUtil.GetLinkUrl(TGZZZContentItems.Contact)";

        /// <summary>
        /// 「お問い合わせ内容確認画面」のパス
        /// </summary>
        public static string CONTACT_REGIST_CONFIRM_PATH = "TGZZZUtil.GetLinkUrl(TGZZZContentItems.ContactConfirm)";

        /// <summary>
        /// ログインIDの最大桁数
        /// </summary>
        public const int LOGIN_ID_MAXLENGTH = 32;

        /// <summary>
        /// メールアドレスの最大桁数
        /// </summary>
        public const int MAIL_ADD_MAXLENGTH = 256;

        // <summary>
        /// 認証コード4桁
        /// </summary>
        public const int CREATE_SECURITYCODE_DIGIT = 4;

        // <summary>
        /// 認証コード6桁
        /// </summary>
        public const int CREATE_SECURITYCODE_DIGIT6 = 6;

        // <summary>
        /// 認証コード生成(シリアルID)
        /// </summary>
        public const int CREATE_SECURITYCODE_SERIALID = 14;

        // <summary>
        /// 認証コード生成(数字のみ)
        /// </summary>
        public const string CREATE_SECURITYCODE_NUMBER = "10";

        /// <summary>
        /// 認証コード生成(英数字(大文字小文字混在))
        /// </summary>
        public const string CREATE_SECURITYCODE_CAPITALSMALLMIXED = "20";

        /// <summary>
        /// 認証コード生成(英(大文字)数字)
        /// </summary>
        public const string CREATE_SECURITYCODE_UPPER_ALPH_NUM = "30";

        /// <summary>
        /// パスワードの最大桁数
        /// </summary>
        public const int PASSWORD_MAXLENGTH = 16;

        /// <summary>
        /// パスワードの最小桁数
        /// </summary>
        public const int PASSWORD_MINLENGTH = 8;

        /// <summary>
        /// 会員名表示桁数
        /// </summary>
        public const int MEMBER_NAME_LENGTH = 10;

        /// <summary>
        /// 会員IDの小桁数
        /// </summary>
        public const int KIIN_ID_MINLENGTH = 8;

        /// <summary>
        /// 会員IDの最大桁数
        /// </summary>
        public const int KIIN_ID_MAXLENGTH = 32;

        /// <summary>
        /// お名前(姓)最大桁数
        /// </summary>
        public const int FIRST_NAME_MAXLENGTH = 30;

        /// <summary>
        /// お名前(名)最大桁数
        /// </summary>
        public const int LAST_NAME_MAXLENGTH = 30;

        /// <summary>
        /// お名前(姓(カナ))最大桁数
        /// </summary>
        public const int FIRST_NAME_KANA_MAXLENGTH = 40;

        /// <summary>
        /// お名前(名(カナ))最大桁数
        /// </summary>
        public const int LAST_NAME_KANA_MAXLENGTH = 40;

        /// <summary>
        /// 氏名(カナ)最大桁数
        /// </summary>
        public const int SMI_KN_MAXLENGTH = 90;

        /// <summary>
        /// 会員 - 仮名
        /// </summary>
        public const string KIIN_KAMEI = "会員";

        /// <summary>
        /// 電話番号最小桁数
        /// </summary>
        public const int PHONE_NUM_MINLENGTH = 10;

        /// <summary>
        /// 電話番号最大桁数
        /// </summary>
        public const int PHONE_NUM_MAXLENGTH = 11;

        /// <summary>
        /// 郵便番号の桁数
        /// </summary>
        public const int POSTAL_CODE_LENGTH = 7;

        /// <summary>
        /// 住所(市区町村)の最大桁数
        /// </summary>
        public const int ADDRESS2_MAXLENGTH = 120;

        /// <summary>
        /// 住所(町域名等・番地)の最大桁数
        /// </summary>
        public const int ADDRESS3_MAXLENGTH = 120;

        /// <summary>
        /// 住所(建物名・部屋番号)の最大桁数
        /// </summary>
        public const int ADDRESS4_MAXLENGTH = 30;

        /// <summary>
        /// 都道府県コードの桁数
        /// </summary>
        public const int PREFECTURES_CODE_LENGTH = 2;

        /// <summary>
        /// 最小桁数指定無し
        /// </summary>
        public const int OTHER_MINLENGTH = 1;

        /// <summary>
        /// （新規会員登録）契約情報完了画面 完了メッセージ表示用Path
        /// </summary>
        public const string CONTRACT_MESSAGE = "/sitecore/content/Content/Messages/CreateMember9 Message{0}";

        /// <summary>
        /// GridFilterのキー値_storageName
        /// </summary>
        public const string GRID_FILTER_STORAGENAME = "storageName";

        /// <summary>
        /// GridFilterのキー値_dataKey
        /// </summary>
        public const string GRID_FILTER_DATAKEY = "dataKey";

        /// <summary>
        /// ポイント下限
        /// </summary>
        public const int POINT_MIN = 0;

        /// <summary>
        /// ポイント上限
        /// </summary>
        public const int POINT_MAX = 99999999;

        /// <summary>
        /// クーポン金額上限
        /// </summary>
        public const int DISCOUNT_MAX = 99999999;

        /// <summary>
        /// 郵便番号の桁数（ハイフン込）
        /// </summary>
        public const int POSTAL_CODE_LENGTH_HYPHEN_ADD = 8;

        /// <summary>
        /// ハイフン
        /// </summary>
        public const string HYPHEN = "-";

        /// <summary>
        /// お客さま番号の桁数
        /// </summary>
        public const int CUSTMER_NUM_LENGTH = 10;

        /// <summary>
        /// お客さま番号の桁数（ハイフン込）
        /// </summary>
        public const int CUSTMER_NUM_LENGTH_HYPHEN_ADD = 12;

        /// <summary>
        /// ダミーパスワード生成の桁数
        /// </summary>
        public const int DUMMY_SECURITY_CODE_LENGTH = 4;

        /// <summary>
        /// 三点リーダ
        /// </summary>
        public const string THREE_POINT_LEADER = "…";

        /// <summary>
        /// ドロップダウンリストのバリュー（ディクショナリのキー）
        /// </summary>
        public const string DROP_DWON_LIST_VALUE_FIELD = "Key";

        /// <summary>
        /// ドロップダウンリストのテキスト（ディクショナリのバリュー）
        /// </summary>
        public const string DROP_DWON_LIST_TEXT_FIELD = "Value";

        /// <summary>
        /// TGZZZBase.cs内Page_Loadでの遷移先判定（遷移なし）
        /// </summary>
        public const string NO_REDIRECT = "0";

        /// <summary>
        /// TGZZZBase.cs内Page_Loadでの遷移先判定（エラー画面へ遷移）
        /// </summary>
        public const string REDIRECT_ERR = "-1";

        /// <summary>
        /// TGZZZBase.cs内Page_Loadでの遷移先判定（共通エラー画面へ遷移）
        /// </summary>
        public const string REDIRECT_COMMON_ERR = "-2";

        /// <summary>
        /// TGZZZBase.cs内Page_Loadでの遷移先判定（ログイン画面へ遷移）
        /// </summary>
        public const string REDIRECT_LOGIN = "-3";

        /// <summary>
        /// TGZZZBase.cs内Page_Loadでの遷移先判定（ログアウト画面へ遷移）
        /// </summary>
        public const string REDIRECT_LOGOUT = "-4";

        // ▼▼▼V1.1仕様変更(2-12)_紙申請改善対応▼▼▼
        // ▼▼追加(Start)▼▼
        /// <summary>
        /// リクエストモード「紙登録モード」
        /// </summary>
        public const string WRITTEN_REGISTRATION_MODE = "1";

        /// <summary>
        /// URLのパラメタ変数
        /// </summary>
        public const string REQUEST_PARAM_P001 = "p001";

        /// <summary>
        /// 紙登録モード（環境変数）取得キー
        /// </summary>
        public const string ENV_URL_PARA_WRITTEN_REGT = "URLparaWrittenRegistration";
        // ▲▲追加(End)▲▲

        /// <summary>
        /// タブレット入会モード（環境変数）取得キー
        /// </summary>
        public const string URL_PARA_TABLET_REGISTRATION = "URLparaTabletRegistration";

        /// <summary>
        /// タブレット入会モード パスワード設定有効期限 取得キー
        /// </summary>
        public const string TABLET_REGIST_PASSWORD_RESET_EXPIRATION = "TabletRegistrationPWDResetExpiration";

        /// <summary>
        /// クライントIPアドレス（環境変数）取得キー
        /// </summary>
        public const string ENV_CLIENT_IPADDRESS = "ClientIPAddress";

        /// <summary>
        /// 付帯サービス（有）
        /// </summary>
        public const string FTSBS_YES = "1";

        /// <summary>
        /// 付帯サービス（無）
        /// </summary>
        public const string FTSBS_NO = "0";

        /// <summary>
        /// NONE_VALUE
        /// </summary>
        public const string NONE_VALUE = "none";

        /// <summary>
        /// 定義なし（付帯サービス）
        /// </summary>
        public const string FTSBS_NO_DEFINE = "";

        /// <summary>
        /// OUTPUT_SWITCH_FLG_ON（出力する）
        /// </summary>
        public const string OUTPUT_SWITCH_FLG_ON = "1";

        /// <summary>
        /// OUTPUT_SWITCH_FLG_OFF（出力しない）
        /// </summary>
        public const string OUTPUT_SWITCH_FLG_OFF = "0";

        /// <summary>
        /// 広告コンテンツ（表示回数ゴール）
        /// </summary>
        public const string DISPLAY_KEYWORD = "display_";

        /// <summary>
        /// 広告コンテンツ（クリック回数ゴール）
        /// </summary>
        public const string CLICK_KEYWORD = "click_";

        /// <summary>
        /// リンク先URL(外部)
        /// </summary>
        public const string LINK_OTHER_SITE = "1";

        /// <summary>
        /// リンクURL(ゴール)
        /// </summary>
        public const string LINK_URL_GOAL = "/sitecore/system/Marketing Control Panel/Goals/Tohogas/";

        /// <summary>
        /// まとめ使用量照会エリア(表示)
        /// </summary>
        public const string SUMMARY_USAGE_AREA_DISPLAY = "1";

        /// <summary>
        /// コンテンツ所属フォルダPath判別用：キャンペーン
        /// </summary>
        public const string CAMPAIGN_CONTENTS_FOLDER = "/sitecore/content/Content/Contents/InsideContentsFolder/CampaignContentsFolder";
        /// <summary>
        /// コンテンツ所属フォルダPath：お役立ち情報
        /// </summary>
        public const string USEFUL_CONTENTS_FOLDER = "/sitecore/content/Content/Contents/InsideContentsFolder/UsefulContentsFolder";
        /// <summary>
        /// コンテンツ所属フォルダPath：申込み・手続き
        /// </summary>
        public const string PROCEDURE_CONTENTS_FOLDER = "/sitecore/content/Content/Contents/InsideContentsFolder/ProcedureContentsFolder";

        /// <summary>
        /// コンテンツ（ポイント取得）種類
        /// </summary>
        public enum CONTENT_TYPE
        {
            Questionnaire = 11,// アンケート
            Content = 21,// コンテンツ
            ContentWithWffm = 22,// WFFM付きコンテンツ
            ContentWithEntryOneTime = 23,// エントリーコード付きコンテンツ(一回のみ登録)
            ContentWithEntryMutiTimes = 24,// エントリーコード付きコンテンツ(複数回登録)
            Others = 99// 未知
        };

        /// <summary>
        /// 認証コード区分：メール
        /// </summary>
        public const string NNSY_CLS_MAIL = "1";
        /// <summary>
        /// 認証コード区分：書面
        /// </summary>
        public const string NNSY_CLS_POST = "2";
        /// 認証コード区分：なし(発行していない)
        /// </summary>
        public const string NNSY_CLS_NOTHING = "3";

        /// <summary>
        /// 認証コード情報.認証済みフラグ - 未認証
        /// </summary>
        public const string NNSY_ZM_FLG_NO = "0";

        /// <summary>
        /// 認証コード情報.認証済みフラグ - 認証済み
        /// </summary>
        public const string NNSY_ZM_FLG_YES = "1";

        /// <summary>
        /// 認証コード発行送付先住所選択：基本情報変更
        /// </summary>
        public const string TGPME0105_SC05_UPDATE = "TGPME0105_SC05_UPDATE";

        /// <summary>
        /// 認証コード発行送付先住所選択：キャンセル
        /// </summary>
        public const string TGPME0105_SC05_CANCEL = "TGPME0105_SC05_CANCEL";

        /// <summary>
        /// 全角マイナス
        /// </summary>
        public const string ZENKAKU_MINUS = "－";

        /// <summary>
        /// UserId取得API WebAPIキー（環境変数）取得キー
        /// </summary>
        public const string ENV_LINE_USER_ID_GET_WEB_API_KEY = "LineUserIdGetWebApiKey";

        /// <summary>
        /// UserId取得API WebAPI URL（環境変数）取得キー
        /// </summary>
        public const string ENV_LINE_USER_ID_GET_WEB_API_URL = "LineUserIdGetWebApiUrl";

        /// <summary>
        /// Forms.チェックボックスリスト/ラジオリストでの選択肢の並び順 - 水平
        /// /// </summary>
        public const string Horizontal = "Horizontal";

        /// <summary>
        /// Forms.チェックボックスリスト/ラジオリストでの選択肢の並び順 - 垂直
        /// </summary>
        public const string Vertical = "Vertical";

        /// <summary>
        /// 外部接続PROXYサーバ（環境変数）取得キー
        /// </summary>
        public const string ENV_OUTBOUND_PROXY_SERVER = "OutboundProxyServer";

        /// <summary>
        /// 日付書式
        /// </summary>
        public const string DATETIME_FORMAT = "yyyyMMddHHmmss";

        /// <summary>
        /// SMS送信API
        /// </summary>
        public const string SEND_TYPE_SMS = "1";

        /// <summary>
        /// IVR認証API
        /// </summary>
        public const string SEND_TYPE_IVR = "2";

        /// <summary>
        /// GiftCard発行API GiftCard参照API URL（環境変数）取得キー
        /// </summary>
        public const string GIFTCARD_API_URL = "GiftCardApiUrl";

        /// <summary>
        /// ギフトカード(giftee Box)発行 API URL（環境変数）取得キー
        /// </summary>
        public const string GIFTEEBOX_API_URL = "GifteeboxApiUrl";

        /// <summary>
        /// GiftCard発行API GiftCard参照API チケットタイプ - 固定ギフト
        /// </summary>
        public const string GIFTEEAPI_TICKETTYPE_FIXED = "fixed";

        /// <summary>
        /// GiftCard発行API GiftCard参照API チケットタイプ - 選択ギフト
        /// </summary>
        public const string GIFTEEAPI_TICKETTYPE_CHOOSABLE = "choosable";

        /// <summary>
        /// PayPayAPI認可結果 - 承認
        /// </summary>
        public const string PAYPAY_DECISION_SUCCEEDED = "succeeded";

        /// <summary>
        /// グリーンエコがすてきポイント メニューID
        /// </summary>
        public const string GreenEcoPointMenuId = "201";

        #endregion

        #region "リクエストパラメータ

        /// <summary>
        /// リクエストパラメータ（コンテンツID）
        /// </summary>
        public const string REQUEST_PARAM_CONTENT_ID = "content";

        /// <summary>
        /// リクエストパラメータ（お知らせID）
        /// </summary>
        public const string REQUEST_PARAM_NEWS_ID = "news";

        /// <summary>
        /// リクエストパラメータ（ページ番号）
        /// </summary>
        public const string REQUEST_PARAM_PAGE_NUM = "page";

        /// <summary>
        /// リクエストパラメータ（管理ID）
        /// </summary>
        public const string REQUEST_PARAM_MANAGEMENT_ID = "ManagementId";

        /// <summary>
        /// リクエストパラメータ（ID）
        /// </summary>
        public const string REQUEST_PARAM_ID = "id";

        /// <summary>
        /// リクエストパラメータ（使用量・料金明細画面への会員ID）
        /// </summary>
        public const string REQUEST_PARAM_USAGE_KIIN_ID = "P001";

        /// <summary>
        /// リクエストパラメータ（使用量・料金明細画面へのセッションID）
        /// </summary>
        public const string REQUEST_PARAM_USAGE_SESSION_ID = "P002";

        #endregion

        #region "セッションキー"

        /// <summary>
        /// セッションキー(メールアドレス)
        /// </summary>
        public const string SESSION_KEY_MAILADDRESS = "TGPME0103_SC01_MailAddress";

        /// <summary>
        /// セッションキー(メールアドレス確認)
        /// </summary>
        public const string SESSION_KEY_MAILADDRESS_CONFIRM = "TGPME0103_SC01_MailAddressConfirm";

        /// <summary>
        /// セッションキー(パスワード)
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC04_PASSWORD = "TGPME0103_SC04_Password";

        /// <summary>
        /// セッションキー(メール配信の希望)<br/>
        /// [{id: xxx, value: 0 or 1}, ...] のJSON形式で格納する
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC04_MAILRECEIVABLE = "TGPME0103_SC04_MagazineDeliver";

        /// <summary>
        /// セッションキー(P_KIIN_KHN)
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC04_P_KIIN_KHN = "TGPME0103_SC04_P_KIIN_KHN";

        /// <summary>
        /// セッションキー(紹介者情報)
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC04_P_SYOKAISYA = "TGPME0103_SC04_P_SYOKAISYA";

        /// <summary>
        /// セッションキー(部署１情報)
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC04_GET_DIV_ASYNC = "TGPME0103_SC04_GET_DIV_ASYNC";

        /// <summary>
        /// セッションキー(会員基本情契約情報一覧の報契約情報)
        /// </summary>
        public const string SESSION_KEY_MEMBER_CONTRACT = "TGPME0108_SC01_CONTRACT";

        /// <summary>
        /// セッションキー(P_TIAWS)
        /// </summary>
        public const string SESSION_KEY_TGPQA0101_SC01_P_TIAWS = "TGPQA0101_SC01_P_TIAWS";

        /// <summary>
        /// セッションキー(メールアドレス確認)
        /// </summary>
        public const string SESSION_KEY_TGPQA0101_MAILADDRESS_CONFIRM = "TGPQA0101_SC01_ConfirmMailAddress";

        /// <summary>
        /// セッションキー(会員ID)
        /// </summary>
        public const string SESSION_KEY_KIINID = "KiinId";

        /// <summary>
        /// セッションキー(エラータイトル)
        /// </summary>
        public const string SESSION_KEY_HAVE_ERROR_TITLE = "HaveErrorTitle";

        /// <summary>
        /// セッションキー(エラーメッセージ)
        /// </summary>
        public const string SESSION_KEY_HAVE_ERROR_MESSAGE = "HaveErrorMessage";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_お名前(姓))
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_FIRSTNAME = "firstName";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_お名前(名))
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_LASTNAME = "lastName";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_お名前(セイ))
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_FIRSTNAMEKANA = "firstNameKana";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_お名前(メイ))
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_LASTNAMEKANA = "lastNameKana";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_性別)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_GENDER = "gender";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_メールアドレス)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_MAILADDRESS = "mailAddress";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_メールアドレス（サブ）)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_MAILADDRESSSUB = "mailAddressSub";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_電話番号１)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_PHONENUMBER1 = "phoneNumber1";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_電話番号２)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_PHONENUMBER2 = "phoneNumber2";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_郵便番号)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_POSTALCODE = "postalCode";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_都道府県)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_ADDRESS1 = "address1";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_市区町村)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_ADDRESS2 = "address2";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_町域名等・番地)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_ADDRESS3 = "address3";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_建物名・部屋番号)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_ADDRESS4 = "address4";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_ご利用用途)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_USEPURPOSE = "usePurpose";

        /// <summary>
        /// セッションキー(TGPME0107_SC01_お客さま番号)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_CUSTOMERNUM = "TGPME0107_SC01_CustomerNum";

        /// <summary>
        /// セッションキー(TGPME0107_SC01_郵送先コード)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_POSTALCODE = "TGPME0107_SC01_PostalCode";

        /// <summary>
        /// セッションキー(TGPME0107_SC01_郵送先)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_POSTAL = "TGPME0107_SC01_Postal";

        /// <summary>
        /// セッションキー(TGPME0107_SC01_契約番号)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_AGREEMENTNUM = "TGPME0107_SC01_AgreementNum";

        /// <summary>
        /// セッションキー(TGPME0107_SC01_サービス種別)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_SERVICEKIND = "TGPME0107_SC01_ServiceKind";

        /// <summary>
        /// セッションキー(TGPME0107_SC01_契約種別)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_AGREEMENTKIND = "TGPME0107_SC01_AgreementKind";

        /// <summary>
        /// セッションキー(TGPME0107_SC01_請求単位番号)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_CLAIMUNITNUM = "TGPME0107_SC01_ClaimUnitNum";

        /// <summary>
        /// セッションキー(TGPME0107_SC01_支払方法区分)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_PAYMENTDIV = "TGPME0107_SC01_PaymentDiv";

        /// <summary>
        /// セッションキー(TGPME0107_SC05_お客さま番号)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC05_CUSTOMERNUM = "TGPME0107_SC05_CustomerNum";

        /// <summary>
        /// セッションキー(TGPME0107_SC05_郵送先コード)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC05_POSTALCODE = "TGPME0107_SC05_PostalCode";

        /// <summary>
        /// セッションキー(TGPME0107_SC05_郵送先)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC05_POSTAL = "TGPME0107_SC05_Postal";

        /// <summary>
        /// セッションキー(TGPME0107_SC05_契約番号)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC05_AGREEMENTNUM = "TGPME0107_SC05_AgreementNum";

        /// <summary>
        /// セッションキー(TGPME0107_SC05_サービス種別)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC05_SERVICEKIND = "TGPME0107_SC05_ServiceKind";

        /// <summary>
        /// セッションキー(TGPME0107_SC05_契約種別)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC05_AGREEMENTKIND = "TGPME0107_SC05_AgreementKind";

        /// <summary>
        /// セッションキー(TGPME0107_SC05_請求単位番号)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC05_CLAIMUNITNUM = "TGPME0107_SC05_ClaimUnitNum";

        /// <summary>
        /// セッションキー(TGPME0107_SC05_支払方法区分)
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC05_PAYMENTDIV = "TGPME0107_SC05_PaymentDiv";

        /// <summary>
        /// セッションキー(TGPPT0201_ポイント交換)
        /// </summary>
        public const string SESSION_KEY_TGPPT0201_DATA = "TGPPT0201_Data";

        /// <summary>
        /// セッションキー(TGPPT0201_ポイント交換)
        /// </summary>
        public const string SESSION_KEY_USERNAME = "UserName";

        /// <summary>
        /// セッションキー(TGPME0104_退会_WFFM保存アクション制御)
        /// </summary>
        public const string SESSION_KEY_TGPME0104_WFFM = "TGPME0104_WFFM";

        /// <summary>
        /// セッションキー(ログアウトタイトル)
        /// </summary>
        public const string SESSION_KEY_HAVE_LOGOUT_TITLE = "HaveLogoutTitle";

        /// <summary>
        /// セッションキー(ログアウトメッセージ)
        /// </summary>
        public const string SESSION_KEY_HAVE_LOGOUT_MESSAGE = "HaveLogoutMessage";

        /// <summary>
        /// セッションキー(TGPPS0103_リファラ)
        /// </summary>
        public const string SESSION_KEY_TGPPS0103_REFERRER = "TGPPS0103_REFERRER";

        /// <summary>
        /// セッションキー(ダミー)
        /// </summary>
        public const string SESSION_KEY_DUMMY = "dummy";

        /// <summary>
        /// セッションキー(遷移元画面ID)
        /// </summary>
        public const string SESSION_KEY_PRE_SCREEN_ID = "preScreenId";

        /// <summary>
        /// セッションキー(画面表示時刻) ※ViewStateキーと兼用
        /// </summary>
        public const string SESSION_KEY_TAB_SCREEN_DISP_TIME = "TabScreenDispTime";

        // ▼▼▼V1.1仕様変更(2-12)_紙申請改善対応▼▼▼
        // ▼▼追加(Start)▼▼
        /// <summary>
        /// セッションキー(TGPME0102_SC01_リクエストモード)
        /// </summary>
        public const string SESSION_KEY_TGPME0102_SC01_REQUEST_MODE = "TGPME0102_SC01_RequestMode";

        /// <summary>
        /// セッションキー(TGPME0102_SC03_リクエストモード)
        /// </summary>
        public const string SESSION_KEY_TGPME0102_SC03_REQUEST_MODE = "TGPME0102_SC03_RequestMode";

        /// <summary>
        /// セッションキー(TGPME0103_SC02_リクエストモード)
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC02_REQUEST_MODE = "TGPME0103_SC02_RequestMode";

        /// <summary>
        /// セッションキー(TGPME0103_SC05_リクエストモード)
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC05_REQUEST_MODE = "TGPME0103_SC05_RequestMode";
        // ▲▲追加(End)▲▲

        /// <summary>
        /// セッションキー(TGPME0103_SC03_仮会員認証コード)
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC03_AUTHENTICATION_CODE = "TGPME0103_SC03_AuthenticationCode";

        /// <summary>
        /// セッションキー(TGPCM0102_SC02_戻り先URL)
        /// </summary>
        public const string SESSION_KEY_TGPCM0102_SC02_ReturnURL = "TGPCM0102_SC02_ReturnURL";

        /// <summary>
        /// セッションキー(TGPCM0102_SC02_戻り先名称)
        /// </summary>
        public const string SESSION_KEY_TGPCM0102_SC02_ReturnName = "TGPCM0102_SC02_ReturnName";

        /// <summary>
        /// セッションキー(TGPPT0201_SC10_他ポイント交換認証済みフラグ)
        /// </summary>
        public const string SESSION_KEY_TGPPT0201_SC10_AuthOkFlg = "TGPPT0201_SC10_AuthOkFlg";

        /// <summary>
        /// セッションキー(TGPME0105_SC01_遷移元画面)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC01_ScreenID = "TGPME0105_SC01_ScreenID";

        /// <summary>
        /// セッションキー(TGPME0105_SC05_郵送先住所)
        /// </summary>
        public const string SESSION_KEY_TGPME0105_SC05_PostAddress = "TGPME0105_SC05_PostAddress";

        /// <summary>
        /// セッションキー(TGPPT0201_SC10_ワンタイムパスワード)
        /// </summary>
        public const string SESSION_KEY_TGPPT0201_SC10_OneTimePassword = "TGPPT0201_SC10_OneTimePassword";

        /// <summary>
        /// セッションキー（受付者ID）
        /// </summary>
        public const string SESSION_KEY_UKTKSY_ID = "TGPME02_ReceptionistId";

        /// <summary>
        /// セッションキー(未登録会員情報)
        /// </summary>
        public const string SESSION_KEY_TGPME0301_SC01_NOT_REGISTER_USER_INFO = "TGPME0301_SC01_NOT_REGISTER_USER_INFO";

        /// <summary>
        /// セッションキー(遷移元画面ID)
        /// </summary>
        public const string SESSION_KEY_TGPME0301_SC01_SCREEN_ID = "TGPME0301_SC01_SCREEN_ID";

        /// <summary>
        /// セッションキー(P_KIIN_KHN)
        /// </summary>
        public const string SESSION_KEY_TGPME0303_SC01_P_KIIN_KHN = "TGPME0303_SC01_P_KIIN_KHN";

        /// <summary>
        /// セッションキー(PASSWORD)
        /// </summary>
        public const string SESSION_KEY_TGPME0303_SC01_PASSWORD = "TGPME0303_SC01_PASSWORD";

        /// <summary>
        /// セッションキー(Web明細)
        /// </summary>
        public const string SESSION_KEY_TGPME0303_SC01_WEB_MEISAI = "TGPME0303_SC01_WEB_MEISAI";

        /// <summary>
        /// セッションキー(メール配信)
        /// </summary>
        public const string SESSION_KEY_TGPME0303_SC01_MAIL_DELIVERY = "TGPME0303_SC01_MAIL_DELIVERY";

        /// <summary>
        /// セッションキー(TGPME0301_SC01_ワンタイムパスワード)
        /// </summary>
        public const string SESSION_KEY_TGPME0301_SC01_OneTimePassword = "TGPME0301_SC01_OneTimePassword";

        /// <summary>
        /// セッションキー(TGPRA0101_SC01_提携サービス情報リスト)
        /// </summary>
        public const string SESSION_KEY_TGPRA0101_SC01_TK_SBS_JYH = "TGPRA0101_SC01_TK_SBS_JYH";

        /// <summary>
        /// セッションキー(TGPRA0101_SC01_請求単位番号)
        /// </summary>
        public const string SESSION_KEY_TGPRA0101_SC01_SKTI_NO = "TGPRA0101_SC01_SKTI_NO";

        /// <summary>
        /// セッションキー(TGPPS0201_SC01_トークン)
        /// </summary>
        public const string SESSION_KEY_TGPPS0201_SC01_TOKEN = "TGPPS0201_SC01_TOKEN";

        /// <summary>
        /// セッションキー（TGPAN0102_SC03_契約番号）
        /// </summary>
        public const string SESSION_KEY_TGPAN0102_SC03_KIYK_NO = "TGPAN0102_SC03_KIYK_NO";

        /// <summary>
        /// セッションキー（TGPAN0102_SC03_DB_アクション）
        /// </summary>
        public const string SESSION_KEY_TGPAN0102_SC03_DB_ACTION = "TGPAN0102_SC03_DB_ACTION";

        /// <summary>
        /// セッションキー（SESSION_KEY_TGPME0103_SC01_画面遷移ID）
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC01_CID = "TGPME0103_SC01_CID";

        /// <summary>
        /// セッションキー（SESSION_KEY_TGPME0103_SC04_画面遷移ID）
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC04_CID = "TGPME0103_SC04_CID";

        /// <summary>
        /// セッションキー（SESSION_KEY_TGPME0103_SC04_商材ID）
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC04_SYZI_ID = "SESSION_KEY_TGPME0103_SC04_SYZI_ID";

        /// <summary>
        /// セッションキー（TGPME0110_SC01_dポイント会員番号）
        /// </summary>
        public const string SESSION_KEY_TGPME0110_SC01_D_POINT_NUMBER = "TGPME0110_SC01_D_POINT_NUMBER";

        /// <summary>
        /// セッションキー（TGPCM0103_SC02_dポイント会員番号）
        /// </summary>
        public const string SESSION_KEY_TGPCM0103_SC02_D_POINT_NUMBER = "TGPCM0103_SC02_D_POINT_NUMBER";

        /// <summary>
        /// セッションキー（TGPME0103_SC11_新規会員メール受付情報）
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC11_P_SNKKIIN_MAIL_UKTK = "TGPME0103_SC11_P_SNKKIIN_MAIL_UKTK";

        /// <summary>
        /// セッションキー（TGPME0103_SC11_新規会員受付情報）
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC11_P_SHK_KIIN_UKTK = "SCREEN_TGPME0103_SC11_P_SHK_KIIN_UKTK";

        /// <summary>
        /// セッションキー（TGPME0103_SC11_会員基本情報）
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC11_P_KIIN_KHN = "SCREEN_TGPME0103_SC11_P_KIIN_KHN";

        /// <summary>
        /// セッションキー（TGPME0103_SC11_メール配信のIDごとの希望フラグ）
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC11_MAIL_DELIVERY = "SCREEN_TGPME0103_SC11_MAIL_DELIVERY";

        /// <summary>
        /// セッションキー(TGPME0301_SC01_電話番号)
        /// </summary>
        public const string SESSION_KEY_TGPME0301_SC01_PHONE_NUMBER = "TGPME0301_SC01_Phone_Number";

        /// <summary>
        /// セッションキー（お知らせポップアップ表示フラグ）
        /// </summary>
        public const string SESSION_KEY_NOTICE_POPUP = "NoticePopup";

        /// <summary>
        /// セッションキー（コンタクトリスト）
        /// </summary>
        public const string SESSION_KEY_MY_CONTACT = "MyContact";

        /// <summary>
        /// セッションキー（TGPME0107_SC01_電話番号）
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_PHONENUMBER = "TGPME0107_SC01_PhoneNumber";

        /// <summary>
        /// セッションキー（TGPME0107_SC01_契約情報）
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_CONTRACT_INFO = "TGPME0107_SC01_ContractInfo";

        /// <summary>
        /// セッションキー（TGPME0107_SC01_お客さま番号）
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_SYB_NO = "TGPME0107_SC01_SybNo";

        /// <summary>
        /// セッションキー（TGPME0107_SC01_支払方法）
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC01_SHH_KBN = "TGPME0107_SC01_ShhKbn";

        /// <summary>
        /// セッションキー（TGPME0107_SC04_電話番号）
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC04_PHONENUMBER = "TGPME0107_SC04_PhoneNumber";

        /// <summary>
        /// セッションキー（TGPME0107_SC04_契約情報）
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC04_CONTRACT_INFO = "TGPME0107_SC04_ContractInfo";

        /// <summary>
        /// セッションキー（TGPME0107_SC04_お客さま番号）
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC04_SYB_NO = "TGPME0107_SC04_SybNo";

        /// <summary>
        /// セッションキー（TGPME0107_SC04_支払方法）
        /// </summary>
        public const string SESSION_KEY_TGPME0107_SC04_SHH_KBN = "TGPME0107_SC04_ShhKbn";

        /// <summary>
        /// セッションキー（TGPCM0103_SC02_AmazonユーザーID）
        /// </summary>
        public const string SESSION_KEY_TGPCM0103_SC02_AMAZON_USER_ID = "TGPCM0103_SC02_AMAZON_USER_ID";

        /// <summary>
        /// セッションキー（TGPME0111_SC01_AmazonユーザーID）
        /// </summary>
        public const string SESSION_KEY_TGPME0111_SC01_AMAZON_USER_ID = "TGPME0111_SC01_AMAZON_USER_ID";

        /// <summary>
        /// セッションキー（TGPME0114_SC01_キャンペーンID）
        /// </summary>
        public const string SESSION_KEY_TGPME0114_SC01_CAMPAIGN_ID = "TGPME0114_SC01_CAMPAIGN_ID";

        /// <summary>
        /// セッションキー（TGPCM0103_SC02_PayPayユーザー認可ID）
        /// </summary>
        public const string SESSION_KEY_TGPCM0103_SC02_PAYPAY_USER_ID = "TGPCM0103_SC02_PAYPAY_USER_ID";

        /// <summary>
        /// セッションキー（TGPME0115_SC01_PayPayユーザー認可ID）
        /// </summary>
        public const string SESSION_KEY_TGPME0115_SC01_PAYPAY_USER_ID = "TGPME0115_SC01_PAYPAY_USER_ID";

        /// <summary>
        /// セッションキー（TGPME0115_SC01_PayPay認可リダイレクトフラグ）
        /// </summary>
        public const string SESSION_KEY_TGPME0115_SC01_PAYPAY_REDIRECT_FLG = "TGPME0115_SC01_PAYPAY_REDIRECT_FLG";

        /// <summary>
        /// セッションキー（TGPME0115_SC01_PayPay認可エラーメッセージ）
        /// </summary>
        public const string SESSION_KEY_TGPME0115_SC01_PAYPAY_ERR_MESSAGE = "TGPME0115_SC01_PAYPAY_ERR_MESSAGE";

        /// <summary>
        /// セッションキー（TGPCM0103_SC02_nonce）
        /// </summary>
        public const string SESSION_KEY_TGPCM0103_SC02_NONCE = "TGPCM0103_SC02_NONCE";

        /// <summary>
        /// セッションキー（TGPME0115_SC01_nonce）
        /// </summary>
        public const string SESSION_KEY_TGPME0115_SC01_NONCE = "TGPME0115_SC01_NONCE";

        /// <summary>
        /// セッションキー（AuthRedirect_URL）
        /// </summary>
        public const string SESSION_KEY_AUTHREDIRECT_URL = "AUTHREDIRECT_URL";

        /// <summary>
        /// セッションキー（TGPCM0103_SC02_responseToken）
        /// </summary>
        public const string SESSION_KEY_TGPCM0103_SC02_RESPONSE_TOKEN = "TGPCM0103_SC02_RESPONSE_TOKEN";

        /// <summary>
        /// セッションキー（TGPME0103_SC01_提携先連携会員情報ID1）
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC01_TKS_RNKI_KIIN_INFO_PID1 = "TGPME0103_SC01_TKS_RNKI_KIIN_INFO_PID1";

        /// <summary>
        /// セッションキー（TGPME0103_SC01_提携先連携会員情報ID2）
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC01_TKS_RNKI_KIIN_INFO_PID2 = "TGPME0103_SC01_TKS_RNKI_KIIN_INFO_PID2";

        /// <summary>
        /// セッションキー（TGPME0103_SC01_提携先連携会員情報ID3）
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC01_TKS_RNKI_KIIN_INFO_PID3 = "TGPME0103_SC01_TKS_RNKI_KIIN_INFO_PID3";

        /// <summary>
        /// セッションキー（TGPME0103_SC01_商材ID）
        /// </summary>
        public const string SESSION_KEY_TGPME0103_SC01_SYZI_ID = "SESSION_KEY_TGPME0103_SC01_SYZI_ID";

        /// <summary>
        /// セッションキー（TGPME0116_SC01_エラーメッセージ）
        /// </summary>
        public const string SESSION_KEY_TGPME0116_SC01_ERR_MESSAGE = "TGPME0116_SC01_ERR_MESSAGE";

        /// <summary>
        /// セッションキー（TGPME0116_SC01_申込完了メッセージ）
        /// </summary>
        public const string SESSION_KEY_TGPME0116_SC01_COMPLETE_MESSAGE = "TGPME0116_SC01_COMPLETE_MESSAGE";


        #endregion

        #region "Sitecore区分値"

        /// <summary>
        /// 仮会員のドメイン
        /// </summary>
        public const string DOMAIN_TEMPORARY = "tohogasTemporary";

        /// <summary>
        /// ライト・本会員のドメイン
        /// </summary>
        public const string DOMAIN_REGULAR = "tohogasRegular";

        /// <summary>
        /// EmailCampaignのドメイン
        /// </summary>
        public const string DOMAIN_EMAIL_CAMPAIGN = "Emailcampaign";

        /// <summary>
        /// 業務種別 - 家庭用
        /// </summary>
        public const string BUSINESS_TYPE_FAMILY = "Business Type1";

        /// <summary>
        /// 業務種別 - 業務用
        /// </summary>
        public const string BUSINESS_TYPE_BUSINESS = "Business Type2";

        /// <summary>
        /// コンテンツの横幅 - 2枠
        /// </summary>
        public const string CONTENT_WIDTH2 = "Content Width2";

        /// <summary>
        /// コンテンツの横幅 - 3枠
        /// </summary>
        public const string CONTENT_WIDTH3 = "Content Width3";

        /// <summary>
        /// WFFMフォームのフィールドID　会員ID
        /// </summary>
        public const string WFFM_FORM_FIELD_KIIN_ID = "kiinId";

        /// <summary>
        /// WFFMフォームのフィールドID　コンテンツID
        /// </summary>
        public const string WFFM_FORM_FIELD_CONTENT_ID = "contentId";

        /// <summary>
        /// WFFMフォームのフィールドID　エントリーコード
        /// </summary>
        public const string WFFM_FORM_FIELD_ENTRY_CODE = "entryCode";

        /// <summary>
        /// WFFMフォームのフィールドID　支払方法
        /// </summary>
        public const string WFFM_FORM_FIELD_PAYMENT = "payment";

        /// <summary>
        /// WFFMフォームのフィールドID　お客さま番号
        /// </summary>
        public const string WFFM_FORM_FIELD_SYB_NO = "syb_no";

        /// <summary>
        /// PC用デバイスアイテムのGUID
        /// </summary>
        public const string DEVICE_ID_PC = "{FE5D7FDF-89C0-4D99-9AA3-B5FBD009C9F3}";

        /// <summary>
        /// IPAD用デバイスアイテムのGUID
        /// </summary>
        public const string DEVICE_ID_IPAD = "{CA5A6076-1DA5-4B8D-8FA9-6A3BEDBCCF3C}";

        /// <summary>
        /// SP用デバイスアイテムのGUID
        /// </summary>
        public const string DEVICE_ID_SP = "{9B7CA1FC-A8CE-4F1A-8127-ACDF4EE606D8}";

        #endregion

        #region "DB区分値"

        /// <summary>
        /// 論理削除フラグ - 未削除
        /// </summary>
        public const string RNR_SKZY_FLG_NOT_DELETED = "0";

        /// <summary>
        /// 論理削除フラグ - 削除済み
        /// </summary>
        public const string RNR_SKZY_FLG_DELETED = "1";

        /// <summary>
        /// 連携状態 - 連携済み状態
        /// </summary>
        public const string RNKI_JYTI_LINKED = "1";

        /// <summary>
        /// 連携状態 - 連携解除状態
        /// </summary>
        public const string RNKI_JYTI_RELEASED = "0";

        /// <summary>
        /// 付与年月の固定値 - 付与タイプがバージョンの場合の固定値
        /// </summary>
        public const string HY_YM_FIXED_VALUE = "999999";

        /// <summary>
        /// 付与キーの固定値 - 付与タイプが年月の場合の固定値
        /// </summary>
        public const string HY_KY_FIXED_VALUE = "9999999999";

        /// <summary>
        /// 会員状態 - ライト会員
        /// </summary>
        public const string KIIN_JYTI_LIGHT_KIIN = "1";

        /// <summary>
        /// 会員状態 - 本会員
        /// </summary>
        public const string KIIN_JYTI_HON_KIIN = "2";

        /// <summary>
        /// 会員基本情報.用途区分 - 初期値(家庭用)
        /// </summary>
        public const string YUT_KBN_FAMILY = "1";

        /// <summary>
        /// 会員基本情報.用途区分 - 業務用
        /// </summary>
        public const string YUT_KBN_BUSINESS = "2";

        /// <summary>
        /// 会員基本情報.性別 - 不明
        /// </summary>
        public const string SIBT_UNKNOWN = "0";

        /// <summary>
        /// 会員基本情報.性別 - 男
        /// </summary>
        public const string SIBT_MAN = "1";

        /// <summary>
        /// 会員基本情報.性別 - 女
        /// </summary>
        public const string SIBT_WOMAN = "2";

        /// <summary>
        /// 会員基本情報.性別 - 適用不能
        /// </summary>
        public const string SIBT_NOTAPPLICABLE = "9";

        /// <summary>
        /// 会員基本情報.会員ランク - ランクX
        /// </summary>
        public const string RANK_RANKX = "1";

        /// <summary>
        /// 会員基本情報.会員ランク - ランクY
        /// </summary>
        public const string RANK_RANKY = "2";

        /// <summary>
        /// 会員基本情報.紙検針票廃止フラグ - 廃止しない
        /// </summary>
        public const string KMKNSN_HIS_FLG_OFF = "0";

        /// <summary>
        /// 会員基本情報.紙検針票廃止フラグ - 廃止する
        /// </summary>
        public const string KMKNSN_HIS_FLG_ON = "1";

        /// <summary>
        /// 会員基本情報.ポイント会員状態 - 非ポイント会員(ライト会員の時)
        /// </summary>
        public const string PINT_KIIN_JYTI_LIGHT = "0";

        /// <summary>
        /// 会員基本情報.ポイント会員状態 - 非ポイント会員
        /// </summary>
        public const string PINT_KIIN_JYTI_NOT = "1";

        /// <summary>
        /// 会員基本情報.ポイント会員状態 - ポイント会員
        /// </summary>
        public const string PINT_KIIN_JYTI_PINT = "2";

        /// <summary>
        /// 会員基本情報.ポイント付与可否フラグ - 付与しない
        /// </summary>
        public const string PINT_HYKH_FLG_OFF = "0";

        /// <summary>
        /// 会員基本情報.ポイント付与可否フラグ - 付与する
        /// </summary>
        public const string PINT_HYKH_FLG_ON = "1";

        /// <summary>
        /// 会員基本情報.退会フラグ - 会員状態
        /// </summary>
        public const string TIKI_FLG_OFF = "0";

        /// <summary>
        /// 会員基本情報.退会フラグ - 退会
        /// </summary>
        public const string TIKI_FLG_ON = "1";

        /// <summary>
        /// 会員基本情報.実行モード - 本番
        /// </summary>
        public const string RUN_MODE_HON = "1";

        /// <summary>
        /// 会員基本情報.実行モード - テスト
        /// </summary>
        public const string RUN_MODE_TEST = "2";

        /// <summary>
        /// 会員基本情報.予備区分１ - 初期値
        /// </summary>
        public const string YB1 = "0";

        /// <summary>
        /// 会員基本情報.予備区分１ - 同一請求先契約の自動登録（要）
        /// </summary>
        public const string YB1_YES = "1";

        /// <summary>
        /// 会員基本情報.予備区分１ - 同一請求先契約の自動登録（否）
        /// </summary>
        public const string YB1_NO = "0";

        /// <summary>
        /// 会員基本情報.予備区分２ - 初期値
        /// </summary>
        public const string YB2 = "0";

        /// <summary>
        /// 会員基本情報.予備区分３ - 初期値
        /// </summary>
        public const string YB3 = "0";

        /// <summary>
        /// 認証失敗種別コード - ログイン失敗
        /// </summary>
        public const string NNSY_MISS_CD_LOGIN = "00";

        /// <summary>
        /// 認証失敗種別コード - 口座番号入力失敗
        /// </summary>
        public const string NNSY_MISS_CD_BANK = "10";

        /// <summary>
        /// 認証失敗種別コード - 認証番号入力失敗
        /// </summary>
        public const string NNSY_MISS_CD_AUTH = "20";

        /// <summary>
        /// 認証失敗種別コード - 退会認証失敗
        /// </summary>
        public const string NNSY_MISS_CD_QUIT = "30";

        /// <summary>
        /// 認証失敗種別コード - パスワード変更認証失敗
        /// </summary>
        public const string NNSY_MISS_CD_PASS = "40";

        /// <summary>
        /// 認証失敗種別コード - 電話番号入力失敗
        /// </summary>
        public const string NNSY_MISS_CD_PHONE = "50";

        /// <summary>
        /// 付与タイプ - バージョン
        /// </summary>
        public const string HY_TYPE_VERSION = "2";

        /// <summary>
        /// 付与タイプ - 年月
        /// </summary>
        public const string HY_TYPE_YM = "1";

        /// <summary>
        /// 紐づけ状態 - 未紐付け
        /// </summary>
        public const string HMTK_JYTI_NOTHING = "0";

        /// <summary>
        /// 紐づけ状態 - 紐付け済み
        /// </summary>
        public const string HMTK_JYTI_DONE = "1";

        /// <summary>
        /// 紐づけ状態 - 解除済み
        /// </summary>
        public const string HMTK_JYTI_RELESE = "2";

        /// <summary>
        /// 紐づけ状態 - 契約終了日（未終了）
        /// </summary>
        public const string HMTK_KIYK_SYRY_YMD_NOT = "99999999";

        /// <summary>
        /// 適用終了年月日（未終了）
        /// </summary>
        public const string TYS_YMD_NOT = "99999999";

        /// <summary>
        /// メルマガ配信設定.メルマガ配信ID - お知らせメルマガ
        /// </summary>
        public const string MLMG_ID_NOTICE = "10";

        /// <summary>
        /// メルマガ配信設定.メルマガ配信ID - 請求確定メール
        /// </summary>
        public const string MLMG_ID_BILLING = "50";

        /// <summary>
        /// メルマガ配信設定.メルマガ配信フラグ - 配信しない
        /// </summary>
        public const string MLMG_HISN_FLG_OFF = "0";

        /// <summary>
        /// メルマガ配信設定.メルマガ配信フラグ - 配信する
        /// </summary>
        public const string MLMG_HISN_FLG_ON = "1";

        /// <summary>
        /// メルマガ配信設定.請求確定メール拒否フラグ - 請求確定メール拒否なし
        /// </summary>
        public const string SKKKTI_KYH_FLG_OFF = "0";

        /// <summary>
        /// メルマガ配信設定.請求確定メール拒否フラグ - 請求確定メール拒否あり
        /// </summary>
        public const string SKKKTI_KYH_FLG_ON = "1";

        /// <summary>
        /// 会員管理メモ.会員管理メモ - メインアドレス変更
        /// </summary>
        public const string KIIN_KNR_MM = "メイン変更";

        /// <summary>
        /// 会員管理メモ.会員管理メモ - サブアドレス削除
        /// </summary>
        public const string KIIN_KNR_MM_SB_SKZY = "サブ削除";

        /// <summary>
        /// 会員管理メモ.会員管理メモ - サブアドレス変更
        /// </summary>
        public const string KIIN_KNR_MM_SB_KIZY = "サブ変更";

        /// <summary>
        /// 商品交換受付情報.状態 - 初期値
        /// </summary>
        public const string SYHN_KUKN_STATUS_DEF = "0";

        /// <summary>
        /// 商品交換受付情報.状態 - SmarP連携正常
        /// </summary>
        public const string SYHN_KUKN_STATUS_OK = "1";

        /// <summary>
        /// 商品交換受付情報.状態 - SmarP連携異常
        /// </summary>
        public const string SYHN_KUKN_STATUS_NG = "9";

        /// <summary>
        /// 会員契約紐づけ.契約会社コード - 東邦ガス
        /// </summary>
        public const string KIYK_KISY_CD_TOHOGAS = "100";

        /// <summary>
        /// 会員契約紐づけ.メインとする契約 - メイン以外
        /// </summary>
        public const string MN_KIYK_OTHER = "0";

        /// <summary>
        /// 会員契約紐づけ.メインとする契約 - メイン
        /// </summary>
        public const string MN_KIYK_MAIN = "1";

        /// <summary>
        /// 請求単位認証.認証番号郵送先 - 認証番号利用無
        /// </summary>
        public const string NNSY_NO_YUSUSK_NONE = "0";

        /// <summary>
        /// 請求単位認証.認証番号郵送先 - 請求先
        /// </summary>
        public const string NNSY_NO_YUSUSK_BILLING = "1";

        /// <summary>
        /// 請求単位認証.認証番号郵送先 - 使用場所
        /// </summary>
        public const string NNSY_NO_YUSUSK_USE = "2";

        /// <summary>
        /// 請求単位認証.認証番号郵送先 - 電話番号
        /// </summary>
        public const string NNSY_NO_YUSUSK_PHONE = "3";

        /// <summary>
        /// 請求単位認証.認証済みフラグ - 未認証
        /// </summary>
        public const string NNSY_ZM_FLG_OFF = "0";

        /// <summary>
        /// 請求単位認証.認証済みフラグ - 認証済み
        /// </summary>
        public const string NNSY_ZM_FLG_ON = "1";

        /// <summary>
        /// 請求単位認証.認証方法区分 - 口座番号下4桁による認証
        /// </summary>
        public const string NNSY_KBN_BANK = "1";

        /// <summary>
        /// 請求単位認証.認証方法区分 - 認証番号による認証
        /// </summary>
        public const string NNSY_KBN_AUTH = "2";

        /// <summary>
        /// 請求単位認証.認証方法区分 - 受付者による認証
        /// </summary>
        public const string NNSY_KBN_RECEPTION = "3";

        /// <summary>
        /// 請求単位認証.認証方法区分 - 会員化促進による認証
        /// </summary>
        public const string NNSY_KBN_PROMOTION = "4";

        /// <summary>
        /// 請求管理.請求タイミング区分 - 臨時
        /// </summary>
        public const string SEIKYU_TIMING_KBN_TEMP = "3";

        /// <summary>
        /// 請求管理.口座振替請求状態区分 - 振替依頼予定
        /// </summary>
        public const string KOUZA_FURIKAE_SEIKYU_KBN_FIRST = "1";

        /// <summary>
        /// 請求管理.口座振替請求状態区分 - 再振替依頼予定
        /// </summary>
        public const string KOUZA_FURIKAE_SEIKYU_KBN_SECOND = "2";

        /// <summary>
        /// 請求管理.口座振替請求状態区分 - 再々振替依頼予
        /// </summary>
        public const string KOUZA_FURIKAE_SEIKYU_KBN_THIRD = "3";

        /// <summary>
        /// 請求管理.請求確定年月日 - 確定済みを対象とする
        /// </summary>
        public const string SEIKYU_KAKUTEI_YMD = "00000000";

        /// <summary>
        /// 請求管理.最新入金状態区分 - 未入金
        /// </summary>
        public const string SAISIN_NYUKIN_KBN_MINYUKIN = "0";

        /// <summary>
        /// 請求管理.最新入金状態区分 - 一部入金
        /// </summary>
        public const string SAISIN_NYUKIN_KBN_ICHIBU_NYUKIN = "2";

        /// <summary>
        /// 請求管理.最新仮入金状態区分 - 未入金
        /// </summary>
        public const string SAISIN_KARI_NYUKIN_KBN_MINYUKIN = "0";

        /// <summary>
        /// 請求管理.最新仮入金状態区分 - 一部入金
        /// </summary>
        public const string SAISIN_KARI_NYUKIN_KBN_ICHIBUNYUKIN = "2";

        /// <summary>
        /// 請求管理.最新仮入金状態区分 - 未清算
        /// </summary>
        public const string SAISIN_KARI_NYUKIN_KBN_MISEISAN = "3";

        /// <summary>
        /// 調定.確定済フラグ, 請求.確定済フラグ - 確定済み
        /// </summary>
        public const string KAKUTEI_DETERMINED_FLAG = "1";

        /// <summary>
        /// 調定.調定発行区分 - 定例
        /// </summary>
        public const string TYUTI_HKU_KBN_TIRI = "1";

        /// <summary>
        /// 調定.調定発行区分 - 洩発行
        /// </summary>
        public const string TYUTI_HKU_KBN_HKUMR = "2";

        /// <summary>
        /// 調定.調定発行区分 - 追加
        /// </summary>
        public const string TYUTI_HKU_KBN_TIK = "4";

        /// <summary>
        /// 有効調定明細有フラグ
        /// </summary>
        public const string YUKU_TTMS_AR_FLG_1 = "1";

        /// <summary>
        /// 調定明細.サービス種別 - ガス
        /// </summary>
        public const string SERVICE_TYPE_GAS = "01";

        /// <summary>
        /// 調定明細.サービス種別 - 熱
        /// </summary>
        public const string SERVICE_TYPE_HEAT = "02";

        /// <summary>
        /// 調定明細.サービス種別 - 電気
        /// </summary>
        public const string SERVICE_TYPE_ELEC = "07";

        /// <summary>
        /// 調定明細.料金訂正区分 - 指針取消
        /// </summary>
        public const string RYOUKIN_TEISEI_KBN_SHISHIN_DELETE = "03";

        /// <summary>
        /// 調定明細.料金訂正区分 - 料金取消
        /// </summary>
        public const string RYOUKIN_TEISEI_KBN_RYOUKIN_DELETE = "13";

        /// <summary>
        /// 調定明細.内訳区分 - 内訳なし
        /// </summary>
        public const string UTWK_KBN_UTWK_NS = "0";

        /// <summary>
        /// 調定明細.内訳区分 - 合計
        /// </summary>
        public const string UTWK_KBN_GK = "1";

        /// <summary>
        /// 有効な契約種別.本会員フラグ - 無効
        /// </summary>
        public const string HKIIN_FLG_INVALID = "0";

        /// <summary>
        /// 有効な契約種別.本会員フラグ - 有効
        /// </summary>
        public const string HKIIN_FLG_VALID = "1";

        /// <summary>
        /// 有効な契約種別.ポイント会員フラグ - 無効
        /// </summary>
        public const string POINT_KIIN_FLG_INVALID = "0";

        /// <summary>
        /// 有効な契約種別.ポイント会員フラグ - 有効
        /// </summary>
        public const string POINT_KIIN_FLG_VALID = "1";

        /// <summary>
        /// 有効な契約種別.用途区分 - 家庭用
        /// </summary>
        public const string YUTO_KB_FAMILY = "1";

        /// <summary>
        /// 有効な契約種別.用途区分 - 業務用
        /// </summary>
        public const string YUTO_KB_BUSINESS = "2";

        /// <summary>
        /// 有効な契約種別.用途区分 - 家庭用／業務用混在
        /// </summary>
        public const string YUTO_KB_MIX = "9";

        /// <summary>
        /// 有効な契約種別.ポイント充当フラグ - 有効
        /// </summary>
        public const string PINT_JYT_FLG = "1";

        /// <summary>
        /// 契約.契約状態 - 契約済み
        /// </summary>
        public const string KIYK_ZYUTI = "1";

        /// <summary>
        /// 管理者.会員管理権限 - 照会のみ可能
        /// </summary>
        public const string KNGN_KAIIN_REFER = "0";

        /// <summary>
        /// 管理者.会員管理権限 - 利用不可
        /// </summary>
        public const string KNGN_KAIIN_NONE = "9";

        /// <summary>
        /// 管理者.ポイント付与管理権限 - 照会のみ可能
        /// </summary>
        public const string KNGN_POINT_REFER = "0";

        /// <summary>
        /// 管理者.ポイント付与管理権限 - 照会／更新が可能
        /// </summary>
        public const string KNGN_POINT_UPDATE = "1";

        /// <summary>
        /// 管理者.ポイント付与管理権限 - 利用不可
        /// </summary>
        public const string KNGN_POINT_NONE = "9";

        /// <summary>
        /// コード定義.コード種別 - サービス種別
        /// </summary>
        public const string CD_TYPE_SRV_KND = "0001";

        /// <summary>
        /// コード定義.コード種別 - 支払方法区分
        /// </summary>
        public const string CD_TYPE_SHR_KBN = "0024";

        /// <summary>
        /// コード定義.コード値 - （支払方法区分）口座振替
        /// </summary>
        public const string CD_SHR_KBN_KOZA = "2";

        /// <summary>
        /// コード定義.コード値 - （支払方法区分）その他
        /// </summary>
        public const string CD_SHR_KBN_OTHER = "9";

        /// コード定義.コード名称 - （支払方法区分）その他
        /// </summary>
        public const string NAME_SHR_KBN_OTHER = "その他（払込票等）";

        /// <summary>
        /// 支払口座.ゆうちょフラグ - ゆうちょ
        /// </summary>
        public const string YUTY_FLG_POSTBANK = "1";

        /// <summary>
        /// 支払口座.ゆうちょフラグ - ゆうちょ以外
        /// </summary>
        public const string YUTY_FLG_OTHER = "0";

        /// <summary>
        /// 性別：男性
        /// </summary>
        public const string SIBT_MAN_NAME = "男性";
        /// <summary>
        /// 性別：女性
        /// </summary>
        public const string SIBT_WOMAN_NAME = "女性";
        /// <summary>
        /// 日付：年
        /// </summary>
        public const string DATE_YEAR = "年";
        /// <summary>
        /// 日付：月
        /// </summary>
        public const string DATE_MONTH = "月";
        /// <summary>
        /// 日付：日
        /// </summary>
        public const string DATE_DAY = "日";
        /// <summary>
        /// 用途区分：家庭用
        /// </summary>
        public const string YUT_KBN_KATEI = "家庭用";
        /// <summary>
        /// 用途区分：業務用
        /// </summary>
        public const string YUT_KBN_GYOMU = "業務用";

        /// <summary>
        /// 管理者まとめ使用量紐づけ解除フラグ - 解除済み
        /// </summary>
        public const string KNRSY_MTM_SYR_HMTK_KIJY_FLG_RELEASED = "1";

        /// <summary>
        /// 管理者まとめ使用量紐づけ解除フラグ - 未解除
        /// </summary>
        public const string KNRSY_MTM_SYR_HMTK_KIJY_FLG_NOT_RELEASED = "0";

        /// <summary>
        /// 未登録会員情報.未登録会員発行区分 - 通常
        /// </summary>
        public const string MTURK_KIIN_HKUKBN_Normal = "1";

        /// <summary>
        /// 未登録会員情報.未登録会員発行区分 - 臨時
        /// </summary>
        public const string MTURK_KIIN_HKUKBN_Special = "2";

        /// <summary>
        /// 未登録会員情報.未登録会員発行区分 - 画面より申込み
        /// </summary>
        public const string MTURK_KIIN_HKUKBN_Apply = "9";

        /// <summary>
        /// 未登録会員情報.発行済み区分 - 未発行
        /// </summary>
        public const string HKZM_KBN_NOT_ISSUED = "0";

        /// <summary>
        /// 未登録会員情報.発行済み区分 - 発行済み
        /// </summary>
        public const string HKZM_KBN_ISSUED = "1";

        /// <summary>
        /// 未登録会員情報.発行済み区分 - 処理済み未発行
        /// </summary>
        public const string HKZM_KBN_PROCESSING = "2";

        /// <summary>
        /// 未登録会員情報.登録状態フラグ - 未登録
        /// </summary>
        public const string TURK_ZYUTI_FLG_NotYet = "0";

        /// <summary>
        /// 未登録会員情報.登録状態フラグ - 登録済み
        /// </summary>
        public const string TURK_ZYUTI_FLG_Already = "1";

        /// <summary>
        /// 未登録会員情報.登録区分 - 新規会員
        /// </summary>
        public const string TURK_KBN_NewKiin = "1";

        /// <summary>
        /// 未登録会員情報.登録区分 - 既存会員
        /// </summary>
        public const string TURK_KBN_ExistingKiin = "2";

        /// <summary>
        /// 新規会員受付情報.認証方法 - 通常認証
        /// </summary>
        public const string NINSY_HUHU_Normal = "0";

        /// <summary>
        /// 新規会員受付情報.認証方法 - 手動認証
        /// </summary>
        public const string NINSY_HUHU_Manual = "1";

        /// <summary>
        /// ClubTOHOGAS・表示対応区分 - 表示
        /// </summary>
        public const string CLUB_THG_HJTSY_KBN_YES = "1";

        /// <summary>
        /// 提携サービス継続状況 - 取消済み（キャンセル）
        /// </summary>
        public const string TK_SBS_KZK_JYKY_CANCEL = "901";

        /// <summary>
        /// 提携サービス継続状況 - 取消済み（重複）
        /// </summary>
        public const string TK_SBS_KZK_JYKY_DUP = "902";

        /// <summary>
        /// 提携サービス継続状況 - 取消済み（その他）
        /// </summary>
        public const string TK_SBS_KZK_JYKY_OTHER = "999";

        /// <summary>
        /// お知らせ区分グループ管理．大区分 - 契約
        public const string DIKBN_KIYK = "1";

        /// <summary>
        /// 料金コード(01:ガス料金)
        /// </summary>
        public const string RYUKN_CD_GAS = "01";

        /// <summary>
        /// 料金コード(02:熱料金)
        /// </summary>
        public const string RYUKN_CD_HEAT = "02";

        /// <summary>
        /// 料金コード(05:電気料金)
        /// </summary>
        public const string RYUKN_CD_ELEC = "05";

        /// <summary>
        /// 契約開始終了区分：料金改定（99）
        /// </summary>
        public const string KIYK_KIS_KBN_99 = "99";

        /// <summary>
        /// 使用場所電力補足.最新フラグ - 最新でない
        /// </summary>
        public const string SISN_FLG_OLD = "0";

        /// <summary>
        /// 使用場所電力補足.最新フラグ - 最新
        /// </summary>
        public const string SISN_FLG_LATEST = "1";

        /// <summary>
        /// ギフトキャンペーン管理.ステータス - 抽選対象登録済
        /// </summary>
        public const string STATUS_2 = "2";

        /// <summary>
        /// ギフトキャンペーン管理.ステータス - メール配信予約済
        /// </summary>
        public const string STATUS_3 = "3";

        /// <summary>
        /// ギフトクーポン管理.落選用フラグ - 通常当選用クーポン
        /// </summary>
        public const string RKSN_FLG_0 = "0";

        /// <summary>
        /// ギフトクーポン管理.落選用フラグ - 落選用クーポン
        /// </summary>
        public const string RKSN_FLG_1 = "1";

        /// <summary>
        ///ギフトキャンペーン管理.gifteeBoxフラグ - gifteeBoxではない
        /// </summary>
        public const string GBOX_FLG_FALSE = "0";

        /// <summary>
        ///ギフトキャンペーン管理.gifteeBoxフラグ - gifteeBoxである
        /// </summary>
        public const string GBOX_FLG_TRUE = "1";

        /// <summary>
        /// ギフトクーポン当選.チケットタイプ - 固定ギフト
        /// </summary>
        public const string TKT_TIP_01 = "01";

        /// <summary>
        /// ギフトクーポン当選.チケットタイプ - 選択ギフト
        /// </summary>
        public const string TKT_TIP_02 = "02";

        /// <summary>
        /// ギフトクーポン当選.チケットタイプ - giftee Box
        /// </summary>
        public const string TKT_TIP_03 = "03";

        /// <summary>
        /// 新商材会員申込履歴.紹介種類コード - 紹介あり
        /// </summary>
        public const string SYKI_SYRI_CD_TRUE = "1";

        /// <summary>
        /// 新商材会員申込履歴.紹介種類コード - 紹介なし
        /// </summary>
        public const string SYKI_SYRI_CD_FALSE = "2";
        #endregion

        #region "SmarP区分値"

        /// <summary>
        /// ポイント履歴取得 - 1ページあたりの取得数
        /// </summary>
        public const string TRANSACTIONPOINTAPI_MAXRESULT_DEF = "20";

        /// <summary>
        /// HTTPリクエストボディ部フォーマットのキー - sc
        /// </summary>
        public const string SMARP_HTTP_REQUEST_BODY_KEY_SC = "sc";

        /// <summary>
        /// HTTPリクエストボディ部フォーマットのキー - uc
        /// </summary>
        public const string SMARP_HTTP_REQUEST_BODY_KEY_UC = "uc";

        /// <summary>
        /// HTTPリクエストボディ部フォーマットのキー - ucc
        /// </summary>
        public const string SMARP_HTTP_REQUEST_BODY_KEY_UCC = "ucc";

        /// <summary>
        /// HTTPリクエストボディ部フォーマットのキー - p
        /// </summary>
        public const string SMARP_HTTP_REQUEST_BODY_KEY_P = "p";

        /// <summary>
        /// HTTPリクエストボディ部フォーマットのキー - bc
        /// </summary>
        public const string SMARP_HTTP_REQUEST_BODY_KEY_BC = "bc";

        /// <summary>
        /// SmarP退会API - 退会理由(未設定)
        /// </summary>
        public const string SMARP_LEAVE_REASON_NO_SETTING = "00";


        /// <summary>
        /// SmarP会員情報登録（磁気カード用）API - 会員姓（カナ）、会員名（カナ）
        /// </summary>
        public const string SMARP_MEMBER_REGIST_KANA = "ー";

        /// <summary>
        /// SmarP会員情報登録（磁気カード用）API - 携帯メールアドレス
        /// </summary>
        public const string SMARP_MEMBER_REGIST_MOBILE_ADDRESS = "";

        /// <summary>
        /// SmarP会員情報登録（磁気カード用）API - 郵便番号「000-0000」固定
        /// </summary>
        public const string SMARP_MEMBER_REGIST_ZIPCODE = "000-0000";

        /// <summary>
        /// SmarP会員情報登録（磁気カード用）API - 住所２（市区郡）「市区町村」固定
        /// </summary>
        public const string SMARP_MEMBER_REGIST_ADDRESS2 = "市区町村";

        /// <summary>
        /// SmarP会員情報登録（磁気カード用）API - 住所３（町名番地）「所番地」固定
        /// </summary>
        public const string SMARP_MEMBER_REGIST_ADDRESS3 = "所番地";

        /// <summary>
        /// SmarP会員情報登録（磁気カード用）API - 携帯メルマガ配信
        /// </summary>
        public const string SMARP_MEMBER_REGIST_MOBILE_MAGAZINE_FLAG = "";

        /// <summary>
        /// SmarP会員情報登録（磁気カード用）API - 表示先（PC or Mobile）「0：PC]固定
        /// </summary>
        public const string SMARP_MEMBER_REGIST_DISPLAY_TYPE = "0";

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [0]トランザクションID
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_TRANSACTION_ID = 0;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [1]取引処理年月日
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_TRADE_DATE = 1;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [2]取引処理時刻
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_TRADE_TIME = 2;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [3]ポイント種別コード
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_POINT_TYPE_CODE = 3;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [4]ポイント種別名称
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_POINT_TYPE_NAME = 4;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [5]取引ポイント
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_POINT = 5;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [6]購入金額
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_PROCEEDS = 6;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [7]備考
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_TRANSACTION_NOTE = 7;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [8]商品コード
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_GOODS_CODE = 8;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [9]商品名
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_GOODS_NAME = 9;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [10]交換先付帯情報
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_REMARK_TXT = 10;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [11]交換ステータスコード
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_EXCHANGE_STATUS_CODE = 11;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [12]交換ステータス名
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_EXCHANGE_STATUS_NAME = 12;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [13]加盟店コード
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_SHOP_CODE = 13;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [14]店舗名
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_SHOP_NAME = 14;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [15]キャンペーンコード
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_CAMPAIGN_CODE = 15;

        /// <summary>
        /// ポイント履歴取得API - 項目番号 - [16]キャンペーン名
        /// </summary>
        public const int SMARP_POINT_HISTORY_ITEMNUM_CAMPAIGN_NAME = 16;

        /// <summary>
        /// ポイント履歴 - ポイント種別4002
        /// </summary>
        public const int POINT_KIND_4002 = 4002;

        /// <summary>
        /// ポイント履歴 - ポイント種別9002
        /// </summary>
        public const int POINT_KIND_9002 = 9002;

        /// <summary>
        /// ポイント履歴 - ポイント種別9050
        /// </summary>
        public const int POINT_KIND_9050 = 9050;

        /// <summary>
        /// ポイント履歴 - ポイント種別4001
        /// </summary>
        public const int POINT_KIND_4001 = 4001;

        /// <summary>
        /// ポイント履歴 - ポイント種別4002のグリーンエコがすてきポイント名称
        /// </summary>
        public const string POINT_KIND_4002_HISTORY_ITEM_CN_NAME = "グリーンエコがすてきポイント";

        #endregion

        #region "会員種別区分値"

        /// <summary>
        /// 親コントロール名 - form1
        /// </summary>
        public const string PARENT_CONTROL = "form1";

        /// <summary>
        /// ライト会員を表すクラス名 - cl_common_lightMember
        /// </summary>
        public const string MEMBER_KIND_LIGHT_CLASS = "cl_common_lightMember";

        /// <summary>
        /// 本会員（非ポイント）を表すクラス名 - cl_common_noPoint
        /// </summary>
        public const string MEMBER_KIND_NOT_POINT_CLASS = "cl_common_noPoint";

        /// <summary>
        /// 契約紐付けなしを表すクラス名 - cl_common_noAgree
        /// </summary>
        public const string AVAILABLE_CONTRACT_NO_CLASS = "cl_common_noAgree";

        /// <summary>
        /// 取得対象コントロールタイプ - System.Web.UI.WebControls.HyperLink
        /// </summary>
        public const string CONTROL_TYPE = "System.Web.UI.WebControls.HyperLink";

        #endregion

        #region "メールID"

        /// <summary>
        /// 会員ID忘却通知メール
        /// </summary>
        public const string MAIL_ID_TGTM001 = "TGTM001";

        /// <summary>
        /// パスワード忘却通知メール
        /// </summary>
        public const string MAIL_ID_TGTM002 = "TGTM002";

        /// <summary>
        /// パスワード再設定通知メール
        /// </summary>
        public const string MAIL_ID_TGTM003 = "TGTM003";

        /// <summary>
        /// 会員本登録案内メール
        /// </summary>
        public const string MAIL_ID_TGTM004 = "TGTM004";

        /// <summary>
        /// ライト会員登録完了通知メール
        /// </summary>
        public const string MAIL_ID_TGTM005 = "TGTM005";

        /// <summary>
        /// 会員情報変更完了通知メール
        /// </summary>
        public const string MAIL_ID_TGTM006 = "TGTM006";

        /// <summary>
        /// パスワード変更完了通知メール
        /// </summary>
        public const string MAIL_ID_TGTM007 = "TGTM007";

        /// <summary>
        /// 商品交換受付メール
        /// </summary>
        public const string MAIL_ID_TGTM008 = "TGTM008";

        /// <summary>
        /// 問合せ受付メール
        /// </summary>
        public const string MAIL_ID_TGTM009 = "TGTM009";

        /// <summary>
        /// 請求金額確定メール
        /// </summary>
        public const string MAIL_ID_TGTM010 = "TGTM010";

        /// <summary>
        /// 商品交換受付管理者用メール
        /// </summary>
        public const string MAIL_ID_TGTM011 = "TGTM011";

        /// <summary>
        /// 会員ID忘却通知メール（メールアドレス登録無し）
        /// </summary>
        public const string MAIL_ID_TGTM012 = "TGTM012";

        /// <summary>
        /// クーポン発行完了メール
        /// </summary>
        public const string MAIL_ID_TGTM013 = "TGTM013";

        /// <summary>
        /// 管理者向けクーポン発行完了メール
        /// </summary>
        public const string MAIL_ID_TGTM014 = "TGTM014";

        // ▼▼▼V1.1仕様変更(2-12)_紙申請改善対応▼▼▼
        // ▼▼追加(Start)▼▼
        /// <summary>
        /// 紙登録用パスワード設定通知メール
        /// </summary>
        public const string MAIL_ID_TGTM015 = "TGTM015";

        /// <summary>
        /// 紙登録用会員本登録事務局メール
        /// </summary>
        public const string MAIL_ID_TGTM016 = "TGTM016";

        /// <summary>
        /// 紙登録用ライト会員登録完了事務局メール
        /// </summary>
        public const string MAIL_ID_TGTM017 = "TGTM017";
        // ▲▲追加(End)▲▲

        /// <summary>
        /// ポイント充当申込完了メール
        /// </summary>
        public const string MAIL_ID_TGTM018 = "TGTM018";

        /// <summary>
        /// 管理者向けポイント充当申込完了メール
        /// </summary>
        public const string MAIL_ID_TGTM019 = "TGTM019";

        /// <summary>
        /// 他ポイント交換ワンタイムパスワード通知メール
        /// </summary>
        public const string MAIL_ID_TGTM020 = "TGTM020";

        /// <summary>
        /// 会員情報変更認証コード通知メール
        /// </summary>
        public const string MAIL_ID_TGTM021 = "TGTM021";

        /// <summary>
        /// タブレット入会用パスワード設定通知メール
        /// </summary>
        public const string MAIL_ID_TGTM022 = "TGTM022";

        /// <summary>
        /// パスワード設定完了メール
        /// </summary>
        public const string MAIL_ID_TGTM023 = "TGTM023";

        /// <summary>
        /// 未登録会員認証ワンタイムパスワード通知メール
        /// </summary>
        public const string MAIL_ID_TGTM024 = "TGTM024";

        /// <summary>
        /// 会員化促進用会員情報契約情報登録完了通知メール
        /// </summary>
        public const string MAIL_ID_TGTM025 = "TGTM025";

        /// <summary>
        /// 電気のお申込完了メール_契約切替&新規_dプラン_らくらく申込む
        /// </summary>
        public const string MAIL_ID_TGTM027 = "TGTM027";

        /// <summary>
        /// 電気のお申込完了メール_契約切替&新規_dプラン_らくらく申し込まない
        /// </summary>
        public const string MAIL_ID_TGTM028 = "TGTM028";

        /// <summary>
        /// 電気のお申込完了メール_契約切替&新規_dプラン以外_らくらく申込む
        /// </summary>
        public const string MAIL_ID_TGTM029 = "TGTM029";

        /// <summary>
        /// 電気のお申込完了メール_契約切替&新規_dプラン以外_らくらく申し込まない
        /// </summary>
        public const string MAIL_ID_TGTM030 = "TGTM030";

        /// <summary>
        /// 電気のお申込完了メール_契約変更_dプラン_らくらく申込む
        /// </summary>
        public const string MAIL_ID_TGTM031 = "TGTM031";

        /// <summary>
        /// 電気のお申込完了メール_契約変更_dプラン_らくらく申し込まない
        /// </summary>
        public const string MAIL_ID_TGTM032 = "TGTM032";

        /// <summary>
        /// タブレット入会促進パスワード設定通知メール
        /// </summary>
        public const string MAIL_ID_TGTM033 = "TGTM033";

        /// <summary>
        /// タブレット入会促進パスワード設定完了メール
        /// </summary>
        public const string MAIL_ID_TGTM034 = "TGTM034";

        /// <summary>
        /// 電気のお申込完了メール_契約切替&新規_aプラン_らくらく申込む
        /// </summary>
        public const string MAIL_ID_TGTM035 = "TGTM035";

        /// <summary>
        /// 電気のお申込完了メール_契約切替&新規_aプラン_らくらく申し込まない
        /// </summary>
        public const string MAIL_ID_TGTM036 = "TGTM036";

        /// <summary>
        /// 電気のお申込完了メール_契約変更_aプラン_らくらく申込む
        /// </summary>
        public const string MAIL_ID_TGTM037 = "TGTM037";

        /// <summary>
        /// 電気のお申込完了メール_契約切替&新規_pプラン_らくらく申込む
        /// </summary>
        public const string MAIL_ID_TGTM039 = "TGTM039";

        /// <summary>
        /// 電気のお申込完了メール_契約切替&新規_pプラン_らくらく申し込まない
        /// </summary>
        public const string MAIL_ID_TGTM040 = "TGTM040";

        /// <summary>
        /// 電気のお申込完了メール_契約変更_pプラン
        /// </summary>
        public const string MAIL_ID_TGTM041 = "TGTM041";

        /// <summary>
        /// グリーンエコがすてきポイント交換完了メール
        /// </summary>
        public const string MAIL_ID_TGTM042 = "TGTM042";

        /// <summary>
        /// 管理者向けグリーンエコがすてきポイント交換完了メール
        /// </summary>
        public const string MAIL_ID_TGTM043 = "TGTM043";

        #endregion

        #region "新商材"
        /// <summary>
        /// 販売形態 - 代理
        /// </summary>
        public const string HNBI_KITI_DAIRI = "01";
        /// <summary>
        /// 販売形態 - 媒介
        /// </summary>
        public const string HNBI_KITI_BAIKAI = "02";
        /// <summary>
        /// 販売形態 - 取次
        /// </summary>
        public const string HNBI_KITI_TORITSUGI = "03";
        /// <summary>
        /// 販売形態 - 自社
        /// </summary>
        public const string HNBI_KITI_JISYA = "04";
        #endregion

        #region "画面ID"

        /// <summary>
        /// 画面ID - ポイント交換商品一覧画面
        /// </summary>
        public const string SCREEN_ID_TGPPT0201_SC10 = "TGPPT0201_SC10";

        /// <summary>
        /// 画面ID - ポイント交換商品詳細画面
        /// </summary>
        public const string SCREEN_ID_TGPPT0201_SC03 = "TGPPT0201_SC03";

        /// <summary>
        /// 画面ID - ポイント交換商品注文入力画面
        /// </summary>
        public const string SCREEN_ID_TGPPT0201_SC04 = "TGPPT0201_SC04";

        /// <summary>
        /// 画面ID - ポイント交換商品注文確認画面
        /// </summary>
        public const string SCREEN_ID_TGPPT0201_SC05 = "TGPPT0201_SC05";

        /// <summary>
        /// 画面ID - クーポン発行入力画面
        /// </summary>
        public const string SCREEN_ID_TGPPT0202_SC01 = "TGPPT0202_SC01";

        /// <summary>
        /// 画面ID - クーポン発行確認画面
        /// </summary>
        public const string SCREEN_ID_TGPPT0202_SC02 = "TGPPT0202_SC02";

        /// <summary>
        /// 画面ID - ポイント充当申込入力画面
        /// </summary>
        public const string SCREEN_ID_TGPPT0204_SC01 = "TGPPT0204_SC01";

        /// <summary>
        /// 画面ID - ポイント充当申込確認画面
        /// </summary>
        public const string SCREEN_ID_TGPPT0204_SC02 = "TGPPT0204_SC02";

        /// <summary>
        /// 画面ID - 会員情報契約情報一覧画面
        /// </summary>
        public const string SCREEN_ID_TGPME0108_SC01 = "TGPME0108_SC01";

        /// <summary>
        /// 画面ID - 契約情報入力画面
        /// </summary>
        public const string SCREEN_ID_TGPME0107_SC04 = "TGPME0107_SC04";

        /// <summary>
        /// 画面ID - 契約情報確認画面
        /// </summary>
        public const string SCREEN_ID_TGPME0107_SC05 = "TGPME0107_SC05";

        /// <summary>
        /// 画面ID - 契約情報詳細画面
        /// </summary>
        public const string SCREEN_ID_TGPME0112_SC01 = "TGPME0112_SC01";

        /// <summary>
        /// 画面ID - 未登録会員既存会員紐付画面
        /// </summary>
        public const string SCREEN_ID_TGPME0302_SC01 = "TGPME0302_SC01";

        /// <summary>
        /// 画面ID - 未登録会員お客さま情報入力画面
        /// </summary>
        public const string SCREEN_ID_TGPME0303_SC01 = "TGPME0303_SC01";

        /// <summary>
        /// 画面ID - 未登録会員お客さま情報確認画面
        /// </summary>
        public const string SCREEN_ID_TGPME0303_SC02 = "TGPME0303_SC02";

        /// <summary>
        /// 画面ID - ログイン画面
        /// </summary>
        public const string SCREEN_ID_TGPPS0101_SC01 = "TGPPS0101_SC01";

        /// <summary>
        /// 画面ID - お知らせ画面（お知らせ表示）
        /// </summary>
        public const int PAGE_OSRS = 1;

        /// <summary>
        /// 画面ID - クーポン一覧画面（お知らせ表示）
        /// </summary>
        public const int PAGE_LOTTERY = 2;

        #endregion

        #region 新商材

        /// <summary>
        /// 新商材 - 新商材申し込み一覧画面 - 金額
        /// </summary>
        public const string SNSYZI_LIST_ID_001 = "1001";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 商材画像説明
        /// </summary>
        public const string SNSYZI_DETAIL_ID_001 = "2001";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 商品詳細説明２
        /// </summary>
        public const string SNSYZI_DETAIL_ID_002 = "2002";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 商品タイトル／発送地域
        /// </summary>
        public const string SNSYZI_DETAIL_ID_003 = "2003";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 商品詳細説明
        /// </summary>
        public const string SNSYZI_DETAIL_ID_004 = "2004";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - お届け日
        /// </summary>
        public const string SNSYZI_DETAIL_ID_005 = "2005";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 初回お届け日
        /// </summary>
        public const string SNSYZI_DETAIL_ID_006 = "2006";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 初回ご注文日時と翌月以降のお届け日の説明
        /// </summary>
        public const string SNSYZI_DETAIL_ID_007 = "2007";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 税区分
        /// </summary>
        public const string SNSYZI_DETAIL_ID_008 = "2008";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 価格改定文言
        /// </summary>
        public const string SNSYZI_DETAIL_ID_009 = "2009";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 送料テキスト
        /// </summary>
        public const string SNSYZI_DETAIL_ID_010 = "2010";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - お支払方法
        /// </summary>
        public const string SNSYZI_DETAIL_ID_011 = "2011";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - お支払い金額と時期
        /// </summary>
        public const string SNSYZI_DETAIL_ID_012 = "2012";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 定期購入の停止について
        /// </summary>
        public const string SNSYZI_DETAIL_ID_013 = "2013";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 解約について
        /// </summary>
        public const string SNSYZI_DETAIL_ID_014 = "2014";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 返品・交換・不良品対応について
        /// </summary>
        public const string SNSYZI_DETAIL_ID_015 = "2015";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 会社名
        /// </summary>
        public const string SNSYZI_DETAIL_ID_016 = "2016";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - ストア
        /// </summary>
        public const string SNSYZI_DETAIL_ID_017 = "2017";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 住所
        /// </summary>
        public const string SNSYZI_DETAIL_ID_018 = "2018";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 担当者
        /// </summary>
        public const string SNSYZI_DETAIL_ID_019 = "2019";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 連絡先
        /// </summary>
        public const string SNSYZI_DETAIL_ID_020 = "2020";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 電話
        /// </summary>
        public const string SNSYZI_DETAIL_ID_021 = "2021";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - ストアコンセプト
        /// </summary>
        public const string SNSYZI_DETAIL_ID_022 = "2022";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 配送方法／配送会社についての文章
        /// </summary>
        public const string SNSYZI_DETAIL_ID_023 = "2023";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - プライバシーポリシーの文章
        /// </summary>
        public const string SNSYZI_DETAIL_ID_024 = "2024";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 会員登録をせずに申込
        /// </summary>
        public const string SNSYZI_DETAIL_ID_025 = "2025";

        /// <summary>
        /// 新商材 - 新商材申し込み詳細画面 - 金額
        /// </summary>
        public const string SNSYZI_DETAIL_ID_026 = "2026";

        #endregion

        #region 2022年度3Q案件_安心サービスUI対応による更新
        /// Update Date      : 2023/02/15

        /// <summary>
        /// リクエストパラメータ（安心サービス申込コード）
        /// </summary>
        public const string REQUEST_PARAM_ANSHINMUSKM_CODE = "mid";

        /// <summary>
        /// 申込コード - 加入
        /// </summary>
        public const string ANSHINMUSKM_CODE_APPLY = "1";

        /// <summary>
        /// 申込コード - 解約
        /// </summary>
        public const string ANSHINMUSKM_CODE_CANCEL = "2";

        /// <summary>
        /// 会員コード定義.コード種別 - 安心サービスプラン区分
        /// </summary>
        public const string KIIN_CD_SHBT_ANSHIN_PLAN = "5";

        /// <summary>
        /// 会員コード定義.コード値 - （ 安心サービスプラン区分）安心サービス共通プラン
        /// </summary>
        public const string KIIN_CD_ANSHINPLAN_KBN_KYOTSU = "0";

        /// <summary>
        /// セッションキー（TGPME0117_SC03_会員ID）
        /// </summary>
        public const string SESSION_KEY_TGPME0117_SC03_KIIN_ID = "TGPME0117_SC03_KIIN_ID";

        /// <summary>
        /// セッションキー（TGPME0117_SC03_申込番号）
        /// </summary>
        public const string SESSION_KEY_TGPME0117_SC03_MSM_NO = "TGPME0117_SC03_MSM_NO";

        /// <summary>
        /// セッションキー（TGPME0117_SC06_申込番号）
        /// </summary>
        public const string SESSION_KEY_TGPME0117_SC06_MSM_NO = "TGPME0117_SC06_MSM_NO";

        /// <summary>
        /// 画面ID - タブレット入会促進新規会員登録会員情報入力画面
        /// </summary>
        public const string SCREEN_ID_TGPME0103_SC11 = "TGPME0103_SC11";

        /// <summary>
        /// 画面ID - タブレット入会促進新規会員登録会員情報確認画面
        /// </summary>
        public const string SCREEN_ID_TGPME0103_SC12 = "TGPME0103_SC12";

        /// <summary>
        /// 画面ID - タブレット入会促進新規会員登録会員情報完了画面
        /// </summary>
        public const string SCREEN_ID_TGPME0103_SC13 = "TGPME0103_SC13";

        /// <summary>
        /// 画面ID - タブレット入会促進安心サービス申込入力画面
        /// </summary>
        public const string SCREEN_ID_TGPME0117_SC01 = "TGPME0117_SC01";

        /// <summary>
        /// 画面ID - タブレット入会促進安心サービス申込確認画面
        /// </summary>
        public const string SCREEN_ID_TGPME0117_SC02 = "TGPME0117_SC02";

        /// <summary>
        /// 画面ID - 安心サービス申込入力画面
        /// </summary>
        public const string SCREEN_ID_TGPME0117_SC04 = "TGPME0117_SC04";

        /// <summary>
        /// 画面ID - 安心サービス申込確認画面
        /// </summary>
        public const string SCREEN_ID_TGPME0117_SC05 = "TGPME0117_SC05";

        /// <summary>
        /// 安心サービス契約の申込み受付完了通知メール
        /// </summary>
        public const string MAIL_ID_TGTM044 = "TGTM044";

        /// <summary>
        /// 安心サービス契約の解約申込み受付完了のメール
        /// </summary>
        public const string MAIL_ID_TGTM045 = "TGTM045";

        /// <summary>
        /// 申込区分詳細 - 新規 - CTG申込
        /// </summary>
        public const string ANSHIN_MSM_KBN_SYUSI_TIE1 = "1";

        /// <summary>
        /// 申込区分詳細 - 新規 - 現場出張
        /// </summary>
        public const string ANSHIN_MSM_KBN_SYUSI_TIE2 = "2";

        /// <summary>
        /// 申込区分詳細 - 解約 - CTG申込
        /// </summary>
        public const string ANSHIN_MSM_KBN_SYUSI_UNTIE3 = "3";

        /// <summary>
        /// 申込区分詳細 - 解約 - ガス契約紐付解除
        /// </summary>
        public const string ANSHIN_MSM_KBN_SYUSI_UNTIE4 = "4";

        /// <summary>
        /// 申込区分詳細 - 解約 - 退会
        /// </summary>
        public const string ANSHIN_MSM_KBN_SYUSI_UNTIE5 = "5";

        /// <summary>
        /// CusTo-net連携許可フラグ - 許可しない
        /// </summary>
        public const string ANSHIN_RNKE_KYK_FLG_NOTALLOW = "0";

        /// <summary>
        /// CusTo-net連携許可フラグ - 許可する
        /// </summary>
        public const string ANSHIN_RNKE_KYK_FLG_ALLOW = "1";

        /// <summary>
        /// CTGエラー依頼フラグ - エラーとしない
        /// </summary>
        public const string ANSHIN_CTG_ERR_IRI_FLG_ERROR = "0";

        /// <summary>
        /// CTGエラー依頼フラグ - エラーとする
        /// </summary>
        public const string ANSHIN_CTG_ERR_IRI_FLG_NOTERROR = "1";

        /// <summary>
        /// エラー理由コード - 正常
        /// </summary>
        public const string ANSHIN_ERR_CD_NORMAL = "0";

        /// <summary>
        /// エラー理由コード - CusTo-netへの連携期限切れ
        /// </summary>
        public const string ANSHIN_ERR_CD_CUSTONET_EXPIRE = "1";

        /// <summary>
        /// エラー理由コード - 安心サービス紐付け期限切れ
        /// </summary>
        public const string ANSHIN_ERR_CD_CONTRACT_TIE_EXPIRE = "2";

        /// <summary>
        /// 建物コード - 戸建
        /// </summary>
        public const string TATEMONO_CD_KDT = "1";

        /// <summary>
        /// 建物コード - 賃貸
        /// </summary>
        public const string TATEMONO_CD_CHNTI = "2";

        /// <summary>
        /// 建物コード - 分譲集合
        /// </summary>
        public const string TATEMONO_CD_BNJYSYG = "3";

        #endregion
    }
}
