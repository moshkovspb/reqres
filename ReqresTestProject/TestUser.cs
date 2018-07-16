using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.IO;
using System.Data;

namespace ReqresTestProject
{
    [TestClass]
    public class TestUser
    {
        //Test case GET-01
        [TestMethod]
        public void UserGet()
        {
            UserGet user = new UserGet("2");
            Assert.AreEqual(2, user.response.Data.data.id); 
            Assert.AreEqual("Janet", user.response.Data.data.first_name);
            Assert.AreEqual("Weaver", user.response.Data.data.last_name);
            Assert.AreEqual("https://s3.amazonaws.com/uifaces/faces/twitter/josephstein/128.jpg", user.response.Data.data.avatar);
        }

        //Test case CREATE-01
        [TestMethod]
        public void UserCreate()
        {
            UserCreate user = new UserCreate("morpheus", "leader");
            Assert.AreEqual("morpheus", user.response.Data.name);
            Assert.AreEqual("leader", user.response.Data.job);
            Assert.IsTrue(user.response.Data.id > 0);
            Assert.AreEqual(0, user.date.CompareTo(user.response.Data.createdAt.Date));
        }

        //Test case UPDATE-01
        [TestMethod]
        public void UserUpdate()
        {
            UserUpdate user = new UserUpdate("morpheus", "zion resident");
            Assert.AreEqual("morpheus", user.response.Data.name);
            Assert.AreEqual("zion resident", user.response.Data.job);
            Assert.AreEqual(0, user.date.CompareTo(user.response.Data.updatedAt.Date));
        }

        //Test case DELETE-01
        [TestMethod]
        public void UserDelete()
        {
            UserDelete user = new UserDelete("2");
            Assert.AreEqual(System.Net.HttpStatusCode.NoContent, user.response.StatusCode);

        }
    }
}
