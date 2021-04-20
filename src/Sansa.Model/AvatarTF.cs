using System.Collections.Generic;
using System.Text.Json;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// 
        /// </summary>
        public string[] extensionsUsed { get; set; }

        //public Extensions extensions { get; set; }
        //public Asset asset { get; set; }
        //public Buffer[] buffers { get; set; }
        //public Bufferview[] bufferViews { get; set; }
        //public Accessor[] accessors { get; set; }
        //public Image[] images { get; set; }
        //public Sampler[] samplers { get; set; }
        //public Texture[] textures { get; set; }
        //public Material[] materials { get; set; }
        //public Mesh[] meshes { get; set; }

        //public Skin[] skins { get; set; }

        /// <summary>
        /// ノードリスト
        /// </summary>
        public Node[] nodes { get; set; }

        /// <summary>
        /// シーンリスト
        /// </summary>
        public Scene[] scenes { get; set; } = null;

        /// <summary>
        /// シーンNo.（シーンリストのインデックス）
        /// </summary>
        public int scene { get; set; } = -1;
    }
}
