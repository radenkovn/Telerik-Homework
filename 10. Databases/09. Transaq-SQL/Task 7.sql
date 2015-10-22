--Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name)
 --and all town's names that are comprised of given set of letters.

--    Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.


CREATE FUNCTION dbo.fn_AllEmpployeeNames (@letters nvarchar(50))
RETURNS TABLE 
AS
RETURN(

SELECT efn.FirstName as AllNames
FROM Employees efn
WHERE PATINDEX ('%[' + @letters + ']',efn.FirstName) > 0

UNION

SELECT emn.MiddleName
FROM Employees emn
WHERE PATINDEX ('%[' + @letters + ']',emn.MiddleName) > 0

UNION

SELECT eln.LastName
FROM Employees eln
WHERE PATINDEX ('%[' + @letters + ']',eln.LastName) > 0

UNION

SELECT t.Name
FROM Towns t
WHERE PATINDEX ('%[' + @letters + ']', t.Name) > 0
)
GO

--The best i could do..


