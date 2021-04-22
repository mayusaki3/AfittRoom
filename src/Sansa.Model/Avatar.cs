using Jaffa.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Sansa.Model
{
    /// <summary>
    /// アバター
    /// </summary>
    public class Avatar
    {
        #region メソッド

        #region アバターロード (Load)

        /// <summary>
        /// GLBチャンクリストからアバターをロードする。
        /// </summary>
        /// <param name="ChunkList">GLBチャンクリスト</param>
        public void Load(List<GLB_Chunk> ChunkList)
        {
            // チャンク0を処理
            using var ms = new MemoryStream(ChunkList[0].ChunkData, 0, (int)ChunkList[0].ChunkLength);
            using var rd = new StreamReader(ms, Encoding.UTF8);
            string js = rd.ReadToEnd();

            string fnam = @"C:\WORKPLACE\VRoom\LOAD.txt";
            using (StreamWriter sw = new(fnam))
            {
                sw.WriteLine(js.Replace(",", ",\r\n"));
                Logging.Write("入力VRMのチャンク0(JSON)を " + fnam + " に出力しました。");
            }

            SetJsonSerializerOptions(out JsonSerializerOptions opt);

            avatarTF.schema = JsonSerializer.Deserialize<AvatarTF.Schema>(js, opt);

            Logging.Write("***VRM情報***");
            Logging.Write("[title]: " + avatarTF.schema.extensions.VRM.meta.title);
            Logging.Write("[author]: " + avatarTF.schema.extensions.VRM.meta.author);

            AvatarTF.EnumAttribute ea = avatarTF.GetEnumAttr<AvatarTF.Meta.AllowedUserName>(avatarTF.schema.extensions.VRM.meta.allowedUserName);
            Logging.Write("[allowedUserName]: " + ea.display + "  // " + ea.description);

            ea = avatarTF.GetEnumAttr<AvatarTF.Meta.AllowOrDisallow>(avatarTF.schema.extensions.VRM.meta.violentUssageName);
            Logging.Write("[violentUssageName]: " + ea.display);

            ea = avatarTF.GetEnumAttr<AvatarTF.Meta.AllowOrDisallow>(avatarTF.schema.extensions.VRM.meta.sexualUssageName);
            Logging.Write("[sexualUssageName]: " + ea.display);

            ea = avatarTF.GetEnumAttr<AvatarTF.Meta.LicenseName>(avatarTF.schema.extensions.VRM.meta.licenseName);
            Logging.Write("[licenseName]: " + ea.display + "  // " + ea.description);

        }

        #endregion

        #region アバターセーブ (Save)

        /// <summary>
        /// GLBチャンクリストにアバターをセーブする。
        /// </summary>
        /// <param name="ChunkList"></param>
        public void Save(out List<GLB_Chunk> ChunkList)
        {
            ChunkList = new();

            // GLBチャンク0作成
            GLB_Chunk chunk0 = new();
            chunk0.ChunkType = GLB_Chunk.ChankType.JSON;

            SetJsonSerializerOptions(out JsonSerializerOptions opt);

            string js = JsonSerializer.Serialize(avatarTF.schema, opt);
            byte[] jsbytes = System.Text.Encoding.UTF8.GetBytes(js);
            chunk0.ChunkLength = (uint)(jsbytes.Length + jsbytes.Length % 4);
            chunk0.ChunkData = new byte[chunk0.ChunkLength];
            jsbytes.CopyTo(chunk0.ChunkData, 0);
            for (int i = jsbytes.Length; i < chunk0.ChunkLength; i++) chunk0.ChunkData[i] = 0x20;
            ChunkList.Add(chunk0);


            string fnam = @"C:\WORKPLACE\VRoom\SAVE.txt";
            using StreamWriter sw = new(fnam);
            sw.WriteLine(js.Replace(",", ",\r\n"));
            Logging.Write("出力VRMのチャンク0(JSON)を " + fnam + " に出力しました。");

        }

        #endregion

        #region アバターセーブ (Save)

        /// <summary>
        /// GLBチャンクリストにアバターをセーブする。
        /// </summary>
        /// <param name="ChunkList"></param>
        private void SetJsonSerializerOptions(out JsonSerializerOptions option)
        {
            option = new()
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
            option.Converters.Add(new AvatarTF.JsonConverterForNullableInt());
            option.Converters.Add(new AvatarTF.JsonConverterForNullableDouble());
            option.Converters.Add(new AvatarTF.JsonConverterForNullableEnum<AvatarTF.Meta.AllowedUserName>());
            option.Converters.Add(new AvatarTF.JsonConverterForNullableEnum<AvatarTF.Meta.AllowOrDisallow>());
            option.Converters.Add(new AvatarTF.JsonConverterForNullableEnum<AvatarTF.Meta.LicenseName>());
            option.Converters.Add(new AvatarTF.JsonConverterForNullableEnumValue<AvatarTF.Accessor.ComponentType>());
            option.Converters.Add(new AvatarTF.JsonConverterForNullableEnum<AvatarTF.Accessor.AttributeType>());
        }

        #endregion

        #endregion

        #region



        #endregion

        #region




        #endregion

        #region プロパティ

        #region アバター

        public AvatarTF avatarTF { get; } = new();

        #endregion

        #endregion

        #region




        #endregion
    }
}
