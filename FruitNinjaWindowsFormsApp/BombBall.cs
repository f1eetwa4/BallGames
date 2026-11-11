using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaWindowsFormsApp
{
    public class BombBall : FruitBall
    {
        public BombBall(Form mainForm) : base(mainForm)
        {
            brush = Brushes.Black;
        }
    }
}
