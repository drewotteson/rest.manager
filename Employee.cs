using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public bool Trained { get; set; }
        public bool sectionChecked { get; set; }
        public string DaysAvailable { get; set; }

        public Employee(string firstName, string lastName, string title, string daysAvailable)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Title = title;
            this.DaysAvailable = daysAvailable;
            Trained = false;
            sectionChecked = false;
        }

        public Employee()
        {

        }
    }
}
