using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sansa.Model.FormatHelper;

namespace Sansa.Model.UnitTest
{
    [TestClass]
    public class EnumAttribute_UnitTest
    {

        enum TEST
        {
            [Enum(Display ="テスト項目１", Value = "test/item1", Description ="テスト項目１の説明文です。")]
            Item1,

            Item2,

            [Enum(Value = "test/item3", Description = "テスト項目３の説明文です。")]
            Item3,

            [Enum(Display = "テスト項目４", Description = "テスト項目４の説明文です。")]
            Item4,

            [Enum(Display = "テスト項目５", Value = "test/item5")]
            Item5
        }

        /// <summary>
        /// 正常系テスト
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            TEST? test;
            EnumAttribute attr;

            // -------
            // 全Enum属性値の取得
            test = TEST.Item1;
            attr = EnumAttribute.GetEnumAttr<TEST>(test);
            Assert.AreEqual(attr.Display, "テスト項目１");
            Assert.AreEqual(attr.Value, "test/item1");
            Assert.AreEqual(attr.Description, "テスト項目１の説明文です。");

            // -------
            // Enum属性の指定がない場合
            test = TEST.Item2;
            attr = EnumAttribute.GetEnumAttr<TEST>(test);
            Assert.AreEqual(attr.Display, "");
            Assert.AreEqual(attr.Value, "");
            Assert.AreEqual(attr.Description, "");

            // -------
            // Enum属性の一部のみ指定１
            test = TEST.Item3;
            attr = EnumAttribute.GetEnumAttr<TEST>(test);
            Assert.AreEqual(attr.Display, "");
            Assert.AreEqual(attr.Value, "test/item3");
            Assert.AreEqual(attr.Description, "テスト項目３の説明文です。");

            // -------
            // Enum属性の一部のみ指定２
            test = TEST.Item4;
            attr = EnumAttribute.GetEnumAttr<TEST>(test);
            Assert.AreEqual(attr.Display, "テスト項目４");
            Assert.AreEqual(attr.Value, "");
            Assert.AreEqual(attr.Description, "テスト項目４の説明文です。");

            // -------
            // Enum属性の一部のみ指定３
            test = TEST.Item5;
            attr = EnumAttribute.GetEnumAttr<TEST>(test);
            Assert.AreEqual(attr.Display, "テスト項目５");
            Assert.AreEqual(attr.Value, "test/item5");
            Assert.AreEqual(attr.Description, "");
        }
    }
}
