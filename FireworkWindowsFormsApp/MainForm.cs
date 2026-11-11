namespace FireworkWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            RocketBall rocketBall = new RocketBall(this);
            rocketBall.Start();
        }

    }
}
