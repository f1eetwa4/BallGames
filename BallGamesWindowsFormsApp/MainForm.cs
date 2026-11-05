namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveBall> moveBalls = new List<MoveBall>();
        private SpecificPlaceBall specificPlaceBall;
        private static Random random = new Random();
        private int countBallsOnForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            specificPlaceBall = new SpecificPlaceBall(this, e.X, e.Y);
            specificPlaceBall.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var moveBall in moveBalls)
            {
                moveBall.Stop();
                moveBall.Clear();
            }

            moveBalls = new List<MoveBall>();
            int countMoveBalls = random.Next(6, 16);
            for (int i = 0; i < countMoveBalls; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }
    }
}
