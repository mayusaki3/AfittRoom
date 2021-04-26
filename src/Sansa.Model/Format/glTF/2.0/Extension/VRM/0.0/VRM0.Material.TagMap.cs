using Sansa.Model.FormatHelper;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            public partial class VRM0
            {
                public partial class Material
                {
                    /// <summary>
                    /// VRM拡張
                    /// TODO: 説明
                    /// </summary>
                    /// <remarks>
                    /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.material.schema.json
                    /// </remarks>
                    [TypeConverter(typeof(ExpandableObjectConverter))]
                    public class TagMap
                    {
                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public string RenderType { get; set; } = null;
                    }
                }
            }
        }
    }
}
