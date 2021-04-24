using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sansa.Model.FormatHelper;
using System.Text.Json;

namespace Sansa.Model.UnitTest
{
    [TestClass]
    public class JsonConverterForNullableEnumValue_UnitTest
    {

        enum TESTENUM
        {
            Item1 = 120,
            Item2 = 135,
            Item3 = 140,
            Item4 = 273,
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
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
            option.Converters.Add(new JsonConverterForNullableEnumValue<TESTENUM>());

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
            js = "{\"value1\":140}";
            schema = JsonSerializer.Deserialize<TESTCLASS>(js, option);
            Assert.AreEqual(schema.value1, TESTENUM.Item3);
            Assert.AreEqual(schema.value2, null);
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, js);

            // -------
            // 複数の場合
            js = "{\"value1\":135,\"value2\":306}";
            schema = JsonSerializer.Deserialize<TESTCLASS>(js, option);
            Assert.AreEqual(schema.value1, TESTENUM.Item2);
            Assert.AreEqual(schema.value2, TESTENUM.Item5);
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, js);
        }
    }
}
