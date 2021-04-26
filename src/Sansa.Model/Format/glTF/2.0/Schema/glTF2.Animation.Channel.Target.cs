using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Animation
        {
            public partial class Channel
            {
                /// <summary>
                /// アニメーションチャンネルのターゲット
                /// <br/>アニメーションチャンネルが対象とするノードとTRSプロパティのインデックスです。
                /// </summary>
                /// <remarks>
                /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/animation.channel.target.schema.json
                /// </remarks>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public partial class Target
                {
                    /// <summary>
                    /// ノード
                    /// <br/>対象となるノードのインデックスです。
                    /// </summary>
                    /// <remarks>
                    /// 最小 = 0
                    /// </remarks>
                    public int? node { get; set; } = null;

                    /// <summary>
                    /// パス
                    /// </summary>
                    public enum Path
                    {
                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        translation,

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        rotation,

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        scale,

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        weights
                    }

                    /// <summary>
                    /// 変更するノードのTRSプロパティの名前、またはインスタンス化しているモーフターゲットの weights です。
                    /// <br/>translation プロパティでは、サンプラーから提供される値は、x、y、z軸に沿った平行移動となります。
                    /// <br/>rotation プロパティでは、x, y, z, w の順に4元変換された値が提供されます。（wはスカラー）
                    /// <br/>scale プロパティは、x, y, z軸のスケーリングファクターを表します。
                    /// </summary>
                    /// <remarks>
                    /// 必須項目
                    /// </remarks>
                    public Path? path { get; set; } = null;

                    /// <summary>
                    /// エクステンション
                    /// </summary>
                    public Extensions extensions { get; set; } = null;

                    /// <summary>
                    /// アプリケーション固有のデータ
                    /// </summary>
                    public Extras extras { get; set; } = null;
                }
            }
        }
    }
}
