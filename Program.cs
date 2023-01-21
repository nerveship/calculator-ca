using System.Security.Cryptography.X509Certificates;

namespace calculator
{
    class Calculator
    {
        static int readInt(string prompt, int max, int min)
        {
            int result = 0;
            do
            {
                Console.WriteLine(prompt);
                result = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            while (result > max || result < min);
            return result;
        }

        static void Main()
        {
            int choice = readInt("Type which function you would like to use\n" +
                "1. Addition\n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division\n", 4, 1);

            Console.WriteLine("Enter first input:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second input:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            switch (choice)
            {
                case 1:
                    {
                        result = Addition(number1, number2); break;
                    }
                case 2:
                    {
                        result = Subtraction(number1, number2); break;
                    }
                case 3:
                    {
                        result = Multiplication(number1, number2); break;
                    }
                case 4:
                    {
                        result = Divide(number1, number2); break;
                    }
            }
            Console.WriteLine($"The result is {result}");

        }

        public static int Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        public static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}