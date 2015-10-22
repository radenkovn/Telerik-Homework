--Write a SQL query to find all departments and the average salary for each of them.
SELECT 
  d.Name AS DeptName,
  AVG(e.Salary) as Salaries
FROM Employees e 
  JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

