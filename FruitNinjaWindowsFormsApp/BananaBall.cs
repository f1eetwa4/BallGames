using BallsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaWindowsFormsApp
{
    public class BananaBall : FruitBall
    {
        public BananaBall(Form mainForm) : base(mainForm)
        {
            brush = Brushes.Yellow;
        }
    }
}
