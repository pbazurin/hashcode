using OptimizeDataCenter.Models;
using System;

namespace TaskTemplate.Models
{
    public class InputDataParser
    {
        public InputData GetParsedModel(string input)
        {
            var result = new InputData();

            var lines = input.Split('\n');
            var firstLineValues = lines[0].Split(' ');

            result.RowsNumber = Int32.Parse(firstLineValues[0]);
            result.SlotsNumber = Int32.Parse(firstLineValues[1]);
            result.UnavailableSlotsNumber = Int32.Parse(firstLineValues[2]);
            result.PoolsNumber = Int32.Parse(firstLineValues[3]);
            result.ServersNumber = Int32.Parse(firstLineValues[4]);

            for (var i = 1; i < result.UnavailableSlotsNumber + 1; i++)
            {
                var unavailableSlotCoordinate = lines[i].Split(' ');

                result.UnavailableSlots.Add(new Coordinate
                {
                    RowNumber = Int32.Parse(unavailableSlotCoordinate[0]),
                    SlotNumber = Int32.Parse(unavailableSlotCoordinate[1])
                });
            }

            var serverId = 0;

            for (var i = result.UnavailableSlotsNumber + 1;
                i < result.ServersNumber + result.UnavailableSlotsNumber + 1;
                i++)
            {
                var serverCoordinate = lines[i].Split(' ');

                result.Servers.Add(new Server
                {
                    Id = serverId,
                    Size = Int32.Parse(serverCoordinate[0]),
                    Capacity = Int32.Parse(serverCoordinate[1])
                });

                serverId++;
            }

            return result;
        }
    }
}
