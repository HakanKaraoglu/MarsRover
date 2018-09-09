using System;

namespace Nasa.MarsRover.ErrorHandle
{
    public class EntryParamsError : Exception
    {
        public EntryParamsError(string message) : base(message)
        {

        }
    }
}
