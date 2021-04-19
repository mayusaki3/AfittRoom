using System.Reflection;
using System.Resources;

namespace Sansa.Model
{
    /// <summary>
    /// Sansaモデル・コア
    /// </summary>
    public class Core
    {
        #region コンストラクタ―

        /// <summary>
        /// コンストラクタ―
        /// </summary>
        static Core()
        {
            // リソースマネージャ初期化（Jaffaコアリソース）
            Assembly thisAsm = Assembly.GetExecutingAssembly();
            Jaffa.Core.SetResource(SansaModel, "Sansa.Model.Resources.{Culture}.Resource", thisAsm);

            // カルチャー変更イベント設定
            Jaffa.International.CultureChanged += International_CultureChanged;
        }

        #endregion

        #region 定数

        /// <summary>
        /// Sansa.Modelリソース領域名
        /// </summary>
        public const string SansaModel = "SansaModel";

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
            Jaffa.Core.SetResource(SansaModel, "Sansa.Model.Resources.{Culture}.Resource", thisAsm);
        }

        #endregion

        #endregion

        #region メソッド

        #region リソースマネージャを参照 (Resource)

        /// <summary>
        /// リソースマネージャを参照します。
        /// </summary>
        /// <param name="name">リソース名</param>
        /// <returns>リソースマネージャ</returns>
        public static ResourceManager Resource(string name)
        {
            return Jaffa.Core.Resource(name);
        }

        #endregion

        #region メッセージ構築 (MakeMessage)

        /// <summary>
        /// メッセージを構築します。
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <param name="paramList">メッセージに埋め込むパラメータのリスト</param>
        /// <returns>構築したメッセージ</returns>
        /// <remarks>
        /// メッセージは、テキスト中に {resource-name} と %paramList-index を指定できます。
        /// パラメータは、テキスト中に {resource-name} を指定できます。
        /// メッセージとパラメータは、それぞれリソースを参照してから、１つに編集します。
        /// </remarks>
        public static string MakeMessage(string message, string[] paramList = null)
        {
            return Jaffa.Core.MakeMessage(SansaModel, message, paramList);
        }

        #endregion

        #endregion
    }
}
