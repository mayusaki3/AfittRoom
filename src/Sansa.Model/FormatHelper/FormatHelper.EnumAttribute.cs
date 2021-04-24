using System;
using System.Reflection;

namespace Sansa.Model.FormatHelper
{
    /// <summary>
    /// Enum属性クラス
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EnumAttribute : Attribute
    {
        #region メソッド

        #region Enum値の属性を取得 (GetEnumAttr) [static]

        /// <summary>
        /// Enum値の属性を取得します
        /// </summary>
        /// <typeparam name="T">対象のenumクラス名</typeparam>
        /// <param name="value">Enum値</param>
        /// <returns>属性</returns>
        public static EnumAttribute GetEnumAttr<T>(T? value) where T : struct, Enum
        {
            EnumAttribute rt = new();
            FieldInfo fld = typeof(T).GetField(Enum.GetName(typeof(T), value));
            EnumAttribute ea = (EnumAttribute)fld.GetCustomAttribute(typeof(EnumAttribute));
            if (ea != null)
            {
                rt.Display = Core.MakeMessage(ea.Display);
                rt.Value = Core.MakeMessage(ea.Value);
                rt.Description = Core.MakeMessage(ea.Description);
            }
            return rt;
        }

        #endregion

        #endregion

        #region プロパティ

        /// <summary>
        /// 表示
        /// <br/>表示用の文字列を設定できます。
        /// </summary>
        public string Display { get; set; } = "";

        /// <summary>
        /// 文字列値
        /// <br/>enum値に文字列値を設定できます。
        /// /// </summary>
        public string Value { get; set; } = "";

        /// <summary>
        /// 説明
        /// <br/>説明文を設定できます。
        /// </summary>
        public string Description { get; set; } = "";

        #endregion
    }
}