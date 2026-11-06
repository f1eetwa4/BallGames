using BallsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilliardBallsWindowsFormsApp
{
    public class BilliardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public BilliardBall(Form mainForm) : base(mainForm)
        {}
        protected override void Go()
        {
            base.Go();

            if (CenterX <= LeftSide())
            {
                v_x = -v_x;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }

            if (CenterX >= RightSide())
            {
                v_x = -v_x;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (CenterY <= TopSide())
            {
                v_y = -v_y;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }

            if (CenterY >= DownSide())
            {
                v_y = -v_y;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
    }
}
