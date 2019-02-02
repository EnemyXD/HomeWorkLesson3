using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission1
{
    class Complex
    {

        public double re;
        public double im;
        
        /// <summary>
        /// метод сложение комплексных чисел
        /// </summary>
        /// <param name="x2"></param>
        /// <returns></returns>
        public Complex Plus (Complex x2)
        {

            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;           
            return x3;

        }


        /// <summary>
        /// метод вычитания комплексных чисел
        /// </summary>
        /// <param name="x4"></param>
        /// <returns></returns>
        public Complex Minus(Complex x4)
        {

            Complex x5 = new Complex();
            x5.im = x4.im - this.im;
            x5.re = x4.re - this.re;
            return x5;

        }


        /// <summary>
        /// метод умножения комплексных чисел
        /// </summary>
        /// <param name="x6"></param>
        /// <returns></returns>
        public Complex Multiplication(Complex x6)
        {

            Complex x7 = new Complex();
            x7.re = x6.re * this.re - x6.im * this.im;
            x7.im = x6.im * this.re + x6.re * this.im;           
            return x7;

        }

        public string toString()
        {
            return re + "+" + im + "i";
        }
    }
}
