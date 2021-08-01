using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2.Properties
{
    class Class4
    {
        static int tryEnter = 3;
        static string log = "root", pass = "GeekBrains", logUser, passUser;
        public static void authorization()
        {
            do
            {
                Console.WriteLine("Введите логин");
                logUser = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                passUser = Console.ReadLine();
                if(log == logUser && pass==passUser)
                {
                    Console.WriteLine("Вы вошли в систему");
                    break;
                }
                else
                {
                    if (log != logUser) { Console.WriteLine("Не верный логин"); }
                    if(pass != passUser) { Console.WriteLine("Не верный пароль"); }
                    tryEnter--;
                }
            }
            while (tryEnter != 0);
            if (tryEnter < 1) Console.WriteLine("Вы исчерпали попытки");

            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
        }
    }
}
