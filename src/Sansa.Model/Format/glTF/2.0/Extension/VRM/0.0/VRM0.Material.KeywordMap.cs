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
                    public class KeywordMap
                    {

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public bool? MTOON_OUTLINE_COLOR_FIXED { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public bool? MTOON_OUTLINE_WIDTH_WORLD { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public bool? _ALPHATEST_ON { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public bool? _NORMALMAP { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明(?)
                        /// </summary>
                        public bool? _ALPHABLEND_ON { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明(?)
                        /// </summary>
                        public bool? MTOON_OUTLINE_COLOR_MIXED { get; set; } = null;


                        /// <summary>
                        /// TODO: 説明(?)
                        /// </summary>
                        public bool? MTOON_OUTLINE_WIDTH_SCREEN { get; set; } = null;

                    }
                }
            }
        }
    }
}

