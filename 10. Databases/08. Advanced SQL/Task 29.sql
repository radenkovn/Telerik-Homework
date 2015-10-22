--Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).

--    Don't forget to define identity, primary key and appropriate foreign key.
--    Issue few SQL statements to insert, update and delete of some data in the table.
--    Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
--        For each change keep the old record data, the new record data and the command (insert / update / delete).



--TAKEN FROM INTERNET

CREATE TABLE WorkHours (
	EmployeeId INT IDENTITY,
	[Date] DATETIME,
	Task NVARCHAR(100),
	[Hours] INT,
	Comments NVARCHAR(300)
	CONSTRAINT PK_WorkHours PRIMARY KEY(EmployeeId)
	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY(EmployeeId)
	REFERENCES Employees(EmployeeId)
)
GO

INSERT INTO WorkHours
VALUES (GETDATE(), 'Write homework', 5, 'Homework about advanced SQL'),
		(GETDATE(), 'Go go Lecture', 4, 'Attend to lecture in Telerik Academy'),
		(GETDATE(), 'Rest', 2, 'Rest after hard day')

UPDATE WorkHours
SET Date = '2015-10-05 18:00'
WHERE Task LIKE '%Lecture%'

DELETE FROM WorkHours
WHERE [Hours] < 3

CREATE TABLE WorkHoursLogs(
	LogId INT IDENTITY,
	OldRecord nvarchar(500),
	NewRecord nvarchar(500),
	Command nvarchar(10),
	EmployeeId INT,
	CONSTRAINT PK_WorkHoursLogs PRIMARY KEY(LogId),
	CONSTRAINT FK_WorkHoursLogs_WorkHours FOREIGN KEY(EmployeeId) 
	REFERENCES WorkHours(EmployeeId)
)
GO

CREATE TRIGGER tr_WorkHoursInsert ON WorkHours FOR INSERT
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES('',
		   (SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments
			FROM Inserted),
		   'INSERT',
		   (SELECT EmployeeID FROM Inserted))
GO

CREATE TRIGGER tr_WorkHoursUpdate ON WorkHours FOR UPDATE
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES((SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' +
					 ' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Deleted),
		   (SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Inserted),
		   'UPDATE',
		   (SELECT EmployeeID FROM Inserted))
GO

CREATE TRIGGER tr_WorkHoursDelete ON WorkHours FOR DELETE
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES((SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Deleted),
		   '',
		   'DELETE',
		   (SELECT EmployeeID FROM Deleted))
GO

INSERT INTO WorkHours
VALUES(GETDATE(), 'Sleep', 8, 'Sleep when its dark outside')

DELETE FROM WorkHours
WHERE Task = 'Rest'

UPDATE WorkHours
SET Task = 'Win Money'
WHERE EmployeeID = 1