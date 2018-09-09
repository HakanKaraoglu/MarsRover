using System;

namespace Nasa.MarsRover.ErrorHandle
{
    public class DirectionError:Exception
    {
        public DirectionError(string message) : base(message)
        {

        }
    }
}
