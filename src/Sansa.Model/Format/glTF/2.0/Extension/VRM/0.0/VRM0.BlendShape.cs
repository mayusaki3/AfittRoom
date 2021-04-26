using System.Collections.Generic;
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
                /// VRM拡張：モーフ設定
                /// <br/>UniVRM の BlendShapeAvatar
                /// </summary>
                /// <remarks>
                /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.blendshape.schema.json
                /// </remarks>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public partial class BlendShape
                {
                    /// <summary>
                    /// BlendShapeのグループ
                    /// <br/>BlendShapeをグループ化するBlendShapeGroupのリストを設定します。
                    /// </summary>
                    public List<Group> blendShapeGroups { get; set; } = null;
                }
            }
        }
    }
}