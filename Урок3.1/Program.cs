using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок3._1 {
    class Program {
        static void Main(string[] args) {

            double first;
            double second;
            while (true) {
                Console.Write("Введите первое число: ");
                if (double.TryParse(Console.ReadLine(), out double number)) {
                    first = number;
                    break;
                }
                Console.WriteLine("Внимание, введено не число!");
            }
            while (true) {
                Console.Write("Введите второе число: ");
                if (double.TryParse(Console.ReadLine(), out double number)) {
                    second = number;
                    break;
                }
                Console.WriteLine("Внимание, введено не число!");
            }
            if (first > second) {
                Console.WriteLine("Первое число больше второго.");
            }
            else {
                if (second > first) {
                    Console.WriteLine("Второе число больше первого.");
                }
                else {
                    Console.WriteLine("Числа равны");
                }
            }
            Console.ReadKey();
        }
    }
}
