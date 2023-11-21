using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17part2Day12
{
    public class HerbalProduct:Product
    {
        string herbsUsed;
        DateTime mfDate;
        DateTime expDate;
        public HerbalProduct()
        {
            herbsUsed = "null";
            mfDate = DateTime.Now;
            expDate = DateTime.Now.AddYears(1);
        }

      public  override void  setMethod()
        {
            base.setMethod();
            Console.WriteLine("Enter the herbs ");
            herbsUsed = Console.ReadLine();
            Console.WriteLine("enter the manufacture date ");
            mfDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the expiry date");
            expDate = DateTime.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Children");
            Console.WriteLine("The herbs:'\t"+herbsUsed);
            Console.WriteLine("Manufacturing Date:\t"+mfDate);
            Console.WriteLine("Expiry Date:\t" + expDate);
        }

    }
}
