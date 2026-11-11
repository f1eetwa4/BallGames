using BallsLibrary;
using Timer = System.Windows.Forms.Timer;

namespace FruitNinjaWindowsFormsApp
{
    public partial class MainForm : Form
    {
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
            BallsManager.BallCaught(e.X, e.Y, fruitBalls);
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
                    FruitBall fruitBall = new FruitBall(this);
                    fruitBalls.Add(fruitBall);
                    fruitBall.Start();
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

    }
}
