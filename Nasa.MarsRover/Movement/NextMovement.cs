using Nasa.MarsRover.Map;
using Nasa.MarsRover.Movement.Base;

namespace Nasa.MarsRover.Movement
{
    public class NextMovement : IDirective
    {
        private Location _location = null;
        private string _direction = string.Empty;
        public Position Process(Position position)
        {
            _direction = position.Direction;

            switch (position.Direction)
            {
                case "E":
                    _location = new Location(position.Location.XCoordinate + 1, position.Location.YCoordinate);
                    break;
                case "W":
                    _location = new Location(position.Location.XCoordinate - 1, position.Location.YCoordinate);
                    break;
                case "N":
                    _location = new Location(position.Location.XCoordinate, position.Location.YCoordinate + 1);
                    break;
                case "S":
                    _location = new Location(position.Location.XCoordinate, position.Location.YCoordinate - 1);
                    break;
            }

            return new Position(_location, _direction);
        }
    }
}
