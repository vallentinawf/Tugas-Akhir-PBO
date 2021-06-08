using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;

namespace KopiLibrary
{
    public class KopiMenu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Kopilih`s Menu : ");
            Console.WriteLine($"1. {NamaKopi.Espresso}         RP.{HargaKopi.Espresso}");
            Console.WriteLine($"2. {NamaKopi.Cappuccino}       RP.{HargaKopi.Cappuccino}");
            Console.WriteLine($"3. {NamaKopi.CaffeLatte}       RP.{HargaKopi.CaffeLatte}");
            Console.WriteLine($"4. {NamaKopi.VietnamDrip}      RP.{HargaKopi.VietnamDrip}");
            Console.WriteLine($"5. {NamaKopi.V60}              RP.{HargaKopi.V60}");
            Console.WriteLine($"6. {NamaKopi.AeroPress}        Rp.{HargaKopi.AeroPress}");
            Console.WriteLine();
        }
    }
            
}
