using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    /// <summary>
    /// glTFスキーマ
    /// <br/>glTFアセットのルートオブジェクトです。
    /// </summary>
    /// <remarks>
    /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/glTF.schema.json
    /// </remarks>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public partial class glTF2
    {
        /// <summary>
        /// 使用しているエクステンション
        /// <br/>このアセットのどこかで使用されているglTFエクステンションの名前リストです。
        /// </summary>
        /// <remarks>
        /// ユニークアイテム
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<string> extensionsUsed { get; set; } = null;

        /// <summary>
        /// 必須のエクステンション
        /// <br/>このアセットを正しく読み込むために必要なglTFエクステンションの名前リストです。
        /// </summary>
        /// <remarks>
        /// ユニークアイテム
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<string> extensionsRequired { get; set; } = null;

        /// <summary>
        /// アクセサのリスト
        /// <br/>アクセサは bufferView への型付けされたビューです。
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Accessor> accessors { get; set; } = null;

        /// <summary>
        /// アニメーションのリスト
        /// <br/>キーフレームアニメーションのリストです。
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Animation> animations { get; set; } = null;

        /// <summary>
        /// アセット
        /// <br/>glTFアセットに関するメタデータです。
        /// </summary>
        /// <remarks>
        /// 必須項目
        /// </remarks>
        public Asset asset { get; set; } = null;

        /// <summary>
        /// バッファのリスト
        /// <br/>バッファは、バイナリジオメトリ、アニメーション、スキンを指します。
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Buffer> buffers { get; set; } = null;

        /// <summary>
        /// bufferViewsのリスト
        /// <br/>bufferViewは、バッファのサブセットを表すビューです。
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<BufferView> bufferViews { get; set; } = null;

        /// <summary>
        /// カメラのリスト
        /// <br/>カメラは投影行列を定義します。
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Camera> cameras { get; set; } = null;

        /// <summary>
        /// 画像のリスト
        /// <br/>画像は、テクスチャを作成するためのデータを定義するものです。
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Image> images { get; set; } = null;

        /// <summary>
        /// マテリアルのリスト
        /// <br/>マテリアルは、プリミティブの外観を定義します。
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Material> materials { get; set; } = null;

        /// <summary>
        /// メッシュのリスト
        /// <br/>メッシュとは、レンダリングされるプリミティブの集合体です。
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Mesh> meshes { get; set; } = null;

        /// <summary>
        /// ノードのリスト
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Node> nodes { get; set; } = null;

        /// <summary>
        /// サンプラーのリスト
        /// <br/>サンプラーには、テクスチャのフィルタリングやラッピングモードのプロパティが含まれています。
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Sampler> samplers { get; set; } = null;

        /// <summary>
        /// デフォルトシーンのインデックス
        /// </summary>
        /// <remarks>
        /// 依存関係: scenes
        /// </remarks>
        public int? scene { get; set; } = null;

        /// <summary>
        /// シーンのリスト
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Scene> scenes { get; set; } = null;

        /// <summary>
        /// スキンのリスト
        /// <br/>スキンはジョイントとマトリクスで定義されます。
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Skin> skins { get; set; } = null;

        /// <summary>
        /// テクスチャーのリスト
        /// </summary>
        /// <remarks>
        /// <br/>指定する場合、最低１つ以上定義します。
        /// </remarks>
        public List<Texture> textures { get; set; } = null;

        /// <summary>
        /// エクステンション
        /// </summary>
        public Extensions extensions { get; set; } = null;

        /// <summary>
        /// アプリケーション固有のデータ
        /// </summary>
        public Extras extras { get; set; } = null;
    }
}
