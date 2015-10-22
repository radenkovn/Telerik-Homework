--Create another table – Logs(LogID, AccountID, OldSum, NewSum).

--    Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.


USE PeopleHwDatabase

CREATE TABLE Logs(
	Id INT IDENTITY NOT NULL PRIMARY KEY,
	AccountId int FOREIGN KEY REFERENCES Accounts(Id),
	OldSum money,
	NewSum money 
)

--The trigger

CREATE TRIGGER tr_BalanceChanged ON Accounts
FOR UPDATE
AS

DECLARE @accountId int
DECLARE @oldSum money 
DECLARE @newSum money 
SELECT @accountId =  Id FROM inserted
SELECT @oldSum =  Balance FROM deleted
SELECT @newSum =  Balance FROM inserted

IF(@oldSum <> @newSum)
	BEGIN
	  INSERT INTO Logs (AccountId, OldSum, NewSum)
	  VALUES(@accountId, @oldSum, @newSum)
	END
GO