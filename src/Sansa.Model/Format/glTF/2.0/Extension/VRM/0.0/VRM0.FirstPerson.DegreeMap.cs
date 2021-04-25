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
                    /// VRM拡張：一人時のヘッドセットの目標位置
                    /// </summary>
                    /// <remarks>
                    /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.firstperson.degreemap.schema.json
                    /// </remarks>
                    public class DegreeMap
                    {

                        /*

                          "title": "vrm.firstperson.degreemap",
                            "description": "Eye controller setting.",
                            "type": "object",
                            "properties": {
                                "curve": {
                                    "description": "None linear mapping params. time, value, inTangent, outTangent",
                                    "type": "array",
                                    "items": {
                                        "type": "number"
                                    }
                                },
                                "xRange": {
                                    "description": "Look at input clamp range degree.",
                                    "type": "number"
                                },
                                "yRange": {
                                    "description": "Look at map range degree from xRange.",
                                    "type": "number"
                                }

                         */


                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public double?[] curve { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public double? xRange { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public double? yRange { get; set; } = null;
                    }
                }
            }
        }
    }
}
