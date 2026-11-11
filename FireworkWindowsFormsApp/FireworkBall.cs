using BallsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace FireworkWindowsFormsApp
{
    public class FireworkBall : MoveBall
    {
        private List<Brush> brushes = new List<Brush>()
        { Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green,
          Brushes.LightBlue, Brushes.Blue, Brushes.Purple
        };
        private float g = 0.2f;
        public FireworkBall(Form mainForm, int centerX, int centerY) : base(mainForm)
        {
            this.CenterX = centerX;
            this.CenterY = centerY;
            v_y = -Math.Abs(v_y);
            Radius = 9;

            int randomColorIndex = random.Next(brushes.Count);
            brush = brushes[randomColorIndex];
        }
        protected override void Go()
        {
            base.Go();
            v_y += g;
        }
    }
}
