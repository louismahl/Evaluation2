using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2
{
    public class Customer
    {

        private String m_name;
        public Program.selectDish m_preferences;

        public String name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public Customer(String nom, Program.selectDish preferences)
        {
            name = nom;
            m_preferences = preferences;
        }

    }
}
