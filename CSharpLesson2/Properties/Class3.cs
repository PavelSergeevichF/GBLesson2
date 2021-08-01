using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2.Properties
{
    class Class3
    {
        static int num=-1,summ=0;
        public static void SummNum()
        {
            do
            {
                Console.WriteLine("Введите число. Для завершения введите 0");
                bool checErr = false;
                string str = Console.ReadLine();
                for(int i=0;i<str.Length;i++)
                {
                    if (str[i] < 48 || str[i] > 57) checErr = true;
                }
                if (!checErr)
                {
                    num = Convert.ToInt32(str);
                    summ += num;
                    Console.WriteLine("Вы ввели " + num);
                }
                else Console.WriteLine("Вводить можно только числа");
            }
            while (num != 0);
            Console.WriteLine("Сумма всех чисел равна "+ summ);
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
        }
        
    }
}
