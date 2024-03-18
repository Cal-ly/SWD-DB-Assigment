-- Hotels
CREATE TABLE Hotels (
    HotelID INT IDENTITY (1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Address NVARCHAR(100),
	City NVARCHAR(50),
	PostalCode VARCHAR(10),
    Rating INT
);

-- Customers
CREATE TABLE Customers (
    CustomerID INT IDENTITY (1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Email VARCHAR(100),
    Phone VARCHAR(15)
);

-- Rooms
CREATE TABLE Rooms (
    RoomID INT IDENTITY (1,1) PRIMARY KEY,
    HotelID INT,
    RoomNumber VARCHAR(10),
    Type VARCHAR(50),
    Price DECIMAL(10, 2),
    FOREIGN KEY (HotelID) REFERENCES Hotels(HotelID)
);

-- Reservations
CREATE TABLE Reservations (
    ReservationID INT IDENTITY (1,1) PRIMARY KEY,
    CustomerID INT,
    RoomID INT,
    CheckInDate DATE,
    CheckOutDate DATE,
    Status VARCHAR(50),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
);

-- Facilities
CREATE TABLE Facilities (
    FacilityID INT IDENTITY (1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Description TEXT
);

-- HotelFacilities
CREATE TABLE HotelFacilities (
    HotelFacilityID INT IDENTITY (1,1) PRIMARY KEY,
    HotelID INT,
    FacilityID INT,
    FOREIGN KEY (HotelID) REFERENCES Hotels(HotelID),
    FOREIGN KEY (FacilityID) REFERENCES Facilities(FacilityID)
);