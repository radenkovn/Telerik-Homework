-- Write a SQL query to find the names of all employees whose first name starts with "SA".

SELECT e.FirstName
FROM dbo.Employees e
WHERE e.FirstName LIKE 'SA%'