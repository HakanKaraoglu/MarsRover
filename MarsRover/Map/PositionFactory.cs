using System;
using System.Collections.Generic;

namespace MarsRover.Map
{
    public class PositionFactory
    {
        private const string _entryNotCharError = "direction is not char type input : '{0}'";
        private const string _notValidDirectionError = "invalid direction : '{0}'";
        private const string _errorParams = "error parameters";
        private const string _locationNotFound = "Location not found '{0}':'{1}'";
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
                    throw new Exception(string.Format(_entryNotCharError, direction));
                }

                if (!_validDirections.Contains(direction))
                {
                    throw new Exception(string.Format(_notValidDirectionError, direction));
                }

                return new Position(location, direction);
            }

            throw new Exception(_errorParams);
        }


        private int AxisSeperation(string @string, string axis)
        {
            int x;

            var parser = int.TryParse(@string, out x);
            if (!parser)
            {
                throw new Exception(string.Format(_locationNotFound, axis, @string));
            }

            return x;
        }
    }
}