using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Spaceship
    {
        
        private int speed;
        private int lat;
        private int longitude;

        public Spaceship(int speed, int lat, int longitude)
        {
            this.speed = speed;
            this.lat = lat;
            this.longitude = longitude;
        }

        public int Speed { get => speed; set => speed = value; }
        public int Lat { get => lat; set => lat = value; }
        public int Longitude { get => longitude; set => longitude = value; }
    }
}
