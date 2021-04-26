using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            public partial class VRM0
            {
                /// <summary>
                /// VRM拡張：x, y, z成分の値からなる3次元ベクトル
                /// </summary>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public partial class Vector3
                {
                    /// <summary>
                    /// X座標
                    /// </summary>
                    public float? x { get; set; } = null;

                    /// <summary>
                    /// Y座標
                    /// </summary>
                    public float? y { get; set; } = null;

                    /// <summary>
                    /// Z座標
                    /// </summary>
                    public float? z { get; set; } = null;
                }
            }
        }
    }
}
