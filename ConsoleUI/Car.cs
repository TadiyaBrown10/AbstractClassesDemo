using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		

        public override void DriveAbstract()
        {
            Console.WriteLine("This car is on the road.");
        }

        public bool Hastrunk { get; set; } = true;
    }
}

