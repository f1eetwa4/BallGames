namespace BallGamesLauncher
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();
        }

        private void LauncherForm_Load(object sender, EventArgs e)
        {

        }

        private void fruitNinjaButton_Click(object sender, EventArgs e)
        {
            new FruitNinjaWindowsFormsApp.MainForm().ShowDialog();
        }

        private void ballsButton_Click(object sender, EventArgs e)
        {
            new BallGamesWindowsFormsApp.MainForm().ShowDialog();
        }

        private void billiardButton_Click(object sender, EventArgs e)
        {
            new BilliardBallsWindowsFormsApp.BilliardBallsForm().ShowDialog();
        }

        private void catchBallsButton_Click(object sender, EventArgs e)
        {
            new CatchBallsWindowsFormsApp.CatchBallForm().ShowDialog();
        }

        private void fireworkButton_Click(object sender, EventArgs e)
        {
            new FireworkWindowsFormsApp.MainForm().ShowDialog();
        }
    }
}
