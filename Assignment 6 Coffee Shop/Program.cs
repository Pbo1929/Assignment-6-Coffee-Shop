using System;

namespace Assignment_6_Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink[] drinks = new Drink[10];

            drinks[0] = new Drink("Coffee", 50);
            drinks[1] = new Drink("Tea", 45);
            drinks[2] = new Drink("Juice", 30);
            drinks[3] = new Drink("Coffee", 50);

            int count = 0;
            int total = 0;

            int countOfCoffee = 0;
            int countOfJuice = 0;
            int countOfTea = 0;
            for(int i = 0; i < drinks.Length; i++)
            {
                if (drinks[i] != null)
                {
                    Console.WriteLine(drinks[i].GetName() + drinks[i].GetPrice());
                    count = count + 1;
                    total = total + drinks[i].GetPrice();
                    if (drinks[i].GetName() == "Coffee")
                    {
                        countOfCoffee++;
                    }
                    if (drinks[i].GetName() == "Tea")
                    {
                        countOfTea++;
                    }
                    if (drinks[i].GetName() == "Juice")
                    {
                        countOfJuice++;
                    }
                }
            }
            Console.WriteLine("DRINKS SOLD:" + count);
            Console.WriteLine("TOTAL:" + total);
            int drinksleft = drinks.Length - count;
            Console.WriteLine("STOCK REMAINING:" + drinksleft);
            Console.WriteLine("COFFEES SOLD:" + countOfCoffee);
            Console.WriteLine("JUICE SOLD:" + countOfJuice);
            Console.WriteLine("TEA SOLD:" + countOfTea);
        }
    }
}
