using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// JSONシリアル化のためのNull許容型int用カスタムコンバーター
        /// </summary>
        public class JsonConverterForNullableInt : JsonConverter<int?>
        {
            public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                int? rt = null;
                try
                {
                    rt = reader.GetInt32();
                }
                catch { }
                return rt;
            }

            public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
            {
                if (value.HasValue)
                {
                    writer.WriteNumberValue(value.Value);
                }
            }
        }
    }
}
