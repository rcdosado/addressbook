using System;
using NUnit.Framework;
using AddressBook.Modules.Tests;


namespace AddressBook.Modules.Tests
{
    [TestFixture]
    class RecordTests
    {

        [Test]
        public void TestIfRecordIsValid()
        {
            var rec = new Record {_id = 123,_age = 20,_firstname="John",_lastname="Doe",_sex="M"};
            Assert.AreEqual(rec._id, 123);
            Assert.AreEqual(rec._age, 20);
            Assert.AreEqual(rec._firstname, "John");
            Assert.AreEqual(rec._lastname, "Doe");
            Assert.AreEqual(rec._sex, "M");            

        }
    }
}
