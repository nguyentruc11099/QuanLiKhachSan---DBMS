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
	PhoneNumber NVARCHAR(10) not null,
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

-- Primary Key Constraint 
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

-- Foreign Key Constraint 
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
ON DELETE CASCADE;
GO

ALTER TABLE dbo.Employees  
WITH CHECK 
ADD CONSTRAINT FK_Employees_EmployeeTypes
FOREIGN KEY(EmployeeTypeID)
REFERENCES dbo.EmployeeTypes(EmployeeTypeID)
ON DELETE CASCADE;
GO

ALTER TABLE dbo.Booking  
WITH CHECK 
ADD CONSTRAINT FK_Booking_Customers 
FOREIGN KEY(CustomerID)
REFERENCES dbo.Customers(CustomerID)
ON DELETE CASCADE;
GO

ALTER TABLE dbo.Booking  
WITH CHECK 
ADD CONSTRAINT FK_Booking_Rooms 
FOREIGN KEY(RoomID)
REFERENCES dbo.Rooms(RoomID)
ON DELETE CASCADE;
GO

ALTER TABLE dbo.Invoices  
WITH CHECK 
ADD CONSTRAINT FK_Invoices_Customers 
FOREIGN KEY(CustomerID)
REFERENCES dbo.Customers(CustomerID)
ON DELETE CASCADE;
GO

ALTER TABLE dbo.Invoices  
WITH CHECK 
ADD CONSTRAINT FK_Invoices_Room 
FOREIGN KEY(RoomID)
REFERENCES dbo.Rooms(RoomID)
ON DELETE CASCADE;
GO

ALTER TABLE dbo.Invoices_Services  
WITH CHECK 
ADD CONSTRAINT FK_InvoicesService_Service
FOREIGN KEY(ServiceID)
REFERENCES dbo.HotelServices(ServiceID)
ON DELETE CASCADE;
go

ALTER TABLE dbo.Invoices_Services  
WITH CHECK 
ADD CONSTRAINT FK_InvoicesService_Invoice
FOREIGN KEY(InvoiceID)
REFERENCES dbo.Invoices(InvoiceID)
ON DELETE CASCADE;
GO

ALTER TABLE dbo.Invoices
WITH CHECK 
ADD CONSTRAINT FK_InvoicesService_Employee
FOREIGN KEY(EmployeeID)
REFERENCES dbo.Employees(EmployeeID)
ON DELETE CASCADE;
go

-- Check Constraint 

--ALTER TABLE dbo.Booking  
--add CONSTRAINT Check_BookingAppointmentDate CHECK ( AppoinmentDate >= CAST(CAST(GETDATE() AS DATE) AS SMALLDATETIME));
--GO

ALTER TABLE dbo.Invoices  
ADD CONSTRAINT Check_InvoicesEndDate CHECK (CheckOutDate >= CheckInDate);
GO

ALTER TABLE dbo.Invoices  
ADD CONSTRAINT Check_InvoicesInvoiceTotal CHECK (InvoiceTotal >= 0);
GO


-- Index
--drop index if exists idx_Room_RoomType
--on dbo.Rooms;
--go

--CREATE nonclustered INDEX idx_Room_RoomType
--ON dbo.Rooms(RoomTypeID)
--INCLUDE (Status,OnFloor,RoomID)
--go
drop index if exists idx_Customer
on dbo.Customers;
go

CREATE nonclustered INDEX idx_Customer
ON dbo.Customers(CustomerName,IdentityCard)
INCLUDE (CustomerID,PhoneNumber)
go

drop index if exists idx_Booking_Identify
on dbo.booking;
go

CREATE nonclustered INDEX idx_Booking_Identify
ON dbo.Booking(CustomerID,RoomID)
include(BookingID)
go

drop index if exists idx_Invoice_CalRoomPrice
on dbo.invoices;
go

CREATE nonclustered INDEX idx_Invoice_CalRoomPrice
ON dbo.invoices(CustomerID,RoomID)
include ( invoiceID, Checkindate, checkoutdate )
go

drop index if exists idx_InvoiceService_cal
on dbo.Invoices_Services;
go

CREATE nonclustered INDEX idx_InvoiceService_cal
ON dbo.Invoices_Services(InvoiceID, ServiceID)
Include(Times)
go

--Seed Data
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
(1,1,1),
(1,1,1),
(1,1,0),
(2,2,0),
(2,1,2),
(2,2,2),
(2,2,2)

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
(N'Luong Nguyen Giao Khanh',2,'0328953425','313383707',N'1111'),
(N'Le Tran Yen Nhi',2,'0328957725','313399707',N'2222')

INSERT INTO dbo.Customers
(
    CustomerName,
    IdentityCard,
    PhoneNumber,
    CustomerAddress
)
VALUES
(   N'Huynh Kim Lien','312383706',N'0328942384',N'HCM'  ),
(   N'Doan Nguyen Xuan Huy','312383206',N'0328342484',N'HCM'  ),
(   N'Nguyen Mai Khanh','312383346',N'0323342485',N'HCM'  ),
(   N'Nguyen Minh Nhut','312383377',N'0325662485',N'HCM'  )

 INSERT INTO dbo.HotelServices
 (
     ServiceName,
     Price
 )
 VALUES
 (   N'Spa',50000 ),
 (   N'Food',20000)


INSERT INTO dbo.Invoices
(
    CustomerID,
    RoomID,
    EmployeeID,
    InvoiceTotal,
    CheckInDate,
	CheckOutDate,
    HasPaid
)
VALUES
(   1,2,1000,0,'2019-12-08 12:00:30',null,0),
(   2,1,1000,0,'2019-12-07 12:00:30',null,0),
(   2,1,1000,1500,'2019-11-02 12:00:30','2019-11-04 12:00:30',1),
(   2,1,1000,3000,'2019-10-02 12:00:30','2019-10-03 12:00:30',1),
(   3,1,1000,4500,'2019-09-02 12:00:30','2019-09-04 12:00:30',1),
(   4,1,1000,10000,'2019-08-02 12:00:30','2019-08-03 12:00:30',1)

INSERT INTO dbo.Invoices_Services
(
    InvoiceID,
    ServiceID,
    Times
)
VALUES
( 2, 1, 2 ),
( 2, 2, 1 )
 
INSERT INTO dbo.Booking
(
    CustomerID,
    RoomID,
    AppoinmentDate
)
VALUES
(3,5,'2019-12-13 05:59:52' ),
(4,6,'2019-12-13 05:59:52' ),
(2,7,'2019-12-10 05:59:52' )

USE HotelDB;
IF OBJECT_ID(N'dbo.vi_InvoicesHasPaid', N'P') IS NOT NULL DROP view dbo.vi_InvoicesHasPaid;
GO
CREATE view dbo.vi_InvoicesHasPaid
AS
	select InvoiceID,CheckInDate,CheckOutDate,InvoiceTotal  from Invoices where HasPaid = 1;
GO