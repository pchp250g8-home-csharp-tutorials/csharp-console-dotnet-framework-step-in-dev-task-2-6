using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_6_ru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n; // Число, "корень" которого нужно найти
            //--Ввод данных с клавиатуры--
            Console.Write("Введите число: ");
            uint.TryParse(Console.ReadLine(), out n);
            //--Поиск "корня" введённого числа
            uint m = n;  // Начальное значение "корня" числа
            while (m > 9) // Внешний цикл: повторять пока число не станет однозначным
            {
                uint s = 0;  // Сумма цифр введённого числа
                while (m > 0) // Внутренний цикл: повторять пока число больше нуля
                {
                    s = s + m % 10; // Вычислить сумму цифр числа.
                    m = m / 10; // Число уменьшить в 10 раз.
                }
                m = s;  // Промежуточное значение "корня" числа
            }
            // Вывод на экран исходного числа и его "корня"
            Console.WriteLine($"\"Корень\" числа {n} - {m}");
            Console.Read(); // Задержка вывода до нажатия клавиши "Ввод"
        }
    }
}
