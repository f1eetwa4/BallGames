namespace BallGamesWindowsFormsApp
{
    public class SpecificPlaceBall : Ball
    {
        public SpecificPlaceBall(MainForm mainForm, int x, int y) : base(mainForm)
        {
            this.x = x - 40;
            this.y = y - 40;
        }
    }
}
