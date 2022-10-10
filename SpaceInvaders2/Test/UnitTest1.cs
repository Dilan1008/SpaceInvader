using Class;

namespace Test
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMoveAlien()
        {
            byte X = 10;
            byte Y = 10;
            Alien alien = new Alien();
            alien.location(X, Y);
            for(int i = 0; i < 5; i++)
            {
                alien.location(X--, Y); 
            }
            Assert.AreEqual(X--, Y) ;
            
        }

        [TestMethod]

        public void TestnameUser()
        {
            User user = new User();
            user.Name = "Julien";
            Assert.AreEqual("Julien", user.Name);
        }

        [TestMethod]

        public void TestShoot()
        {
            bool spaceBar = false;
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Spacebar:
                    
                    Shoot shoot = new Shoot();
                    spaceBar = true;
                    break;
            }
            Assert.AreEqual(true,spaceBar);
        }

        [TestMethod]

        public void TestMoveShip()
        {
            byte X = 1;
            byte Y = 1;
            SpaceShip Ship = new SpaceShip();
            Ship.location(X, Y);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.RightArrow:
                    Ship.location(X++, Y);
                    break;

            }
            Assert.AreEqual(X++, ConsoleKey.UpArrow);
        }

    }
}