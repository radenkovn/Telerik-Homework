-- Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

SELECT e.FirstName + ' ' + e.LastName AS FullName
FROM dbo.Employees e
WHERE e.Salary = 25000 OR e.Salary = 14000 OR e.Salary = 12500 OR e.Salary = 23600