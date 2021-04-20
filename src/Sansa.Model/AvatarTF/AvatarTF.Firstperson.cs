namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張：一人称設定
        /// </summary>
        public class Firstperson
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// 一人称時に描画を切り替えるべきボーン（ボーンリストのインデックス、通常Headを指定）
            /// </summary>
            public int? firstPersonBone { get; set; } = null;

            /// <summary>
            /// 一人時のヘッドセットの目標位置
            /// </summary>
            public Firstpersonboneoffset firstPersonBoneOffset { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// 各メッシュに対して一人称時とそれ以外で表示・非表示を切り替えることができます。 以下の設定があります。
            /// Auto: firstPersonBoneとその子孫に対するボーンWeightを持つポリゴンを自動で非表示にする^firstPersonAuto
            /// FirstPersonOnly: 一人称のみ表示
            /// ThirdPersonOnly: 三人称のみ表示(頭など一人称時に非表示にするメッシュに指定する)
            /// Both: 特に表示切替をしない
            /// </summary>
            public object[] meshAnnotations { get; set; } = null;

            /// <summary>
            /// 目線タイプ
            /// 設定値：Bone       : ボーンにより目線を操作
            ///         BlendShape : BlendShapeにより目線を操作（BlendShapePreset.LookUp, LookDown, LookLeft, LookRightを使用）
            /// </summary>
            public string lookAtTypeName { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Lookathorizontalinner lookAtHorizontalInner { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Lookathorizontalouter lookAtHorizontalOuter { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Lookatverticaldown lookAtVerticalDown { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Lookatverticalup lookAtVerticalUp { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
