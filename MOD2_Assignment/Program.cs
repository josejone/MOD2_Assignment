using System;

namespace MOD2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] brands = { "Nike", "Adidas", "Under Armour", "Gucci", "Levi's", "GAP", "North Face", "Old Navy", "Chanel", "Valentino" };
            Console.WriteLine(brands[1]);
            Console.WriteLine(brands[5]);
            Console.WriteLine(brands[7]);
            Console.WriteLine(brands[9]);
            for (int i = 0; i < brands.Length; i++)
            {
                Console.WriteLine(brands[i]);

            }

            int[] modelyear = { 1991, 1993, 1994, 1996, 1998, 2000, 2002, 2004, 2006, 2007 };
            Console.WriteLine(modelyear[1]);
            Console.WriteLine(modelyear[5]);
            Console.WriteLine(modelyear[7]);
            Console.WriteLine(modelyear[9]);
            for (int i = 0; i < modelyear.Length; i++)
            {
               Console.WriteLine(modelyear[i]);
            }

            double[] price = { 35.00, 40.00, 12.00, 13.50, 55.50, 110.00, 70.00, 80.00, 100.00, 10.00 };
            Console.WriteLine(price[1]);
            Console.WriteLine(price[5]);
            Console.WriteLine(price[7]);
            Console.WriteLine(price[9]);
            for(int i = 0; i < price.Length; i++)
            {

                Console.WriteLine(price[i]);
            }
        }













    }
}    

