namespace FireworkWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var random = new Random();
            var count = random.Next(10, 21 + 1);
            for (int i = 0; i < count; i++)
            {
                FireworkBall firework = new FireworkBall(this, e.X, e.Y);
                firework.Start();
            }
        }
    }
}
