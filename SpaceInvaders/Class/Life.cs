/* 
    Auteur : Dilan Morais Pinheiro
    Date : 05.01.2023
    Description : Classe Life
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Life
    {
        private int contain;

        public Life(int contain)
        {
            this.contain = contain;
        }

        public int Contain { get => contain; set => contain = value; }
    }
}
