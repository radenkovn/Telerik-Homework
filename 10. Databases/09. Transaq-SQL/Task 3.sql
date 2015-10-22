--Create a function that accepts as parameters – sum, yearly interest rate and number of months.

--    It should calculate and return the new sum.
--    Write a SELECT to test whether the function works as expected.

CREATE FUNCTION dbo.ufn_CalcSum(@balance money, @yearlyInterest money, @months int)
  RETURNS money
AS
BEGIN
  RETURN (@balance * @months * 100 / 12 * @yearlyInterest) + @balance
END
GO

-- Example

USE PeopleHwDatabase

	SELECT p.FirstName + ' ' + p.LastName AS FullName, a.Balance as CurrentBalance, dbo.ufn_CalcSum (a.Balance, 0.05, 1) as InFiveMonths
	FROM Persons p
	JOIN Accounts a
	ON p.Id=a.PersonId