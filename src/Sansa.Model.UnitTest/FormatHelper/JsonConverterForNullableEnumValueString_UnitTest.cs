using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sansa.Model.FormatHelper;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Sansa.Model.UnitTest
{
    [TestClass]
    public class JsonConverterForNullableEnumValueString_UnitTest
    {

        enum TESTENUM
        {
            [Enum(Value = "test/item1")]
            Item1 = 120,

            [Enum(Value = "test/item2")]
            Item2 = 135,

            [Enum(Value = "test/item3")]
            Item3 = 140,

            [Enum(Value = "test/item4")]
            Item4 = 273,

            [Enum(Value = "test/項目5")]
            Item5 = 306
        }

        class TESTCLASS
        {
            public TESTENUM? value1 { get; set; } = null;
            public TESTENUM? value2 { get; set; } = null;
        }

        /// <summary>
        /// 正常系テスト
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            string js;
            string jsout;
            TESTCLASS schema;
            JsonSerializerOptions option = new()
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            option.Converters.Add(new JsonConverterForNullableEnumValueString<TESTENUM>());

            schema = new();
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, "{}");

            // -------
            // 空の場合
            js = "{}";
            schema = JsonSerializer.Deserialize<TESTCLASS>(js, option);
            Assert.AreEqual(schema.value1, null);
            Assert.AreEqual(schema.value2, null);
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, js);

            // -------
            // 指定と未指定の混在
            js = "{\"value1\":\"test/item3\"}";
            schema = JsonSerializer.Deserialize<TESTCLASS>(js, option);
            Assert.AreEqual(schema.value1, TESTENUM.Item3);
            Assert.AreEqual(schema.value2, null);
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, js);

            // -------
            // 複数の場合
            js = "{\"value1\":\"test/item2\",\"value2\":\"test/項目5\"}";
            schema = JsonSerializer.Deserialize<TESTCLASS>(js, option);
            Assert.AreEqual(schema.value1, TESTENUM.Item2);
            Assert.AreEqual(schema.value2, TESTENUM.Item5);
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, js);
        }
    }
}
