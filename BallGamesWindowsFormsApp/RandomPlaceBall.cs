namespace BallGamesWindowsFormsApp
{
    public class RandomPlaceBall : Ball
    {
        protected static Random random = new Random();
        public RandomPlaceBall(MainForm mainForm) : base(mainForm)
        {
            x = random.Next(0, mainForm.ClientSize.Width - size);
            y = random.Next(0, mainForm.ClientSize.Height - size);
        }
    }
}
