namespace Sansa.Model
{
    public static class Messages
    {
        // GLBファイルメッセージ -------------------------------------------------------

        /// <summary>
        /// ロード開始
        /// </summary>
        public const string SMBI0001 = "SMBI0001 {SMBI0001}%0";

        /// <summary>
        /// ロード完了
        /// </summary>
        public const string SMBI0002 = "SMBI0002 {SMBI0002}";

        /// <summary>
        /// セーブ開始
        /// </summary>
        public const string SMBI0003 = "SMBI0003 {SMBI0003}%0";

        /// <summary>
        /// セーブ完了
        /// </summary>
        public const string SMBI0004 = "SMBI0004 {SMBI0004}";

        /// <summary>
        /// GLBヘッダマジックがglTFではない
        /// </summary>
        public const string SMBE0001 = "SMBE0001 {SMBE0001}";

        /// <summary>
        /// GLBヘッダバージョンがサポート外
        /// </summary>
        public const string SMBE0002 = "SMBE0002 {SMBE0002}";

        /// <summary>
        /// GLBチャンクがない
        /// </summary>
        public const string SMBE0003 = "SMBE0003 {SMBE0003}";

        /// <summary>
        /// GLBチャンク0のタイプがJSONではない
        /// </summary>
        public const string SMBE0004 = "SMBE0004 {SMBE0004}";

        /// <summary>
        /// GLBチャンクのタイプがJSON/BINではない
        /// </summary>
        public const string SMBE0005 = "SMBE0005 {SMBE0005}";

        /// <summary>
        /// GLBチャンク長が本ライブラリのサポート限界を超過
        /// </summary>
        public const string SMBE0006 = "SMBE0006 {SMBE0006}";
    }
}
