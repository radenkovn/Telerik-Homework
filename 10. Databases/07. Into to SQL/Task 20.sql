--Write a SQL query to find all employees along with their manager.

SELECT e.FirstName + ' ' + e.LastName AS FullName, m.FirstName + ' ' + m.LastName AS ManagerName
FROM dbo.Employees e, dbo.Employees m
WHERE e.ManagerID = m.EmployeeID