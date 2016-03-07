using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Read
    {
        public static string readFromFile(string filePath)
        {
            return File.ReadAllText(filePath);         
        }

        public static List<string> readFromFile2(string filePath)
        {
            return File.ReadAllLines(filePath).ToList();
        }
    }
}
