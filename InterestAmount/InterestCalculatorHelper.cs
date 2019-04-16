namespace InterestAmount
{
    internal class InterestCalculatorHelper
    {
        private float principal;
        private float rate;
        private int years;

        public InterestCalculatorHelper(float principal, float rate, int years)
        {
            this.principal = principal;
            this.rate = rate;
            this.years = years;
        }
    }
}