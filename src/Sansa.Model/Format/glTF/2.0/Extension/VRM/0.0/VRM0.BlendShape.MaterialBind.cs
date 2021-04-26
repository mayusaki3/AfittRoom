using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            public partial class VRM0
            {
                public partial class BlendShape
                {
                    /// <summary>
                    /// VRM拡張：BlendShapeのグループ
                    /// </summary>
                    /// <remarks>
                    /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.blendshape.materialbind.schema.json
                    /// </remarks>
                    [TypeConverter(typeof(ExpandableObjectConverter))]
                    public class MaterialBind
                    {
                        /// <summary>
                        /// マテリアルの名前
                        /// </summary>
                        public string materialName { get; set; } = null;

                        /// <summary>
                        /// プロパティの名前
                        /// </summary>
                        public string propertyName { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public List<float> targetValue { get; set; } = null;
                    }
                }
            }
        }
    }
}