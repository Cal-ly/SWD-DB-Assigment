-- 1. What is the average price of a room?
SELECT AVG(Price) AS AveragePrice
FROM Rooms;

-- 2. What is the average price of a single room?
SELECT AVG(Price) AS AverageSingleRoomPrice
FROM Rooms
WHERE Type = 'Enkelt';

-- 3. What is the average price of a double room?
SELECT AVG(Price) AS AverageDoubleRoomPrice
FROM Rooms
WHERE Type = 'Dobbelt';

-- 4. What is the average price of a room at "Hotel Scandic"?
SELECT AVG(r.Price) AS AveragePriceAtScandic
FROM Rooms r
JOIN Hotels h ON r.HotelID = h.HotelID
WHERE h.Name = 'Scandic Hotel';

-- 5. What is the total revenue per night for all "Dobbelt" rooms?
SELECT SUM(Price) AS TotalRevenueDobbelt
FROM Rooms
WHERE Type = 'Dobbelt';

-- 6. How many different guests have made bookings in the month of April?
SELECT COUNT(DISTINCT CustomerID) AS DistinctGuestsInApril
FROM Reservations
WHERE MONTH(CheckInDate) = 4 OR MONTH(CheckOutDate) = 4;

-- 7. How many bookings are there today at "Scandic hotel"?
SELECT COUNT(*) AS BookingsTodayAtScandic
FROM Reservations res
JOIN Rooms r ON res.RoomID = r.RoomID
JOIN Hotels h ON r.HotelID = h.HotelID
WHERE h.Name = 'Scandic Hotel'
AND CAST(GETDATE() AS DATE) BETWEEN res.CheckInDate AND res.CheckOutDate;

-- 8. How many bookings are there tomorrow at the "Scandic hotel"?
SELECT COUNT(*) AS BookingsTomorrowAtScandic
FROM Reservations res
JOIN Rooms r ON res.RoomID = r.RoomID
JOIN Hotels h ON r.HotelID = h.HotelID
WHERE h.Name = 'Scandic Hotel'
AND CAST(DATEADD(day, 1, GETDATE()) AS DATE) BETWEEN res.CheckInDate AND res.CheckOutDate;

-- 9. List all customers at Scandic Hotel in April
SELECT DISTINCT c.Name, c.Email, c.Phone
FROM Customers c
JOIN Reservations res ON c.CustomerID = res.CustomerID
JOIN Rooms r ON res.RoomID = r.RoomID
JOIN Hotels h ON r.HotelID = h.HotelID
WHERE h.Name = 'Scandic Hotel'
AND MONTH(CheckInDate) = 4 OR MONTH(CheckOutDate) = 4;

-- 10. List all rooms and their types in Scandic Hotel
SELECT r.RoomNumber, r.Type
FROM Rooms r
JOIN Hotels h ON r.HotelID = h.HotelID
WHERE h.Name = 'Scandic Hotel'
ORDER BY r.RoomNumber;
