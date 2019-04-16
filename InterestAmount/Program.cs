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
            var start = new DateTime(2000, 1, 12);
            var end = new DateTime(2002, 4, 12);

            var diff = end - start;
            Console.WriteLine(diff.Days);
        }
    }
}
