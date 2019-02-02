using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калмыков
//1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;

namespace Mission1
{
    class Program
    {
        static void Main(string[] args)
        {

            Complex Complex1 = new Complex();
            Complex Complex2 = new Complex();
            Complex result = new Complex();

            Console.Write($"Введите дествительную часть комплексного числа номер 1:");
            Complex1.re = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите мнимую часть комплексного числа номер 1:");
            Complex1.im = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Введите дествительную часть комплексного числа номер 2:");
            Complex2.re = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите мнимую часть комплексного числа номер 2:");
            Complex2.im = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Выберите операцию(+,-,*)");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                result = Complex1.Plus(Complex2);
            }
            else if (operation == "-")
            {
                result = Complex1.Minus(Complex2);                
            }
            else if (operation == "*")
            {
                result = Complex1.Multiplication(Complex2);
            }

            Console.WriteLine(result.toString());
            Console.ReadKey();

        }
    }
}
