using Class;

namespace Test
{
    [TestClass]
    public class spaceInvaders
    {
        [TestMethod]
        public void alienspeed()
        {
            Alien alien = new Alien();

        }

        [TestMethod]
        public void TestnameUser()
        {
            User user = new User();
            user.Name = "JuLIeN";
            Assert.AreEqual("Julien", user.Name);
        }
    }
}