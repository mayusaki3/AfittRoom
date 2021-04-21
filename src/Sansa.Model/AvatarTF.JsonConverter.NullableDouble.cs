using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// TODO: 説明
        /// </summary>
        public class JsonConverterForNullableDouble : JsonConverter<double?>
        {
            /// <summary>
            /// TODO: 説明
            /// </summary>
            /// <param name="reader"></param>
            /// <param name="typeToConvert"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public override double? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return reader.GetString() == "" ? null : reader.GetSingle();
            }

            /// <summary>
            /// TODO: 説明
            /// </summary>
            /// <param name="writer"></param>
            /// <param name="value"></param>
            /// <param name="options"></param>
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
