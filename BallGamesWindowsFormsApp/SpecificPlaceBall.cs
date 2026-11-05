namespace BallGamesWindowsFormsApp
{
    public class SpecificPlaceBall : Ball
    {
        public SpecificPlaceBall(MainForm mainForm, int x, int y) : base(mainForm)
        {
            this.x = x - (size / 2);
            this.y = y - (size / 2);
        }
    }
}
