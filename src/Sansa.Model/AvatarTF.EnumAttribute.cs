using System;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// Enum属性クラス
        /// </summary>
        [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
        public class EnumAttribute : Attribute
        {
            /// <summary>
            /// 表示
            /// </summary>
            public string display { get; set; } = "";

            /// <summary>
            /// 説明
            /// </summary>
            public string description { get; set; } = "";
        }
    }
}
