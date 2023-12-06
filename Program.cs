using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int sizearr = Convert.ToInt32(Console.ReadLine()); // ввод размерности массива
            int[] array = new int[sizearr]; // объявление массива
            int max = 0, min = 0, res = 0; // переменные для записи в них индексов минимального и максимального числа, res для подсчета суммы чисел
            Random rnd = new Random(); // объявление рандома

            for (int i = 0; i < array.Length; i++) // цикл наполнения массива рандомными числами и нахождения мин. и макс. числа
            {
                array[i] = rnd.Next(100); // генерация и наполнение массива рандомными числами
                Console.Write(array[i] + " | "); // вывод массива для удобства

                if (array[i] > array[max]) max = i; // нахождение макс. числа, а иммено его индекса в массиве
                if (array[i] < array[min]) min = i; // нахождение мин. числа, а иммено его индекса в массиве
            }

            if (max > min) // если индекс максимального числа больше, то есть число находится в массиве правее чем мин.
            {
                for (int i = min; i <= max; i++) // цикл подсчета суммы чисел 
                {
                    res += array[i]; // сумма чисел
                }
            }
            else if (max < min) // если индекс максимального числа меньше, то есть число находится в массиве левее чем мин.
            {
                for (int i = max; i <= min; i++) // цикл подсчета суммы чисел
                {
                    res += array[i]; // сумма чисел
                }
            }
            Console.WriteLine("\nМин: " + array[min] + "\nМакс: " + array[max]); // вывод мин. макс. числа в консоль для удобства
            Console.WriteLine("Сумма: " + res); // вывод результата
        }
    }
}
