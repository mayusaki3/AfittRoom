using Jaffa.Diagnostics;
using Sansa.Model.Format;
using Sansa.Model.FormatHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using static Sansa.Model.Format.glTF2.Extension;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        #region メソッド

        #region GLBチャンク0(JSON)のパース (Parse)


        /// <summary>
        /// GLBチャンク0(JSON)のパース
        /// </summary>
        /// <param name="chunk0">GLBチャンク0</param>
        public void Parse(GLB_Chunk chunk0)
        {
            using var ms = new MemoryStream(chunk0.ChunkData, 0, (int)chunk0.ChunkLength);
            using var rd = new StreamReader(ms, Encoding.UTF8);
            string js = rd.ReadToEnd();


            string fnam = @"C:\WORKPLACE\VRoom\LOAD.json";
            WriteFormattedJson(fnam, js);
            Logging.Write("入力VRMのチャンク0(JSON)を " + fnam + " に出力しました。");

            SetJsonSerializerOptions(out JsonSerializerOptions opt);

            //var jsonElems = JsonDocument.Parse(text);
            //var elmLength = jsonElems.RootElement.GetProperty(TotalItems).GetInt32();



            //JsonDocument jsdoc = JsonDocument.Parse(js);


            //foreach (JsonElement je in jsdoc.RootElement.EnumerateArray())
            //{
            //    System.Diagnostics.Debug.Print(je.GetString());


            //}



            //object obj = JsonSerializer.Deserialize(js, opt);

            schema = JsonSerializer.Deserialize<glTF2>(js, opt);

            //Logging.Write("***VRM情報***");
            //Logging.Write("[title]: " + avatarTF.schema.extensions.VRM.meta.title);
            //Logging.Write("[author]: " + avatarTF.schema.extensions.VRM.meta.author);

            //AvatarTF.EnumAttribute ea = avatarTF.GetEnumAttr<AvatarTF.Meta.AllowedUserName>(avatarTF.schema.extensions.VRM.meta.allowedUserName);
            //Logging.Write("[allowedUserName]: " + ea.display + "  // " + ea.description);

            //ea = avatarTF.GetEnumAttr<AvatarTF.Meta.AllowOrDisallow>(avatarTF.schema.extensions.VRM.meta.violentUssageName);
            //Logging.Write("[violentUssageName]: " + ea.display);

            //ea = avatarTF.GetEnumAttr<AvatarTF.Meta.AllowOrDisallow>(avatarTF.schema.extensions.VRM.meta.sexualUssageName);
            //Logging.Write("[sexualUssageName]: " + ea.display);

            //ea = avatarTF.GetEnumAttr<AvatarTF.Meta.LicenseName>(avatarTF.schema.extensions.VRM.meta.licenseName);
            //Logging.Write("[licenseName]: " + ea.display + "  // " + ea.description);
        }

        #endregion

        #region GLBチャンク0(JSON)に変換 (ToChunk)

        /// <summary>
        /// GLBチャンク0(JSON)に変換
        /// </summary>
        /// <param name="chunk0">GLBチャンク0</param>
        public void ToChunk(out GLB_Chunk chunk0)
        {
            chunk0 = new();
            chunk0.ChunkType = GLB_Chunk.ChankType.JSON;

            SetJsonSerializerOptions(out JsonSerializerOptions opt);

            string js = JsonSerializer.Serialize(schema, opt);
            byte[] jsbytes = Encoding.UTF8.GetBytes(js);
            chunk0.ChunkLength = (uint)(jsbytes.Length + jsbytes.Length % 4);
            chunk0.ChunkData = new byte[chunk0.ChunkLength];
            jsbytes.CopyTo(chunk0.ChunkData, 0);
            for (int i = jsbytes.Length; i < chunk0.ChunkLength; i++) chunk0.ChunkData[i] = 0x20;

            string fnam = @"C:\WORKPLACE\VRoom\SAVE.json";
            WriteFormattedJson(fnam, js);
            Logging.Write("出力VRMのチャンク0(JSON)を " + fnam + " に出力しました。");
        }

        #endregion

        #region JSONシリアル化のためのオプションを設定 (SetJsonSerializerOptions) [private/static]

        /// <summary>
        /// JSONシリアル化のためのオプションを設定
        /// </summary>
        /// <param name="ChunkList"></param>
        private static void SetJsonSerializerOptions(out JsonSerializerOptions option)
        {
            option = new()
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            option.Converters.Add(new JsonConverterForNullableFloat());
            option.Converters.Add(new JsonConverterForNullableEnum<VRM0.Meta.AllowedUserName>());
            option.Converters.Add(new JsonConverterForNullableEnum<VRM0.Meta.AllowOrDisallow>());
            option.Converters.Add(new JsonConverterForNullableEnum<VRM0.Meta.LicenseName>());
            option.Converters.Add(new JsonConverterForNullableEnumValue<glTF2.Accessor.ComponentType>());
            option.Converters.Add(new JsonConverterForNullableEnum<glTF2.Accessor.AttributeType>());
            option.Converters.Add(new JsonConverterForNullableEnumValueString<glTF2.Image.MimeType>());
            option.Converters.Add(new JsonConverterForNullableEnum<glTF2.Material.AlphaMode>());
            option.Converters.Add(new JsonConverterForNullableEnum<VRM0.Humanoid.Bone.BoneName>());
            option.Converters.Add(new JsonConverterForNullableEnum<VRM0.FirstPerson.LookAtTypeName>());
            option.Converters.Add(new JsonConverterForNullableEnum<VRM0.FirstPerson.MeshAnnotation.FirstPersonFlag>());
            option.Converters.Add(new JsonConverterForNullableEnum<VRM0.BlendShape.Group.PresetName>());
            option.Converters.Add(new JsonConverterForNullableEnumValue<glTF2.Mesh.Primitive.Mode>());
            option.Converters.Add(new JsonConverterForNullableEnumValue<glTF2.Sampler.MagFilter>());
            option.Converters.Add(new JsonConverterForNullableEnumValue<glTF2.Sampler.MinFilter>());
            option.Converters.Add(new JsonConverterForNullableEnumValue<glTF2.Sampler.Wrap>());
        }

        #endregion

        #region JSONを整形してファイルに出力 (WriteFormattedJson)

        /// <summary>
        /// JSONを整形してファイルに出力します。
        /// </summary>
        /// <param name="filename">出力ファイル名</param>
        /// <param name="jsonText">JSONテキスト</param>
        public void WriteFormattedJson(string filename, string jsonText)
        {
            int depth = 0;
            JsonDocument jsdoc = JsonDocument.Parse(jsonText);
            using (StreamWriter sw = new(filename.Replace(".json", "_1.json")))
            {
                sw.WriteLine(jsonText);
            }
            using (StreamWriter sw = new(filename))
            {
                WriteFormattedJsonOutput(jsdoc.RootElement, sw, depth);
            }
        }

        private void WriteFormattedJsonOutput(JsonElement je, StreamWriter sw, int depth, string nam = "", string comma = "", bool skip = false)
        {
            int count = 0;
            bool isWrite = false;
            string sp = new(' ', depth * 4);
            switch (je.ValueKind)
            {
                case JsonValueKind.Object:
                    if (skip == false)
                    {
                        sw.Write(sp);
                    }
                    sw.Write("{");
                    depth++;
                    List<string> plist = new();
                    foreach (JsonProperty p in je.EnumerateObject())
                    {
                        plist.Add(p.Name);
                    }
                    plist.Sort();
                    foreach (string pnam in plist)
                    {
                        foreach (JsonProperty p in je.EnumerateObject())
                        {
                            if (p.Name.Equals(pnam))
                            {
                                if (isWrite == false)
                                {
                                    sw.WriteLine();
                                    isWrite = true;
                                }
                                sw.Write(sp + "    \"" + p.Name + "\": ");
                                if (p.Value.ValueKind == JsonValueKind.Array ||
                                    p.Value.ValueKind == JsonValueKind.Object)
                                {
                                    skip = true;
                                }
                                else
                                {
                                    skip = false;
                                }
                                count++;
                                WriteFormattedJsonOutput(p.Value, sw, depth, pnam, count < plist.Count ? "," : "", skip);
                            }
                        }
                    }
                    if (isWrite == true) sw.Write(sp);
                    sw.WriteLine("}" + comma);
                    break;
                case JsonValueKind.Array:
                    if (skip == false)
                    {
                        sw.Write(sp);
                    }
                    sw.Write("[");
                    depth++;
                    foreach (JsonElement e in je.EnumerateArray())
                    {
                        if (isWrite == false)
                        {
                            sw.WriteLine();
                            isWrite = true;
                        }
                        if (e.ValueKind != JsonValueKind.Array &&
                            e.ValueKind != JsonValueKind.Object)
                        {
                            sw.Write(sp + "    ");
                        }
                        count++;
                        WriteFormattedJsonOutput(e, sw, depth, nam, count < je.GetArrayLength() ? ",":"");
                    }
                    if (isWrite == true) sw.Write(sp);
                    sw.WriteLine("]" + comma);
                    break;
                case JsonValueKind.Null:
                    sw.WriteLine(comma);
                    break;
                case JsonValueKind.True:
                case JsonValueKind.False:
                    sw.WriteLine(je.GetBoolean().ToString().ToLower() + comma);
                    break;
                case JsonValueKind.String:
                    string txt = je.GetString();
                    if (nam.ToLower().Contains("url") == true)
                    {
                        txt = Uri.EscapeUriString(txt);
                    }
                    sw.WriteLine("\"" + txt + "\"" + comma);
                    break;
                case JsonValueKind.Number:
                    sw.WriteLine(je.ToString() + comma);
                    break;
            }
        }

        #endregion

        #region

        /// <summary>
        /// TODO: チェッカーどうする？
        /// 必須項目チェック
        /// </summary>
        public void RequiredCheck()
        {
            // Buffer
            //if (byteLength.HasValue == false) throw new ValidationException("byteLength is a required field.");
            //if (byteLength < 1) throw new ValidationException("The minimum value of byteLength is 1. The current value is %0.");
        }

        #endregion




        #endregion

        #region

        #region

        /// <summary>
        /// TODO: 説明
        /// </summary>
        public glTF2 schema { get; set; }


        #endregion

        #endregion
    }
}
