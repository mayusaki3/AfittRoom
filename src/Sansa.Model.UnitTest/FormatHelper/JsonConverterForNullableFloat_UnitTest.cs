using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sansa.Model.FormatHelper;
using System.Text.Json;

namespace Sansa.Model.UnitTest
{
    [TestClass]
    public class JsonConverterForNullableFloat_UnitTest
    {
        class TESTCLASS
        {
            public float? value1 { get; set; } = null;
            public float? value2 { get; set; } = null;
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
            option.Converters.Add(new JsonConverterForNullableFloat());

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
            js = "{\"value1\":0.9882353}";
            schema = JsonSerializer.Deserialize<TESTCLASS>(js, option);
            Assert.AreEqual(schema.value1, 0.9882353F);
            Assert.AreEqual(schema.value2, null);
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, js);

            // -------
            // 複数の場合
            js = "{\"value1\":0.0170069039,\"value2\":-2.05636024e-06}";
            schema = JsonSerializer.Deserialize<TESTCLASS>(js, option);
            Assert.AreEqual(schema.value1, 0.0170069039F);
            Assert.AreEqual(schema.value2, -2.05636024e-06F);
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, js);
        }
    }
}
