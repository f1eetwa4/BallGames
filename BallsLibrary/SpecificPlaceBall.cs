namespace BallsLibrary
{
    public class SpecificPlaceBall : Ball
    {
        public SpecificPlaceBall(Form mainForm, int x, int y) : base(mainForm)
        {
            this.X = x - (Size / 2);
            this.Y = y - (Size / 2);
        }
    }
}
