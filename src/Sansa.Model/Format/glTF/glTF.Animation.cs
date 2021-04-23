﻿using System.Collections.Generic;

namespace Sansa.Model.Format
{
    public partial class glTF
    {
        /// <summary>
        /// アニメーション
        /// <br/>キーフレームアニメーションです。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/animation.schema.json
        /// </remarks>
        public partial class Animation
        {
            /// <summary>
            /// チャンネルのリスト
            /// <br/>それぞれがアニメーションのサンプラーのターゲットをノードのプロパティに設定します。
            /// <br/>同じアニメーションの異なるチャンネルが同じターゲットを持つことはできません。
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// <br/>最低１つ以上定義
            /// </remarks>
            public List<Channel> channels { get; set; } = null;

            /// <summary>
            /// サンプラーのリスト
            /// <br/>入力と出力のアクセッサと補間アルゴリズムを組み合わせて、
            /// キーフレームのグラフを定義するサンプラーのリストです。
            /// （ターゲットではありません）。
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// <br/>最低１つ以上定義
            /// </remarks>
            public List<Sampler> samplers { get; set; } = null;
 
            /// <summary>
            /// 名前
            /// <br/>このアニメーションの名前です。
            /// </summary>
            public string name { get; set; } = null;

            /// <summary>
            /// エクステンション
            /// </summary>
            public List<Extension> extensions { get; set; } = null;

            /// <summary>
            /// アプリケーション固有のデータ
            /// </summary>
            public Extras extras { get; set; } = null;
        }
    }
}
