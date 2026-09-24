using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_6_en
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n; // The number whose "root" is to be found
            //--Input from the keyboard--
            Console.Write("Enter a number: ");
            uint.TryParse(Console.ReadLine(), out n);
            //--Finding the "root" of the entered number
            uint m = n; // Initial value of the number's "root"
            while (m > 9) // Outer loop: repeat until the number becomes a single digit
            {
                uint s = 0; // Sum of the digits of the entered number
                while (m > 0) // Inner loop: repeat while the number is greater than zero
                {
                    s = s + m % 10; // Calculate the sum of the digits. 
                    m = m / 10; // Divide the number by 10.
                }
                m = s; // Intermediate value of the number's "root"
            }
            // Display the original number and its "root" on the screen
            Console.WriteLine($"The \"root\" of the number {n} is {m}");
            Console.Read(); // Pause output until the "Enter" key is pressed
        }
    }
}
