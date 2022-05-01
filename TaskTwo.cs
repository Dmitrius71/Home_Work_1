using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_1
{
    internal class TaskTwo
    {
        int numberOne;

        public TaskTwo(string number)
        {
            numberOne = Convert.ToInt32(number);
            if (numberOne >=5 && numberOne <=10)
                Console.WriteLine($" Первое число {numberOne} больше пяти и меньше десяти") ;
            else
                Console.WriteLine(" Первое число или меньше пяти или больше десяти");
        }
    }
}
