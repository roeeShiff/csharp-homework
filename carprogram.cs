using System;


namespace HomeworkLession5
{
    class Program2
    {
        static void Main(string[] args)
        {
            //Create new car
            Car car1 = new Car();
            //Show the info about the new car that i create
            Console.WriteLine("car info:");
            Console.WriteLine(car1.GetDescription());
            Console.WriteLine("what speed fo you want to car to drive?");
            car1.Speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"You are driving:{car1.Speed}-kmh");
            Console.ReadLine();
            // Show the info after the car slowdown by 2 kmh 
            car1.Speed -= 2;
            car1.SlowDown = 2;
            Console.WriteLine($"car slowed down by {car1.speed} kmh");
            Console.ReadLine();
            Console.WriteLine($"You slow your speed by:{car1.SlowDown}-kmh\n");
            Console.WriteLine(car1.GetDescription());
            car1.Speed = 0;
            car1.SlowDown = 0;
            car1.Stop = true;
            Console.ReadLine();
            Console.WriteLine("the car has stopped");
            Console.WriteLine(car1.GetDescription());
        }
    }
}
