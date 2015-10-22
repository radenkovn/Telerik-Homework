--Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.

SELECT e.FirstName + ' ' + e.LastName AS FullName, m.FirstName + ' ' + m.LastName AS ManagerName, a.AddressText AS Address
FROM dbo.Employees e
JOIN dbo.Employees m ON e.ManagerID = m.EmployeeID
JOIN dbo.Addresses a ON e.AddressID = a.AddressID