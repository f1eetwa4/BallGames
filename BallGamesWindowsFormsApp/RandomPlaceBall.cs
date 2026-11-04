namespace BallGamesWindowsFormsApp
{
    public class RandomPlaceBall : Ball
    {
        protected static Random random = new Random();
        public RandomPlaceBall(MainForm mainForm) : base(mainForm)
        {
            x = random.Next(0, mainForm.ClientSize.Width - 80);
            y = random.Next(0, mainForm.ClientSize.Height - 80);
        }
    }
}
