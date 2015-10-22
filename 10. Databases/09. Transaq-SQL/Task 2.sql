--Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.

CREATE PROC dbo.usp_GetPeopleWithMoreMoney (@money money)
AS
	SELECT p.FirstName + ' ' + p.LastName AS FullName, a.Balance
	FROM Persons p
	JOIN Accounts a
	ON p.Id=a.PersonId
	WHERE a.Balance > @money
GO

--Sample usage
EXEC dbo.usp_GetPeopleWithMoreMoney 100000