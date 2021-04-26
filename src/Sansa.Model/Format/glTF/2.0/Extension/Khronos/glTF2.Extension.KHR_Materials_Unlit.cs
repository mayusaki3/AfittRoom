using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            /// <summary>
            /// 非発光マテリアル
            /// <br/>この拡張機能は、コア仕様で提供されているPBR（Physically Based Rendering）シェーディングモデルの
            /// 代わりに、glTF 2.0マテリアルで使用するための非発光シェーディングモデルを定義するものです。
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/tree/master/extensions/2.0/Khronos/KHR_materials_unlit
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public class KHR_Materials_Unlit
            {
            }
        }
    }
}
