

if exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'LogBook')
begin
	
	drop table LogBook;
	PRINT 'Table Logbook deleted'

end;


CREATE TABLE
LogBook
(
Id UNIQUEIDENTIFIER NOT NULL,
ClassName VARCHAR(30) NOT NULL,
MethodName VARCHAR(30) NOT NULL,
TypeName VARCHAR(30) NOT NULL,
MessageName VARCHAR(100) NOT NULL,
DateCreated DATETIME NOT NULL

);


