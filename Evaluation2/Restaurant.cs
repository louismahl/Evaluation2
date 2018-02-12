using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Evaluation2
{
    public class Restaurant : IRestaurant
    {
        // Attributes
        private List<Dish> m_menu;
        private Program.fillMenu m_leChef;

        // Getters and setters
        public List<Dish> menu
        {
            get { return m_menu; }
            set { m_menu = value; }
        }

        public struct meal
        {
            public int energy;
            public int bill;
        }

        public Restaurant(Program.fillMenu chef)
        {
            m_leChef = chef;
        }

        // Implement IRestaurant methods
        public void Open()
        {
            menu = m_leChef();
        }
        
        // Overriding ToString to show the menu
        override
        public String ToString()
        {
            String tmp = "";
            foreach (Dish a in menu)
            {
                tmp += a.ToString();
                tmp += "\n";
            }
            return tmp;
        }

        // Overriding Welcome to say coucou au customer
        public void Welcome(Customer customer)
        {
            Console.WriteLine("Welcome " + customer.name + " !");
            meal m = new meal();
            m.energy = 0;
            m.bill = 0;
            foreach(Dish d in menu)
            {
                if (customer.m_preferences(d))
                {
                    Console.WriteLine("You ordered " + d.name);
                    m.bill += d.price;
                    m.energy += d.calories;
                }
            }
            Console.WriteLine("You ate " + m.energy + " calories and payed " + m.bill + " euros !");
        }
    }
}
