using BallsLibrary;
using Timer = System.Windows.Forms.Timer;

namespace BilliardBallsWindowsFormsApp
{
    public partial class BilliardBallsForm : Form
    {
        List<BilliardBall> billiardBalls = new List<BilliardBall>();
        List<GasBall> firstGasBalls = new List<GasBall>();
        List<GasBall> secondGasBalls = new List<GasBall>();
        private bool areBallsMoving = false;
        List<Label> GasPressureLabels;
        private Timer timer = new Timer();
        private bool isDiffusionStarted = false;
        public BilliardBallsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void FirstGasBall_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    firstGasLeftLabel.Text = (Convert.ToInt32(firstGasLeftLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    firstGasRightLabel.Text = (Convert.ToInt32(firstGasRightLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    firstGasTopLabel.Text = (Convert.ToInt32(firstGasTopLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    firstGasDownLabel.Text = (Convert.ToInt32(firstGasDownLabel.Text) + 1).ToString();
                    break;
            }
        }
        private void SecondGasBall_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    secondGasLeftLabel.Text = (Convert.ToInt32(secondGasLeftLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    secondGasRightLabel.Text = (Convert.ToInt32(secondGasRightLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    secondGasTopLabel.Text = (Convert.ToInt32(secondGasTopLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    secondGasDownLabel.Text = (Convert.ToInt32(secondGasDownLabel.Text) + 1).ToString();
                    break;
            }
        }
        private void CreateBallsOnHalf(Side side)
        {
            for (int i = 0; i < 10; i++)
            {
                GasBall gasBall = new GasBall(side, this);
                if (side == Side.Left)
                {
                    gasBall.OnHited += FirstGasBall_OnHited;
                    firstGasBalls.Add(gasBall);
                }
                else
                {
                    secondGasBalls.Add(gasBall);
                    gasBall.OnHited += SecondGasBall_OnHited;
                }
            }
        }

        private void BilliardBallsForm_Shown(object sender, EventArgs e)
        {
            CreateBallsOnHalf(Side.Left);
            CreateBallsOnHalf(Side.Right);

            Invalidate();
        }

        private void BilliardBallsForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (var firstGasBall in firstGasBalls)
            {
                firstGasBall.Show();
            }
            foreach (var secondGasBall in secondGasBalls)
            {
                secondGasBall.Show();
            }
        }
        private void StartBalls()
        {
            foreach (var firstGasBall in firstGasBalls)
            {
                firstGasBall.Start();
            }
            foreach (var secondGasBall in secondGasBalls)
            {
                secondGasBall.Start();
            }
        }
        private void StopBalls()
        {
            foreach (var firstGasBall in firstGasBalls)
            {
                firstGasBall.Stop();
            }
            foreach (var secondGasBall in secondGasBalls)
            {
                secondGasBall.Stop();
            }
        }

        private void BilliardBallsForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isDiffusionStarted)
            {
                isDiffusionStarted = true;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            if (!areBallsMoving)
            {
                StartBalls();
            }
            else
            {
                StopBalls();
                ShowGasPressure();
            }
            areBallsMoving = !areBallsMoving;
        }
        private void ShowGasPressure()
        {
            GasPressureLabels = new List<Label>()
           {
               firstGasDownLabel, firstGasLeftLabel, firstGasRightLabel, firstGasTopLabel,
               secondGasDownLabel, secondGasLeftLabel, secondGasRightLabel, secondGasTopLabel
           };
            MessageBox.Show($"Верхняя стенка: синий газ — {firstGasTopLabel.Text}, красный — {secondGasTopLabel.Text}\n" +
                $"Левая стенка: синий газ — {firstGasLeftLabel.Text}, красный — {secondGasLeftLabel.Text}\n" +
                $"Нижняя стенка: синий газ — {firstGasDownLabel.Text}, красный — {secondGasDownLabel.Text}\n" +
                $"Правая стенка: синий газ — {firstGasRightLabel.Text}, красный — {secondGasRightLabel.Text}");
        }
        private bool IsDiffusionComplete()
        {
            int firstGasLeftCount = 0;
            int secondGasLeftCount = 0;
            int firstGasRightCount = 0;
            int secondGasRightCount = 0;

            foreach (var firstGasBall in firstGasBalls)
            {
                if (firstGasBall.CenterX <= this.ClientSize.Width / 2 - firstGasBall.Radius)
                {
                    firstGasLeftCount++;
                }
                if (firstGasBall.CenterX >= this.ClientSize.Width / 2 + firstGasBall.Radius)
                {
                    firstGasRightCount++;
                }
            }

            foreach (var secondGasBall in secondGasBalls)
            {
                if (secondGasBall.CenterX <= this.ClientSize.Width / 2 - secondGasBall.Radius)
                {
                    secondGasLeftCount++;
                }
                if (secondGasBall.CenterX >= this.ClientSize.Width / 2 + secondGasBall.Radius)
                {
                    secondGasRightCount++;
                }
            }

            if (firstGasLeftCount == firstGasBalls.Count / 2 && secondGasLeftCount == firstGasBalls.Count / 2
                && firstGasRightCount == firstGasBalls.Count / 2 && secondGasRightCount == firstGasBalls.Count / 2)
            {
                return true;
            }
            return false;
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (IsDiffusionComplete())
            {
                timer.Stop();
                StopBalls();
                MessageBox.Show("Произошло полное перемешивание газов");
                Application.Restart();
            }
        }

        private void BilliardBallsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopBalls();
            timer.Stop();
        }
    }
}
