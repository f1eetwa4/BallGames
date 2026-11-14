using BallsLibrary;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Ball> balls = new List<Ball>();
        private int countBallsOnForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Stop();
                if (ball.IsOnForm())
                {
                    countBallsOnForm++;
                }
            }
            MessageBox.Show($"Шариков поймано: {countBallsOnForm}");
            countBallsOnForm = 0;
            return;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            BallsManager.ClearBalls(balls);
            balls = BallsManager.GetBalls(this);
            BallsManager.StartBalls(balls);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BallsManager.ClearBalls(balls);
        }
    }
}
