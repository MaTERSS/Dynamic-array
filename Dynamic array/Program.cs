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
            const string ExitCommand = "exit";
            const string SumCommand = "sum";

            int[] numbers = new int[0];

            bool isWork = true; 

            while (isWork)
            {
                Console.WriteLine("Текущие числа: " + string.Join(", ", numbers));
                Console.Write($"Введите число (или команду '{SumCommand}' для суммы, '{ExitCommand}' для выхода): ");
                string input = Console.ReadLine();

                if (input.Equals(ExitCommand, StringComparison.OrdinalIgnoreCase))
                {
                    isWork = false; 
                }
                else if (input.Equals(SumCommand, StringComparison.OrdinalIgnoreCase))
                {
                    int sum = 0;
                    foreach (int number in numbers)
                    {
                        sum += number;
                    }
                 
                    Console.WriteLine("Сумма всех введенных чисел: " + sum);
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
                     
                        newNumbers[newNumbers.Length - 1] = number;
                        numbers = newNumbers;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, вводите только числа или команды.");
                    }
                }
            }
        }
    }
}
