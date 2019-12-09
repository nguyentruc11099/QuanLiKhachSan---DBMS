USE master
GO

ALTER DATABASE HotelDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

IF DB_ID('HotelDB') IS NOT NULL DROP DATABASE HotelDB;
go

CREATE DATABASE HotelDB;
go

USE HotelDB;
GO

CREATE TABLE RoomTypes 
(
	RoomTypeID TINYINT IDENTITY NOT NULL,
	Name NVARCHAR(100) not null,
	Price smallmoney not null,
)
GO

CREATE TABLE Rooms
(
	RoomID int IDENTITY(1,1) NOT NULL,
	RoomTypeID TINYINT not null,
	OnFloor INT not null,
	[Status] INT DEFAULT 0 NOT NULL,
)
GO

CREATE TABLE Customers
(
	CustomerID INT IDENTITY(1,1) NOT NULL,
	CustomerName NVARCHAR(30) not null,
	IdentityCard VARCHAR(9) not null,
	PhoneNumber NVARCHAR(10) null,
	CustomerAddress NVARCHAR(40) null, 
)
go


CREATE TABLE HotelServices
(
	ServiceID INT IDENTITY(1,1) NOT NULL,
	ServiceName NVARCHAR(20) not null,
	Price smallmoney not null,
)
go

CREATE TABLE EmployeeTypes
(
	EmployeeTypeID TINYINT IDENTITY(1,1) NOT null,
	EmployeeTypeName NVARCHAR(30) not null,
)
GO

CREATE TABLE Employees 
(
	EmployeeID int IDENTITY(1000,1) NOT null,
	EmployeeName NVARCHAR(30) not null,
	EmployeeTypeID TINYINT not null,
	PhoneNumber VARCHAR(10) not null,
	IdentityCard VARCHAR(9) not null,
	[Password] NVARCHAR(20) not null,
)
GO

CREATE TABLE Booking 
( 
  BookingID int IDENTITY(1,1) NOT null,
  CustomerID INT UNIQUE NOT NULL,
  RoomID int unique NOT NULL,
  AppoinmentDate smalldatetime not null,
)
go

CREATE TABLE Invoices
(
	InvoiceID INT IDENTITY(1,1) NOT null,
	CustomerID INT not null,
	RoomID int not null,
	NumberOfDay TINYINT NULL,
	EmployeeID INT not null,
	InvoiceTotal SMALLMONEY not null,
	CheckInDate smalldatetime not null,
	CheckOutDate SMALLDATETIME null,
	HasPaid BIT NOT NULL DEFAULT 0
)
go

CREATE TABLE Invoices_Services
(
	Invoices_Services_ID int IDENTITY(1,1) NOT null,
	InvoiceID INT NOT NULL,
	ServiceID INT NOT NULL,
	[Times] INT NULL DEFAULT(1),
)
go


ALTER TABLE dbo.Customers ADD CONSTRAINT PK_Customers PRIMARY KEY(CustomerID);
ALTER TABLE dbo.RoomTypes ADD CONSTRAINT PK_RoomTypes PRIMARY KEY(RoomTypeID);
ALTER TABLE dbo.Rooms ADD CONSTRAINT PK_Rooms PRIMARY KEY(RoomID);
ALTER TABLE dbo.HotelServices ADD CONSTRAINT PK_Services PRIMARY KEY(ServiceID);
ALTER TABLE dbo.Employees ADD CONSTRAINT PK_Employees PRIMARY KEY(EmployeeID);
ALTER TABLE dbo.EmployeeTypes ADD CONSTRAINT PK_EmployeeTypes PRIMARY KEY(EmployeeTypeID);
ALTER TABLE dbo.Booking ADD CONSTRAINT PK_Booking PRIMARY KEY(BookingID);
ALTER TABLE dbo.Invoices_Services ADD CONSTRAINT PK_InvoicesServices PRIMARY KEY(Invoices_Services_ID);
ALTER TABLE dbo.Invoices ADD CONSTRAINT PK_Invoices PRIMARY KEY(InvoiceID);
GO

