using Class;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string AlienName = "brook";
            Alien small;

            small = new Alien(AlienName);
            Assert.IsNotNull(small);

        }

        [TestMethod]

        public void TestnameUser()
        {
            User user = new User();
            user.Name = "JuLiEN";
            Assert.AreEqual("Julien", user.Name);
        }

        [TestMethod]

        public void TestShoot()
        {
            for(int i = 0; i < 10; i++)
            {
                Shoot missile = new Shoot();
            }
        }
    }
}