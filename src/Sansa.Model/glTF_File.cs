using Jaffa.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sansa.Model
{
    /// <summary>
    /// GLBファイルクラス
    /// </summary>
    public class glTF_File
    {
        #region メソッド

        #region glTFファイルロード (Load)

        /// <summary>
        /// glTFファイルからロードします。
        /// </summary>
        /// <param name="path">glTFファイルパス</param>
        public void Load(string path)
        {
            if (path.Length < 1) return;
            //Logging.Write(Core.MakeMessage(Messages.SMBI0001, new string[] { Path.GetFullPath(path) }));

            //// 読み込み
            //Header.Version = 0;
            //Header.Length = 12;
            //ChunkList.Clear();

            //using (FileStream fs = new(path, FileMode.Open))
            //{
            //    using BinaryReader br = new(fs);
            //    Header.Read(br);

            //    UInt32 rsize = Header.Length - 12;
            //    while (rsize > 0)
            //    {
            //        GLB_Chunk chunk = new();
            //        chunk.Read(br);
            //        ChunkList.Add(chunk);
            //        rsize -= 8;
            //        rsize -= chunk.ChunkLength;
            //    }
            //}

            //// ヘッダバージョンチェック
            //if (Header.Version < 2)
            //{
            //    throw new FormatException(Core.MakeMessage(Messages.SMBE0002));
            //}

            //// チャンク数チェック
            //if (ChunkList.Count == 0)
            //{
            //    throw new FormatException(Core.MakeMessage(Messages.SMBE0003));
            //}

            //// チャンク0チェック
            //if (ChunkList[0].ChunkType != GLB_Chunk.ChankType.JSON)
            //{
            //    throw new FormatException(Core.MakeMessage(Messages.SMBE0004));
            //}

            //Logging.Write(Core.MakeMessage(Messages.SMBI0002));
        }

        #endregion

        #region glTFファイルセーブ (Save)

        /// <summary>
        /// glTFファイルにセーブします。
        /// </summary>
        /// <param name="path">glTFファイルパス</param>
        public void Save(string path)
        {
            if (path.Length < 1) return;
     //       Logging.Write(Core.MakeMessage(Messages.SMBI0003, new string[] { Path.GetFullPath(path) }));

        }

        #endregion

        #endregion

        #region プロパティ


        #endregion
    }
}
