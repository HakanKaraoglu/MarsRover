using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Initial Position");
            var initialPosition = Console.ReadLine();

            Console.WriteLine("Please Enter Moves");
            var moves = Console.ReadLine();

            var marsRover = new MarsRover(initialPosition);
            marsRover.Move(moves);

            Console.WriteLine(
                "Direction :" + marsRover.GetPosition().Direction +
                "\nLocation X:" + marsRover.GetPosition().Location.XCoordinate +
                "\nLocation Y:" + marsRover.GetPosition().Location.YCoordinate
                );


            Console.ReadKey();
        }

        public static object[] GetRoversInitial()
        {
            return new object[]
            {
                new object[] {"1 2 N",1,2,"N"},
                new object[] {"5 7 W",5,7,"W"},
                new object[] {"4 9 S",4,9,"S"},
                new object[] {"3 3 E",3,3,"E"}
            };
        }
    }
}