ALTER TABLE dbo.Customers
WITH Check
ADD CONSTRAINT UK_Customers UNIQUE(IdentityCard);
GO

ALTER TABLE dbo.Employees
WITH Check
ADD CONSTRAINT UK_Employees UNIQUE(IdentityCard);
GO

ALTER TABLE dbo.Rooms 
WITH CHECK 
ADD CONSTRAINT FK_Rooms_RoomTypes
FOREIGN KEY(RoomTypeID)
REFERENCES dbo.RoomTypes(RoomTypeID)
GO

ALTER TABLE dbo.Employees  
WITH CHECK 
ADD CONSTRAINT FK_Employees_EmployeeTypes
FOREIGN KEY(EmployeeTypeID)
REFERENCES dbo.EmployeeTypes(EmployeeTypeID)
GO

ALTER TABLE dbo.Booking  
WITH CHECK 
ADD CONSTRAINT FK_Booking_Customers 
FOREIGN KEY(CustomerID)
REFERENCES dbo.Customers(CustomerID)
GO

ALTER TABLE dbo.Booking  
WITH CHECK 
ADD CONSTRAINT FK_Booking_Rooms 
FOREIGN KEY(RoomID)
REFERENCES dbo.Rooms(RoomID)
GO

ALTER TABLE dbo.Invoices  
WITH CHECK 
ADD CONSTRAINT FK_Invoices_Customers 
FOREIGN KEY(CustomerID)
REFERENCES dbo.Customers(CustomerID)
GO

ALTER TABLE dbo.Invoices  
WITH CHECK 
ADD CONSTRAINT FK_Invoices_Room 
FOREIGN KEY(RoomID)
REFERENCES dbo.Rooms(RoomID)
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


ALTER TABLE dbo.Booking  
add CONSTRAINT Check_BookingAppointmentDate CHECK ( AppoinmentDate >= CAST(CAST(GETDATE() AS DATE) AS SMALLDATETIME));
GO

ALTER TABLE dbo.Invoices  
ADD CONSTRAINT Check_InvoicesEndDate CHECK (CheckOutDate >= CheckInDate);
GO

ALTER TABLE dbo.Invoices  
ADD CONSTRAINT Check_InvoicesNumberOfDay CHECK (NumberOfDay >= 0);
GO

ALTER TABLE dbo.Invoices  
ADD CONSTRAINT Check_InvoicesInvoiceTotal CHECK (InvoiceTotal >= 0);
GO

INSERT INTO dbo.RoomTypes
(
    Name,
    Price
)
VALUES
( N'VIP', 1000 ),
( N'Normal ', 1000 )


INSERT INTO dbo.Rooms
(
    RoomTypeID,
    OnFloor,
    Status
)
VALUES
(1,1,0),
(1,1,1),
(1,1,0),
(2,2,0),
(2,1,1),
(2,2,1),
(2,2,0)

INSERT INTO dbo.EmployeeTypes
(
    EmployeeTypeName
)
VALUES
(N'Admin'),
(N'Receptionist')


INSERT INTO dbo.Employees
(
    EmployeeName,
    EmployeeTypeID,
    PhoneNumber,
    IdentityCard,
    PassWord
)
VALUES
(N'Pham Ky Han',1,'0328953485','312383707',N'0000'),
(N'Luong Nguyen Giao Khanh',2,'0328953425','313383707',N'1111')

INSERT INTO dbo.Customers
(
    CustomerName,
    IdentityCard,
    PhoneNumber,
    CustomerAddress
)
VALUES
(   N' Huynh Kim Lien','312383706',N'0328942384',N'HCM'  ),
(   N' Huynh Nguyen Xuan Huy','312383206',N'0328342484',N'HCM'  ),
(   N' Huynh Nguyen Mai Khanh','312383346',N'0323342485',N'HCM'  )



