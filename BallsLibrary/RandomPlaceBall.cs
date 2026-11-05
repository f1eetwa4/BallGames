namespace BallsLibrary
{
    public class RandomPlaceBall : Ball
    {
        protected static Random random = new Random();
        public RandomPlaceBall(Form mainForm) : base(mainForm)
        {
            X = random.Next(0, mainForm.ClientSize.Width - Size);
            Y = random.Next(0, mainForm.ClientSize.Height - Size);
        }
    }
}
