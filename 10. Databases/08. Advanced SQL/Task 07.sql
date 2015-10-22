--Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(e.FirstName) AS [Employees With A Manager Count]

FROM dbo.Employees e
WHERE e.ManagerID IS NOT NULL
