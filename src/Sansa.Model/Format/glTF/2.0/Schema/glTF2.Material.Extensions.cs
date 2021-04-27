using System.ComponentModel;
using static Sansa.Model.Format.glTF2.Extension;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Material
        {
            /// <summary>
            /// エクステンション
            /// <br/>拡張機能固有のオブジェクトを持つディクショナリーオブジェクト。
            /// <br/>ここに対応するエクステンションを定義します。
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/extension.schema.json
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public class Extensions
            {
                /// <summary>
                /// 非発光マテリアル
                /// </summary>
                public KHR_Materials_Unlit KHR_materials_unlit { get; set; } = null;
            }
        }
    }
}
