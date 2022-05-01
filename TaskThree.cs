using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_1
{
    internal class TaskThree
    {
        double Diposit { get; set; }
        int bonus = 15;

        public TaskThree(string diposit)
        {
            Diposit = Convert.ToDouble(diposit);

            if (Diposit < 100)
                Console.WriteLine("Сумма с процентами равна  = "+(Diposit+(Diposit*5/100))+ " Плюс бонус от банка 15 ед. Итого " + (Diposit + (Diposit * 5 / 100) +bonus));
            else if (Diposit >=100 && Diposit<200)
                Console.WriteLine("Сумма с процентами равна  = " + (Diposit + (Diposit * 7 / 100)) + " Плюс бонус от банка 15 ед. Итого " + (Diposit + (Diposit * 7 / 100) + bonus));
            else if (Diposit >=200)
                Console.WriteLine("Сумма с процентами равна  = " + (Diposit + (Diposit * 10 / 100))+ " Плюс бонус от банка 15 ед. Итого " + (Diposit + (Diposit * 10 / 100) + bonus));
            else
                Console.WriteLine("Неверно ввели число");
        }



    }
}
