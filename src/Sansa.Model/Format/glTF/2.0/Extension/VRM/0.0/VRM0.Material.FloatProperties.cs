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
                    public class FloatProperties
                    {

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public float? _Cutoff { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _BumpScale { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _ReceiveShadowRate { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _ShadingGradeRate { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public float? _ShadeShift { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public float? _ShadeToony { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _LightColorAttenuation { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public float? _IndirectLightIntensity { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public float? _OutlineWidth { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public float? _OutlineScaledMaxDistance { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public float? _OutlineLightingMix { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _DebugMode { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _BlendMode { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _OutlineWidthMode { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _OutlineColorMode { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _CullMode { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _OutlineCullMode { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _SrcBlend { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _DstBlend { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? _ZWrite { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明(?)
                        /// </summary>
                        public int? _MToonVersion { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明(?)
                        /// </summary>
                        public int? _RimFresnelPower { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明(?)
                        /// </summary>
                        public int? _RimLift { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明(?)
                        /// </summary>
                        public int? _RimLightingMix { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明(?)
                        /// </summary>
                        public int? _UvAnimRotation { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明(?)
                        /// </summary>
                        public int? _UvAnimScrollX { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明(?)
                        /// </summary>
                        public int? _UvAnimScrollY { get; set; } = null;
                    }
                }
            }
        }
    }
}
