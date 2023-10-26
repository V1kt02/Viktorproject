namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Converter");
            Console.WriteLine("1: Binary to Decimal");
            Console.WriteLine("2: Decimal to Binary");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter binary number");
                    int n = int.Parse(Console.ReadLine());
                    int curr = 0;
                    int answer = 0;
                    int i = 0;
                    while (n != 0)
                    {
                        curr = n % 10;
                        answer += curr * (int)Math.Pow(2, i);
                        n /= 10;
                        i++;
                    }
                    Console.WriteLine($"Decimal: {answer}");
                    break;


                case 2:
                    {
                        Console.WriteLine("Enter decimal number");
                        int n2 = int.Parse(Console.ReadLine());
                        int curr2 = 0;
                        int answer2 = 0;
                        int i2 = 0;
                        while (n2 != 0)
                        {
                            curr2 = n2 % 2;
                            answer2 += curr2 * (int)Math.Pow(10, i2);
                            n2 /= 2;
                            i2++;
                        }
                        Console.WriteLine($"Binary: {answer2}");
                        break;
                    }
            }
        }
    }
}