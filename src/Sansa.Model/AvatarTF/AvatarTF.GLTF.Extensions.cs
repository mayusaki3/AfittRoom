namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public partial class GLTF
        {
            /// <summary>
            /// glTFエクステンション
            /// <br/>拡張機能固有のオブジェクトを持つディクショナリーオブジェクト。
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/extension.schema.json
            /// <br/>本来は Dictionary&lt;string, object&gt;で定義するべきだが、
            /// 追加のプロパティは決め打ちで定義している。
            /// </remarks>
            public class Extensions
            {
              
            }
        }
    }
}