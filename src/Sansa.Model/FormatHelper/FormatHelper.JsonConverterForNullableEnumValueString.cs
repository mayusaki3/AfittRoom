using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sansa.Model.FormatHelper
{
    /// <summary>
    /// JSONシリアル化のためのNull許容型enum文字列用カスタムコンバーター
    /// <br/>
    /// </summary>
    public class JsonConverterForNullableEnumValueString<T> : JsonConverter<T?> where T : struct, Enum
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            T? rt = null;
            string val = reader.GetString();
            foreach (T value in Enum.GetValues(typeof(T)))
            {
                EnumAttribute attr = EnumAttribute.GetEnumAttr<T>(value);
                if (attr.Value.Equals(val))
                {
                    rt = value;
                    break;
                }
            }
            return rt;
        }

        public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
        {
            if (value != null)
            {
                EnumAttribute attr = EnumAttribute.GetEnumAttr<T>(value);
                writer.WriteStringValue(attr.Value);
            }
        }
    }
}
