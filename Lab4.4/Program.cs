using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            first:
            Console.WriteLine("Enter the product`s key:");
            string product_key = Convert.ToString(Console.ReadLine());
            ApplicationLicense license = new ApplicationLicense(product_key);
            license.Method();
            Console.WriteLine("Do you want to enter another key ?(Enter '1')");
            int q = Convert.ToInt32(Console.ReadLine());
            if (q > 0)
            { goto first; }          
        }
    }
}
