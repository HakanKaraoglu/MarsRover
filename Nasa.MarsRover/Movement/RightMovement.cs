﻿using Nasa.MarsRover.Map;
using Nasa.MarsRover.Movement.Base;

namespace Nasa.MarsRover.Movement
{
    public class RightMovement : IDirective
    {
        private string _direction = string.Empty;
        public Position Process(Position position)
        {
            switch (position.Direction)
            {
                case "E":
                    _direction = "S";
                    break;

                case "S":
                    _direction = "W";
                    break;

                case "W":
                    _direction = "N";
                    break;

                case "N":
                    _direction = "E";
                    break;
            }

            return new Position(position.Location, _direction);
        }
    }
}