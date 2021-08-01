using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2.Properties
{
    class Class2
    {
        static Random random = new Random();
        static int num = random.Next();
        public static void CountingNumbers()
        {
            string str = num.ToString();
            Console.WriteLine("Исходное число " + num + ", количиство знаков " + str.Length);
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
        }
    }
}
