using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sansa.Model.FormatHelper
{
    /// <summary>
    /// JSONシリアル化のためのNull許容型enum数値用カスタムコンバーター
    /// </summary>
    public class JsonConverterForNullableEnumValue<T> : JsonConverter<T?> where T : struct, Enum
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            T? rt = null;
            try
            {
                rt = (T)Enum.ToObject(typeof(T), reader.GetInt32());
            }
            catch { }
            return rt;
        }

        public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
        {
            if (value != null)
            {
                writer.WriteNumberValue(value.GetHashCode());
            }
        }
    }
}
