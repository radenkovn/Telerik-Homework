--Write SQL statements to update some of the records in the Users and Groups tables.

UPDATE Users
SET [Full Name] = 'Hermione'
WHERE UserId = 1;

UPDATE Groups
SET Name = 'Alchemism'
WHERE Name LIKE '%Alchemy';