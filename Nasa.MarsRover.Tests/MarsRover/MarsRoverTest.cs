using FluentAssertions;
using Nasa.MarsRover.Map;
using Xunit;

namespace Nasa.MarsRover.Tests.MarsRover
{
     
    public class MarsRoverTest
    {
        [Theory]
        [MemberData(nameof(GetRovers))]
        public void mars_rover_move_tests_and_position_test(string startPosition, string moves, string endPosition)
        {
            Vehicle.MarsRover marsRoverVehicle = new Vehicle.MarsRover(startPosition);
            marsRoverVehicle.Move(moves);

            var position = new PositionFactory().Create(endPosition);
            marsRoverVehicle.GetPosition().Location.XCoordinate.Should().Be(position.Location.XCoordinate);
            marsRoverVehicle.GetPosition().Location.YCoordinate.Should().Be(position.Location.YCoordinate);
            marsRoverVehicle.GetPosition().Direction.Should().Be(position.Direction);
        }

        public static System.Collections.Generic.IEnumerable<object[]> GetRovers()
        {
            return new[]
            {
                new object[] {"1 2 N", "LMLMLMLMM", "1 3 N"},
                new object[] {"3 3 E", "MMRMMRMRRM", "5 1 E"}
            };
        }
    }
}