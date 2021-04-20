namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// 拡張情報
        /// </summary>
        public class Extensions
        {
            /// <summary>
            /// VRM拡張
            /// </summary>
            public VRM VRM { get; set; } = null;

            /// <summary>
            /// クロノス拡張：マテリアルユニット
            /// </summary>
            public KHR_Materials_Unlit KHR_Materials_Unlit { get; set; } = null;
        }
    }
}
