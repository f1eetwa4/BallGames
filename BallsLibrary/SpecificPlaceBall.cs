namespace BallsLibrary
{
    public class SpecificPlaceBall : Ball
    {
        public SpecificPlaceBall(Form mainForm, int x, int y) : base(mainForm)
        {
            this.CenterX = x;
            this.CenterY = y;
        }
    }
}
