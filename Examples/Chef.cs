using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Chef
    {
        private string name;
        public int age;

        public Chef(string name, int age)
        {
            name= "Joss";
            this.age = age;
        }

        //PROPERTY. special method to define getters and setters
        public string Name
        { 
            //get the attribute
            get { return name; }

            set
            {
                if (value == "Joss" || value == "Leo")
                {
                    name = value;
                }
                else
                {
                    name = "NOOOO";
                }
            }
        }














        //METHODS
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes Salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes barbecue ribs");
        }


        
    }
}
