using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment18
{
    internal class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        int charge;
        bool connect;
        string brand;
        string Ram;
        string Storage;

        public Laptop()
        {
            Console.WriteLine("Laptop Default Constructor");
        }

        public bool Connect()
        {
            Console.WriteLine("Is device is connected ? True/False");
            connect = bool.Parse(Console.ReadLine());
            return connect;
        }
        public void Charge(int minute)
        {
            charge = minute;
            Console.WriteLine("Enter your Laptop Brand ");
            brand = Console.ReadLine();
            Console.WriteLine("Enter RAM Of the Laptop");
            Ram = Console.ReadLine();
            Console.WriteLine("Enter Storage Of the Laptop");
            Storage = Console.ReadLine();

        }
        public string Display()
        {
            Console.WriteLine("Phone Brand is " + brand);
            Console.WriteLine("{0} RAM and {1} STORAGE of the Laptop  ", Ram, Storage);
            Console.WriteLine("Total time take to charge the Laptop from 0% to 100% is " + charge+" Minutes");
            string x = "End for Laptop";
            return x;
        }



    }
}
