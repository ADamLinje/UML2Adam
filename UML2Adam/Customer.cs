using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UML2Adam
{
    public class Customer
    {
        #region Instance Fields
        private string _name;
        private string _id;

        #endregion

        #region Constructor
        public Customer(string ID, string Name)
        {
            _name = Name;
            _id = ID;
        }


        #endregion
        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public string ID
        {
            get { return _id; }
        }

        public override string ToString()
        {
            return $"Name{_name} ID{_id}";
        }

    }
}


#endregion