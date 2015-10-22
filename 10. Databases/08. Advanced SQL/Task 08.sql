--Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(e.FirstName) AS [Employees Without A Manager Count]

FROM dbo.Employees e
WHERE e.ManagerID IS NULL
