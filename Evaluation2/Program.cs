using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Evaluation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.initRestaurant();
        }

        public void initRestaurant()
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Open();
            Console.WriteLine(restaurant.ToString());
            Console.ReadLine();
        }
    }
}
