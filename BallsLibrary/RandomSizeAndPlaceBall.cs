namespace BallsLibrary
{
    public class RandomSizeAndPlaceBall : RandomPlaceBall
    {
        public RandomSizeAndPlaceBall(Form mainForm) : base(mainForm)
        {
            Radius = random.Next(20, 40 + 1);
        }
    }
}
