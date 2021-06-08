using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using KopiLibrary;

namespace Kopilih
{
    
    public class MainMenu : Data
    {
        public double Total;
        public double Price;
        public string Order;

        public static void Greet()
        {
            Console.WriteLine("Welcome to Kopilih!");
            Console.WriteLine("You can order your favorite coffee, and we will deliver it for you!");
            Console.WriteLine();
            KopiMenu.ShowMenu();
        }
        public void MainOrdering()
        {
            Console.WriteLine("How Many Coffee Do You Want To Order?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            

            int i;
            for (i = 1; i <= quantity; i++)
            {
                Console.WriteLine("Which coffee do you want?");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Price = 18000;
                        Order += "Espresso\n";
                        break;
                    case "2":
                        Price = 28000;
                        Order += "Cappuccino\n";
                        break;
                    case "3":
                        Price = 23000;
                        Order += "Caffe Latte\n";
                        break;
                    case "4":
                        Price = 30000;
                        Order += "Vietnam Drip\n";
                        break;
                    case "5":
                        Price = 25000;
                        Order += "V60\n";
                        break;
                    case "6":
                        Price = 29000;
                        Order += "Aeropress\n";
                        break;
                }
                Total += Price;
            }
        }

        public override void InputData()
        {
            Console.WriteLine("====Please Fill Out This Form====");
            base.InputData();

            Database database = new();
            database.OpenConnection();
            string query = "INSERT INTO Orders ('Name','Address','Phone Number','Order','Total') VALUES ('" + Name + "', " +
                "'" + Address + "', '" + PhoneNumber + "', '" + Order +"', '" + Total + "')";
            SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);

            myCommand.ExecuteNonQuery();
            database.CloseConnection();

            Console.ReadKey();

            MainMenu conclusing = new MainMenu();
            conclusing.Conclusing(Total);
            
            
        }
        public void Conclusing(double Total)
        {
            Console.WriteLine("================");
            Console.WriteLine("Your Total Bill Is : Rp.{0}", Total);
            Console.WriteLine("Your Order Is Being Processed.");
            Console.WriteLine("Our Courier Will Deliver Your Order.");
            Console.WriteLine("Thank You");
        }


    }
}
