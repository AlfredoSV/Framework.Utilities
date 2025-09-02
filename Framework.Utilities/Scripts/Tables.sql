
if exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'LogBook')
begin
	
	drop table LogBook;
	PRINT 'Table Logbook deleted'

end;


CREATE TABLE
LogBook
(
	id UNIQUEIDENTIFIER NOT NULL,
	class NVARCHAR(50) NOT NULL,
	method NVARCHAR(50) NOT NULL,
	type NVARCHAR(MAX) NOT NULL,
	message NVARCHAR(MAX) NOT NULL,
	createdAt DATETIME NOT NULL
	CONSTRAINT PK_Id_Log PRIMARY KEY(id)
);


if exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'TemplateEmail')
begin
	
	drop table TemplateEmail;
	PRINT 'Table TemplateEmail deleted'

end;


CREATE TABLE
TemplateEmail
(
	id INT NOT NULL,
	name NVARCHAR(50) NOT NULL,
	bodyTemplate NVARCHAR(MAX) NOT NULL,
	createdAt DATETIME NOT NULL
	CONSTRAINT PK_Id_Template PRIMARY KEY(Id)
);