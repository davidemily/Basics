using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            //Console.WriteLine(sample1);

            uint sample2 = 58;
            //Console.WriteLine(sample2);

            int heartRate = 85;
            //Console.WriteLine(heartRate);

            double deposits = 135002796;
            //Console.WriteLine(deposits);

            float acceleration = 9.800f;
            //Console.WriteLine(acceleration);

            float mass = 14.6f;
            //Console.WriteLine(mass);

            double distance = 129.763001;
            //Console.WriteLine(distance);

            bool lost = true;
            //Console.WriteLine(lost);

            bool expensive = true;
            //Console.WriteLine(expensive);

            int choice = 2;
            //Console.WriteLine(choice);

            const char integral = '\u222B';
            //Console.WriteLine(integral);

            string greeting = "Hello";
            //Console.WriteLine(greetings);

            string name = "Karen";
            //Console.WriteLine(name);

            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }

            if (heartRate >= 40 & heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }

            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }

            float force = mass * acceleration;

            Console.WriteLine("force = " + force + " and " + distance + " is the distance.");

            if (lost & expensive)
                Console.WriteLine("I am really sorry! I will get the manager.");
            else if (lost == true & expensive)
                Console.WriteLine("Here is a coupon for 10% off.");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }

            Console.WriteLine(integral + " is an integral");

            for (int i = 5; i < 11; i++)
            {
                Console.WriteLine("i= " + i);
            }

            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = " + age);
                age++;
            }
            Console.WriteLine(greeting + " " + name);
            Console.ReadLine();
        }


    }
}
