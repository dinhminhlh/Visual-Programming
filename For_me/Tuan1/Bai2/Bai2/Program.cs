using System;

namespace FractionCalculator
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction Add(Fraction other)
        {
            int newNumerator = Numerator * other.Denominator + other.Numerator * Denominator;
            int newDenominator = Denominator * other.Denominator;
            return Simplify(new Fraction(newNumerator, newDenominator));
        }

        public Fraction Subtract(Fraction other)
        {
            int newNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
            int newDenominator = Denominator * other.Denominator;
            return Simplify(new Fraction(newNumerator, newDenominator));
        }

        public Fraction Multiply(Fraction other)
        {
            int newNumerator = Numerator * other.Numerator;
            int newDenominator = Denominator * other.Denominator;
            return Simplify(new Fraction(newNumerator, newDenominator));
        }

        public Fraction Divide(Fraction other)
        {
            int newNumerator = Numerator * other.Denominator;
            int newDenominator = Denominator * other.Numerator;
            return Simplify(new Fraction(newNumerator, newDenominator));
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private Fraction Simplify(Fraction fraction)
        {
            int gcd = GCD(fraction.Numerator, fraction.Denominator);
            return new Fraction(fraction.Numerator / gcd, fraction.Denominator / gcd);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = InputFraction();
            Fraction fraction2 = InputFraction();

            Console.WriteLine("Fraction 1: " + fraction1);
            Console.WriteLine("Fraction 2: " + fraction2);

            Console.WriteLine("Sum: " + fraction1.Add(fraction2));
            Console.WriteLine("Difference: " + fraction1.Subtract(fraction2));
            Console.WriteLine("Product: " + fraction1.Multiply(fraction2));
            Console.WriteLine("Quotient: " + fraction1.Divide(fraction2));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static Fraction InputFraction()
        {
            Console.Write("Enter numerator: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denominator = int.Parse(Console.ReadLine());

            return new Fraction(numerator, denominator);
        }
    }
}
