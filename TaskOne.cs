using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_1
{
    internal class TaskOne
    {

        int numberIntOne { get; set; }
        int nmberIntTwo { get; set; }
        
public TaskOne(string numberStringOne, string numberStringTwo)
        {

             this.numberIntOne = Convert.ToInt32(numberStringOne);
             this.nmberIntTwo = Convert.ToInt32(numberStringTwo);
            
            
        }
        public void PrintTask()
        {

            Console.WriteLine("Сумма чисел равна = " + (this.numberIntOne + this.nmberIntTwo));

            if (this.numberIntOne == this.nmberIntTwo)
                Console.WriteLine("Эти числа равны");
            else if (this.numberIntOne < this.nmberIntTwo)
                Console.WriteLine($"Превое число {numberIntOne} меньше {nmberIntTwo}");
            else
                Console.WriteLine($"Превое число {numberIntOne} ,больше {nmberIntTwo}");
        }
    }

    
}
