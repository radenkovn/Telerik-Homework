--Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

SELECT e.FirstName + ' ' + e.LastName AS EmployeeName, d.Name, e.HireDate
FROM dbo.Employees e
JOIN dbo.Departments d
ON e.DepartmentID = d.DepartmentID
WHERE (d.Name = 'Sales' OR d.Name = 'Finance') AND (e.HireDate BETWEEN '1995-01-01' AND '2005-12-12')
