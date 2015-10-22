-- Write a SQL query to find all employees that do not have manager.

SELECT e.FirstName + ' ' + e.LastName AS FullName
FROM dbo.Employees e
WHERE e.ManagerID IS NULL