using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Greetings. I recieved your test task, so i gave it a shot. Here it is.
//InterestCalculator.InterestSum(DateTime agreementDate, DateTime calculationDate, float principal, float rate, int years) is to calculate the sum of
//the interest part of payments in that would be made between the given timerange, defined by agreementDate and calculationDate
//I hope i understood your task correctly)
//Best regards

namespace InterestAmount
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new DateTime(2000, 1, 1);
            var end = new DateTime(2006, 1, 1);
            Console.WriteLine(InterestCalculator.InterestSum(start,end,30000f,8.4f,6));
        }
    }
}
