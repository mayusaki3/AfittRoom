using System;

namespace Jaffa.Diagnostics
{
    /// <summary>
    /// ロギング設定クラス
    /// </summary>
    public static class LoggingSettings : Object
    {
        #region プロパティ

        #region ロギングモードを参照または設定 ([R/W] LoggingMode)

        /// <summary>
        /// ロギングモードを参照または設定します。
        /// </summary>
        public static LoggingMode LoggingMode { get; set; } = LoggingMode.None;

        #endregion

        #region ログ出力先フォルダを参照または設定 ([R/W] Folder)

        /// <summary>
        /// ログ出力先フォルダを参照または設定します。
        /// </summary>
        public static string Folder
        {
            get
            {
                return _Folder;
            }
            set
            {
                _Folder = value;
                if (_Folder.Length > 0)
                {
                    if (!_Folder.Substring(_Folder.Length - 1, 1).Equals(@"\"))
                    {
                        _Folder += @"\";
                    }
                }
            }
        }
        private static string _Folder = @"Logs\";

        #endregion

        #region ログファイル名を参照または設定 ([R/W] FileName)

        /// <summary>
        /// ログファイル名を参照または設定します。
        /// ファイル名の'[@]'の部分はLoggingModeに合わせて変化し、
        /// Sizeの場合は01～02, 
        /// Dayの場合は01～31, 
        /// Weekの場合は01～07,
        /// Monthの場合は01～12の値を取ります。
        /// </summary>
        public static string FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                _FileName = value;
                _FileName = _FileName.Replace(@"\", "");
                if (_FileName.LastIndexOf(".") < 1)
                {
                    _FileName += ".txt";
                }
                if (_FileName.LastIndexOf("[@]") < 1)
                {
                    int pos = _FileName.LastIndexOf(".");
                    _FileName = _FileName.Substring(0, pos) +
                        "[@]" +
                        _FileName[pos..];
                }
            }
        }
        private static string _FileName = "syslog[@].txt";

        #endregion

        #region ログファイルサイズ上限をKByte単位で参照または設定 ([R/W] MaxFileSizeKB)

        /// <summary>
        /// ログファイルサイズ上限を参照または設定します。
        /// 2～32767の範囲(単位KByte)で指定し、範囲外の場合は自動調整します。
        /// LoggingModeがSizeの場合に有効で、サイズを超えると1世代のみバックアップを作成します。
        /// </summary>
        public static int MaxFileSizeKB
        {
            get
            {
                return _MaxFileSizeKB;
            }
            set
            {
                if (value < 2)
                {
                    _MaxFileSizeKB = 2;
                }
                else if (value > 32767)
                {
                    _MaxFileSizeKB = 32767;
                }
                else
                {
                    _MaxFileSizeKB = value;
                }
            }
        }
        private static int _MaxFileSizeKB = 2048;

        #endregion

        #region フレームワークメッセージのログ出力が有効かどうかを参照または設定 ([R/W] FrameworkMessage)

        /// <summary>
        /// フレームワークログ出力が有効かどうかを参照または設定します。
        /// </summary>
        public static bool FrameworkMessage { get; set; } = false;

        #endregion

        #endregion
    }
}
