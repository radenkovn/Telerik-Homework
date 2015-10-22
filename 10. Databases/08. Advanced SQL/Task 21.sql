--Write SQL statements to delete some of the records from the Users and Groups tables.

DELETE FROM Users
WHERE Username LIKE '%2';

DELETE FROM Groups
WHERE GroupId BETWEEN 2 AND 3