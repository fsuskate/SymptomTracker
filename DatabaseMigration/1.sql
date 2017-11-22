
if not exists(select * from sys.databases where name = 'SymptomTracker')
begin
	create database SymptomTracker;
end

use SymptomTracker;
if not exists(select * from sys.tables where name = 'ST_Users')
begin
	create table [dbo].ST_Users (UserId int, UserName varchar(255), PassToken varchar(255))
end

if not exists(select * from sys.tables where name = 'ST_Meds')
begin
	create table [dbo].ST_Meds (MedId int, 
		MedName varchar(255), 
		Description varchar(255),
		Dose bigint,
		DoseDate datetime)
end

if not exists(select * from sys.tables where name = 'ST_Activities')
begin
	create table [dbo].ST_Activities (ActivityId int, 
		ActivityName varchar(255), 
		Description varchar(255),
		ActivityDate datetime,
		ActivityLength bigint)
end

if not exists(select * from sys.tables where name = 'ST_Symptoms')
begin
	create table [dbo].ST_Symptoms (SymtomId int, 
		SymtomName varchar(255), 
		Description varchar(255),
		SymptomLevel bigint,
		SymptomLength bigint,
		SymptomDate datetime)
end

