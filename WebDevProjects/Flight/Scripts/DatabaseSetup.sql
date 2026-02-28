-- =============================================
-- Flight Search Engine - Database Setup Script
-- =============================================

-- Step 1: Create the Database
CREATE DATABASE FlightSearchDB;
GO

USE FlightSearchDB;
GO

-- =============================================
-- Step 2: Create Tables
-- =============================================

CREATE TABLE Flights (
    FlightId        INT             PRIMARY KEY IDENTITY(1,1),
    FlightName      NVARCHAR(100)   NOT NULL,
    FlightType      NVARCHAR(50)    NOT NULL,
    Source          NVARCHAR(100)   NOT NULL,
    Destination    NVARCHAR(100)   NOT NULL,
    PricePerSeat   DECIMAL(18,2)   NOT NULL
);
GO

CREATE TABLE Hotels (
    HotelId         INT             PRIMARY KEY IDENTITY(1,1),
    HotelName       NVARCHAR(100)   NOT NULL,
    HotelType       NVARCHAR(50)    NOT NULL,
    Location        NVARCHAR(100)   NOT NULL,
    PricePerDay     DECIMAL(18,2)   NOT NULL
);
GO

-- =============================================
-- Step 3: Insert Sample Data into Flights
-- =============================================

INSERT INTO Flights (FlightName, FlightType, Source, Destination, PricePerSeat) VALUES
('Air India',       'Domestic',       'Delhi',     'Mumbai',      4500.00),
('IndiGo',          'Domestic',       'Delhi',     'Bangalore',   5200.00),
('SpiceJet',        'Domestic',       'Mumbai',    'Chennai',     3800.00),
('Vistara',         'Domestic',       'Bangalore', 'Delhi',       5500.00),
('GoFirst',         'Domestic',       'Chennai',   'Delhi',       4800.00),
('Air India',       'Domestic',       'Mumbai',    'Delhi',       4600.00),
('IndiGo',          'Domestic',       'Delhi',     'Chennai',     5000.00),
('Emirates',        'International',  'Delhi',     'Dubai',       25000.00),
('Singapore Airlines','International','Mumbai',    'Singapore',   30000.00),
('British Airways', 'International',  'Delhi',     'London',      45000.00);
GO

-- =============================================
-- Step 4: Insert Sample Data into Hotels
-- (Each city has only one hotel)
-- =============================================

INSERT INTO Hotels (HotelName, HotelType, Location, PricePerDay) VALUES
('Taj Palace',          'Luxury',    'Delhi',       8000.00),
('The Oberoi',          'Luxury',    'Mumbai',      9500.00),
('ITC Grand Chola',     'Luxury',    'Chennai',     7500.00),
('The Leela Palace',    'Luxury',    'Bangalore',   8500.00),
('Jumeirah',            'Luxury',    'Dubai',       15000.00),
('Marina Bay Sands',    'Luxury',    'Singapore',   18000.00),
('The Savoy',           'Luxury',    'London',      20000.00);
GO

-- =============================================
-- Step 5: Create Stored Procedures
-- =============================================

-- SP 1: Get distinct source cities
CREATE PROCEDURE sp_GetSources
AS
BEGIN
    SET NOCOUNT ON;
    SELECT DISTINCT Source FROM Flights ORDER BY Source;
END;
GO

-- SP 2: Get distinct destination cities
CREATE PROCEDURE sp_GetDestinations
AS
BEGIN
    SET NOCOUNT ON;
    SELECT DISTINCT Destination FROM Flights ORDER BY Destination;
END;
GO

-- SP 3: Search flights only (TotalCost = PricePerSeat * @Persons)
CREATE PROCEDURE sp_SearchFlights
    @Source      NVARCHAR(100),
    @Destination NVARCHAR(100),
    @Persons     INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        FlightId,
        FlightName,
        FlightType,
        Source,
        Destination,
        (PricePerSeat * @Persons) AS TotalCost
    FROM Flights
    WHERE Source = @Source AND Destination = @Destination;
END;
GO

-- SP 4: Search flights with hotels (TotalCost = (PricePerSeat * @Persons) + (PricePerDay * @Persons))
CREATE PROCEDURE sp_SearchFlightsWithHotels
    @Source      NVARCHAR(100),
    @Destination NVARCHAR(100),
    @Persons     INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        f.FlightId,
        f.FlightName,
        f.Source,
        f.Destination,
        h.HotelName,
        ((f.PricePerSeat * @Persons) + (h.PricePerDay * @Persons)) AS TotalCost
    FROM Flights f
    INNER JOIN Hotels h ON h.Location = f.Destination
    WHERE f.Source = @Source AND f.Destination = @Destination;
END;
GO

-- =============================================
-- Step 6: Test the Stored Procedures
-- =============================================

-- Test: Get all sources
EXEC sp_GetSources;

-- Test: Get all destinations
EXEC sp_GetDestinations;

-- Test: Search flights from Delhi to Mumbai for 2 persons
EXEC sp_SearchFlights @Source = 'Delhi', @Destination = 'Mumbai', @Persons = 2;

-- Test: Search flights + hotels from Delhi to Mumbai for 2 persons
EXEC sp_SearchFlightsWithHotels @Source = 'Delhi', @Destination = 'Mumbai', @Persons = 2;
GO
