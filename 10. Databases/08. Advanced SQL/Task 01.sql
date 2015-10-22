--Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.

SELECT FirstName + ' '+ LastName as FullName, Salary
FROM Employees
WHERE Salary = 
  (SELECT MIN(Salary) FROM Employees)