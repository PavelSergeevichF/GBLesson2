using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Федотов Павел Сергеевич ДЗ-2");
            int min = Properties.Class1.MinNum();
            Console.WriteLine("Минимальное значение " + min);
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
            Properties.Class2.CountingNumbers();
            Properties.Class3.SummNum();
            Properties.Class4.authorization();
            Properties.Class5.NormalWeight();
        }
    }
}
