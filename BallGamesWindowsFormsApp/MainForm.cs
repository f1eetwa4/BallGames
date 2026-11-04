namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveBall> moveBalls = new List<MoveBall>();
        private SpecificPlaceBall specificPlaceBall;
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
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }
    }
}
