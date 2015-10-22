--Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.

--    It should take the AccountId and the interest rate as parameters.


CREATE PROC dbo.usp_OneMonthInterest 
	@accountId int,
	@interestRate money
AS

	SELECT p.FirstName + ' ' + p.LastName AS FullName, a.Balance as CurrentBalance, dbo.ufn_CalcSum(a.Balance, @interestRate, 1) as InOneMonth
	FROM Persons p
	JOIN Accounts a
	ON p.Id = a.PersonId
	WHERE a.Id = @accountId
	
GO

EXEC dbo.usp_OneMonthInterest 5, 0.03
GO
