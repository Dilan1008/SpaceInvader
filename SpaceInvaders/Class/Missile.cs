/* 
    Auteur : Dilan Morais Pinheiro
    Date : 05.01.2023
    Description : Classe Missile
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Missile
    {
        private int speed;
        private int PositionX;
        private int PositionY;
        private string design;
        public bool IsDeleted { get; set; }
        public Missile()
        {

        }

        public Missile(int speed, int positionX, int positionY, string design)
        {
            this.speed = speed;
            this.PositionX = positionX;
            this.PositionY = positionY;
            this.design = design;
            IsDeleted = false;
        }

        public int Speed { get => speed; set => speed = value; }

        
    }
}
