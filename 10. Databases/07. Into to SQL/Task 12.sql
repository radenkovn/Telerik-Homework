-- Write a SQL query to find the names of all employees whose last name contains "ei".

SELECT e.LastName
FROM dbo.Employees e
WHERE e.LastName LIKE '%EI%'