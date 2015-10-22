--Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.

SELECT d.Name AS DepartmentName, e.JobTitle, MIN(e.Salary) AS [Minimum Employee Salary]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle