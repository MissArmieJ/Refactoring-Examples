namespace RefactoringExamples.InlineMethod
{
    public class Courier
    {
        private readonly int _numberOfLateDeliveries;

        public Courier(int numberOfLateDeliveries)
        {
            _numberOfLateDeliveries = numberOfLateDeliveries;
        }

        public int GetRating()
        {
            return _numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}