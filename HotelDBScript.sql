IF DB_ID('HotelDB') IS NOT NULL DROP DATABASE HotelDB;
go

CREATE DATABASE HotelDB;
go

USE HotelDB;
GO

CREATE TABLE RoomTypes 
(
	RoomTypeID TINYINT IDENTITY NOT null,
	Name NVARCHAR(100) not null,
	Price smallmoney NOT null,
	Hide BIT DEFAULT(0) NULL,
)
GO

CREATE TABLE Rooms
(
	RoomID VARCHAR(5) NOT null,
	RoomTypeID TINYINT NOT NULL,
	OnFloor INT NOT NULL,
	Hide BIT DEFAULT(0) NULL,
)
GO

CREATE TABLE Customers
(
	CustomerID INT NOT NULL,
	CustomerName NVARCHAR(30) NOT null,
	IdentityCard INT NOT null,
	PhoneNumber NVARCHAR(10) NOT null,
	CustomerAddress NVARCHAR(40) null, 
	Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE ServiceTypes
(
	ServiceTypeID TINYINT NOT null, 
	ServiceTypeName NVARCHAR(20) NOT null,
	Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE HotelServices
(
	ServiceID INT NOT null,
	ServiceName NVARCHAR(20) NOT null,
	ServiceTypeID TINYINT NOT null,
	Price smallmoney NOT NULL,
	Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE SalePhases
(
	SalePhaseID INT NOT null,
	ServiceTypeID TINYINT NOT NULL,
	StartDate date NOT NULL,
	EndDate date NOT NULL,
	Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE EmployeeTypes
(
	EmployeeTypeID TINYINT NOT NULL,
	EmployeeTypeName NVARCHAR(30) NOT NULL,
	Hide BIT DEFAULT(0) NULL,
)
GO

CREATE TABLE Employees 
(
	EmployeeID VARCHAR(5) NOT NULL,
	EmployeeName NVARCHAR(30) NOT NULL,
	EmployeeTypeID TINYINT NOT NULL,
	PhoneNumber INT NULL,
	IndetityCard INT NOT NULL,
	[PassWord] NVARCHAR(20) NULL,
	Hide BIT DEFAULT(0) NULL,
)
GO

CREATE TABLE Booking 
( 
  CustomerID INT NOT NULL,
  RoomID VARCHAR(5) NOT NULL,
  AppoinmentDate smalldatetime NOT NULL,
  Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE Invoices
(
	InvoiceID INT NOT NULL,
	CustomerID INT NOT NULL,
	RoomID VARCHAR(5) NOT NULL,
	NumberOfDay TINYINT NULL,
	EmployeeID VARCHAR(5) NOT NULL,
	InvoiceTotal SMALLMONEY NULL,
	CheckInDate smallmoney NULL,
	CheckOutDate DATE NULL,
	Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE Invoices_Services
(
	InvoiceID INT NOT NULL,
	ServiceID int NOT NULL,
	[Times] INT NOT NULL DEFAULT(1),
	Hide BIT DEFAULT(0) NULL,
)
go


ALTER TABLE dbo.Customers ADD CONSTRAINT PK_Customer PRIMARY KEY(CustomerID);
ALTER TABLE dbo.RoomTypes ADD CONSTRAINT PK_RoomType PRIMARY KEY(RoomTypeID);
ALTER TABLE dbo.Rooms ADD CONSTRAINT PK_Room PRIMARY KEY(RoomID);
ALTER TABLE dbo.ServiceTypes ADD CONSTRAINT PK_ServiceType PRIMARY KEY(ServiceTypeID);
ALTER TABLE dbo.HotelServices ADD CONSTRAINT PK_Service PRIMARY KEY(ServiceID);
ALTER TABLE dbo.Employees ADD CONSTRAINT PK_Employee PRIMARY KEY(EmployeeID);
ALTER TABLE dbo.EmployeeTypes ADD CONSTRAINT PK_EmployeeType PRIMARY KEY(EmployeeTypeID);
ALTER TABLE dbo.Booking ADD CONSTRAINT PK_Booking PRIMARY KEY(CustomerID,RoomID);
ALTER TABLE dbo.Invoices_Services ADD CONSTRAINT PK_InvoicesServices PRIMARY KEY(InvoiceID,ServiceID);
ALTER TABLE dbo.Invoices ADD CONSTRAINT PK_Invoice PRIMARY KEY(InvoiceID);
ALTER TABLE dbo.SalePhases ADD CONSTRAINT PK_SalePhase PRIMARY KEY(SalePhaseID);
GO

ALTER TABLE dbo.Rooms 
WITH CHECK 
ADD CONSTRAINT FK_Room_RoomType 
FOREIGN KEY(RoomTypeID)
REFERENCES dbo.RoomTypes(RoomTypeID)
GO

ALTER TABLE dbo.Employees  
WITH CHECK 
ADD CONSTRAINT FK_Employee_EmployeeType
FOREIGN KEY(EmployeeTypeID)
REFERENCES dbo.EmployeeTypes(EmployeeTypeID)
GO

ALTER TABLE dbo.HotelServices
WITH CHECK 
ADD CONSTRAINT FK_Service_ServiceType 
FOREIGN KEY(ServiceTypeID)
REFERENCES dbo.ServiceTypes(ServiceTypeID)
GO

ALTER TABLE dbo.SalePhases  
WITH CHECK 
ADD CONSTRAINT FK_SalePhase_ServiceType 
FOREIGN KEY(ServiceTypeID)
REFERENCES dbo.ServiceTypes(ServiceTypeID)
GO

ALTER TABLE dbo.Booking  
WITH CHECK 
ADD CONSTRAINT FK_Booking_Customer 
FOREIGN KEY(CustomerID)
REFERENCES dbo.Customers(CustomerID)
GO

ALTER TABLE dbo.Booking  
WITH CHECK 
ADD CONSTRAINT FK_Booking_Room 
FOREIGN KEY(RoomID)
REFERENCES dbo.Rooms(RoomID)
GO

ALTER TABLE dbo.Invoices  
WITH CHECK 
ADD CONSTRAINT FK_Invoices_Customer 
FOREIGN KEY(CustomerID)
REFERENCES dbo.Customers(CustomerID)
GO

ALTER TABLE dbo.Invoices  
WITH CHECK 
ADD CONSTRAINT FK_Invoices_Room 
FOREIGN KEY(RoomID)
REFERENCES dbo.Rooms(RoomID)
GO

ALTER TABLE dbo.Invoices  
WITH CHECK 
ADD CONSTRAINT FK_Invoices_Booking 
FOREIGN KEY(CustomerID,RoomID)
REFERENCES dbo.Booking(CustomerID,RoomID)
GO

ALTER TABLE dbo.Invoices_Services  
WITH CHECK 
ADD CONSTRAINT FK_InvoicesService_Service
FOREIGN KEY(ServiceID)
REFERENCES dbo.HotelServices(ServiceID)
go

ALTER TABLE dbo.Invoices_Services  
WITH CHECK 
ADD CONSTRAINT FK_InvoicesService_Invoice
FOREIGN KEY(InvoiceID)
REFERENCES dbo.Invoices(InvoiceID)
GO

ALTER TABLE dbo.Invoices
WITH CHECK 
ADD CONSTRAINT FK_InvoicesService_Employee
FOREIGN KEY(EmployeeID)
REFERENCES dbo.Employees(EmployeeID)
go