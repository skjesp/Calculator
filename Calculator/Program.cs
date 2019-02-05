namespace Calculator
{
    public class Calculator
    {
        static void Main()
        {
            return;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return System.Math.Pow(x, exp);
        }
    }
}