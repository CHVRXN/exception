using System;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            double first_num, second_num, result;
            try
            {
                Console.Write("Введите первое число: ");

                first_num = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число: ");
                second_num = Convert.ToDouble(Console.ReadLine());


                if (second_num == 0) throw new DivideByZeroException();
                result = first_num / second_num;
                Console.WriteLine("Результат: " + (result));

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на 0 нельзя");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }

                Console.WriteLine("Размер типа данных int равен: " + sizeof(int) + " байт");
                Console.WriteLine("Размер типа данных float равен: " + sizeof(float) + " байт");
                Console.ReadLine();
        }     
    }
}
