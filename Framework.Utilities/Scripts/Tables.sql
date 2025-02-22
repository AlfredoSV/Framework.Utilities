
if exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'LogBook')
begin
	
	drop table LogBook;
	PRINT 'Table Logbook deleted'

end;


CREATE TABLE
LogBook
(
id UNIQUEIDENTIFIER NOT NULL,
class VARCHAR(50) NOT NULL,
method VARCHAR(50) NOT NULL,
type VARCHAR(MAX) NOT NULL,
message VARCHAR(MAX) NOT NULL,
createdAt DATETIME NOT NULL

);


if exists(select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'TemplateEmail')
begin
	
	drop table TemplateEmail;
	PRINT 'Table TemplateEmail deleted'

end;


CREATE TABLE
TemplateEmail
(
id UNIQUEIDENTIFIER NOT NULL,
name VARCHAR(50) NOT NULL,
bodyTemplate VARCHAR(MAX) NOT NULL,
createdAt DATETIME NOT NULL

);