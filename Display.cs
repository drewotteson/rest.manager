using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    class Display
    {
        public static string logInPrompt()
        {
            string promptLogIn = "Welcome to Restaurant Manager";
            return promptLogIn;
        }

        public static string managerChoicePrompt()
        {
            string choicePrompt = "What would you like to do?\nemployee options(employee)\nmenu options(menu)\nset roster(roster)\ntraining options(training)\ninventory options(inventory)\nreservation options(reserve)";
            return choicePrompt;
        }

        public static string employeeOptionPrompt()
        {
            string employeePrompt = "Choose an employee option.\nhire employee(hire)\nterminate employee(terminate)\ncheck off employee zone(check)\n";
            return employeePrompt;
        }

        public static string menuOptionPrompt()
        {
            string menuPrompt = "Choose a menu option.\nset daily menu(menu)\nset daily specials(specials)\n";
            return menuPrompt;
        }

        public static string displayMondaySpecial()
        {
            string special = "Its Monday! All drinks are half-off!";
            return special;
        }
    }
}
