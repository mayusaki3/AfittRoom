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
                    public class VectorProperties
                    {
                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public float?[] _Color { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public float?[] _ShadeColor { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int?[] _MainTex { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int?[] _ShadeTexture { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int?[] _BumpMap { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int?[] _ReceiveShadowTexture { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int?[] _ShadingGradeTexture { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int?[] _SphereAdd { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public float?[] _EmissionColor { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int?[] _EmissionMap { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int?[] _OutlineWidthTexture { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public float?[] _OutlineColor { get; set; } = null;
                    }
                }
            }
        }
    }
}

