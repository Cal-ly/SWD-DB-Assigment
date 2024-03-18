CREATE VIEW HotelsWithFacilities AS
SELECT 
    h.HotelID,
    h.Name AS HotelName,
    f.FacilityID,
    f.Name AS FacilityName,
    f.Description
FROM 
    Hotels h
JOIN 
    HotelFacilities hf ON h.HotelID = hf.HotelID
JOIN 
    Facilities f ON hf.FacilityID = f.FacilityID;

SELECT * FROM HotelsWithFacilities;