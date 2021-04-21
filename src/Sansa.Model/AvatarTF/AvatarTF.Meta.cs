namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張：モデル情報
        /// </summary>
        public class Meta
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: どうする
            /// </summary>
            public enum ViolentUssageName
            {
                /// <summary>
                /// 許可
                /// </summary>
                Allow,

                /// <summary>
                /// 不許可
                /// </summary>
                Disallow
            }

            /// <summary>
            /// バージョン
            /// </summary>
            public string version { get; set; } = null;

            /// <summary>
            /// 作者
            /// </summary>
            public string author { get; set; } = null;

            /// <summary>
            /// 作者（代表者）への連絡先
            /// </summary>
            public string contactInformation { get; set; } = null;

            /// <summary>
            /// 参照（何か「親作品」に相当するものがある場合は参照URLなどを記述）
            /// </summary>
            public string reference { get; set; } = null;

            /// <summary>
            /// タイトル
            /// </summary>
            public string title { get; set; } = null;

            /// <summary>
            /// サムネイル（テクスチャーリストのインデックス）
            /// </summary>
            public int? texture { get; set; } = null;

            /// <summary>
            /// アバターに人格を与えることの許諾範囲
            /// 設定値: アバターを操作することはアバター作者にのみ許される(Only Author)
            ///         明確に許可された人限定(Explictly Licensed Person)
            ///         全員に許可(Everyone)
            /// </summary>
            public string allowedUserName { get; set; } = null;

            /// <summary>
            /// このアバターを用いて暴力表現を演じることの許可
            /// 設定値: 不許可(Disallow)
            ///         許可(Allow) 
            /// </summary>
            public string violentUssageName { get; set; } = null;

            /// <summary>
            /// このアバターを用いて性的表現を演じることの許可
            /// 設定値: 不許可(Disallow)
            ///         許可(Allow) 
            /// </summary>
            public string sexualUssageName { get; set; } = null;

            /// <summary>
            /// 商用利用の許可
            /// 設定値: 不許可(Disallow)
            ///         許可(Allow) 
            /// </summary>
            public string commercialUssageName { get; set; } = null;

            /// <summary>
            /// その他のライセンス条件（上記許諾条件以外のライセンス条件がある場合はライセンス文書へのURL）
            /// </summary>
            public string otherPermissionUrl { get; set; } = null;

            /// <summary>
            /// ライセンスタイプ
            /// 設定値: 再配布禁止(Redistribution Prohibited)
            ///         著作権放棄(CC0)
            ///         Creative Commons CC BYライセンス(CC_BY)
            ///         Creative Commons CC BY NCライセンス(CC_BY_NC)
            ///         Creative Commons CC BY SAライセンス(CC_BY_SA)
            ///         Creative Commons CC BY NC SAライセンス(CC_BY_NC_SA)
            ///         Creative Commons CC BY NDライセンス(CC_BY_ND)
            ///         Creative Commons CC BY NC NDライセンス(CC_BY_NC_ND)
            ///         その他(Other)
            /// </summary>
            public string licenseName { get; set; } = null;

            /// <summary>
            /// その他ライセンス条件（上記許諾条件以外のライセンス条件がある場合はライセンス文書へのURL）
            /// </summary>
            public string otherLicenseUrl { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
