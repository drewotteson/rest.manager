using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class GetInput
    {
        public static string getUserName()
        {
            string userName;
            Console.WriteLine("enter username.");
            userName = Console.ReadLine();
            return userName;
        }

        public static string getPassword()
        {
            string passWord;
            Console.WriteLine("enter password.");
            passWord = Console.ReadLine();
            return passWord;
        }

        public static string getEmployeeFirstName()
        {
            string firstName;
            Console.WriteLine("Enter employee first name.");
            firstName = Console.ReadLine();
            return firstName;
        }

        public static string getEmployeeLastName()
        {
            string lastName;
            Console.WriteLine("Enter employee last name.");
            lastName = Console.ReadLine();
            return lastName;
        }

        public static string getEmployeeTitle()
        {
            string Title;
            Console.WriteLine("Enter job title for employee.");
            Title = Console.ReadLine();
            return Title;
        }

        public static string getDaysAvailable()
        {
            string Days;
            Console.WriteLine("What days is employee available to work?");
            Days = Console.ReadLine();
            return Days;
        }

        public static int provideBartender()
        {
            int bartenders;
            Console.WriteLine("How many bartenders do you need?");
            bartenders = Convert.ToInt32(Console.ReadLine());
            return bartenders;
        }

        public static int provideWaiter()
        {
            int waiters;
            Console.WriteLine("how many waiters do you need?");
            waiters = Convert.ToInt32(Console.ReadLine());
            return waiters;
        }

        public static int provideHosts()
        {
            int hosts;
            Console.WriteLine("how many hosts do you need");
            hosts = Convert.ToInt32(Console.ReadLine());
            return hosts;
        }

        public static int provideBusser()
        {
            int bussers;
            Console.WriteLine("how many bussers do you need?");
            bussers = Convert.ToInt32(Console.ReadLine());
            return bussers;
        }

        public static int provideDishWasher()
        {
            int dishers;
            Console.WriteLine("how many dish washers do you need?");
            dishers = Convert.ToInt32(Console.ReadLine());
            return dishers;
        }

        public static int provideCooks()
        {
            int cooks;
            Console.WriteLine("how many cooks do you need?");
            cooks = Convert.ToInt32(Console.ReadLine());
            return cooks;
        }

        public static int numberToHire()
        {
            int numberToHire;
            Console.WriteLine("how many employees are you hiring?");
            numberToHire = Convert.ToInt32(Console.ReadLine());
            return numberToHire;
        }

        public static string employeeToWorkByTitle()
        {
            string toWork;
            Console.WriteLine("Enter employee type to work.");
            toWork = Console.ReadLine();
            return toWork;
        }

        public static string getPartyName()
        {
            string partyName;
            Console.WriteLine("provide a name for the party.");
            partyName = Console.ReadLine();
            return partyName;
        }

        public static string getPartySize()
        {
            string partySize;
            Console.WriteLine("provide the size of the party");
            partySize = Console.ReadLine();
            return partySize;
        }

        public static string getPartyTime()
        {
            string partyTime;
            Console.WriteLine("what time is the party arriving.");
            partyTime = Console.ReadLine();
            return partyTime;
        }

        public static string createFoodItem()
        {
            string foodItem;
            Console.WriteLine("provide the food item.");
            foodItem = Console.ReadLine();
            return foodItem;
        }

        public static string giveFoodItemPrice()
        {
            string foodPrice;
            Console.WriteLine("give the food item a price.");
            foodPrice = Console.ReadLine();
            return foodPrice;
        }

        public static string createDrinkItem()
        {
            string drinkItem;
            Console.WriteLine("provide the drink item.");
            drinkItem = Console.ReadLine();
            return drinkItem;
        }

        public static string giveDrinkItemPrice()
        {
            string drinkPrice;
            Console.WriteLine("give the drink a price.");
            drinkPrice = Console.ReadLine();
            return drinkPrice;
        }
        
        public static string chooseDayOfWeek()
        {
            string Day;
            Console.WriteLine("enter day of the week.");
            Day = Console.ReadLine();
            return Day;
        }

        public static string checkSection()
        {
            string check;
            Console.WriteLine("section clean?");
            check = Console.ReadLine();
            return check;
        }

        public static string checkTrained()
        {
            string train;
            Console.WriteLine("employee trained?");
            train = Console.ReadLine();
            return train;
        }




        
    }
}
