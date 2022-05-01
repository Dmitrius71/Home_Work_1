
using System;

namespace Home_Work_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string numberStringOne;
            string numberStringTwo;
            string numberStringThree;

            Console.WriteLine("Введите  с клавиатуры 2 числа.Числа будут сравниваться с последующим выводом в консоль результата этого сравнения");
            numberStringOne = Console.ReadLine();
            numberStringTwo = Console.ReadLine();
            
            TaskOne taskOne = new TaskOne(numberStringOne,numberStringTwo);
            taskOne.PrintTask();

            TaskTwo taskTwo = new TaskTwo(numberStringOne);

            Console.WriteLine("Введите размер вклада");
            numberStringThree = Console.ReadLine();

            TaskThree taskThree = new TaskThree(numberStringThree);
        }
    }
}
