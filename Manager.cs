using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Manager
    {
        public static List<Employee> staffList;
        List<string> reservationList;
        List<Employee> dailyStaff;
        List<string> dailyMenu;
        GetInput getInput = new GetInput();
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public Manager(string userName, string passWord)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            staffList = new List<Employee>();
            reservationList = new List<string>();
            dailyStaff = new List<Employee>();
            dailyMenu = new List<string>();
        }

        public Manager()
        {
            staffList = new List<Employee>();
            reservationList = new List<string>();
            dailyStaff = new List<Employee>();
            dailyMenu = new List<string>();
        }

        public void logIn()
        {
            Console.WriteLine(Display.logInPrompt());
            UserName = GetInput.getUserName();
            PassWord = GetInput.getPassword();
            foreach (string line in Read.readFromFile2("managerData.txt"))
            {
                if (line.Contains(UserName))
                {
                    if (line.Contains(PassWord))
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome: " + UserName);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("invalid entry");
                    logIn();
                }
            }
        }
        //pass user input in for getinput class and use that number 
        public void hireNewEmployees()
        {
            int numberToHire = GetInput.numberToHire();
            for (int i = 0; i < numberToHire; i++)
            {
                Employee employeeToAdd;
                employeeToAdd = new Employee(GetInput.getEmployeeFirstName(), GetInput.getEmployeeLastName(), GetInput.getEmployeeTitle(), GetInput.getDaysAvailable());
                Manager.staffList.Add(employeeToAdd);
            }
        }

        public void terminateEmployees()
        {
            string name = GetInput.getEmployeeFirstName();
            name = Console.ReadLine();
            foreach (Employee emp in staffList)
            {
                if (emp.FirstName == name)
                {
                    staffList.Remove(emp);
                }
            }
        }

        public void setDailyStaff()
        {
            bool containsTitle = false;
            string day = GetInput.chooseDayOfWeek();
            day = Console.ReadLine();
            string employeeToWork = GetInput.employeeToWorkByTitle();
            employeeToWork = Console.ReadLine();
            while (dailyStaff.Count < 6)
            {
                foreach (Employee emp in dailyStaff)
                {
                    if (emp.Title == employeeToWork)
                    {
                        containsTitle = true;
                        Console.WriteLine("already filled");
                        setDailyStaff();
                    }
                    else if (containsTitle == false)
                    {
                        if (employeeToWork == emp.Title && emp.DaysAvailable == day)
                        {
                            dailyStaff.Add(emp);
                        }
                    }
                }
            }
        }
        public void setDailyMenu()
        {
            string foodItem = GetInput.createFoodItem();
            string foodPrice = GetInput.giveFoodItemPrice();
            string drinkItem = GetInput.createDrinkItem();
            string drinkPrice = GetInput.giveDrinkItemPrice();
            dailyMenu.Add(foodItem);
            dailyMenu.Add(foodPrice);
            dailyMenu.Add(drinkItem);
            dailyMenu.Add(drinkPrice);
        }

        public void setDailySpecials()
        {
            string day = GetInput.chooseDayOfWeek();
            day = Console.ReadLine();
            string special = Display.displayMondaySpecial();
            if (day == "monday")
            {
                dailyMenu.Add(special);
            }
            else
            {
                Console.WriteLine("special on Monday only.");
            }
        }

        public void takeReservation()
        {
            string time = GetInput.getPartyTime();
            string size = GetInput.getPartySize();
            string name = GetInput.getPartyName();
            reservationList.Add(time);
            reservationList.Add(size);
            reservationList.Add(name);
        }

        public void inventoryOptions()
        {
            foreach (var inventory in dailyMenu)
            {
                Console.WriteLine(inventory);
            }         
        }

        public void checkEmployeeZone()
        {
            string check = GetInput.checkSection();
            bool isClean;
            if (check == "yes")
            {
                isClean = true;
            }
            else if (check == "no")
            {
                isClean = false;
            }
        }

        public void isTrained()
        {
            string trained = GetInput.checkTrained();
            bool isTrained;
            if (trained == "yes")
            {
                isTrained = true;
            }
            else if (trained == "no")
            {
                isTrained = false;
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
