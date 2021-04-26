using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            public partial class VRM0
            {
                public partial class FirstPerson
                {
                    /// 
                    /// <summary>
                    /// VRM拡張：アイコントローラの設定
                    /// </summary>
                    /// <remarks>
                    /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.firstperson.degreemap.schema.json
                    /// </remarks>
                    [TypeConverter(typeof(ExpandableObjectConverter))]
                    public class DegreeMap
                    {
                        /// <summary>
                        /// ノンリニアマッピングパラメータ
                        /// <br/>(time, value, inTangent, outTangent)
                        /// </summary>
                        public float[] curve { get; set; } = null;

                        /// <summary>
                        /// 入力クランプを見る角度範囲
                        /// TODO: 説明
                        /// Look at input clamp range degree.
                        /// </summary>
                        public float? xRange { get; set; } = null;

                        /// <summary>
                        /// xRange に対する
                        /// TODO: 説明
                        /// Look at map range degree from xRange.
                        /// </summary>
                        public float? yRange { get; set; } = null;
                    }
                }
            }
        }
    }
}
