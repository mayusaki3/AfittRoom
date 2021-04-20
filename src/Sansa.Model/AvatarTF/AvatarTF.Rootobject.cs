using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Jaffa.Diagnostics;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// アバター・ルートオブジェクト
        /// </summary>
        public class Rootobject
        {
            public string[] extensionsUsed { get; set; }
            public Extensions extensions { get; set; }
            public Asset asset { get; set; }
            public Buffer[] buffers { get; set; }
            public Bufferview[] bufferViews { get; set; }
            public Accessor[] accessors { get; set; }
            public Image[] images { get; set; }
            public Sampler[] samplers { get; set; }
            public Texture[] textures { get; set; }
            public Material[] materials { get; set; }
            public Mesh[] meshes { get; set; }
            public Skin[] skins { get; set; }
            public Node[] nodes { get; set; }
            public Scene[] scenes { get; set; }
            public int scene { get; set; }
        }
    }
}
