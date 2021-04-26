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
                    /// VRM拡張：一人時のヘッドセットの目標位置
                    /// </summary>
                    /// <remarks>
                    /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.firstperson.meshannotation.schema.json
                    /// </remarks>
                    [TypeConverter(typeof(ExpandableObjectConverter))]
                    public class MeshAnnotation
                    {
                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        public int? mesh { get; set; } = null;

                        /// <summary>
                        /// 一人称視点での各メッシュの表示／非表示の切り替え
                        /// </summary>
                        public enum FirstPersonFlag
                        {
                            /// <summary>
                            /// 自動
                            /// <br/>firstPersonBone とその子孫に対するボーン Weight を持つポリゴンを自動で非表示にします。
                            /// <br/>表示されていない部分を実行時に自動的に削除したモデルを生成します。
                            /// </summary>
                            Auto,

                            /// <summary>
                            /// 一人称のみ表示
                            /// </summary>
                            FirstPersonOnly,

                            /// <summary>
                            /// 三人称のみ表示
                            /// <br/>頭など一人称時に非表示にするメッシュに指定します。
                            /// </summary>
                            ThirdPersonOnly,

                            /// <summary>
                            /// 特に表示切替をしない。
                            /// </summary>
                            Both
                        }

                        /// <summary>
                        /// 一人称視点での各メッシュの表示／非表示の切り替え
                        /// </summary>
                        public FirstPersonFlag? firstPersonFlag { get; set; } = null;
                    }
                }
            }
        }
    }
}
