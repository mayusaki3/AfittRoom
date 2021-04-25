﻿namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Camera
        {
            public partial class Perspective
            {
                /// <summary>
                /// アプリケーション固有のデータ
                /// <br/>
                /// </summary>
                /// <remarks>
                /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/extras.schema.json
                /// <br/>**実装上の注意：**
                /// <br/>エクストラは任意の型を持つことができますが、
                /// アプリケーションではカスタムデータをキー/値のペアとして
                /// 保存およびアクセスすることが一般的です。
                /// <br/>ベストプラクティスとしては、移植性を高めるために、
                /// extras はプリミティブな値ではなく Object であるべきです。
                /// </remarks>
                public class Extras
                {
                }
            }
        }
    }
}
