using System;
using System.Collections.Generic;
using Nasa.MarsRover.ErrorHandle;

namespace Nasa.MarsRover.Map
{
    public class PositionFactory
    {
        private int _x, _y;
        private readonly List<string> _validDirections = new List<string>() { "E", "N", "W", "S" };

        public Position Create(string initialLocation)
        {
            var entryDirection = initialLocation.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (entryDirection.Length == 3)
            {
                var xCoordinate = entryDirection[0];
                _x = AxisSeperation(xCoordinate, "X");

                var yCoordinate = entryDirection[1];
                _y = AxisSeperation(yCoordinate, "Y");

                var direction = entryDirection[2];

                var location = new Location(_x, _y);

                if (!char.IsLetter(direction[0]))
                {
                    throw new EntryParamsError($"The direction is not a char type value");
                }

                if (!_validDirections.Contains(direction))
                {
                    throw new DirectionError($"Invalid direction");
                }

                return new Position(location, direction);
            }

            throw new EntryParamsError("Error Parameters ");
        }


        private int AxisSeperation(string @string, string axis)
        {
            int x;
            var parser = int.TryParse(@string, out x);
            if (parser) return x;
            throw new LocationError($"The Location not found");
        }
    }
}