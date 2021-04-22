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
        #region メソッド

        #region GLBファイルロード (Load)

        /// <summary>
        /// GLBファイルからロードします。
        /// </summary>
        /// <param name="path">GLBファイルパス</param>
        public void Load(string path)
        {
            if (path.Length < 1) return;
            Logging.Write(Core.MakeMessage(Messages.SMBI0001, new string[] { Path.GetFullPath(path) }));

            // 読み込み
            Header.Version = 0;
            Header.Length = 12;
            ChunkList.Clear();

            using (FileStream fs = new(path, FileMode.Open))
            {
                using BinaryReader br = new(fs);
                Header.Read(br);

                UInt32 rsize = Header.Length - 12;
                while (rsize > 0)
                {
                    GLB_Chunk chunk = new();
                    chunk.Read(br);
                    ChunkList.Add(chunk);
                    rsize -= 8;
                    rsize -= chunk.ChunkLength;
                }
            }

            // ヘッダバージョンチェック
            if (Header.Version < 2)
            {
                throw new FormatException(Core.MakeMessage(Messages.SMBE0002));
            }

            // チャンク数チェック
            if (ChunkList.Count == 0)
            {
                throw new FormatException(Core.MakeMessage(Messages.SMBE0003));
            }

            // チャンク0チェック
            if (ChunkList[0].ChunkType != GLB_Chunk.ChankType.JSON)
            {
                throw new FormatException(Core.MakeMessage(Messages.SMBE0004));
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
            if (path.Length < 1) return;
            Logging.Write(Core.MakeMessage(Messages.SMBI0003, new string[] { Path.GetFullPath(path) }));

            // ヘッダ全バイト長再計算
            Header.Length = 12;
            foreach (GLB_Chunk chunk in ChunkList)
            {
                Header.Length += 8 + chunk.ChunkLength;
            }

            // 書き込み
            using (FileStream fs = new(path, FileMode.Create))
            {
                using BinaryWriter bw = new(fs);
                Header.Write(bw);
                foreach (GLB_Chunk chunk in ChunkList)
                {
                    chunk.Write(bw);
                }
            }

            Logging.Write(Core.MakeMessage(Messages.SMBI0004));
        }

        #endregion

        #endregion

        #region プロパティ

        #region GLBヘッダ ([R] Header)

        /// <summary>
        /// GLBヘッダ
        /// </summary>
        public GLB_Header Header { get; } = new();

        #endregion

        #region GLBチャンクリスト ([R] ChunkList)

        /// <summary>
        /// GLBチャンクリスト
        /// </summary>
        public List<GLB_Chunk> ChunkList { get; } = new();

        #endregion
        
        #endregion
    }
}
