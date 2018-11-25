using System;
namespace ConsoleApp10
{
    class cookie
    {
        public int gluten = 12;
        public int egg = 11;
        public int sugar = 13;
        public int flour = 14;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, choice = 0;
            cookie cookie1 = new cookie(), cookie2 = new cookie(), cookie3 = new cookie();
            while (choice != 999)
            {
                Console.WriteLine("what you like to do? \n1)fill \n2)print \n3)update sugar on cookie1  \n4)Placement from first to second  \n5)update egg on cookie2 \nfor Exit 99");
                Console.WriteLine("------------------------");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    fill(cookie1, cookie2);
                }
                if (choice == 2)
                {
                    Console.WriteLine("which cookie you want to print? (1/2) \nfor print all enter (3)");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num == 1)
                    {
                        PrintCooke(cookie1);
                    }
                    if (num == 2)
                    {
                        PrintCooke(cookie2);
                    }
                    if (num == 3)
                    {
                        PrintAllCooke(cookie1, cookie2);
                    }
                }
                if (choice == 3)
                {
                    update_suger(cookie1);
                }
                if (choice==4)
                {
                    Placement(cookie1, cookie2);
                }
                if (choice==5)
                {
                    update_egg(cookie2);
                }
                if (choice == 99 )
                {
                    Console.WriteLine("Good day");
                    break;
                }
                choice = 0;
                System.Console.ReadKey();
                Console.Clear();
            }

        }
        static void fill(cookie cookie1, cookie cookie2)
        {
            Console.WriteLine("Enter a quantity of ingredients for coockie 1: (in grams)");
            Console.WriteLine("gluten:");
            cookie1.gluten = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("egg:");
            cookie1.egg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sugar:");
            cookie1.sugar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("flour:");
            cookie1.flour = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($" gluten:{cookie1.gluten} \n egg: {cookie1.egg} \n sugar: {cookie1.sugar} \n flour: {cookie1.flour } ");


            Console.WriteLine("Enter a quantity of ingredients for coockie 2: (in grams)");
            Console.WriteLine("gluten:");
            cookie2.gluten = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("egg:");
            cookie2.egg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sugar:");
            cookie2.sugar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("flour:");
            cookie2.flour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" gluten:{cookie2.gluten} \n egg: {cookie2.egg} \n sugar: {cookie2.sugar} \n flour: {cookie2.flour } ");
        }

        static void PrintCooke(cookie cookie)
        {
            Console.WriteLine($"Gluten:  |  {cookie.gluten}");
            Console.WriteLine($"Egg:     |  {cookie.egg}");
            Console.WriteLine($"Sugar:   |  {cookie.sugar}");
            Console.WriteLine($"Flour:   |  {cookie.flour } ");
        }

        static void PrintAllCooke(cookie cookie1, cookie cookie2)
        {
            Console.WriteLine("cookie 1:");
            Console.WriteLine($"Gluten:  |  {cookie1.gluten}");
            Console.WriteLine($"Egg:     |  {cookie1.egg}");
            Console.WriteLine($"Sugar:   |  {cookie1.sugar}");
            Console.WriteLine($"Flour:   |  {cookie1.flour } ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("cookie 2:");
            Console.WriteLine($"Gluten:  |  {cookie2.gluten}");
            Console.WriteLine($"Egg:     |  {cookie2.egg}");
            Console.WriteLine($"Sugar:   |  {cookie2.sugar}");
            Console.WriteLine($"Flour:   |  {cookie2.flour } ");
        }

        static void update_suger(cookie cookie1)
        {
            Console.WriteLine("update sugar on cookie1");
            cookie1.sugar= Convert.ToInt32(Console.ReadLine());
        }

        static void Placement(cookie cookie1, cookie cookie2)
        {
            cookie2.egg = cookie1.egg;
            cookie2.flour= cookie1.flour;
            cookie2.gluten= cookie1.gluten;
            cookie2.sugar = cookie1.sugar;
        }

        static void update_egg(cookie cookie2)
        {
            Console.WriteLine("update egg on cookie2");
            cookie2.egg= Convert.ToInt32(Console.ReadLine());
        }

    }
}
