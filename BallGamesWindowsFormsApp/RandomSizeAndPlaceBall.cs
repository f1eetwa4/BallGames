namespace BallGamesWindowsFormsApp
{
    public class RandomSizeAndPlaceBall : RandomPlaceBall
    {
        public RandomSizeAndPlaceBall(MainForm mainForm) : base(mainForm)
        {
            size = random.Next(20, 80);
        }
    }
}
