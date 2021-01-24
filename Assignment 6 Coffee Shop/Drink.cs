using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_Coffee_Shop
{
    class Drink
    {
        private string name;
        private bool Sold;
        private int price;

        public static int NumberOfDrinksSold = 0;

        public Drink(string name, int price)
        {

            this.name = name;
            this.Sold = false;
            this.price = price;

            
        }

        public void BuyDrink()
        {
            if (Sold == false)
            {
                Sold = true;
                NumberOfDrinksSold = NumberOfDrinksSold + 1;

            }
        }
    }
}

