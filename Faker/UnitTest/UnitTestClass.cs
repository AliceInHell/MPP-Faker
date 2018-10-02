using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FakerLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTestClass
    {
        private Faker _faker;
        private Foo<string> _foo;

        [TestInitialize]
        public void SetUp()
        {
            _faker = new Faker();
            FieldValueGenerator.SetFaker(_faker);
            FieldValueGenerator.DTOAdd(typeof(Foo<string>));
            FieldValueGenerator.DTOAdd(typeof(Bar<char>));
            FieldValueGenerator.DTOAdd(typeof(Bar<byte>));

            _foo = _faker.Create<Foo<string>>();
        }

        //the most useless test
        [TestMethod]
        public void BoolGeneratorTest()
        {
            Assert.IsTrue(_foo.GetBool() == false || _foo.GetBool() == true);
        }

        [TestMethod]
        public void CharGeneratorTest()
        {
            Assert.IsTrue((byte)_foo.GetChar() > 0 && (byte)_foo.GetChar() <= 255);
        }

        [TestMethod]
        public void DateTimeTest()
        {
            Assert.IsTrue(_foo.GetDate() != null);
        }

        [TestMethod]
        public void DoubleGenratorTest()
        {
            Assert.IsTrue((_foo.GetDouble() >= double.MinValue && _foo.GetDouble() <= double.MaxValue) 
                && _foo.GetDouble() != default(double));
        }

        [TestMethod]
        public void FloatGeneratorTest()
        {
            Assert.IsTrue(_foo.GetFloat() >= float.MinValue && _foo.GetFloat() <= float.MaxValue 
                && _foo.GetFloat() != default(float));
        }

        [TestMethod]
        public void IntGeneratorTest()
        {
            Assert.IsTrue(_foo.GetInt() >= int.MinValue && _foo.GetInt() <= int.MaxValue 
                && _foo.GetInt() != default(int));
        }

        [TestMethod]
        public void ListGeneratorTest1()
        {
            Assert.IsTrue(_foo.GetList() != null && _foo.GetList() is List<string>);
        }

        [TestMethod]
        public void ListGeneratorTest2()
        {
            Assert.IsTrue(_foo.GetList() != null && _foo.GetList() is List<string> && _foo.GetList()[0] is string);
        }

        [TestMethod]
        public void LongGeneratorTest()
        {
            Assert.IsTrue(_foo.GetLong() >= long.MinValue && _foo.GetLong() <= long.MaxValue);
        }

        [TestMethod]
        public void ObjectGeneratorTest()
        {
            Assert.IsTrue(_foo.GetObkect() != null);
        }

        [TestMethod]
        public void StringGeneratorTest()
        {
            Assert.IsTrue(_foo.GetString() != null && _foo.GetString().Length != 0);
        }

        [TestMethod]
        public void InsertedBarTest1()
        {
            Assert.IsTrue(_foo.GetBar() != null);
        }

        [TestMethod]
        public void InsertedBarTest2()
        {
            Assert.IsTrue(_foo.GetBar()._bar._bar == null);
        }

        [TestMethod]
        public void InsertedFooGeneratorTest1()
        {
            Assert.IsTrue(_foo.GetBar()._foo != null);
        }

        [TestMethod]
        public void InsertedFooGeneratorTest2()
        {
            Assert.IsTrue(_foo.GetBar()._foo.GetBar() == null);
        }

        [TestMethod]
        public void FakeIntTest()
        {
            Assert.IsTrue(_foo.fakeInt == default(int));
        }

        [TestMethod]
        public void PublicBarPropertyTest()
        {
            Bar<byte> bar = _faker.Create<Bar<byte>>();
            Assert.IsTrue((byte)bar._char > 0 && (byte)bar._char <= 255);
        }
    }
}
