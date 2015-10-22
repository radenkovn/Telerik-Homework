-- Write a SQL query to find the top 5 best paid employees.

SELECT TOP 5 e.FirstName + ' ' + e.LastName AS FullName, e.Salary
FROM dbo.Employees e
ORDER BY e.Salary DESC