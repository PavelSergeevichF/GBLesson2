using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2.Properties
{
    class Class1
    {
        public static int MinNum()
        {
            int[] Num = new int[3];
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                Num[i] = random.Next(0, 100);
                Console.WriteLine(Num[i]);
            }
            int temp = Num[0];
            if (temp > Num[1]) temp = Num[1];
            else if (temp > Num[2]) temp = Num[2];
            return temp;
        }
    }
}
