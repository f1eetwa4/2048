using System;
using System.Collections.Generic;
using System.Text;

namespace _2048WinFormsApp
{
    internal class User
    {
        public string Name { get; }
        public int Score { get; private set; }
        public User(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public void IncreaseUserScore(int addedPoint)
        {
            Score += addedPoint;
        }
    }
}
