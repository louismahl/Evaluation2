using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Evaluation2
{
    public class Program
    {
        public delegate List<Dish> fillMenu();
        public delegate bool selectDish(Dish dish);

        static void Main(string[] args)
        {
            Program program = new Program();
            program.work();
        }

        public List<Dish> FastFood()
        {
            List<Dish> Menu = new List<Dish>();
            Menu.Add(new Dish("Burger", Course.MAIN, 380, 15, false));
            Menu.Add(new Dish("Salad", Course.STARTER, 80, 8, true));
            Menu.Add(new Dish("ChocMousse", Course.DESSERT, 120, 5, false));
            Menu.Add(new Dish("Apple", Course.DESSERT, 12, 2, true));
            Menu.Add(new Dish("Okonomiaki", Course.MAIN, 300, 16, true));
            return Menu;
        }

        public bool rich(Dish d)
        {
            if (d.name == "Salad" || d.name == "Apple")
            {
                return true;
            }
            return false;
        }

        public bool fat(Dish d)
        {
            if (d.name == "Burger" || d.name == "ChocMousse")
            {
                return true;
            }
            return false;
        }

        void work()
        {
            IRestaurant FastnFat = new Restaurant(new fillMenu(FastFood));
            FastnFat.Open();
            Console.WriteLine(FastnFat.ToString());

            // Rich guy
            Customer Jack = new Customer("Jack", new selectDish(rich));
            FastnFat.Welcome(Jack);

            // Fat guy
            Customer Paul = new Customer("Paul", new selectDish(fat));
            FastnFat.Welcome(Paul);

            //Customer Tao = new Customer("Tao", new selectDish(ascetic));
            //FastnFat.Welcome(Tao);

            Console.ReadLine();
        }
    }
}
