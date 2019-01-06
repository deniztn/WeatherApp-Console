using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //weather forecast
            Console.Write("Please Enter Temperature Degree:"); //write to console
            int s = Convert.ToInt16(Console.ReadLine()); //read console and convert to number
            if (s <= 0) // if Temperature Degree under the 0 degree
                Console.Write("the weather is cold , it may snow"); //write to console
            else if (s >= 15 && s <= 25) //if temperature is between 15 and 25 degrees Celsius.
                Console.Write("the weather is normal.");
            else
                Console.Write("the weather is warm");
            Console.ReadKey(); //wait
        }
    }
}
