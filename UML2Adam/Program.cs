//// See https://aka.ms/new-console-template for more information
using UML2Adam;

//Console.WriteLine("Hello, World!");

CustomerList customerList= new CustomerList();

Customer firstCustomer = new Customer("3939", "Adam");
Customer secondCustomer = new Customer("4015", "Pizzakunde");
Customer thirdCustomer = new Customer("6969", "Pizzakunde2");


customerList.AddCustomer(firstCustomer);
customerList.AddCustomer(secondCustomer);
customerList.AddCustomer(thirdCustomer);
Console.WriteLine($"{customerList.Count}");


customerList.DeleteCustomer("Adam");
Console.WriteLine($"{customerList.Count}");

//kunne ikke få update delen af listen til at virke og fik ikke nået at teste 
//søgefunktionen.
//Customer customerToUpdate = new Customer("3939", "Dims");
//CustomerList.UpdateCustomer("Adam", customerToUpdate);
//customerList.PrintCustomer();

PizzaDictionary pizzaDictionary= new PizzaDictionary();

Pizza firstPizza = new Pizza(" Margerita ", 1 , 75 );
Pizza secondPizza = new Pizza(" Vesuvio ", 2 , 85 );
Pizza thirdPizza = new Pizza(" Pepperoni ", 3 , 100 );

pizzaDictionary.AddPizza (firstPizza);
pizzaDictionary.AddPizza (secondPizza);
pizzaDictionary.AddPizza (thirdPizza);
Console.WriteLine($"{pizzaDictionary.Count}");

pizzaDictionary.DeletePizza(thirdPizza);
Console.WriteLine($"{pizzaDictionary.Count}");

Pizza pizzaToUpdate = new Pizza(" Calzone ", 1 , 110 );
pizzaDictionary.UpdatePizza(1, pizzaToUpdate);
pizzaDictionary.PrintPizzas();


