using System;
using System.Collections.Generic;
using System.Text;

namespace BallsLibrary
{
    public static class BallsManager
    {
        private static Random random = new Random();
        public static void ClearBalls(List<MoveBall> moveBalls)
        {
            foreach (var moveBall in moveBalls)
            {
                moveBall.Stop();
                moveBall.Clear();
            }
        }
        public static List<MoveBall> GetBalls(Form form)
        {
            List<MoveBall> moveBalls = new List<MoveBall>();

            int countMoveBalls = random.Next(6, 16);
            for (int i = 0; i < countMoveBalls; i++)
            {
                var moveBall = new MoveBall(form);
                moveBalls.Add(moveBall);
            }
            return moveBalls;
        }
        public static void StartBalls(List<MoveBall> moveBalls)
        {
            foreach (var moveBall in moveBalls)
            {
               moveBall.Start();
            }
        }
        public static bool BallCaught(int x, int y, List<MoveBall> moveBalls)
        {
            foreach (var moveBall in moveBalls)
            {
                int x0 = moveBall.X + (moveBall.Size / 2);
                int y0 = moveBall.Y + (moveBall.Size / 2);
                int radius = moveBall.Size / 2;

                bool inBall = Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2) <= Math.Pow(radius, 2);
                if (moveBall.IsOnForm() && inBall)
                {
                    moveBall.Stop();
                    moveBall.Clear();
                    moveBalls.Remove(moveBall);
                    return true;
                }
            }
            return false;
        }
    }
}
