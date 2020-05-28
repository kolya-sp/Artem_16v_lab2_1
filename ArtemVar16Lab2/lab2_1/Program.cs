using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створити об'єкт класу Квітка, використовуючи класи Пелюсток, Бутон. Методи: розквітнути, зів'янути, вивести на консоль колір бутона.
            kvitka k = new kvitka("Red", 10);
            k.rozkvitnuti();
            k.zivanuti();
            k.vivod_koloru_bootonu();
            Console.ReadKey();
        }
    }
}
