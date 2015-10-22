--Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).

--    Insert few records for testing.
--    Write a stored procedure that selects the full names of all persons.


CREATE DATABASE PeopleHwDatabase;
GO

USE PeopleHwDatabase

CREATE TABLE Persons(
	Id INT IDENTITY NOT NULL,
	FirstName NVARCHAR(50),
	LastName NVARCHAR(50),
	SSN INT
	CONSTRAINT PK_PId PRIMARY KEY (Id)
)
GO

USE PeopleHwDatabase
CREATE TABLE Accounts(
	Id INT IDENTITY NOT NULL,
	PersonId int FOREIGN KEY REFERENCES Persons(Id),
	Balance MONEY NOT NULL,
	CONSTRAINT PK_AId PRIMARY KEY (Id)
)
GO

USE PeopleHwDatabase
INSERT INTO Persons (FirstName, LastName, SSN)
VALUES ('Harry', 'Potter', 123),
('Ronald', 'Weasley', 100),
('Hermione', 'Granger', 105),
('Bill', 'Clinton', 205),
('Vladimir', 'Putin', 942),
('Barrack', 'Obama', 491),
('Snoop', 'Dogg', 150)
GO

USE PeopleHwDatabase
INSERT INTO Accounts(Balance, PersonId)
VALUES (12448, 1),
(57656, 2),
(455234, 3),
(234567, 4),
(4567, 5),
(234567, 6),
(76535, 7)
GO
