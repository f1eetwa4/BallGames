using BallsLibrary;

namespace BilliardBallsWindowsFormsApp
{
    public partial class BilliardBallsForm : Form
    {
        List<BilliardBall> billiardBalls = new List<BilliardBall>();
        public BilliardBallsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void Ball_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabel.Text = (Convert.ToInt32(leftLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel.Text = (Convert.ToInt32(rightLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel.Text = (Convert.ToInt32(topLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabel.Text = (Convert.ToInt32(downLabel.Text) + 1).ToString();
                    break;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var ball = new BilliardBall(this);
                ball.OnHited += Ball_OnHited;
                ball.Start();
                billiardBalls.Add(ball);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in billiardBalls)
            {
                ball.Stop();
                ball.Clear();
            }
            billiardBalls.Clear();
        }

    }
}
