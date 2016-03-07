using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RestaurantManager
{
    public class Write
    {
        public static void writeToFile(string fileName, string toBeWritten)
        {
            File.WriteAllText(fileName, toBeWritten);
        }

        public static void writeToFile(string fileName, List<string> listToWrite)
        {
            File.WriteAllLines(fileName, listToWrite);
        }
        


    }
}
