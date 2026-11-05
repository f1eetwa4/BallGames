using BallsLibrary;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveBall> moveBalls = new List<MoveBall>();
        private int countBallsOnForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var moveBall in moveBalls)
            {
                moveBall.Stop();
                if (moveBall.IsOnForm())
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
            BallsManager.ClearBalls(moveBalls);
            moveBalls =  BallsManager.GetBalls(this);
            BallsManager.StartBalls(moveBalls);
        }
    }
}
