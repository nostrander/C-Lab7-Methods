using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogInfo="";
            Dog dog1 = new Dog("Boomer", "Labrador Retriever");
            dog1.Display();
            dog1.Bark();
            dogInfo=dog1.GetInfo();
            Console.WriteLine(dogInfo);
        }
    }
}
