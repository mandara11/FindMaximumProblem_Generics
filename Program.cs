namespace FindMaximumProblemUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC1
            //MaxIntNumber maximum = new MaxIntNumber();
            //int value = maximum.MaximumInteger(24, 44, 51);

            //Console.WriteLine("The Maximum Integer is: " + value);

            //UC2
            MaxFloatNumber maximum = new MaxFloatNumber();
            double value = maximum.MaximumFloatNumber(2.4, 4.4, 5.1);

            Console.WriteLine("The Maximum Integer is: " + value);
        }
    }
}
