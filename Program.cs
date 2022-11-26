using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 6. Вычислить частичную сумму ряда S=1/2^2 +1/3^2 +1/4^2 +⋯
Вычисление прекратить, когда модуль очередного слагаемого 
станет меньше 0,001. 
Проверьте, насколько сумма приблизилась к значению π^2/6. */

namespace Lab_3_1_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 2;   // Основание знаменателя
            double sum = 0; // Текущая сумма слагаемых
            double add;     // Текущее слагаемое
            do
            {                                
                add = 1 / (n * n);
                sum += add;
                Console.WriteLine($"n = {n}, add = {add}, sum = {sum}");
                n++;                
            } 
            while (add > 0.001);
                        
            Console.ReadKey();
        }
    }
}
