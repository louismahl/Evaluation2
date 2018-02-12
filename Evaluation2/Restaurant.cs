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
            int energy;
            int bill;
        }

        public Restaurant(Program.fillMenu chef)
        {
            m_leChef = chef;
        }

        // Implement IRestaurant methods
        public void Open()
        {
            List<Dish> b = new List<Dish>();
            XmlSerializer xd = new XmlSerializer(typeof(List<Dish>));
            using (StreamReader rd = new StreamReader("myMenu.xml"))
            {
                b = xd.Deserialize(rd) as List<Dish>;
            }
            this.menu = b;
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
            Console.WriteLine("Bienvenue " + customer.name + " !");
        }
    }
}
