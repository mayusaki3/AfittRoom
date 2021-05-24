using System;

namespace Jaffa.Diagnostics
{
    /// <summary>
    /// ロギングモード
    /// </summary>
    public enum LoggingMode : byte
    {
        /// <summary>
        /// ファイルに出力しません。
        /// </summary>
        None,
        /// <summary>
        /// 指定したサイズを超えたらファイルを切り替えます。ファイル名には(01-02)が入ります。常に01が新しいファイルです。
        /// </summary>
        Size,
        /// <summary>
        /// 日単位でファイルを切り替えます。ファイル名には日(01-31)が入ります。
        /// </summary>
        Day,
        /// <summary>
        /// 週単位でファイルを切り替えます。ファイル名には週(01-07)が入ります。
        /// </summary>
        Week,
        /// <summary>
        /// 月単位でファイルを切り替えます。ファイル名には月(01-12)が入ります。
        /// </summary>
        Month
    }
}
