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
        delegate List<Dish> fillMenu();
        delegate bool selectDish(Dish dish);

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

        public List<Dish> FastFood()
        {
            List<Dish> Menu = new List<Dish>(); Menu.Add(new Dish("Burger", Course.MAIN, 380, 15, false)); Menu.Add(new Dish("Salad", Course.STARTER, 80, 8, true)); Menu.Add(new Dish("ChocMousse", Course.DESSERT, 120, 5, false)); Menu.Add(new Dish("Apple", Course.DESSERT, 12, 2, true)); Menu.Add(new Dish("Okonomiaki", Course.MAIN, 300, 16, true));
            return Menu;
        }

        void work()
        {
            IRestaurant FastnFat = new Restaurant(new fillMenu(FastFood)); FastnFat.Open();
            Customer Jack = new Customer("Jack", new selectDish(rich)); FastnFat.Welcome(Jack);
            Customer Tao = new Customer("Tao", new selectDish(ascetic)); FastnFat.Welcome(Tao); Console.ReadLine();
        }
    }
}
