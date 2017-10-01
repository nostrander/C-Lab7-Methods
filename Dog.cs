using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Methods
{
    class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        // Constructor Method
        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        // Example Method - use this as an example for your method!
        public void Display()
        {
            Console.WriteLine(this.Name + " is a(n) " + this.Breed);
        }
        // Lab 07 - #1
        public void Bark()
        {
            Console.WriteLine("arf, arf");
        }

        // Lab 07 - #2
        public string GetInfo()
        {
            return (this.Name + "," + this.Breed);

        }
    }
}
