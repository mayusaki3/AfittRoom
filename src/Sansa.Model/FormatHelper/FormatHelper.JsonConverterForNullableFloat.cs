using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sansa.Model.FormatHelper
{
    /// <summary>
    /// JSONシリアル化のためのNull許容型float用カスタムコンバーター
    /// </summary>
    /// <remarks>
    /// 本来はfloat型です。
    /// <br/>シリアライズ時に有効桁が１桁欠落するためdouble型で処理しています。
    /// </remarks>
    public class JsonConverterForNullableFloat : JsonConverter<float?>
    {
        public override float? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            float? rt = null;
            try
            {
                rt = reader.GetSingle();
            }
            catch { }
            return rt;
        }

        public override void Write(Utf8JsonWriter writer, float? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteNumberValue(value.Value);
            }
        }
    }
}
