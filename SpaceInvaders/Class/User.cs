/* 
    Auteur : Dilan Morais Pinheiro
    Date : 05.01.2023
    Description : Classe User
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class User
    {
        private string userName;
        private int HighScore;
        private int Score;

        public User()
        {
        }

        public User(string userName, int highScore, int score)
        {
            this.userName = userName;
            HighScore = highScore;
            Score = score;
        }

        public string UserName { get => userName; set => userName = value; }
        public int HighScore1 { get => HighScore; set => HighScore = value; }
        public int Score1 { get => Score; set => Score = value; }
        public string Name { get; set; }
    }
}
