﻿/* 
    Auteur : Dilan Morais Pinheiro
    Date : 05.01.2023
    Description : Classe Alien
*/
namespace Class
{
    public class Alien
    {
        private string name;
        private int lat;
        private int longitude;
        private int speed;

        public Alien()
        {
        }

        public Alien(string alienName)
        {
        }

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

        public void location(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}