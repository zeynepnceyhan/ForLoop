namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("count 1 to 100:");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!************************************************************");
            Console.WriteLine("count 1 to 100(only odd numbers):");

            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!*************************************************************");
            Console.WriteLine("count 0 to 100(only even numbers):");
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("count 100 to 1:");
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Program has already finished!!!!");
            Console.ReadLine();

        }


    }
}