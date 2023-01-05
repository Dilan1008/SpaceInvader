/* 
    Auteur : Dilan Morais Pinheiro
    Date : 05.01.2023
    Description : Classe Wall
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Wall
    {
        private int lat;
        private int longitude;
        private int height;
        private int width;

        public Wall(int lat, int longitude, int height, int width)
        {
            this.lat = lat;
            this.longitude = longitude;
            this.height = height;
            this.width = width;
        }

        public int Lat { get => lat; set => lat = value; }
        public int Longitude { get => longitude; set => longitude = value; }
        public int Height { get => height; set => height = value; }
    }
}
