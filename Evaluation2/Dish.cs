using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2
{
    public enum Course { DESSERT, MAIN, STARTER };

    public class Dish
    {
        private String m_name = " ";
        private bool m_vegan;
        private Course m_course;
        private int m_calories;
        private int m_price;

        //Name
        //non-empty
        public String name
        {
            get { return m_name; }
            set { m_name = value;  }
        }

        //Course
        public Course course
        {
            get { return m_course; }
            set { m_course = value; }
        }

        //Calories
        //Positif => faire qqch ou pas ?
        public int calories
        {
            get { return m_calories; }
            set { m_calories = value;  }
        }

        //Price
        //Positif => faire qqch ou pas ?
        public int price
        {
            get { return m_price; }
            set { m_price = value; }
        }

        //Vegan
        public bool vegan
        {
            get { return m_vegan; }
            set { m_vegan = value; }
        }

        override
        public String ToString()
        {
            String tmp = "";
            tmp += "Name: " + name + " ";
            tmp += "|Course: " + course + " ";
            tmp += "|Calories: " + calories + " cal ";
            tmp += "|Price: " + price + "e ";
            if (vegan) tmp += "|this dish is vegan.";
            else tmp += "|this dish is not vegan.";
            return tmp;
        }
    }
}
