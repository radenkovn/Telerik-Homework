-- Write a SQL query to find the email addresses of each employee (by his first and last name). 
SELECT Employees.FirstName + '.' + Employees.LastName + '@telerik.com' AS [Full Email Adress]
FROM dbo.Employees