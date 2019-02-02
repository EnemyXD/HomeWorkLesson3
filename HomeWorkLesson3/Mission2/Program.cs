using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Калмыков
//а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
//Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
//б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
//При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();            
            //int num = Int32.TryParse(s, out a);
            int sum = 0;
            bool aa = Int32.TryParse(s, out int num);

            if (aa == false)
            {
                MessageBox.Show("Некорректно введены данные.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto end;
            }
            
            num = Convert.ToInt32(s);

            while (num != 0 || aa != false) 
            {
                s = Console.ReadLine();
                aa = Int32.TryParse(s,out num);                
                               
                    if (num > 0 && num % 2 == 1)
                    {
                        sum += num;
                    }
                              
            }

            if (aa == false)
            {
                MessageBox.Show("Некорректно введены данные.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        end: Console.ReadKey();
        }
    }
}
