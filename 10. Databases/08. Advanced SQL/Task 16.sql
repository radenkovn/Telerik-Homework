--Write a SQL statement to create a view that displays the users from the Users table that have been in the system today. 

CREATE VIEW [Logged View] AS
SELECT Username, [Login Time]
FROM Users
WHERE
DAY([Login Time]) = DAY (GETDATE())