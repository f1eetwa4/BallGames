using BallsLibrary;
using Timer = System.Windows.Forms.Timer;

namespace FruitNinjaWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private static Random random = new Random();
        List<Ball> fruitBalls = new List<Ball>();
        private Timer timer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            UpdateFruitBalls();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            Ball cutBall = GetCutBall(e.X, e.Y, fruitBalls);
            if (cutBall != null && cutBall is BombBall)
            {
                EndGame();
                MessageBox.Show("Вы разрезали бомбу! Игра окончена");
                timer.Start();
            }
        }
        public static Ball GetCutBall(int x, int y, List<Ball> balls)
        {
            foreach (var ball in balls)
            {
                float x0 = ball.CenterX;
                float y0 = ball.CenterY;
                int radius = ball.Radius;

                bool inBall = Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2) <= Math.Pow(radius, 2);
                if (ball.IsOnForm() && inBall)
                {
                    ball.Stop();
                    ball.Clear();
                    balls.Remove(ball);
                    return ball;
                }
            }
            return null;
        }
        private bool AreAllFruitBallsOut()
        {
            foreach (var fruitBall in fruitBalls)
            {
                if (fruitBall.IsOnForm())
                {
                    return false;
                }
            }
            return true;
        }
        private void UpdateFruitBalls()
        {
            if (fruitBalls.Count == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    int chance = random.Next(1, 100 + 1);
                    if (chance <= 5)
                    {
                        BombBall bombBall = new BombBall(this);
                        fruitBalls.Add(bombBall);
                        bombBall.Start();
                    }
                    else
                    {
                        FruitBall fruitBall = new FruitBall(this);
                        fruitBalls.Add(fruitBall);
                        fruitBall.Start();
                    }
                }
            }
            if (AreAllFruitBallsOut())
            {
                foreach (var fruitBall in fruitBalls)
                {
                    fruitBall.Clear();
                    fruitBall.Stop();
                }
                fruitBalls.Clear();
            }
        }
        private void EndGame()
        {
            foreach (var fruitBall in fruitBalls)
            {
                fruitBall.Stop();
                fruitBall.Clear();
            }
            fruitBalls.Clear();
            timer.Stop();
        }
    }
}
