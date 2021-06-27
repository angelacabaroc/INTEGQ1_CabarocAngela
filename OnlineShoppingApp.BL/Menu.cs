using System;
using OnlineShoppingApp.DL;
namespace OnlineShoppingApp.BL
{
    public class Menu
    {
        public void Menus()
        {
            ProductManagement productServices = new ProductManagement();

        START:
            Console.WriteLine("|=====================================================================================================|");
            Console.WriteLine("|                               MENU BAR                                                              |");
            Console.WriteLine("|=====================================================================================================|");
            Console.WriteLine();
            Console.WriteLine("|1| Product View");
            Console.WriteLine("|2| Product Add");
            Console.WriteLine("|3| Product Removed");
            Console.WriteLine("|4| Exit           ");
            Console.WriteLine();
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    productServices.ProductView();
                    goto START;
                case 2:
                    productServices.ProductAdd();
                    goto START;
                case 3:
                    productServices.ProductRemoved();
                    goto START;

                default:
                    break;
            }

        }
    }
}