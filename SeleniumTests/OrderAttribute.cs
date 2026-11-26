using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    // Järjesti klass, mis omab omadusi mille järgi teste järjestada saab
    public class OrderAttribute : Attribute
    {
        public int Value { get; } // väärtus
        public OrderAttribute(int value) // konstruktor, kus omistatakse väärtus
        {
            Value = value; 
        }
    }
}
