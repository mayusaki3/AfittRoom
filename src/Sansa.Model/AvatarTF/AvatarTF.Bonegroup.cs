namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張
        /// TODO: 説明
        /// </summary>
        public class Bonegroup
        {

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string comment { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public float? stiffiness { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public float? gravityPower { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Gravitydir gravityDir { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public float? dragForce { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public float? center { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public float? hitRadius { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int?[] bones { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int?[] colliderGroups { get; set; } = null;

        }
    }
}
