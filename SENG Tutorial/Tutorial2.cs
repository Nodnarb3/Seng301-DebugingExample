using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG_Tutorial
{
    class Tutorial2
    {

        public static void Main(string[] args)
        {
            List<String> strs = new List<String>();

            for(int i = 0; i < 100; i++)
            {
                string s = "";

                if (i % 3 == 0)
                    s += "Fizz";

                if (i % 5 == 0)
                    s += "Buzz";

                if( i % 3 != 0 && i % 5 != 0)
                {
                    s += i;
                }

                strs.Add(s);
            }

            foreach(string s in strs)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();

        }

    }
}
