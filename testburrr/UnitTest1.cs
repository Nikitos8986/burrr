using Microsoft.VisualStudio.TestTools.UnitTesting;
using burrr;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace testburrr
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForms111()
        {
            Form f = new Form();
            f.Show();
            Assert.IsTrue(f.Visible);
        }
        [TestMethod]
        public void TestSumm()
        {
            obsluzhivanie obs = new obsluzhivanie();
            obs.summ();
        }
        private string connectionString = "Data Source=DESKTOP-JLG9LLB; Initial Catalog=burrr;Integrated Security = True";
        [TestMethod]
        public void TestDatabaseConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Assert.AreEqual(ConnectionState.Open, connection.State);
                }
                catch (SqlException ex)
                {
                    Assert.Fail($"Failed to connect to database. Error: {ex.Message}");
                }
            }
        }
        [TestMethod]
        public void Testgrid()
        {
           Prosm pro = new Prosm();
            pro.c();
            pro.b();
            pro.a();
            pro.d();
            pro.o();
        }

    }
}
