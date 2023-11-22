using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment18
{
    public class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.Connect();
            laptop.Charge(50);
            laptop.Display();
            Smartphone phone = new Smartphone();
            phone.Connect();
            phone.Charge(50);
            phone.Display();

            



            Console.ReadKey();
        }
    }
}
