namespace Class
{
    public class Alien
    {
        private string name;
        private int lat;
        private int longitude;
        private int speed;

        public Alien(string name, int lat, int longitude, int speed)
        {
            this.name = name;
            this.lat = lat;
            this.longitude = longitude;
            this.speed = speed;
        }

        public string Name { get => name; set => name = value; }
        public int Lat { get => lat; set => lat = value; }
        public int Longitude { get => longitude; set => longitude = value; }
        public int Speed { get => speed; set => speed = value; }
    }
}