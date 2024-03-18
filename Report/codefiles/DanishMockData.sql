-- Delete all records
DELETE FROM Reservations;
DELETE FROM HotelFacilities;
DELETE FROM Rooms;
DELETE FROM Facilities;
DELETE FROM Customers;
DELETE FROM Hotels;

-- This resets all Identity to O, so the next entry is 1
DBCC CHECKIDENT ('Hotels', RESEED, 0);
DBCC CHECKIDENT ('Customers', RESEED, 0);
DBCC CHECKIDENT ('Rooms', RESEED, 0);
DBCC CHECKIDENT ('Reservations', RESEED, 0);
DBCC CHECKIDENT ('Facilities', RESEED, 0);
DBCC CHECKIDENT ('HotelFacilities', RESEED, 0);

-- Insert mock data into Hotels
INSERT INTO Hotels (Name, Address, City, PostalCode, Rating) VALUES
('Scandic Hotel', 'Ved Ringen 2', 'Roskilde', '4000', 5),
('Bjergflugt', 'Højlandet Alle 34', 'Bjergby', '3400', 4),
('Byhotel', 'Centrum Boulevard 56', 'Storby', '4500', 4);

-- Insert mock data into Customers
INSERT INTO Customers (Name, Email, Phone) VALUES
('Jens Hansen', 'jens.hansen@example.com', '10203040'),
('Mette Nielsen', 'mette.nielsen@example.com', '40506070'),
('Lars Andersen', 'lars.andersen@example.com', '70809010'),
('Lars Larsen', 'lars.larsen@mail.com', '10405060'),
('Laila Larsen', 'laila.larsen@mail.com', '40302010');

-- Insert mock data into Rooms
INSERT INTO Rooms (HotelID, RoomNumber, Type, Price) VALUES
(1, '101', 'Enkelt', 750.00),
(1, '102', 'Dobbelt', 1125.00),
(1, '103', 'Suite', 1875.00),
(2, '101', 'Enkelt', 750.00),
(2, '102', 'Dobbelt', 1125.00),
(2, '103', 'Suite', 1875.00),
(3, '101', 'Enkelt', 750.00),
(3, '102', 'Dobbelt', 1125.00),
(3, '103', 'Suite', 1875.00);

-- Insert mock data into Reservations
INSERT INTO Reservations (CustomerID, RoomID, CheckInDate, CheckOutDate, Status) VALUES
(1, 1, '2024-04-01', '2024-04-05', 'Bekræftet'),
(2, 2, '2024-04-10', '2024-04-12', 'Bekræftet'),
(3, 3, '2024-05-01', '2024-05-03', 'Bekræftet'),
(4, 5, '2024-05-24', '2024-05-26', 'Bekræftet'),
(5, 9, '2024-05-24', '2024-05-26', 'Bekræftet');

-- Insert mock data into Facilities
INSERT INTO Facilities (Name, Description) VALUES
('Svømmepøl', 'Udendørs pool med liggestole og bar service'),
('Spa', 'Fuld-service spa der tilbyder massage, ansigtsbehandlinger, og kropsbehandlinger'),
('Fitnessrum', '24/7 adgang til træningsudstyr og frie vægte'),
('Børnebasin', 'Udendørs børnepool med legetøj'),
('Bar', 'All inclusive bar med stort udvalg'),
('Wellness Area', 'Med spa og haram');

-- Insert mock data into HotelFacilities
INSERT INTO HotelFacilities (HotelID, FacilityID) VALUES
(1, 1),
(1, 2),
(2, 3),
(2, 4),
(3, 5),
(3, 6);