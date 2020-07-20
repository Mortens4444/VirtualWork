DECLARE @UserId int;

SELECT * FROM Emails WHERE UserId = @UserId;
SELECT * FROM Addresses WHERE UserId = @UserId;
SELECT * FROM TelephoneNumbers WHERE UserId = @UserId;