using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment18
{
    internal class Smartphone : IConnectable, IRechargeable, IDisplayable

    {
        int charge;
        DateTime purchaseDate;
        bool connect;
        double price;

        public void Charge(int minute)
        {
            Console.WriteLine("Enter The device charging in minutes");
            charge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price for the device");
            double price = double.Parse(Console.ReadLine());
            purchaseDate = DateTime.Now;
        }

        public void Display()
        {
            Console.WriteLine($"Charg of the device {charge} minutes" + charge);
            Console.WriteLine("Price of the device : " + price);
            Console.WriteLine("Purchased Date of the device: " + purchaseDate);
        }
        void IConnectable.Connect(bool v)
        {
            Console.WriteLine("Is the device is connected?");
            connect = bool.Parse(Console.ReadLine());

        }


    }
}
