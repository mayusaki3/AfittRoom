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
                    /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.blendshape.group.schema.json
                    /// </remarks>
                    [TypeConverter(typeof(ExpandableObjectConverter))]
                    public class Group
                    {
                        /// <summary>
                        /// 名前
                        /// <br/>このグループの表現名です。
                        /// </summary>
                        public string name { get; set; } = null;

                        /// <summary>
                        /// プリセットの表現名
                        /// </summary>
                        public enum PresetName
                        {
                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            unknown,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            neutral,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            a,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            i,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            u,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            e,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            o,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            blink,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            joy,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            angry,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            sorrow,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            fun,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            lookup,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            lookdown,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            lookleft,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            lookright,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            blink_l,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            blink_r
                        }

                        /// <summary>
                        /// プリセットの表現名
                        /// </summary>
                        public PresetName? presetName { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// Low level blendshape references.
                        /// </summary>
                        public List<Bind> binds { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// Material animation references.
                        /// </summary>
                        public List<MaterialBind> materialValues { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// 0 or 1. Do not allow an intermediate value. Value should rounded
                        /// </summary>
                        public bool? isBinary { get; set; } = null;
                    }
                }
            }
        }
    }
}