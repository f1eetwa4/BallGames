using System;
using System.Collections.Generic;
using System.Text;

namespace BallsLibrary
{
    public static class BallsManager
    {
        private static Random random = new Random();
        public static void ClearBalls(List<Ball> balls)
        {
            foreach (var ball in balls)
            {
                ball.Stop();
                ball.Clear();
            }
        }
        public static List<Ball> GetBalls(Form form)
        {
            List<Ball> balls = new List<Ball>();

            int countMoveBalls = random.Next(6, 16);
            for (int i = 0; i < countMoveBalls; i++)
            {
                var moveBall = new MoveBall(form);
                balls.Add(moveBall);

                var ball = new RandomSizeAndPlaceBall(form);
                balls.Add(ball);
            }
            return balls;
        }
        public static void StartBalls(List<Ball> balls)
        {
            foreach (var ball in balls)
            {
                ball.Start();
            }
        }
        public static bool BallCaught(int x, int y, List<Ball> balls)
        {
            foreach (var ball in balls)
            {
                int x0 = ball.CenterX;
                int y0 = ball.CenterY;
                int radius = ball.Radius;

                bool inBall = Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2) <= Math.Pow(radius, 2);
                if (ball.IsOnForm() && inBall)
                {
                    ball.Stop();
                    ball.Clear();
                    balls.Remove(ball);
                    return true;
                }
            }
            return false;
        }
    }
}
