using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sansa.Model.FormatHelper;
using System.Text.Json;

namespace Sansa.Model.UnitTest
{
    [TestClass]
    public class JsonConverterForNullableEnum_UnitTest
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
        /// ����n�e�X�g
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
            option.Converters.Add(new JsonConverterForNullableEnum<TESTENUM>());

            schema = new();
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, "{}");

            // -------
            // ��̏ꍇ
            js = "{}";
            schema = JsonSerializer.Deserialize<TESTCLASS>(js, option);
            Assert.AreEqual(schema.value1, null);
            Assert.AreEqual(schema.value2, null);
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, js);

            // -------
            // �w��Ɩ��w��̍���
            js = "{\"value1\":\"Item3\"}";
            schema = JsonSerializer.Deserialize<TESTCLASS>(js, option);
            Assert.AreEqual(schema.value1, TESTENUM.Item3);
            Assert.AreEqual(schema.value2, null);
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, js);

            // -------
            // �����̏ꍇ
            js = "{\"value1\":\"Item2\",\"value2\":\"Item5\"}";
            schema = JsonSerializer.Deserialize<TESTCLASS>(js, option);
            Assert.AreEqual(schema.value1, TESTENUM.Item2);
            Assert.AreEqual(schema.value2, TESTENUM.Item5);
            jsout = JsonSerializer.Serialize(schema, option);
            Assert.AreEqual(jsout, js);
        }
    }
}
