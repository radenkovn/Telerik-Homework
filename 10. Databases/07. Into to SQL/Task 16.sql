-- Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

SELECT e.FirstName + ' ' + e.LastName AS FullName, e.Salary
FROM dbo.Employees e
WHERE e.Salary > 50000
ORDER BY e.Salary DESC