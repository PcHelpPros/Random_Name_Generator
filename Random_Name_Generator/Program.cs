using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Name_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ClassRoster = {"Joanne", "Elijah", "Justin", "Rick", "Tony", "Mike", "Rudy", "Aaron", "Kevin "}; // Array OF Names To Cycle Through.
            Random c = new Random();

            int index = c.Next(0, ClassRoster.Length);
            string randomItem = ClassRoster[index];

            Console.WriteLine(randomItem);
        }
    }
}
