-- Insert mock data into Hotels
INSERT INTO Hotels (Name, Location, Rating) VALUES
('Sunrise Retreat', '123 Ocean View, Beach City', 5),
('Mountain Escape', '456 Highland Ave, Mountain Town', 4),
('Urban Hotel', '789 City Center Blvd, Metro City', 4);

-- Insert mock data into Customers
INSERT INTO Customers (Name, Email, Phone) VALUES
('John Doe', 'john.doe@example.com', '555-0101'),
('Jane Smith', 'jane.smith@example.com', '555-0102'),
('Carlos Johnson', 'carlos.j@example.com', '555-0103');

-- Insert mock data into Rooms
INSERT INTO Rooms (HotelID, RoomNumber, Type, Price) VALUES
(1, '101', 'Single', 100.00),
(1, '102', 'Double', 150.00),
(2, '201', 'Suite', 250.00),
(3, '301', 'Double', 150.00);

-- Insert mock data into Reservations
INSERT INTO Reservations (CustomerID, RoomID, CheckInDate, CheckOutDate, Status) VALUES
(1, 1, '2024-04-01', '2024-04-05', 'Confirmed'),
(2, 2, '2024-04-10', '2024-04-12', 'Confirmed'),
(3, 3, '2024-05-01', '2024-05-03', 'Confirmed');

-- Insert mock data into Facilities
INSERT INTO Facilities (Name, Description) VALUES
('Swimming Pool', 'Outdoor pool with sun loungers and bar service'),
('Spa', 'Full-service spa offering massages, facials, and body treatments'),
('Gym', '24/7 access to fitness equipment and free weights');

-- Insert mock data into HotelFacilities
INSERT INTO HotelFacilities (HotelID, FacilityID) VALUES
(1, 1),
(1, 2),
(2, 3),
(3, 1),
(3, 2),
(3, 3);
