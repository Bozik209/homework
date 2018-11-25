using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            //2.1
            car car1=new car();
            car1.color="Red";
            car1.model = "Toyota";
            car1.speed = 100;

            //2.2
            Console.WriteLine($"car 1 \ncolor {car1.color}\nmodel {car1.model}\nspeed {car1.speed}Kmh");
            Console.WriteLine("------------------");
            //2.3
            Console.WriteLine("you like to add speed prees 1\nor down speed prees 2");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice==1)
            {
                Console.WriteLine("how much?");
                car1.speed += choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------");
            }
            if (choice==2)
            {
                Console.WriteLine("how much?");
                car1.speed -= choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------");
            }
            //2.4
            Console.WriteLine($"car 1 \ncolor {car1.color}\nmodel {car1.model}\nspeed {car1.speed}Kmh");
            Console.WriteLine("------------------");
            //2.5
            car1.speed -= 2;
            //2.6
            Console.WriteLine($"car 1 \ncolor {car1.color}\nmodel {car1.model}\nspeed {car1.speed}Kmh");
            Console.WriteLine("------------------");
            //2.7.
            Console.WriteLine("car stop");
            car1.speed= 0;
            Console.WriteLine($"car 1 \ncolor {car1.color}\nmodel {car1.model}\nspeed {car1.speed}Kmh");
            Console.WriteLine("------------------");

        }
    }
}
