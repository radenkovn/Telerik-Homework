-- Write a SQL query to find all employees along with their managers.
-- For employees that do not have manager display the value "(no manager)".

SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name], 
		ISNULL(m.FirstName + ' ' + m.LastName, '(no manager)') AS [Manager Full Name]
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID