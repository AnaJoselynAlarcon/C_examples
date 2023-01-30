using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef("Joss", 30);
            chef.MakeChicken();

            ItalianChef italianChef = new ItalianChef("Leo", 30);
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();


            Console.ReadLine();
        }
    }
}
