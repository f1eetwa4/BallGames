using System;
using System.Collections.Generic;
using System.Text;

namespace BilliardBallsWindowsFormsApp
{
    public class GasBall : BilliardBall
    {
        private static Brush firstGasColor = Brushes.Blue;
        private static Brush secondGasColor = Brushes.Red;
        public GasBall(Side side,Form form) : base (form)
        {
            if (side == Side.Left)
            {
                CenterX = random.Next(LeftSide(), form.ClientSize.Width / 2 - Radius + 1);
                brush = firstGasColor;
            }
            else
            {
                CenterX = random.Next(form.ClientSize.Width / 2 + Radius, RightSide() + 1);
                brush = secondGasColor;
            }
        }
    }
}
