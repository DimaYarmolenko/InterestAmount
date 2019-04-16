using System;
using System.Runtime.Serialization;

namespace InterestAmount
{
    [Serializable]
    internal class InvalidDataRangeException : Exception
    {
        public InvalidDataRangeException()
        {
        }

        public InvalidDataRangeException(DateTime agreementDate, DateTime calculationDate)
            : base(string.Format("Invalid dates range provided. End date must be greater: {0} - {1}", agreementDate, calculationDate))
        {
        }
    }
}