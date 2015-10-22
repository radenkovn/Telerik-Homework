-- Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

SELECT e.Salary
FROM dbo.Employees e
WHERE e.Salary >= 20000 AND e.Salary <= 30000