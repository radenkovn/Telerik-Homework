--Write a SQL query to find the count of all employees in each department and for each town.

SELECT 
  d.Name AS DeptName,
  COUNT(e.EmployeeID) as [Employees Count]
FROM Employees e 
  JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

SELECT 
  t.Name AS TownName,
  COUNT(e.EmployeeID) AS [Employees Count]
FROM Employees e 
JOIN Addresses a ON e.AddressID = a.AddressID
JOIN Towns t ON t.TownID = a.TownID
GROUP BY t.Name
