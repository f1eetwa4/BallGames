using BallsLibrary;

namespace CatchBallsWindowsFormsApp
{
    public partial class CatchBallForm : Form
    {
        private List<Ball> balls = new List<Ball>();
        private int countCaughtBalls;
        public CatchBallForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            BallsManager.ClearBalls(balls);
            balls = BallsManager.GetBalls(this);
            BallsManager.StartBalls(balls);
        }

        private void CatchBallForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (BallsManager.BallCaught(e.X, e.Y, balls))
            {
                countCaughtBalls++;
                caughtBallsLabel.Text = countCaughtBalls.ToString();
            }
        }

        private void CatchBallForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BallsManager.ClearBalls(balls);
        }
    }
}
