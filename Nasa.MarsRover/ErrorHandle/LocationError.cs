using System;

namespace Nasa.MarsRover.ErrorHandle
{
    public class LocationError : Exception
    {
        public LocationError(string message) : base(message)
        {
            
        }
    }
}
