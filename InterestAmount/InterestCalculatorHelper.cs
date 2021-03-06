﻿using System;

namespace InterestAmount
{   
    //helper class to store payments quantity, rate per conversion period, payment amount
    internal class InterestCalculatorHelper
    {
        public int Payments { get; private set; }
        public float Rate { get; private set; }
        public float PaymentAmount { get; private set; }

        public InterestCalculatorHelper(float principal, float rate, int years, int paymentsPerYear)
        {
            this.Rate = rate / paymentsPerYear / 100;
            this.Payments = years * paymentsPerYear;
            this.PaymentAmount = CalculatePaymentAmount(principal, Rate, Payments);
        }

        //P = A / (((1 + i) ^ n - 1) / (i * (1 + i) ^ n))
        private float CalculatePaymentAmount(float principal, float rate, int payments)
        {
            return principal / ((FastPow(1 + rate, payments) - 1) / (rate * FastPow(1 + rate, payments)));
        }

        static float FastPow(float num, int exp)
        {
            float result = 1f;
            while (exp > 0)
            {
                if (exp % 2 == 1)
                    result *= num;
                exp >>= 1;
                num *= num;
            }

            return result;
        }
    }
}