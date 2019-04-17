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
            //validation of the time range
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
                //interest amount of the current payment
                var interest = CalculatePaymentInterest(principal, helper.Rate);
                sum += interest;

                //uncomment to print out a debug
                //ConsoleOutput(principal, helper, i, interest);
                principal -= PrincipalPaymentPart(helper, interest);
            }
            return sum;
        }

        private static float PrincipalPaymentPart(InterestCalculatorHelper helper, float interest)
        {
            return helper.PaymentAmount - interest;
        }

        private static void ConsoleOutput(float principal, InterestCalculatorHelper helper, int i, float interest)
        {
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}", i, principal, helper.PaymentAmount, interest, helper.PaymentAmount - interest, principal - (helper.PaymentAmount - interest));
        }

        private static float CalculatePaymentInterest(float principal, float rate)
        {
            return principal * rate;
        }
    }
}
