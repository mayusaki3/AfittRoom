using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Mesh
        {
            public partial class Primitive
            {
                /// <summary>
                /// 属性
                /// </summary>
                /// <remarks>
                /// TODO: 仕様はどこ？
                /// </remarks>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public class Attributes
                {
                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public int? POSITION { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public int? NORMAL { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public int? TEXCOORD_0 { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public int? JOINTS_0 { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public int? WEIGHTS_0 { get; set; } = null;
                }
            }
        }
    }
}
