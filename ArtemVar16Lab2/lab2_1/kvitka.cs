using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    class kvitka : booton
    {
        // Створити об'єкт класу Квітка, використовуючи класи Пелюсток, Бутон. Методи: розквітнути, зів'янути, вивести на консоль колір бутона.
        public pelustok pel;
        public kvitka(string kolir, int kpelustok) : base(kolir)
        {
            pel = new pelustok(kpelustok);
        }
        public void rozkvitnuti ()
        {
            Console.WriteLine("kvitka rozkvitla");
        }
        public void zivanuti()
        {
            Console.WriteLine("kvitka ziviala");
        }
        public void vivod_koloru_bootonu()
        {
            Console.WriteLine("kolir bootonu: " + color);
        }
    }
}
