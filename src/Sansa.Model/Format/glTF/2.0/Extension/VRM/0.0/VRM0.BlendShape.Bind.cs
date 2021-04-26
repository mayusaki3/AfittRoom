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
                    /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.blendshape.bind.schema.json
                    /// </remarks>
                    [TypeConverter(typeof(ExpandableObjectConverter))]
                    public class Bind
                    {
                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        /// <remarks>
                        /// 最小 = 0
                        /// </remarks>
                        public int? mesh { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        /// <remarks>
                        /// 最小 = 0
                        /// </remarks>
                        public int? index { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// SkinnedMeshRenderer.SetBlendShapeWeight
                        /// </summary>
                        /// <remarks>
                        /// 最小 = 0
                        /// <br/>最大 = 100
                        /// </remarks>
                        public float? weight { get; set; } = null;
                    }
                }
            }
        }
    }
}