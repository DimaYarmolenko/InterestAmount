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

            var hepler = new InterestCalculatorHelper(principal, rate, years);
            throw new NotImplementedException();
        }
    }
}
