--Write a SQL to find the full name of each employee.
SELECT Employees.FirstName + ' ' + Employees.LastName AS FullName
FROM dbo.Employees