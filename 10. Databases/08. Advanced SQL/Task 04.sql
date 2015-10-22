--Write a SQL query to find the average salary in the department #1.

SELECT
  AVG(Salary) [Average Salary]
  
  FROM dbo.Employees e
  WHERE e.DepartmentID = 1