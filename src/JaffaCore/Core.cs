using Jaffa.Diagnostics;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Text;

namespace Jaffa
{
    /// <summary>
    /// Jaffaフレームワーク・コア
    /// </summary>
    public static class Core
    {
        #region インナークラス

        #region コアヘルパー (CoreHelper) [private]

        /// <summary>
        /// コアヘルパー
        /// </summary>
        private class CoreHelper
        {
            #region コンストラクタ―/デストラクター

            /// <summary>
            /// コンストラクタ―
            /// </summary>
            public CoreHelper()
                : base()
            {
                // 起動パス記憶
                startupPath = Process.GetCurrentProcess().MainModule.FileName;

                // リソースマネージャ初期化（国際化対応リスト）
                Assembly thisAsm = Assembly.GetExecutingAssembly();
                resManLst = new();
                SetResource(JaffaCulture,"Jaffa.Resources.CultureList", thisAsm);

                // 国際化対応の初期化
                International.Initialize();

                // リソースマネージャ初期化（Jaffaコアリソース）
                SetResource(Jaffa, "Jaffa.Resources." + International.CurrentCulture + ".Resource", thisAsm);

                // カルチャー変更イベント設定
                International.CultureChanged += International_CultureChanged;

                // 開始メッセージ
                if (LoggingSettings.FrameworkMessage)
                {
                    Logging.Write(MakeMessage(Jaffa, CoreMessages.JFW00001, new string[] { Version }));
                }
            }

            #endregion

            #region イベント

            #region カルチャー変更イベント (International_CultureChanged)

            /// <summary>
            /// カルチャー変更イベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private static void International_CultureChanged(object sender, System.EventArgs e)
            {
                // リソースマネージャ変更（Jaffaコアリソース）
                Assembly thisAsm = Assembly.GetExecutingAssembly();
                Core.SetResource(Jaffa, "Jaffa.Resources." + International.CurrentCulture + ".Resource", thisAsm);
            }

            #endregion

            #endregion
        }

        #endregion

        #endregion

        #region 定数

        /// <summary>
        /// Jaffaリソース領域名
        /// </summary>
        public const string Jaffa = "Jaffa";

        /// <summary>
        /// Jaffaカルチャーリソース領域名
        /// </summary>
        public const string JaffaCulture = "JaffaCulture";

        #endregion

        #region 変数 

        /// <summary>
        /// コアヘルパー
        /// </summary>
        private static CoreHelper helper = new();

        #endregion

        #region メソッド

        #region リソースマネージャを設定 (SetResource)

        /// <summary>
        /// リソースマネージャを設定します。
        /// </summary>
        /// <param name="name">リソース名</param>
        /// <param name="resourcePath">リソースパス名</param>
        /// <param name="assembly">リソースが格納されたアセンブリ</param>
        public static void SetResource(string name, string resourcePath, Assembly assembly)
        {
            if (resManLst.Contains(name) == true)
            {
                resManLst[name] = new ResourceManager(resourcePath.Replace('-', '_'), assembly);
            }
            else
            {
                resManLst.Add(name, new ResourceManager(resourcePath.Replace('-', '_'), assembly));
            }
        }

        #endregion

        #region リソースマネージャを参照 (Resource)

        /// <summary>
        /// リソースマネージャを参照します。
        /// </summary>
        /// <param name="name">リソース名</param>
        /// <returns>リソースマネージャ</returns>
        public static ResourceManager Resource(string name)
        {
            return resManLst[name] as ResourceManager;
        }

        #endregion

        #region メッセージ構築 (MakeMessage)

        /// <summary>
        /// メッセージを構築します。
        /// </summary>
        /// <param name="name">リソース名</param>
        /// <param name="message">メッセージ</param>
        /// <param name="paramList">メッセージに埋め込むパラメータのリスト</param>
        /// <returns>構築したメッセージ</returns>
        /// <remarks>
        /// メッセージは、テキスト中に {resource-name} と %paramList-index を指定できます。
        /// パラメータは、テキスト中に {resource-name} を指定できます。
        /// メッセージとパラメータは、それぞれリソースを参照してから、１つに編集します。
        /// </remarks>
        public static string MakeMessage(string name, string message, string[] paramList = null)
        {
            StringBuilder rt = new(International.ConvertCurrentCultureResourceString(name, message));
            if (paramList != null)
            {
                for (int i = 0; i < paramList.Length; i++)
                {
                    rt.Replace("%" + i.ToString(), International.ConvertCurrentCultureResourceString(name, paramList[i]));
                }
            }
            return rt.ToString();
        }

        #endregion

        #endregion

        #region プロパティ

        #region リソースマネージャーリスト ([R/W] resManLst) [private]

        private static Hashtable resManLst { get; set; } // 初期化が競合するのでCoreHelper側で初期化

        #endregion

        #region 起動パスを参照 ([R] StartupPath)

        /// <summary>
        /// 起動パスを参照します。
        /// </summary>
        public static string StartupPath
        {
            get
            {
                return startupPath;
            }
        }
        private static string startupPath; // 初期化が競合するのでCoreHelper側で初期化

        #endregion

        #region Jaffaバージョンを参照 ([R] Version)

        /// <summary>
        /// Jaffaバージョンを参照します。
        /// </summary>
        public static string Version
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        #endregion

        #endregion
    }
}
