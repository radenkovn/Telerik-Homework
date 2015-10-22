--Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.

SELECT LastName, LEN(LastName) AS LastNameLength
FROM Employees
WHERE LEN(LastName) = 5