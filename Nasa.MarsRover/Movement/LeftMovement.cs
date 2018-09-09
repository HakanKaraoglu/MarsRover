using Nasa.MarsRover.Map;
using Nasa.MarsRover.Movement.Base;

namespace Nasa.MarsRover.Movement
{
    //Can be used in Strategy Pattern instead of Switch-Case.
    //Switch-Case yerine Strategy Pattern de kullanılabilir.

    public class LeftMovement : IDirective
    {
        private string _direction = string.Empty;
        public Position Process(Position position)
        {
            switch (position.Direction)
            {
                case "S":
                    _direction = "E";
                    break;

                case "N":
                    _direction = "W";
                    break;

                case "E":
                    _direction = "N";
                    break;

                case "W":
                    _direction = "S";
                    break;
            }

            return new Position(position.Location, _direction);
        }
    }
}