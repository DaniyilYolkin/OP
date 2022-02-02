using System;

namespace Lab1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приймаємо значення a, d, n введені в консоль 
            var a = Console.ReadLine();
            var d = Console.ReadLine();
            var n = Console.ReadLine();

            // Конвертуємо ці значення з string в double (для a, d) та в int (n)
            double convertedA = Convert.ToDouble(a);
            double convertedD = Convert.ToDouble(d);
            int convertedN = Convert.ToInt32(n);

            // Перевіряємо, чи цілочисельне значення n від'ємне або дорівнює 0 
            if(convertedN <= 0)
            {
                // Генеруємо нову помилку, яка є об'єктом классу Exception
                throw new Exception("ValueError");
            }
            /* Інакше, виводимо результат функції FindTheValueOfArithmeticProgression в консоль, 
            яка приймає як параметри конвертовані значення a, d, n
            */
            Console.WriteLine("Result is " + FindTheValueOfArithmeticProgression(convertedA, convertedD,convertedN));
        }
        /* Декларуємо функцію, яка вертає формат double 
        та приймає два параметра типу double та один параметр типу int.
        Функція вертає значення n-го члена прогрессії
        */
        static double FindTheValueOfArithmeticProgression(double a, double d, int n)
        {
            return a + (n - 1) * d;
        }
    }
} 
