using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это калькулятор с простыми вычислениями.");
            Console.WriteLine("Калькулятор поддерживает такие операции:|+|-|/|*|");

            Console.WriteLine("Введите первое число:");
            float number_1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            float number_2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите операцию:");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    {
                        Console.WriteLine($"Результат: {number_1 + number_2}");
                        break;
                    }

                case "-":
                    {
                        Console.WriteLine($"Результат: {number_1 - number_2}");
                        break;
                    }

                case "*":
                    {
                        Console.WriteLine($"Результат: {number_1 * number_2}");
                        break;
                    }

                case "/":
                    {
                        if (number_1 == 0)
                            Console.WriteLine($"Результат:{0}");
                        else
                            if (number_2 == 0)
                            Console.WriteLine("Деление невозможно.");
                            else
                                Console.WriteLine($"Результат: {number_1 / number_2}");
                        break;
                    }
            }
        }
    }
}
