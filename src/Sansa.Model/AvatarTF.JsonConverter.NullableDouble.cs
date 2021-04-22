using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// JSONシリアル化のためのNull許容型float用カスタムコンバーター
        /// </summary>
        /// <remarks>
        /// 本来はfloat型です。
        /// <br/>シリアライズ時に有効桁が１桁欠落するためdouble型で処理しています。
        /// </remarks>
        public class JsonConverterForNullableDouble : JsonConverter<double?>
        {
            public override double? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                double? rt = null;
                try
                {
                    rt = reader.GetDouble();
                }
                catch { }
                return rt;
            }

            public override void Write(Utf8JsonWriter writer, double? value, JsonSerializerOptions options)
            {
                if (value.HasValue)
                {
                    writer.WriteNumberValue(value.Value);
                }
            }
        }
    }
}
