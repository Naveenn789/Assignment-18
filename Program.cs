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
            IDisplayable one = laptop;
            IRechargeable two = laptop;
            IConnectable connectable = laptop;
            connectable.Connect(true);
            two.Charge(0);
            one.Display();
            Smartphone phone = new Smartphone();
            IConnectable phone1 = phone;
            phone1.Connect(true);
            IDisplayable phone2 = phone;
            phone.Display();
            IRechargeable phone3 = phone;
            phone3.Charge(0);




            Console.ReadKey();
        }
    }
}
