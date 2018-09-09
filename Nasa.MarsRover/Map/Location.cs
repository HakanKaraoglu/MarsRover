namespace Nasa.MarsRover.Map
{
    public class Location
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Location(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }
    }
}
