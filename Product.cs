using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17part2Day12
{
    public class Product
    {
        int pid;
        string pname;
        string pprice;
        public Product()
        {
            Console.WriteLine("Default Constructor");
            pid = 0;
            pname = "not define";
            pprice = "null";
        }
        public virtual void setMethod()
        {
            Console.WriteLine("Enter product Id");
            pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product name");
            pname = Console.ReadLine();
            Console.WriteLine("Enter product Price");
            pprice = Console.ReadLine();

        }
        public virtual void Display()
        {
            Console.WriteLine("***Display Product Details***");
            Console.WriteLine("Product Id:\t"+pid);
            Console.WriteLine("Product Name:\t" + pname);
            Console.WriteLine("Product Price:\t"+pprice);
        }
    }
}
