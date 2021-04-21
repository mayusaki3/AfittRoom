using System.Collections.Generic;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class RootObject
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// 使用されているglTF拡張の名前リスト
            /// </summary>
            public List<string> extensionsUsed { get; set; } = null;

            /// <summary>
            /// glTF拡張
            /// </summary>
            public Extensions extensions { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Asset asset { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public List<Buffer> buffers { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public List<Bufferview> bufferViews { get; set; } = null;

            /// <summary>
            /// アクセサリスト
            /// </summary>
            public List<Accessor> accessors { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public List<Image> images { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public List<Sampler> samplers { get; set; } = null;

            /// <summary>
            /// テクスチャーリスト
            /// </summary>
            public List<Texture> textures { get; set; } = null;

            /// <summary>
            /// マテリアルリスト
            /// </summary>
            public List<Material> materials { get; set; } = null;

            /// <summary>
            /// メッシュリスト
            /// </summary>
            public List<Mesh> meshes { get; set; } = null;

            /// <summary>
            /// スキンリスト
            /// </summary>
            public List<Skin> skins { get; set; } = null;

            /// <summary>
            /// ノードリスト
            /// </summary>
            public List<Node> nodes { get; set; } = null;

            /// <summary>
            /// シーンリスト
            /// </summary>
            public List<Scene> scenes { get; set; } = null;

            /// <summary>
            /// シーンNo.（シーンリストのインデックス）
            /// </summary>
            public int? scene { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}