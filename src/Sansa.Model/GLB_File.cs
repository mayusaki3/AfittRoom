using Jaffa.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sansa.Model
{
    /// <summary>
    /// GLBファイルクラス
    /// </summary>
    public class GLB_File
    {
        #region 変数

        /// <summary>
        /// GLBヘッダ
        /// </summary>
        public GLB_Header header = new();

        /// <summary>
        /// GLBチャンクリスト
        /// </summary>
        public List<GLB_Chunk> chunkList = new();

        #endregion

        #region メソッド

        #region GLBファイルロード (Load)

        /// <summary>
        /// GLBファイルからロードします。
        /// </summary>
        /// <param name="path">GLBファイルパス</param>
        public void Load(string path)
        {
            Logging.Write(Core.MakeMessage(Messages.SMBI0001, new string[] { Path.GetFullPath(path) }));

            // 読み込み
            header = new GLB_Header();
            chunkList.Clear();

            using (FileStream fs = new(path, FileMode.Open))
            {
                using BinaryReader br = new(fs);
                header.Read(br);

                UInt32 rsize = header.Length - 12;
                while (rsize > 0)
                {
                    GLB_Chunk chunk = new();
                    chunk.Read(br);
                    chunkList.Add(chunk);
                    rsize -= 8;
                    rsize -= chunk.ChunkLength;
                }
            }

            // チャンク数チェック
            if (chunkList.Count == 0)
            {
                throw new FormatException(Core.MakeMessage(Messages.SMBE0002));
            }

            // チャンク0チェック
            if (chunkList[0].ChunkType != 0x4E4F534A) // 'JSON'
            {
                throw new FormatException(Core.MakeMessage(Messages.SMBE0003));
            }

            Logging.Write(Core.MakeMessage(Messages.SMBI0002)); 
        }

        #endregion

        #region GLBファイルセーブ (Save)

        /// <summary>
        /// GLBファイルにセーブします。
        /// </summary>
        /// <param name="path">GLBファイルパス</param>
        public void Save(string path)
        {
            Logging.Write(Core.MakeMessage(Messages.SMBI0003, new string[] { Path.GetFullPath(path) }));

            using (FileStream fs = new(path, FileMode.Create))
            {
                using BinaryWriter bw = new(fs);
                header.Write(bw);
                foreach (GLB_Chunk chunk in chunkList)
                {
                    chunk.Write(bw);
                }
            }

            Logging.Write(Core.MakeMessage(Messages.SMBI0004));
        }

        #endregion

        #endregion
    }
}
