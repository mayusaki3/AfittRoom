using System.Collections.Generic;
using System.Text.Json;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
#pragma warning disable IDE1006 // 命名スタイル

        /// <summary>
        /// 拡張情報リスト
        /// </summary>
        public List<string> extensionsUsed { get; set; } = null;

        /// <summary>
        /// 拡張情報
        /// </summary>
        public Extensions extensions { get; set; } = null;

        /// <summary>
        /// TODO: 説明
        /// </summary>
        public Asset asset { get; set; } = null;

        /// <summary>
        /// TODO: 説明
        /// </summary>
        public Buffer[] buffers { get; set; } = null;

        /// <summary>
        /// TODO: 説明
        /// </summary>
        public Bufferview[] bufferViews { get; set; } = null;

        /// <summary>
        /// TODO: 説明
        /// </summary>
        public Accessor[] accessors { get; set; } = null;

        /// <summary>
        /// TODO: 説明
        /// </summary>
        public Image[] images { get; set; } = null;

        /// <summary>
        /// TODO: 説明
        /// </summary>
        public Sampler[] samplers { get; set; } = null;

        /// <summary>
        /// テクスチャーリスト
        /// </summary>
        public Texture[] textures { get; set; } = null;

        /// <summary>
        /// マテリアルリスト
        /// </summary>
        public Material[] materials { get; set; } = null;

        /// <summary>
        /// メッシュリスト
        /// </summary>
        public Mesh[] meshes { get; set; } = null;

        /// <summary>
        /// スキンリスト
        /// </summary>
        public Skin[] skins { get; set; } = null;

        /// <summary>
        /// ノードリスト
        /// </summary>
        public Node[] nodes { get; set; } = null;

        /// <summary>
        /// シーンリスト
        /// </summary>
        public Scene[] scenes { get; set; } = null;

        /// <summary>
        /// シーンNo.（シーンリストのインデックス）
        /// </summary>
        public int? scene { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
    }
}
