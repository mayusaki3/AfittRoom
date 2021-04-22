using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.Json;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        #region

        #region

        /// <summary>
        /// TODO: チェッカーどうする？
        /// 必須項目チェック
        /// </summary>
        public void RequiredCheck()
        {
            // Buffer
            //if (byteLength.HasValue == false) throw new ValidationException("byteLength is a required field.");
            //if (byteLength < 1) throw new ValidationException("The minimum value of byteLength is 1. The current value is %0.");
        }

        #endregion

        #region

        /// <summary>
        /// TODO: チェッカーどうする？
        /// 必須項目チェック
        /// </summary>
        public EnumAttribute GetEnumAttr<T>(T? value) where T : struct, Enum
        {
            EnumAttribute rt = new();
            FieldInfo fld = typeof(T).GetField(Enum.GetName(typeof(T), value));
            EnumAttribute ea = (EnumAttribute)fld.GetCustomAttribute(typeof(EnumAttribute));
            rt.display = Core.MakeMessage(ea.display);
            rt.description = Core.MakeMessage(ea.description);
            return rt;
        }

        #endregion


        #endregion

        #region

        #region

#pragma warning disable IDE1006 // 命名スタイル
        /// <summary>
        /// TODO: 説明
        /// </summary>
        public Schema schema { get; set; }

#pragma warning restore IDE1006 // 命名スタイル

        #endregion

        #endregion
    }
}
