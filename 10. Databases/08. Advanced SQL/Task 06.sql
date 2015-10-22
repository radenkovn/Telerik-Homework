--Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(e.FirstName) AS [Sales Employees Count]

FROM dbo.Employees e
JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
