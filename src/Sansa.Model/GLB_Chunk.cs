using System;
using System.IO;

namespace Sansa.Model
{
    /// <summary>
    /// GLBファイル・チャンククラス
    /// </summary>
    public class GLB_Chunk
    {
        #region メソッド

        #region GLBファイルチャンク読み取り (Read)

        /// <summary>
        /// GLBファイルからチャンクを読み取る。
        /// </summary>
        /// <param name="reader">使用するバイナリリーダー</param>
        public void Read(BinaryReader reader)
        {
            ChunkLength = reader.ReadUInt32();

            UInt32 w_type = reader.ReadUInt32();
            if (w_type != 0x4E4F534A &&
                w_type != 0x004E4942)
            {
                throw new FormatException(Core.MakeMessage(Messages.SMBE0004));
            }
            ChunkType = w_type;

            if (ChunkLength > int.MaxValue)
            {
                throw new FormatException(Core.MakeMessage(Messages.SMBE0005));
            }

            ChunkData = new byte[ChunkLength];
            ChunkData = reader.ReadBytes((int)ChunkLength);
        }

        #endregion

        #region GLBファイルチャンク書き込み (Write)

        /// <summary>
        /// GLBファイルにチャンクを書き込む。
        /// </summary>
        /// <param name="writer">使用するバイナリライター</param>
        public void Write(BinaryWriter writer)
        {
            writer.Write(ChunkLength);
            writer.Write(ChunkType);
            writer.Write(ChunkData);
        }

        #endregion

        #endregion

        #region プロパティ

        #region チャンクデータバイト長 ([R/W] ChunkLength)

        /// <summary>
        /// チャンクデータ(chunkData)のバイト長
        /// </summary>
        public UInt32 ChunkLength { get; set; }

        #endregion

        #region チャンクタイプ ([R/W] ChunkType)

        /// <summary>
        /// チャンクタイプ
        /// 0x4E4F534A : 'JSON' 構造化されたJSONコンテンツ
        /// 0x004E4942 : ' BIN' バイナリバッファ
        /// </summary>
        public UInt32 ChunkType { get; set; }

        #endregion

        #region チャンクデータ ([R/W] ChunkData)

        /// <summary>
        /// チャンクデータ
        /// 'JSON' の場合、4バイト境界まで末尾に 0x20 を埋める
        /// ' BIN' の場合、4バイト境界まで末尾に 0x00 を埋める
        /// </summary>
        public Byte[] ChunkData { get; set; }

        #endregion

        #endregion
    }
}
