using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace prac7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вывести нечетные двузначные числа в столбик, подсчитать их количество найти сумму и среднее арифметическое
            //int i = 10;
            //int sum = 0;
            //int count = 0;
            //while (i <= 99)
            //{
            //    count++;
            //    i++;
            //    if(i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //        sum += i;

            //    }
            //}
            //Console.WriteLine($"sum={sum}\nсреднее арифметическое = {sum / count}");
            //int sum = 0;
            //int count = 0;
            //for (int i = 10; i <= 99; i ++)
            //{
            //    count++;
            //    if(i%2==1)
            //        {
            //        sum += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine($"sum={sum}\nсреднее арифметическое = {sum / count}");
            //Задача 1. Заполнить одномерный массив из 8 целых чисел с клавиатуры и вывести его на экран.
            //int[] omas = new int[8];
            //Console.WriteLine("Заполнение одномерного масива");
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.Write($"omas[{i}] =");
            //    omas[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Вывод одномерного масива");
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            //foreach(var i in omas)
            //{
            //    Console.WriteLine(i);
            //}
            //Задача 2. Составьте программу ввода (без клавиатуры) и вывода массива: 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3.
            //int[] omas = new int[12] { 5, -2, 3, -6, 7, 9, -4, 8, 1, 2, 7, -3 };
            //Console.WriteLine("Заполнение одномерного масива");
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            //Задача 3. Массив предназначен для хранения значений ростов двенадцати человек.
            //С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.
            //int[] omas = new int[12];
            //Random rng = new Random();
            //for(int i=0;i<omas.Length;i++)
            //{
            //    omas[i] =rng.Next(163,190);
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            //Найти среднюю температуру воздуха за октябрь месяц 
            int[] temp = new int[31];
            Random rng = new Random();
            int srt = 0;
            for(int i = 0;i<temp.Length;i++)
            {
                temp[i] = rng.Next(-2,18);
                Console.WriteLine(temp[i]);
                
            }
            
            Console.ReadLine();
        }
    }
}
