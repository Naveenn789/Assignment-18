using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment18
{
    internal class Smartphone : IConnectable, IRechargeable, IDisplayable

    {
        int charge;
        bool connect;
        string brand;
        string info;
        string Ram;
        string Storage;

        public Smartphone()
        {
            Console.WriteLine("Default SmartPhone Connector");
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
            Console.WriteLine("Enter your Phone Brand ");
            brand = Console.ReadLine();
            Console.WriteLine("Enter RAM Of the Phone");
            Ram = Console.ReadLine();
            Console.WriteLine("Enter Storage Of the Phone");
            Storage = Console.ReadLine();

        }
        public string Display()
        {
            Console.WriteLine($"Smartphone Brand is: {brand} \nTotal time take to charge the phone from 0% to 100% is  {charge} minutes \n{Ram} RAM and {Storage} STORAGE of the Phone");
            string x = "End for Smart Phone";
            return x;
        }


    }
}
