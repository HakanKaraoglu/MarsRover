namespace MarsRover.Map
{
    public class Position
    {
        public Location Location;
        public string Direction;

        public Position(Location location, string direction)
        {
            Location = location;
            this.Direction = direction;
        }
    }
}
