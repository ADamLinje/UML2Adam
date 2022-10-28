using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Adam
{
    public class Pizza
    {
        #region Instance Fields
        private string _name;
        private int _id;
        private int _price;

        #endregion

        #region Constructor
        public Pizza(string Name, int ID, int Price)
        {
            _name = Name;
            _id = ID;
            _price = Price;
        }


        #endregion
        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int ID
        {
            get { return _id; }
        }

        public int Price
        { 
            get { return _price; }
        }

        public override string ToString()
        {
            return $"Name{_name} ID{_id} Price{_price}";
        }

    }
}


#endregion
