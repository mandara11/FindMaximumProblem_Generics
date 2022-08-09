namespace FindMaximumProblemUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC1
            MaxIntNumber maximum1 = new MaxIntNumber();
            int value1 = maximum1.MaximumInteger(24, 44, 51);

            Console.WriteLine("The Maximum Integer is: " + value1);

            //UC2
            MaxFloatNumber maximum2 = new MaxFloatNumber();
            double value2 = maximum2.MaximumFloatNumber(2.4, 4.4, 5.1);

            Console.WriteLine("The Maximum Integer is: " + value2);

            //UC3
            MaxStringNumber maximum3 = new MaxStringNumber();
            string str = maximum3.MaximumStringNumber("Apple", "Peach", "Banana");

            Console.WriteLine("The MaximumString is: " + str);

            //Refactor
            GenericMaximum<int> maximum = new GenericMaximum<int>(24, 44, 99);
            int value3 = maximum.MaximumInteger(24, 44, 99);

            Console.WriteLine("The Maximum Integer is : " +value3);

            //UC4and5
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMax<int> gen = new GenericMax<int>(intArray);
            gen.PrintMaxValue();

            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMax<double> genDouble = new GenericMax<double>(doubleArray);
            genDouble.PrintMaxValue();

            string[] stringArray = { "111", "222", "333", "55", "999" };
            GenericMax<string> genString = new GenericMax<string>(stringArray);
            genString.PrintMaxValue();

        }
    }
}
