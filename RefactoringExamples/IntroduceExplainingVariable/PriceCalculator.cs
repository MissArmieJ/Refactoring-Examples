using System;

namespace RefactoringExamples.IntroduceExplainingVariable
{
    public class PriceCalculator
    {
        private readonly int _quantity;
        private readonly double _itemPrice;

        public PriceCalculator(int quantity, double itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public double Price()
        {
            double basePrice = _quantity*_itemPrice;
            double quantityDiscount = Math.Max(0, _quantity - 500)*_itemPrice*.05;
            double shipping = Math.Min(basePrice*.1, 100.0);

            return basePrice -
                   quantityDiscount +
                   shipping;
        }
    }
}