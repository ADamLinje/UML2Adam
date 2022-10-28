using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Adam
{
    public class PizzaDictionary
    {
        #region Instance fields
        private Dictionary<int, Pizza> _pizzas;
        #endregion

        #region Constructor
        public PizzaDictionary()
        {
            _pizzas = new Dictionary<int, Pizza>();
        }
        #endregion

        #region Properties
        public int Count
        {
            get { return _pizzas.Count; }
        }
        #endregion

        #region Methods
        public void AddPizza(Pizza pizza)
        {
            if ( !_pizzas.ContainsKey(pizza.ID) )
                _pizzas.Add(pizza.ID, pizza);
        }

        public void DeletePizza(Pizza pizza)
        {
            if (_pizzas.ContainsKey(pizza.ID))
                _pizzas.Remove(pizza.ID);
        }

        public void UpdatePizza(int id, Pizza pizzaToUpdate)
        {
            if (_pizzas.ContainsKey(id))
                _pizzas[id] = pizzaToUpdate;
        }

        public void PrintPizzas()
        {
            foreach (Pizza pizza in _pizzas.Values)
            {
                Console.WriteLine(pizza.ToString() );
            }
        }

        public Pizza LookUpPizzas(int id)
        {
            if (_pizzas.ContainsKey(id))
                return _pizzas[id];
            else return
            null;

        }
        #endregion
    }
}
