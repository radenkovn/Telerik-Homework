--Write a SQL query to display the town where maximal number of employees work.

SELECT TOP 1 t.Name AS Town, COUNT(e.EmployeeID) AS EmployeesCount
FROM Employees e
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY COUNT(e.EmployeeID) DESC