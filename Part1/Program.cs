using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calc by dizz");

            try
            {
                Console.Write("Введите X:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите Y:");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите код операции:");

                Console.WriteLine("1:+");
                Console.WriteLine("2:-");
                Console.WriteLine("3:*");
                Console.WriteLine("4:/");

                int cmd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваш выбор {0}",cmd);
                int res;
                switch (cmd) {
                    case 1:
                        res = x + y;
                        break;
                    case 2:
                        res = x - y;
                        break;
                    case 3:
                        res = x * y;
                        break;
                    case 4:
                        res = x / y;
                        break;
                    default:
                        throw new Exception("Нет операции с указанным номером"); 

                }
                Console.WriteLine("Результат: {0}",res);

            }

            catch (DivideByZeroException) {
                Console.WriteLine("Делить на ноль нельзя!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка!" + e.Message);
            }
            Console.ReadKey();
        }
    }
}
