-- Write a SQL query to find all employees along with their address. Use inner join with ON clause.

SELECT e.FirstName + ' ' + e.LastName AS FullName, a.AddressText
FROM dbo.Employees e
INNER JOIN dbo.Addresses a
ON e.AddressID=a.AddressID