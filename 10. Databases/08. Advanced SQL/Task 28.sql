--Write a SQL query to display the number of managers from each town.

SELECT t.Name AS Town, COUNT(DISTINCT e.ManagerID) AS ManagersCount
FROM Employees e
	JOIN Employees m ON e.ManagerID = m.ManagerID
	JOIN Addresses a ON m.AddressID = a.AddressID
	JOIN Towns t ON a.TownID = t.TownID
GROUP BY t.Name