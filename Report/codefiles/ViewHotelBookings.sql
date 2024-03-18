CREATE VIEW HotelBookings AS
SELECT 
    h.Name AS HotelName,
    r.Type AS RoomType,
    res.CheckInDate,
    res.CheckOutDate,
    res.Status AS BookingStatus,
    c.Name AS CustomerName,
    c.Email AS CustomerEmail,
    c.Phone AS CustomerPhone
FROM 
    Hotels h
JOIN 
    Rooms r ON h.HotelID = r.HotelID
JOIN 
    Reservations res ON r.RoomID = res.RoomID
JOIN 
    Customers c ON res.CustomerID = c.CustomerID;
