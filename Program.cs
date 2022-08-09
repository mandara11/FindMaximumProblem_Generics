namespace FindMaximumProblemUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaxIntNumber maximum = new MaxIntNumber();
            int value = maximum.MaximumInteger(24, 44, 51);

            Console.WriteLine("The Maximum Integer is: " + value);
        }
    }
}
