using BallsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaWindowsFormsApp
{
    public class FruitBall : FireworkBall
    {
        private List<Brush> brushes = new List<Brush>()
        { Brushes.Red, Brushes.Orange,Brushes.Green,
          Brushes.LightBlue, Brushes.Blue, Brushes.Purple
        };
        private float g;
        private static Random random = new Random();
        public FruitBall(Form mainForm) : base(mainForm, random.Next(mainForm.ClientSize.Width), mainForm.ClientSize.Height)
        {
            int randomColorIndex = random.Next(brushes.Count);
            brush = brushes[randomColorIndex];

            g = 0.3f * random.Next(1, 6);
            v_y = -15;
            Radius = random.Next(10, 50);
        }
        public override bool IsOnForm()
        {
            return (CenterX >= 0 && CenterX <= mainForm.ClientSize.Width && CenterY >= 0 && CenterY <= mainForm.ClientSize.Height);
        }
        protected override void Go()
        {
            CenterX += v_x;
            CenterY += v_y;
            v_y += g;
        }
        public void IncreaseInterval()
        {
            timer.Interval = 50;
        }
        public void ReturnInterval()
        {
            timer.Interval = 20;
        }
    }
}
