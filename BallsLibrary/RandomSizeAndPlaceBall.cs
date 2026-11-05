namespace BallsLibrary
{
    public class RandomSizeAndPlaceBall : RandomPlaceBall
    {
        public RandomSizeAndPlaceBall(Form mainForm) : base(mainForm)
        {
            Size = random.Next(20, 80);
        }
    }
}
