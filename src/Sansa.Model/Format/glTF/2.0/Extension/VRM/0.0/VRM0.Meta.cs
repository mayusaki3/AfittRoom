using Sansa.Model.FormatHelper;
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
                /// VRM拡張：モデルのメタ情報
                /// </summary>
                /// <remarks>
                /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.meta.schema.json
                /// </remarks>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public class Meta
                {
                    /// <summary>
                    /// タイトル
                    /// <br/>このモデルのタイトルです。
                    /// </summary>
                    public string title { get; set; } = null;

                    /// <summary>
                    /// バージョン
                    /// <br/>このモデルのバージョンです。
                    /// </summary>
                    public string version { get; set; } = null;

                    /// <summary>
                    /// 作者
                    /// <br/>このモデルの作者です。
                    /// </summary>
                    public string author { get; set; } = null;

                    /// <summary>
                    /// 連絡先情報
                    /// <br/>VRMモデル作者の連絡先です。
                    /// </summary>
                    public string contactInformation { get; set; } = null;

                    /// <summary>
                    /// VRMモデルのリファレンス
                    /// <br/>親作品に相当するものがある場合の参照URLなどを記述します。
                    /// </summary>
                    public string reference { get; set; } = null;

                    /// <summary>
                    /// VRMモデルのサムネイル
                    /// <br/>TODO: ??? テクスチャーリストのインデックス
                    /// </summary>
                    public int? texture { get; set; } = null;

                    /// <summary>
                    /// 許可されたユーザー名
                    /// </summary>
                    public enum AllowedUserName
                    {
                        /// <summary>
                        /// アバター作者のみ利用可能
                        /// </summary>
                        [Enum(Display = "{@OnlyAuthor}", Description = "{@OnlyAuthor_desc}")]
                        OnlyAuthor,

                        /// <summary>
                        /// 許可された人のみ利用可能
                        /// </summary>
                        [Enum(Display = "{@ExplicitlyLicensedPerson}", Description = "{@ExplicitlyLicensedPerson_desc}")]
                        ExplicitlyLicensedPerson,

                        /// <summary>
                        /// 誰でも利用可能
                        /// </summary>
                        [Enum(Display = "{@Everyone}", Description = "{@Everyone_desc}")]
                        Everyone
                    }

                    /// <summary>
                    /// 許可されたユーザー名
                    /// <br/>このアバターでパフォーマンスができる人です。
                    /// </summary>
                    public AllowedUserName? allowedUserName { get; set; } = null;

                    /// <summary>
                    /// 許可/不許可
                    /// </summary>
                    public enum AllowOrDisallow
                    {
                        /// <summary>
                        /// 許可
                        /// </summary>
                        [Enum(Display = "{@Allow}")]
                        Allow,

                        /// <summary>
                        /// 不許可
                        /// </summary>
                        [Enum(Display = "{@Disallow}")]
                        Disallow
                    }

                    /// <summary>
                    /// このアバターで暴力的な行為を行うことの許可
                    /// </summary>
                    public AllowOrDisallow? violentUssageName { get; set; } = null;

                    /// <summary>
                    /// このアバターで性行為を行うことへの許可
                    /// </summary>
                    public AllowOrDisallow? sexualUssageName { get; set; } = null;

                    /// <summary>
                    /// 商用利用の許可
                    /// </summary>
                    public AllowOrDisallow? commercialUssageName { get; set; } = null;

                    /// <summary>
                    /// その他のパーミッションURL
                    /// <br/>上記以外の条件がある場合は、ライセンス文書のURLリンクをここに記載してください。
                    /// </summary>
                    public string otherPermissionUrl { get; set; } = null;

                    /// <summary>
                    /// ライセンスタイプ
                    /// </summary>
                    public enum LicenseName
                    {
                        /// <summary>
                        /// 再配布の禁止
                        /// </summary>
                        [Enum(Display = "{@Redistribution_Prohibited}", Description = "{@Redistribution_Prohibited_desc}")]
                        Redistribution_Prohibited,

                        /// <summary>
                        /// 著作権の放棄(CC0)
                        /// </summary>
                        [Enum(Display = "{@CC0}", Description = "{@CC0_desc}")]
                        CC0,

                        /// <summary>
                        /// Creative Commons CC BYライセンス(CC_BY)
                        /// </summary>
                        [Enum(Display = "{@CC_BY}", Description = "{@CC_BY_desc}")]
                        CC_BY,

                        /// <summary>
                        /// Creative Commons CC BY NCライセンス(CC_BY_NC)
                        /// </summary>
                        [Enum(Display = "{@CC_BY_NC}", Description = "{@CC_BY_NC_desc}")]
                        CC_BY_NC,

                        /// <summary>
                        /// Creative Commons CC BY SAライセンス(CC_BY_SA)
                        /// </summary>
                        [Enum(Display = "{@CC_BY_SA}", Description = "{@CC_BY_SA_desc}")]
                        CC_BY_SA,

                        /// <summary>
                        /// Creative Commons CC BY NC SAライセンス(CC_BY_NC_SA)
                        /// </summary>
                        [Enum(Display = "{@CC_BY_NC_SA}", Description = "{@CC_BY_NC_SA_desc}")]
                        CC_BY_NC_SA,

                        /// <summary>
                        /// Creative Commons CC BY NDライセンス(CC_BY_ND)
                        /// </summary>
                        [Enum(Display = "{@CC_BY_ND}", Description = "{@CC_BY_ND_desc}")]
                        CC_BY_ND,

                        /// <summary>
                        /// Creative Commons CC BY NC NDライセンス(CC_BY_NC_ND)
                        /// </summary>
                        [Enum(Display = "{@CC_BY_NC_ND}", Description = "{@CC_BY_NC_ND_desc}")]
                        CC_BY_NC_ND,

                        /// <summary>
                        /// その他
                        /// </summary>
                        [Enum(Display = "{@Other}", Description = "{@Other_desc}")]
                        Other
                    }

                    /// <summary>
                    /// ライセンスタイプ
                    /// </summary>
                    public LicenseName? licenseName { get; set; } = null;

                    /// <summary>
                    /// その他のライセンスURL
                    /// <br/>ライセンスタイプ「その他」を選択した場合は、ライセンス文書のURLリンクをここに記載します。
                    /// </summary>
                    public string otherLicenseUrl { get; set; } = null;
                }
            }
        }
    }
}
