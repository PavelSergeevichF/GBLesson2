using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2.Properties
{
    class Class5
    {
        static int weight=0, height=0, coefficient=0;
        static string sex;
        public static void NormalWeight()
        {
            weight = ChekEnterEndConvert("Введите вес");
            height = ChekEnterEndConvert("Введите рост");
            Console.WriteLine("Введите пол m/w");
            bool checSex = false;
            do
            {
                sex = Console.ReadLine();
                if (sex == "m" || sex == "w") checSex = true;
                else
                {
                    Console.WriteLine("Необходимо ввести m или w");
                }
            } 
            while (!checSex);
            
            if (sex == "m") coefficient = weight - (height - 100);
            if (sex == "w") coefficient = weight - (height - 110);

            if (coefficient == 0) { Console.WriteLine("Ваш вес идеален"); }
            else
            {
                if(coefficient<0)
                { 
                    if(coefficient>-10)
                    {
                        Console.WriteLine("Вам следует питаться чуть лучше");
                    }
                    else
                    {
                        if (coefficient > -20) { Console.WriteLine("Вам следует усилено питаться!"); }
                        else { Console.WriteLine("Вам следует обратится к врачу!"); }
                    }
                }
                else
                {
                    if (coefficient < 10)
                    {
                        Console.WriteLine("Вам следует питаться чуть меньше");
                    }
                    else
                    {
                        if (coefficient < 20) { Console.WriteLine("Вам следует ограничивать себя в еде!"); }
                        else { Console.WriteLine("Вам следует обратится к врачу!"); }
                    }
                }
            }

            Console.ReadLine();
        }
        static int ChekEnterEndConvert(string str)
        {
            bool checErr = false;
            string strEnter;
            int num=0;
            do
            {
                checErr = false;

                Console.WriteLine(str);
                strEnter = Console.ReadLine();
                for (int i = 0; i < strEnter.Length; i++)
                {
                    if (strEnter[i] < 48 || strEnter[i] > 57) checErr = true;
                }
                if (!checErr)
                {
                    num = Convert.ToInt32(strEnter);
                }
                else Console.WriteLine("Вводить можно только числа");
            }
            while (checErr);
            return num;
        }
    }
}
