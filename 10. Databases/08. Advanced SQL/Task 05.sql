-- Write a SQL query to find the average salary in the "Sales" department.

SELECT AVG(e.Salary) AS [Average Sales Salary]

FROM dbo.Employees e
JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
