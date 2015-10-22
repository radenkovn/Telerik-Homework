--Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. 
--Use right outer join. Rewrite the query to use left outer join.

SELECT e.FirstName + ' ' + e.LastName AS EmployeeName, m.FirstName + ' ' + m.LastName AS ManagerName
FROM dbo.Employees e
RIGHT OUTER JOIN dbo.Employees m
ON e.ManagerID = m.EmployeeID

SELECT e.FirstName + ' ' + e.LastName AS EmployeeName, m.FirstName + ' ' + m.LastName AS ManagerName
FROM dbo.Employees m
LEFT OUTER JOIN dbo.Employees e
ON e.ManagerID = m.EmployeeID