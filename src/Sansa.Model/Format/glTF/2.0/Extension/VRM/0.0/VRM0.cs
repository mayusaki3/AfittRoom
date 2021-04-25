namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            /// <summary>
            /// VRM拡張
            /// <br/>VRM拡張は、VRアプリケーションにおける3Dヒューマノイド
            /// アバター（およびモデル）のためのものです。
            /// </summary>
            /// <remarks>
            /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.schema.json
            /// </remarks>
            public partial class VRM0
            {
                /// <summary>
                /// エクスポーターバージョン
                /// vrmを作成したエクスポーターのバージョンです。
                /// </summary>
                public string exporterVersion { get; set; } = null;

                /// <summary>
                /// VRMの仕様バージョン
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public string specVersion { get; set; } = null;

                /// <summary>
                /// モデルのメタ情報
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public Meta meta { get; set; } = null;

                /// <summary>
                /// ノードへのヒューマノイドボーンの割り当て
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public Humanoid humanoid { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// </summary>
                public FirstPerson firstPerson { get; set; } = null;

                /*


                   
                  
                    "firstPerson": {
                      "title": "FirstPerson",
                      "type": "object",
                      "description": "First-person perspective settings",
                      "$ref": "VRMC_vrm.firstPerson.schema.json"
                    },
                    "lookAt": {
                      "title": "LookAt",
                      "type": "object",
                      "description": "Eye gaze control",
                      "$ref": "VRMC_vrm.lookAt.schema.json"
                    },
                    "expressions": {
                      "type": "array",
                      "description": "Definitions of expressions",
                      "items": {
                        "$ref": "VRMC_vrm.expression.schema.json"
                      }
                    }
                  },
                 


                 */









                /// <summary>
                /// TODO: 説明
                /// </summary>
                //             public BlendShapeMaster blendShapeMaster { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// </summary>
                //              public SecondaryAnimation secondaryAnimation { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// </summary>
                //              public MaterialProperty[] materialProperties { get; set; } = null;
            }
        }
    }
}