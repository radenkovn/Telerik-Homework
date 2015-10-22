--Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney(AccountId, money) that operate in transactions.


SELECT * FROM Accounts
GO


-- WithDraw
CREATE PROC dbo.usp_WithDrawMoney
(@accountId int, @withDrawMoney money)
AS 
UPDATE Accounts
SET Balance = Balance - @withDrawMoney
WHERe Id = @accountId
GO

EXECUTE dbo.usp_WithDrawMoney 3,504.5
SELECT * FROM Accounts
GO


-- Deposit

CREATE PROC dbo.usp_DepositMoney
(@accountId int, @depositMoney money)
AS 
UPDATE Accounts
SET Balance = Balance + @depositMoney
WHERe Id = @accountId
GO

EXECUTE dbo.usp_DepositMoney 3,504.5
SELECT * FROM Accounts
GO