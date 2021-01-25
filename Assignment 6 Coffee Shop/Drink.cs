using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_Coffee_Shop
{
    class Drink
    {
        private string name; //tea coffee  juice
        private int price;   //45   50      35

        public Drink(string name, int price)
        {
            this.name = name;
            if (name == "Coffee") price = 50;
            if (name == "Tea") price = 45;
            if (name == "Juice") price = 35;


        }
        public string GetName()
        {
            return name;
        }
        public int GetPrice()
        {
            return price;
        }
    }
}

