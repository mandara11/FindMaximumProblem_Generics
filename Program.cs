namespace FindMaximumProblemUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC1
            //MaxIntNumber maximum1 = new MaxIntNumber();
            //int value = maximum1.MaximumInteger(24, 44, 51);

            //Console.WriteLine("The Maximum Integer is: " + value);

            //UC2
            //MaxFloatNumber maximum2 = new MaxFloatNumber();
            //double value = maximum2.MaximumFloatNumber(2.4, 4.4, 5.1);

            //Console.WriteLine("The Maximum Integer is: " + value);

            //UC3
            MaxStringNumber maximum3 = new MaxStringNumber();
            string str = maximum3.MaximumStringNumber("Apple","Peach","Banana");

            Console.WriteLine("The MaximumString is: " + str);
        }
    }
}
