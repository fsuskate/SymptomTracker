IF not exists(select * from sys.databases where name = 'SymptomTracker')
BEGIN
	CREATE DATABASE SymptomTracker;
END
GO

use SymptomTracker;

IF NOT EXISTS (SELECT LoginName FROM master.dbo.syslogins WHERE Name = 'SymptomTracker_User')
BEGIN
    EXEC('
    CREATE LOGIN [SymptomTracker_User] WITH PASSWORD=''INSERT_PASSWORD_HERE'', DEFAULT_DATABASE=[SymptomTracker], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
    ')
END
GO

IF NOT EXISTS (SELECT Name FROM sys.sysusers WHERE Name = 'SymptomTracker_User')
BEGIN
    CREATE USER SymptomTracker_User FOR LOGIN SymptomTracker_User WITH DEFAULT_SCHEMA=[dbo]
END
GO


if not exists(select * from sys.tables where name = 'ST_Users')
begin
	create table [dbo].ST_Users (UserId bigint IDENTITY(1000,1) NOT NULL, 
		UserName varchar(255), 
		PassToken varchar(255))
end
GO

INSERT INTO ST_Users (UserName, PassToken) VALUES('DevTest', '2test')
GO

GRANT INSERT ON [dbo].ST_Users TO [SymptomTracker_User] AS [dbo]
GO
GRANT SELECT ON [dbo].ST_Users TO [SymptomTracker_User] AS [dbo]
GO
GRANT UPDATE ON [dbo].ST_Users TO [SymptomTracker_User] AS [dbo]
GO


if not exists(select * from sys.tables where name = 'ST_Meds')
begin
	create table [dbo].ST_Meds (MedId bigint IDENTITY(1000,1) NOT NULL, 
		MedName varchar(255), 
		Description varchar(255),
		MedImage varchar(255),
		Dose bigint,
		DoseDate datetime,
		UserId int)
end
GO

GRANT INSERT ON [dbo].ST_Meds TO [SymptomTracker_User] AS [dbo]
GO
GRANT SELECT ON [dbo].ST_Meds TO [SymptomTracker_User] AS [dbo]
GO
GRANT UPDATE ON [dbo].ST_Meds TO [SymptomTracker_User] AS [dbo]
GO


if not exists(select * from sys.tables where name = 'ST_Activities')
begin
	create table [dbo].ST_Activities (ActivityId bigint IDENTITY(1000,1) NOT NULL, 
		ActivityName varchar(255), 
		Description varchar(255),
		ActivityDate datetime,
		ActivityLength bigint,
		UserId int)
end
GO

GRANT INSERT ON [dbo].ST_Activities TO [SymptomTracker_User] AS [dbo]
GO
GRANT SELECT ON [dbo].ST_Activities TO [SymptomTracker_User] AS [dbo]
GO
GRANT UPDATE ON [dbo].ST_Activities TO [SymptomTracker_User] AS [dbo]
GO

if not exists(select * from sys.tables where name = 'ST_Symptoms')
begin
	create table [dbo].ST_Symptoms (SymptomId bigint IDENTITY(1000,1) NOT NULL, 
		SymptomName varchar(255), 
		Description varchar(255),
		SymptomLevel bigint,
		SymptomLength bigint,
		SymptomDate datetime,
		UserId int)
end
GO

GRANT INSERT ON [dbo].ST_Symptoms TO [SymptomTracker_User] AS [dbo]
GO
GRANT SELECT ON [dbo].ST_Symptoms TO [SymptomTracker_User] AS [dbo]
GO
GRANT UPDATE ON [dbo].ST_Symptoms TO [SymptomTracker_User] AS [dbo]
GO

-- TODO: Move this into seperate sampledata.sql script
INSERT INTO ST_Meds (MedName, Description, Dose, DoseDate, UserId, MedImage) VALUES('Methotrexate', '', 12.5, GETDATE(), 1000, 'medicine-bowl-icon.png')
INSERT INTO ST_Meds (MedName, Description, Dose, DoseDate, UserId, MedImage) VALUES('Advil', '', 400, GETDATE(), 1000, 'medicine-bowl-icon.png')
INSERT INTO ST_Meds (MedName, Description, Dose, DoseDate, UserId, MedImage) VALUES('Aleve', '', 800, GETDATE(), 1000, 'medicine-bowl-icon.png')
INSERT INTO ST_Meds (MedName, Description, Dose, DoseDate, UserId, MedImage) VALUES('Plaquenil', '', 400, GETDATE(), 1000, 'medicine-bowl-icon.png')
GO

INSERT INTO ST_Activities (ActivityName, Description, ActivityDate, ActivityLength, UserId) VALUES('Swim', '', GETDATE(), 80, 1000)
INSERT INTO ST_Activities (ActivityName, Description, ActivityDate, ActivityLength, UserId) VALUES('Walk', '', GETDATE(), 1, 1000)
GO

INSERT INTO ST_Symptoms (SymptomName, Description, SymptomLevel, SymptomLength, SymptomDate, UserId) VALUES('Knee Pain', '', 5, 24, GETDATE(), 1000)
INSERT INTO ST_Symptoms (SymptomName, Description, SymptomLevel, SymptomLength, SymptomDate, UserId) VALUES('Hand Pain', 'Both hands', 4, 24, GETDATE(), 1000)
GO