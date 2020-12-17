namespace SwissTransport.Core
{
    using System.Threading.Tasks;
    using System;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id);

        Connections GetConnections(string fromStation, string toStation, int isArrivalTime, DateTime date, DateTime time, int limit);
    }
}