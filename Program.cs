namespace FindMaximumProblemUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenericMaximum<int> maximum = new GenericMaximum<int>(24,44,99);
            int value = maximum.MaximumInteger(24, 44, 99);

            Console.WriteLine("The Maximum Integer is : " +value);

        }
    }
}
