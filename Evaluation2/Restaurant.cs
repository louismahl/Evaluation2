using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2
{
    class Restaurant : IRestaurant
    {
        // Attributes
        private List<Dish> m_menu;

        // Getters and setters
        private List<Dish> menu
        {
            get { return m_menu; }
            set { m_menu = value; }
        }

        // Implement IRestaurant methods
        public void Open()
        {
            
        }
        
        // Overriding ToString to show the menu
        override
        public String ToString()
        {
            String tmp = "";
            foreach (Dish a in menu)
            {
                tmp += a.name + " ";
                tmp += a.course + " ";
                tmp += a.calories + " ";
                tmp += a.price + " ";
                if (a.vegan) tmp += "this dish is vegan.";
                else tmp += "this dish is not vegan.";
                tmp += "\n";
            }
            return tmp;
        }
    }
}
