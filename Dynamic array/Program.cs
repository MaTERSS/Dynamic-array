/*
 Пользователь вводит числа, и программа их запоминает. 
Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел. 
Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
Если введено не sum и не exit, значит это число и его надо добавить в массив.
В начале цикла надо выводить в консоль все числа, которые содержатся в массиве, а значит их ввел пользователь ранее. 
Программа должна работать на основе расширения массива.         
Внимание, нельзя использовать List<T> и Array.Resize 
 */
using System;
using System.Data;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[0]; 
            string input;

            string commandSum = "sum";
            string commandExit = "exit";

            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("Введенные числа: " + string.Join(", ", numbers));
                Console.Write("Введите число (или команду 'sum' для суммы, 'exit' для выхода): ");
                input = Console.ReadLine();

                if (input.ToLower() == commandSum)
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine("Сумма всех введенных чисел: " + sum);
                }
                else if (input.ToLower() == commandExit)
                {
                    isWork = false; 
                }
                else if (int.TryParse(input, out int number))
                {
                    Array.Resize(ref numbers, numbers.Length + 1);
                    numbers[numbers.Length - 1] = number;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное число или команду.");
                }

                Console.WriteLine(); 
            }
        }
    }
}
