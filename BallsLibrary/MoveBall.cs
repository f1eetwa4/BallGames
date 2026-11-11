using System;
using System.Collections.Generic;
using System.Text;
using Timer = System.Windows.Forms.Timer;

namespace BallsLibrary
{
    public class MoveBall : RandomPlaceBall
    {
        private static List<int> possibleSpeedsMoveBalls = new List<int>
        {-6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6};
        public MoveBall(Form mainForm) : base(mainForm)
        {
            int indexV_x = random.Next(possibleSpeedsMoveBalls.Count);
            v_x = possibleSpeedsMoveBalls[indexV_x];

            int indexV_y = random.Next(possibleSpeedsMoveBalls.Count);
            v_y = possibleSpeedsMoveBalls[indexV_y];
        }
    }
}
