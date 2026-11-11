using BallsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace FireworkWindowsFormsApp
{
    public class RocketBall : Ball
    {
        private Random random = new Random();
        public RocketBall(Form mainForm) : base(mainForm)
        {
            CenterY = mainForm.ClientSize.Height;
            CenterX = mainForm.ClientSize.Width / 2;
            Radius = 10;
            v_y = -4;
            v_x = 0;
        }
        protected override void Go()
        {
            base.Go();

            if (CenterY <= 150)
            {
                Clear();
                Stop();
                brush = Brushes.White;

                var random = new Random();
                var count = random.Next(10, 21 + 1);
                for (int i = 0; i < count; i++)
                {
                    FireworkBall firework = new FireworkBall(mainForm, CenterX, CenterY);
                    firework.Start();
                }
            }
        }
    }
}
