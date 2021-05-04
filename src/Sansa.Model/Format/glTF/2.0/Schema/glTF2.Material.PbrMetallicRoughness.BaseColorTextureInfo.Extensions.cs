using System.ComponentModel;
using static Sansa.Model.Format.glTF2.Extension;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Material
        {
            public partial class PbrMetallicRoughness
            {
                public partial class BaseColorTextureInfo
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
                        /// TODO: 説明(?)
                        /// </summary>
                        public KHR_Texture_Transform KHR_texture_transform { get; set; } = null;
                    }
                }
            }
        }
    }
}
