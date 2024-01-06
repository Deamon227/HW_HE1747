namespace HW_HE1747
{
    public class Program
    {
        /// <param name="args">none</param>
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Find the integer numbers from the list");
                Console.WriteLine("2. Basic calculator");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Choose your option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    default:
                        Console.WriteLine("Option invalid. Please choose again.");
                        break;
                    case 0:
                        Console.WriteLine("Exit the program.");
                        return;
                    case 1:
                        {
                            FindInteger();
                            break;
                        }
                    case 2:
                        {
                            basicCal();
                            break;
                        }
                }
            }
        }

        private static void basicCal()
        {
            while (true)
            {
                Console.WriteLine("Available options: ");
                Console.WriteLine("\t1. Addition");
                Console.WriteLine("\t2. Subtraction");
                Console.WriteLine("\t3. Multiplication");
                Console.WriteLine("\t4. Division");
                Console.WriteLine("\t0. Exit");
                Console.WriteLine("Choose an option:");
                int option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    default:
                        Console.WriteLine("Option invalid. Please choose again.");
                        break;
                    case 0:
                        Console.WriteLine("Exit the program.");
                        return;
                    case 1:
                        {
                            Console.Write("Enter the first number: ");
                            double num1 = double.Parse(Console.ReadLine());
                            Console.Write("Enter the second number: ");
                            double num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Result: {num1 + num2}");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter the first number: ");
                            double num3 = double.Parse(Console.ReadLine());
                            Console.Write("Enter the second number: ");
                            double num4 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Result: {num3 - num4}");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter the first number: ");
                            double num5 = double.Parse(Console.ReadLine());
                            Console.Write("Enter the second number: ");
                            double num6 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"Result: {num5 * num6}");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter the first number: ");
                            double num7 = double.Parse(Console.ReadLine());
                            Console.Write("Enter the second number: ");
                            double num8 = double.Parse(Console.ReadLine());
                            if (num8 != 0)
                            {
                                Console.WriteLine($"Result: {(double)num7 / num8}");
                            }
                            else
                            {
                                Console.WriteLine("Can't divide by 0.");
                            }
                            break;
                        }
                }
            }
        }

        private static void FindInteger()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The prime numbers from the list are/is");
            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

