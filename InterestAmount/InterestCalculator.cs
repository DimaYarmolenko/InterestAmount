using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestAmount
{
    public static class InterestCalculator
    {
        public static float InterestSum(DateTime agreementDate, DateTime calculationDate, float principal, float rate, int years)
        {
            if (calculationDate < agreementDate)
            {
                throw new InvalidDataRangeException(agreementDate,calculationDate);
            }

            var helper = new InterestCalculatorHelper(principal, rate, years, 12);
            //payments qty between calc date and agreement date
            var paymentsInRange = (calculationDate - agreementDate).Days / 30;
            var sum = 0f;

            for (int i = 0; i < helper.Payments; i++)
            {
                if (i >= paymentsInRange - 1)
                {
                    return sum;
                }
                var interest = CalculatePaymentInterest(principal, helper.Rate);
                principal -= helper.PaymentAmount - interest;
            }
            return sum;
        }

        private static float CalculatePaymentInterest(float principal, float rate)
        {
            return principal * rate;
        }
    }
}
