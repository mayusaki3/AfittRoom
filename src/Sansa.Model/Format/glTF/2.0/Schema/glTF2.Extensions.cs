using System.ComponentModel;
using static Sansa.Model.Format.glTF2.Extension;

namespace Sansa.Model.Format
{
    public partial class glTF2
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
            /// VRM拡張
            /// </summary>
            public VRM0 VRM { get; set; } = null;

            /// <summary>
            /// Khronos拡張：非発光マテリアル
            /// </summary>
            public KHR_Materials_Unlit KHR_Materials_Unlit { get; set; } = null;
        }
    }
}
