using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class FirstClass
    {
        public static void Main(string[] args)
        {
            int names = 3;

            Person[] pr = new Person[names];

            for(int i=0; i< names; i++)
            {
                pr[i] = new Person()
                {
                    Name = Console.ReadLine()
                };
            }
        for(int i=0; i<names; i++)
            {
                Console.WriteLine(pr[i].ToString());
            }
            Console.ReadLine();
        }
       
    }


    
}

