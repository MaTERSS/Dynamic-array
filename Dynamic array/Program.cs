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
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[0];
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Введеннные числа:");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine("Введите число.\nВведите 'sum' для вывода суммы.\nВведите 'exit' для выхода:\n");
                string input = Console.ReadLine();

                if (input.ToLower() == "sum")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine("Сумма введённых чисел: " + sum);
                }

                else if (input.ToLower() == "exit")
                {
                    break;
                }

                else
                {
                    if (int.TryParse(input, out int number))
                    {
                        int[] newNumbers = new int[numbers.Length + 1];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            newNumbers[i] = numbers[i];
                        }
                        newNumbers[numbers.Length] = number;
                        numbers = newNumbers;
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста, введите корректное число или команду.");
                    }
                }
            }
        }
    }
}