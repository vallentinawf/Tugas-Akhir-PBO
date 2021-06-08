using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Kopilih
{
    public class Data
    {
        protected string Name;
        protected string Address;
        protected string PhoneNumber;

        public virtual void InputData()
        {
            Console.WriteLine("What is Your Name?  ");
            Name = Console.ReadLine();

            Console.WriteLine("And Your Address? ");
            Address = Console.ReadLine();

            Console.WriteLine("What is Your Phone Number? ");
            PhoneNumber = Console.ReadLine();
        }


    }
}
