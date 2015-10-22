-- Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".


SELECT CONVERT(VARCHAR(24),GETDATE(),113) AS CurrentDateTime
