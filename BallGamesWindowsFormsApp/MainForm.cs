namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ball ball = new Ball(this);
            ball.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var randomBall = new RandomSizeAndPlaceBall(this);
            randomBall.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var specificPlaceBall = new SpecificPlaceBall(this, e.X, e.Y);
            specificPlaceBall.Show();
        }
    }
}
