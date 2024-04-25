using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public class RatNum
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public int Numerator => _numerator;
        public int Denominator => _denominator;

        public RatNum(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            int gcd = GCD(numerator, denominator);
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;

            if (_denominator < 0)
            {
                _numerator = -_numerator;
                _denominator = -_denominator;
            }
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        public static RatNum operator +(RatNum a, RatNum b)
        {
            int newNumerator = a._numerator * b._denominator + b._numerator * a._denominator;
            int newDenominator = a._denominator * b._denominator;
            return new RatNum(newNumerator, newDenominator);
        }

        public static RatNum operator -(RatNum a, RatNum b)
        {
            int newNumerator = a._numerator * b._denominator - b._numerator * a._denominator;
            int newDenominator = a._denominator * b._denominator;
            return new RatNum(newNumerator, newDenominator);
        }
       
        public static RatNum operator -(RatNum a)
        {
            return new RatNum(-a._numerator, a._denominator);
        }

        public static bool operator ==(RatNum a, RatNum b)
        {
            return a._numerator == b._numerator && a._denominator == b._denominator;
        }

        public static bool operator !=(RatNum a, RatNum b)
        {
            return !(a == b);
        }

        public static bool operator <(RatNum a, RatNum b)
        {
            return a._numerator * b._denominator < b._numerator * a._denominator;
        }

      /*  public static bool operator <=(Rational a, Rational b)//по идее не нужен
        {
            return a._numerator * b._denominator <= b._numerator * a._denominator;
        }
      */
        public static bool operator >(RatNum a, RatNum b)
        {
            return a._numerator * b._denominator > b._numerator * a._denominator;
        }
        /*
        public static bool operator >=(Rational a, Rational b)//по идее не нужен
        {
            return a._numerator * b._denominator >= b._numerator * a._denominator;
        }
        */
        private static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }


}
