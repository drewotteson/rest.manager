using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Controller
    {
        Manager methodOption = new Manager();

        public void managerOptions()
        {
            Console.WriteLine(Display.managerChoicePrompt());
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "employee":
                    Console.Clear();
                    employeeOptions();
                    break;
                case "menu":
                    Console.Clear();
                    menuOptions();
                    break;
                case "roster":
                    Console.Clear();
                    methodOption.setDailyStaff();
                    managerOptions();
                    break;
                case "training":
                    Console.Clear();
                    methodOption.isTrained();
                    managerOptions();
                    break;
                case "inventory":
                    Console.Clear();
                    methodOption.inventoryOptions();
                    managerOptions();
                    break;
                case "reserve":
                    Console.Clear();
                    methodOption.takeReservation();
                    managerOptions();
                    break;
                case "leave":
                    break;
            }
        }

        public void employeeOptions()
        {
            string choice;
            Console.WriteLine(Display.employeeOptionPrompt());
            choice = Console.ReadLine();
            if (choice == "staff")
            {
                Console.Clear();
                methodOption.setDailyStaff();
                managerOptions();
            }
            else if (choice == "hire")
            {
                Console.Clear();
                methodOption.hireNewEmployees();
                managerOptions();
            }
            else if (choice == "terminate")
            {
                Console.Clear();
                methodOption.terminateEmployees();
                managerOptions();
            }
            else if (choice == "check")
            {
                Console.Clear();
                methodOption.checkEmployeeZone();
                managerOptions();
            }
            else 
            {
                Console.WriteLine("invalid entry");
                employeeOptions();
            }
        }

        public void menuOptions()
        {
            string choice;
            Console.WriteLine(Display.menuOptionPrompt());
            choice = Console.ReadLine();
            if (choice == "menu")
            {
                Console.Clear();
                methodOption.setDailyMenu();
                managerOptions();
            }
            if (choice == "specials")
            {
                Console.Clear();
                methodOption.setDailySpecials();
                managerOptions();
            }
            else
            {
                Console.WriteLine("invalid entry");
                menuOptions();
            }
        }

        //public void 
    }
}
