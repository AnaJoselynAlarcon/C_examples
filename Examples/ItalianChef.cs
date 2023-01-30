using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class ItalianChef :Chef
    {
        public ItalianChef(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.age = age;
        }

        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes chicken parm");
        }
    }
}
