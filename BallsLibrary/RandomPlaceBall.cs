namespace BallsLibrary
{
    public class RandomPlaceBall : Ball
    {
        protected static Random random = new Random();
        public RandomPlaceBall(Form mainForm) : base(mainForm)
        {
            CenterX = random.Next(LeftSide(), RightSide() + 1);
            CenterY = random.Next(TopSide(), DownSide() + 1);
        }
    }
}
