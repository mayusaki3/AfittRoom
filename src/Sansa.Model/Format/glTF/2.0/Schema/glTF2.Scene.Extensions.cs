using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
         public partial class Scene
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
            }
        }
    }
}
