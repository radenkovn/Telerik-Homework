--Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint). 

CREATE TABLE Groups (
	GroupId INT IDENTITY,
	Name NVARCHAR(50) UNIQUE NOT NULL,
	CONSTRAINT PK_Groups PRIMARY KEY(GroupId)
)