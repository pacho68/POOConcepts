using POOConcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(2022, 12, 7);//este es el metodo explicito
          
            Console.WriteLine(date1);
            try
            {
                Console.WriteLine(new Date(2024, 2, 29));
                Console.WriteLine(new Date(1976, 9, 23));
                Console.WriteLine(new Date(1985, 11, 31));
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }

            Console.ReadKey();

        }
    }
}
