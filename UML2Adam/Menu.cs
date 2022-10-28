using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace UML2Adam
//Skal få menuen til at virke...
//{
//    public class Menu
//    {
//        private PizzaDictionary _PizzaDictionary;
//        public Menu(PizzaDictionary PizzaDictionary)
//        {
//            _PizzaDictionary = PizzaDictionary;
//        }

//        public int ReadUserChoice()
//        {
//            string choice = Console.ReadLine();
//            int input = -1;
//            if (int.TryParse(choice, out input))
//            {
//                return input;
//            }
//            else
//            {
//                return -1;
//            }
//        }

//        public int ShowMenu()
//        {
//            Console.Clear();
//            Console.WriteLine("\t1.\tVælge ordre fra id");
//            Console.WriteLine("\t2.\tSe alle pizzaer");
//            Console.WriteLine("\t3.\tSlet din ordre");
//            Console.WriteLine("\t4.\tSøg efter pizza ud fra id");
//            Console.Write("\tIndtast dit valg:");
//            return ReadUserChoice();
//        }

//        public void Run()
//        {
//            int options = ShowMenu();
//            while (options != 0)
//            {
//                switch (options)
//                {
//                    case 1:
//                        Console.Clear();
                       
//                        AddPizzaDictionary();
//                        break;
//                    case 2: 
//                        Console.Clear();
//                        pizzaDictonary.PrintPizzas();
//                        break;
//                    case 3: 
//                        Console.Clear();
//                        SearchPizzaDictionary();
//                        break;
//                    case 4:
//                        Console.Clear();
                        
//                        DeletePizzaDictionary();
//                        break;
                 
//                    default:
//                        Console.Clear();
//                        Console.WriteLine("Fejl i input");
//                        break;
//                }
//                Console.ReadLine();
//                Console.Clear();
//                options = ShowMenu();

//            }

//        }
//    }
//}
