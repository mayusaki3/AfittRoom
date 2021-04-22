namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// エクステンション
        /// <br/>拡張機能固有のオブジェクトを持つディクショナリーオブジェクト。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/extension.schema.json
        /// <br/>本来は Dictionary&lt;string, object&gt;で定義するべきだが、
        /// 追加のプロパティは決め打ちで定義している。
        /// </remarks>
        public class Extensions
        {
            /// <summary>
            /// TODO: 説明
            /// VRM拡張
            /// </summary>
            public VRM VRM { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// クロノス拡張：マテリアルユニット
            /// </summary>
            public KHR_Materials_Unlit KHR_Materials_Unlit { get; set; } = null;
        }
    }
}
