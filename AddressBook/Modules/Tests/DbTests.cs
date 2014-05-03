using NUnit.Framework;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace AddressBook.Modules.Tests
{
    [TestFixture]
    class DbTests
    {
        [Test]
       public void TestIfInvalidConnectionString()
        {
            var db = new Db();
            db.ConString = "Server=localhosts;Database=testdb;Uid=root;Pwd=;";//erroneous
            db.Connect();
            Assert.AreEqual(db.IsConnected(), false);
        }

        [Test]
        public void TestIfValidConnectionString()
        {
            var db = new Db();
            db.Connect();
            Assert.AreEqual(db.IsConnected(), true);
            db.CloseConn();
            Assert.AreEqual(db.IsConnected(), false);
        }

        [Test]
        public void TestIfRowValuesAreSelected()
        {
            var db = new Db();
            db.Connect();
            if (db.IsConnected())
            {                
                db.bind("id", "1");
                string[] p = db.row("select * from persons where id = @id");
                Assert.AreEqual(p[0], "1");
                Assert.AreEqual(p[1], "John");
                Assert.AreEqual(p[2], "Doe");
                db.CloseConn();
            }
        }

        [Test]
        public void TestIfSingleCellValueIsSelected()
        {
            var db = new Db();
            db.Connect();
            if (db.IsConnected())
            { 
                db.Connect();
                db.bind("id", "1");
                string p = db.single("select age from persons where id = @id");
                Assert.AreEqual(p, "19");
                db.CloseConn();
            }
        }
        [Test]
        public void TestCreationOfNewDatabase()
        {
            var db = new Db();
            db.Drop("kungfoo");
            Assert.AreEqual(db.Create("kungfoo",true),true);
        }
    }
}
