using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{

        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is on the move.");
        }

        public bool HasSideCart { get; set; } = true;

        public override void DriveVirtual()
        {
            Console.WriteLine("The Motorcycle takes to the streets.");
        }

    }
}

