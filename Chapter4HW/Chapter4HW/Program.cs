using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4HW
{
    class Program
    {
        static void Main(string[] args)

        //Minimun function 
        {
            int min(int x, int y)
            {
                if (x <= y)
                { return x; }
                else
                { return y; }
            }

            Console.WriteLine(min(0, 10));
            Console.WriteLine(min(0, -10));
        }

        //Testing for even
        int[] myInts = new int[3];
        myInts[0] = 55;
        myInts[1] = 86;
            myInts[2] = -15;

        static int isEven(i)
        {
            bool b1 = true, b2 = false;
            if (i % 2 == 0)
            { return b1; }
            else
            { return b2; }

            Console.WriteLine(isEven(55));
        }

        //Counting Characters

        //        string countBs = "Baby Boom";
        //        int count = 0;
        //        char charToCount = 'B';
        //for (char c in countBs)
        //{
        //    if(c == charToCount )
        //    {
        //        count++;
        //    }
        //}

        //Sum of a Range

    }
}

  