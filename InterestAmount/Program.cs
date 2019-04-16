using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
