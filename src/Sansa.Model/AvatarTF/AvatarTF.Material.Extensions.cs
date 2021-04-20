namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// マテリアル
        /// </summary>
        public partial class Material
        {
            /// <summary>
            /// 拡張情報
            /// </summary>
            public class Extensions
            {
                /// <summary>
                /// クロノス拡張：マテリアルユニット
                /// </summary>
                public KHR_Materials_Unlit KHR_materials_unlit { get; set; } = null;
            }
        }
    }
}
