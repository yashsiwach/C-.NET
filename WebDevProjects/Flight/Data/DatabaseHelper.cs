using System.Data;
using Flight.Models;
using Microsoft.Data.SqlClient;

namespace Flight.Data;

public class DatabaseHelper
{
    private readonly string _connectionString;

    public DatabaseHelper(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
    }

    public async Task<List<string>> GetSourcesAsync()
    {
        var sources = new List<string>();

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("sp_GetSources", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            sources.Add(reader.GetString(0));
        }

        return sources;
    }

    public async Task<List<string>> GetDestinationsAsync()
    {
        var destinations = new List<string>();

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("sp_GetDestinations", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            destinations.Add(reader.GetString(0));
        }

        return destinations;
    }

    public async Task<List<FlightResult>> SearchFlightsAsync(string source, string destination, int persons)
    {
        var results = new List<FlightResult>();

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("sp_SearchFlights", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.AddWithValue("@Source", source);
        command.Parameters.AddWithValue("@Destination", destination);
        command.Parameters.AddWithValue("@Persons", persons);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(new FlightResult
            {
                FlightId = reader.GetInt32(reader.GetOrdinal("FlightId")),
                FlightName = reader.GetString(reader.GetOrdinal("FlightName")),
                FlightType = reader.GetString(reader.GetOrdinal("FlightType")),
                Source = reader.GetString(reader.GetOrdinal("Source")),
                Destination = reader.GetString(reader.GetOrdinal("Destination")),
                TotalCost = reader.GetDecimal(reader.GetOrdinal("TotalCost"))
            });
        }

        return results;
    }

    public async Task<List<FlightHotelResult>> SearchFlightsWithHotelsAsync(string source, string destination, int persons)
    {
        var results = new List<FlightHotelResult>();

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("sp_SearchFlightsWithHotels", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.AddWithValue("@Source", source);
        command.Parameters.AddWithValue("@Destination", destination);
        command.Parameters.AddWithValue("@Persons", persons);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            results.Add(new FlightHotelResult
            {
                FlightId = reader.GetInt32(reader.GetOrdinal("FlightId")),
                FlightName = reader.GetString(reader.GetOrdinal("FlightName")),
                Source = reader.GetString(reader.GetOrdinal("Source")),
                Destination = reader.GetString(reader.GetOrdinal("Destination")),
                HotelName = reader.GetString(reader.GetOrdinal("HotelName")),
                TotalCost = reader.GetDecimal(reader.GetOrdinal("TotalCost"))
            });
        }

        return results;
    }
}
