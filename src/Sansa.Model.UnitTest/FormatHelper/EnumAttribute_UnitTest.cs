using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sansa.Model.FormatHelper;

namespace Sansa.Model.UnitTest
{
    [TestClass]
    public class EnumAttribute_UnitTest
    {

        enum TEST
        {
            [Enum(Display ="�e�X�g���ڂP", Value = "test/item1", Description ="�e�X�g���ڂP�̐������ł��B")]
            Item1,

            Item2,

            [Enum(Value = "test/item3", Description = "�e�X�g���ڂR�̐������ł��B")]
            Item3,

            [Enum(Display = "�e�X�g���ڂS", Description = "�e�X�g���ڂS�̐������ł��B")]
            Item4,

            [Enum(Display = "�e�X�g���ڂT", Value = "test/item5")]
            Item5
        }

        /// <summary>
        /// ����n�e�X�g
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            TEST? test;
            EnumAttribute attr;

            // -------
            // �SEnum�����l�̎擾
            test = TEST.Item1;
            attr = EnumAttribute.GetEnumAttr<TEST>(test);
            Assert.AreEqual(attr.Display, "�e�X�g���ڂP");
            Assert.AreEqual(attr.Value, "test/item1");
            Assert.AreEqual(attr.Description, "�e�X�g���ڂP�̐������ł��B");

            // -------
            // Enum�����̎w�肪�Ȃ��ꍇ
            test = TEST.Item2;
            attr = EnumAttribute.GetEnumAttr<TEST>(test);
            Assert.AreEqual(attr.Display, "");
            Assert.AreEqual(attr.Value, "");
            Assert.AreEqual(attr.Description, "");

            // -------
            // Enum�����̈ꕔ�̂ݎw��P
            test = TEST.Item3;
            attr = EnumAttribute.GetEnumAttr<TEST>(test);
            Assert.AreEqual(attr.Display, "");
            Assert.AreEqual(attr.Value, "test/item3");
            Assert.AreEqual(attr.Description, "�e�X�g���ڂR�̐������ł��B");

            // -------
            // Enum�����̈ꕔ�̂ݎw��Q
            test = TEST.Item4;
            attr = EnumAttribute.GetEnumAttr<TEST>(test);
            Assert.AreEqual(attr.Display, "�e�X�g���ڂS");
            Assert.AreEqual(attr.Value, "");
            Assert.AreEqual(attr.Description, "�e�X�g���ڂS�̐������ł��B");

            // -------
            // Enum�����̈ꕔ�̂ݎw��R
            test = TEST.Item5;
            attr = EnumAttribute.GetEnumAttr<TEST>(test);
            Assert.AreEqual(attr.Display, "�e�X�g���ڂT");
            Assert.AreEqual(attr.Value, "test/item5");
            Assert.AreEqual(attr.Description, "");
        }
    }
}
