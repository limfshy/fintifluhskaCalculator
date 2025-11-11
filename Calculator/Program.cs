using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Калькулятор ===");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Возведение в степень");
                Console.WriteLine("6. Квадратный корень");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите операцию: ");
                string op = Console.ReadLine();

                if (op == "0")
                    break;

                double a, b, result = 0;

                if (op == "6")
                {
                    Console.Write("Введите число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    result = Math.Sqrt(a);
                    Console.WriteLine($"√{a} = {result}");
                }
                else
                {
                    Console.Write("Введите первое число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    switch (op)
                    {
                        case "1": result = a + b; break;
                        case "2": result = a - b; break;
                        case "3": result = a * b; break;
                        case "4":
                            if (b == 0)
                            {
                                Console.WriteLine("Ошибка: деление на ноль!");
                                continue;
                            }
                            result = a / b;
                            break;
                        case "5": result = Math.Pow(a, b); break;
                        default:
                            Console.WriteLine("Неверная операция!");
                            continue;
                    }

                    Console.WriteLine($"Результат: {result}");
                }
            }

            Console.WriteLine("Программа завершена.");
        }
    }
}
