using System;
using System.Collections.Generic;
using System.Text;
using Timer = System.Windows.Forms.Timer;

namespace BallGamesWindowsFormsApp
{
    public class MoveBall : RandomPlaceBall
    {
        private Timer timer;
        private static List<int> possibleSpeedsMoveBalls = new List<int>
        { -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6};
        public MoveBall(MainForm mainForm) : base(mainForm)
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;

            int indexV_x = random.Next(possibleSpeedsMoveBalls.Count);
            v_x = possibleSpeedsMoveBalls[indexV_x];

            int indexV_y = random.Next(possibleSpeedsMoveBalls.Count);
            v_y = possibleSpeedsMoveBalls[indexV_y];
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }

        public bool IsOnForm()
        {
            if (x >= 0 && y >= 0)
            {
                if (x + size <= mainForm.ClientSize.Width && y + size <= mainForm.ClientSize.Height)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
