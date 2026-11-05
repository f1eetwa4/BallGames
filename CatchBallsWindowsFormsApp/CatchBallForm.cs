using BallsLibrary;

namespace CatchBallsWindowsFormsApp
{
    public partial class CatchBallForm : Form
    {
        private List<MoveBall> moveBalls = new List<MoveBall>();
        private int countCaughtBalls;
        public CatchBallForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            BallsManager.ClearBalls(moveBalls);
            moveBalls = BallsManager.GetBalls(this);
            BallsManager.StartBalls(moveBalls);
        }

        private void CatchBallForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (BallsManager.BallCaught(e.X, e.Y, moveBalls))
            {
                countCaughtBalls++;
                caughtBallsLabel.Text = countCaughtBalls.ToString();
            }
        }
    }
}
