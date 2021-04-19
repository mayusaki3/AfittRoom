using System;
using System.IO;

namespace Sansa.Model
{
    /// <summary>
    /// GLBファイル・ヘッダクラス
    /// </summary>
    public class GLB_Header
    {
        #region メソッド

        #region GLBファイルヘッダ読み取り (Read)

        /// <summary>
        /// GLBファイルのヘッダを読み取る。
        /// </summary>
        /// <param name="reader">使用するバイナリリーダー</param>
        /// <returns>GLBヘッダ</returns>
        public void Read(BinaryReader reader)
        {
            UInt32 w_magic =  reader.ReadUInt32();
            if (w_magic != Magic)
            {
                throw new FormatException(Core.MakeMessage(Messages.SMBE0001));
            }
            Version = reader.ReadUInt32();
            Length = reader.ReadUInt32();
        }

        #endregion

        #region GLBファイルヘッダ書き込み (Write)

        /// <summary>
        /// GLBファイルのヘッダを書き込む。
        /// </summary>
        /// <param name="writer">使用するバイナリライター</param>
        public void Write(BinaryWriter writer)
        {
            writer.Write(Magic);
            writer.Write(Version);
            writer.Write(Length);
        }

        #endregion

        #endregion

        #region プロパティ

        #region マジック値 ([R] Magic)

        /// <summary>
        /// マジック値
        /// </summary>
        public UInt32 Magic { get; } = 0x46546C67; // 'glTF'

        #endregion

        #region バージョンNo ([R/W] Version)

        /// <summary>
        /// バージョンNo
        /// </summary>
        public UInt32 Version { get; set; }

        #endregion

        #region 全バイト長 ([R/W] Length)

        /// <summary>
        /// 全バイト長
        /// </summary>
        public UInt32 Length { get; set; }

        #endregion

        #endregion
    }
}
