--Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department. 

SELECT e.FirstName + ' '+ e.LastName as FullName, e.Salary, d.Name
FROM dbo.Employees e
JOIN dbo.Departments d ON e.DepartmentID = d.DepartmentID
WHERE e.Salary =
  (SELECT MIN(Salary) FROM Employees 
   WHERE DepartmentID = e.DepartmentID)