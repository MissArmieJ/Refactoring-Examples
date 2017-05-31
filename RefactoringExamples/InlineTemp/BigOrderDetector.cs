namespace RefactoringExamples.InlineTemp
{
    public class BigOrderDetector
    {
        public bool IsBig(Order order)
        {
            return order.BasePrice > 1000;
        }
    }
}