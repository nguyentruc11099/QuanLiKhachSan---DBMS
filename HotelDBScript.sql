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
	Price smallmoney not null,
	Hide BIT DEFAULT(0) null,
)
GO

CREATE TABLE Rooms
(
	RoomID VARCHAR(5) NOT null,
	RoomTypeID TINYINT not null,
	OnFloor INT not null,
	Hide BIT DEFAULT(0) NULL,
)
GO

CREATE TABLE Customers
(
	CustomerID INT NOT NULL,
	CustomerName NVARCHAR(30) not null,
	IdentityCard INT not null,
	PhoneNumber NVARCHAR(10) not null,
	CustomerAddress NVARCHAR(40) not null, 
	Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE ServiceTypes
(
	ServiceTypeID TINYINT NOT null, 
	ServiceTypeName NVARCHAR(20) not null,
	Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE HotelServices
(
	ServiceID INT NOT null,
	ServiceName NVARCHAR(20) not null,
	ServiceTypeID TINYINT not null,
	Price smallmoney not null,
	Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE SalePhases
(
	SalePhaseID INT NOT null,
	ServiceTypeID TINYINT not null,
	StartDate date not null,
	EndDate date not null,
	Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE EmployeeTypes
(
	EmployeeTypeID TINYINT NOT NULL,
	EmployeeTypeName NVARCHAR(30) not null,
	Hide BIT DEFAULT(0) NULL,
)
GO

CREATE TABLE Employees 
(
	EmployeeID VARCHAR(5) NOT NULL,
	EmployeeName NVARCHAR(30) not null,
	EmployeeTypeID TINYINT not null,
	PhoneNumber INT not null,
	IndetityCard INT not null,
	[PassWord] NVARCHAR(20) not null,
	Hide BIT DEFAULT(0) NULL,
)
GO

CREATE TABLE Booking 
( 
  CustomerID INT NOT NULL,
  RoomID VARCHAR(5) NOT NULL,
  AppoinmentDate smalldatetime not null,
  Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE Invoices
(
	InvoiceID INT NOT NULL,
	CustomerID INT not null,
	RoomID VARCHAR(5) not null,
	NumberOfDay TINYINT not null,
	EmployeeID VARCHAR(5) not null,
	InvoiceTotal SMALLMONEY not null,
	CheckInDate smalldatetime not null,
	CheckOutDate smalldatetime not null,
	Hide BIT DEFAULT(0) NULL,
)
go

CREATE TABLE Invoices_Services
(
	InvoiceID INT NOT NULL,
	ServiceID int NOT NULL,
	[Times] INT NULL DEFAULT(1),
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

--CRUD
--Create Room
use HotelDB;
if object_id('CreateRoom') is not null
	drop proc CreateRoom;
go
create proc CreateRoom
	(@RoomID VARCHAR(5) = null,
	@RoomTypeID TINYINT= null,	
	@OnFloor INT= null,
	@Hide BIT = 0)
as

if exists (select * from Rooms where RoomID = @RoomID)
	throw 50001, 'Invalid RoomID.', 1;
if not exists (select * from RoomTypes where RoomTypeID = @RoomTypeID)
	throw 50001, 'Invalid RoomTypeID.', 1;
if(@OnFloor is null)
	throw 50001, 'Invalid Onfloor.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
insert into Rooms (RoomID,RoomTypeID,OnFloor,Hide)
values (@RoomID,@RoomTypeID,@OnFloor,@Hide)
delete RedoTable
go
exec CreateRoom @RoomID = '00005', @RoomTypeID = 0001, @OnFloor = 4, @Hide = 1
go

--Update Room
use HotelDB;
if object_id('UpdateRoom') is not null
	drop proc UpdateRoom;
go
create proc UpdateRoom
	(@RoomID VARCHAR(5) =null,
	@RoomTypeID TINYINT=null,	
	@OnFloor INT=null,
	@Hide BIT = 0)
as
if not exists (select * from Rooms where RoomID = @RoomID)
	throw 50001, 'Invalid RoomID.', 1;
if not exists (select * from RoomTypes where RoomTypeID = @RoomTypeID)
	throw 50001, 'Invalid RoomTypeID.', 1;
if(@OnFloor is null)
	throw 50001, 'Invalid Onfloor.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
update Rooms
set 
	RoomTypeID = @RoomTypeID, 
	OnFloor = @OnFloor, 
	Hide = @Hide
	where RoomID = @RoomID
delete RedoTable
go
exec UpdateRoom '00005',1,6
go
--Delete Room
use HotelDB;
if object_id('DeleteRoom') is not null
	drop proc DeleteRoom;
go
create proc DeleteRoom
	(@RoomID VARCHAR(5) =null)
as
if not exists (select * from Rooms where RoomID = @RoomID)
	throw 50001, 'Invalid RoomID.', 1;
delete Rooms
	where RoomID = @RoomID
delete RedoTable
go
exec DeleteRoom '00003'
go

--Create RoomType
use HotelDB;
if object_id('CreateRoomType') is not null
	drop proc CreateRoomType;
go
create proc CreateRoomType
	(
	@Name NVARCHAR(100) =  null,
	@Price smallmoney = null,
	@Hide BIT =0)
as
if(@Name is null)
	throw 50001, 'Invalid Name.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
insert into RoomTypes(Name,Price,Hide)
values ( @Name, @Price, @Hide)
go
exec CreateRoomType @Name = 'a', @Price = 10000, @Hide = 1 

--Update RoomType
use HotelDB;
if object_id('UpdateRoomType') is not null
	drop proc UpdateRoomType;
go
create proc UpdateRoomType
	(
	@RoomTypeID int = null,
	@Name NVARCHAR(100) =  null,
	@Price smallmoney = null,
	@Hide BIT =0)
as
if not exists (select * from RoomTypes where RoomTypeID = @RoomTypeID)
	throw 50001, 'Invalid RoomTypeID.', 1;
if(@Name is null)
	throw 50001, 'Invalid Name.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
UPdate RoomTypes
Set 
	Name = @Name, 
	Price = @Price, 
	Hide = @Hide
	where @RoomTypeID = RoomTypeID
go
exec UpdateRoomType 2,'abcfg',5000

--Delete RoomType
use HotelDB;
if object_id('DeleteRoomType') is not null
	drop proc DeleteRoomType;
go
create proc DeleteRoomType
	(
	@RoomTypeID int = null)
as
if not exists (select * from RoomTypes where RoomTypeID = @RoomTypeID)
	throw 50001, 'Invalid RoomTypeID.', 1;
Delete RoomTypes
	where @RoomTypeID = RoomTypeID
go
exec DeleteRoomType 2


--Create Customer
use HotelDB;
if object_id('CreateCustomer') is not null
	drop proc CreateCustomer;
go
create proc CreateCustomer
	(
		@CustomerID INT = NULL,
	@CustomerName NVARCHAR(30) = null,
	@IdentityCard INT = null,
	@PhoneNumber NVARCHAR(10) =  null,
	@CustomerAddress NVARCHAR(40) = null, 
	@Hide BIT = 0)
as
if exists (select * from Customers where CustomerID = @CustomerID)
	throw 50001, 'Invalid CustomerID.', 1;
if(@CustomerName is null)
	throw 50001, 'Invalid CustomerName.', 1;
if(@IdentityCard is null)
	throw 50001, 'Invalid IdentityCard.', 1;
if(@PhoneNumber is null)
	throw 50001, 'Invalid PhoneNumber.', 1;
if(@CustomerAddress is null)
	throw 50001, 'Invalid CustomerAddress.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
insert into Customers(CustomerID,CustomerName,IdentityCard,PhoneNumber,CustomerAddress,Hide)
values (@CustomerID, @CustomerName, @IdentityCard, @PhoneNumber, @CustomerAddress, @Hide)
go
exec CreateCustomer 7,'Phuong', 30, 0901333666, 'ABC', 1
exec CreateCustomer 5,'Phuong', 30, 0901333666, 'ABC', 1
--Update Customer
use HotelDB;
if object_id('UpdateCustomer') is not null
	drop proc UpdateCustomer;
go
create proc UpdateCustomer
	(
		@CustomerID INT = NULL,
	@CustomerName NVARCHAR(30) = null,
	@IdentityCard INT = null,
	@PhoneNumber NVARCHAR(10) =  null,
	@CustomerAddress NVARCHAR(40) = null, 
	@Hide BIT = 0)
as
if not exists (select * from Customers where CustomerID = @CustomerID)
	throw 50001, 'Invalid CustomerID.', 1;
if(@CustomerName is null)
	throw 50001, 'Invalid CustomerName.', 1;
if(@IdentityCard is null)
	throw 50001, 'Invalid IdentityCard.', 1;
if(@PhoneNumber is null)
	throw 50001, 'Invalid PhoneNumber.', 1;
if(@CustomerAddress is null)
	throw 50001, 'Invalid CustomerAddress.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
update Customers
set
	CustomerName = @CustomerName, 
	IdentityCard = @IdentityCard, 
	PhoneNumber = @PhoneNumber, 
	CustomerAddress = @CustomerAddress, 
	Hide = @Hide
	where CustomerID = @CustomerID
go
exec UpdateCustomer 9,' My Phuong', 30, 0901333666, 'ABCD', 1
--Delete Customer
use HotelDB;
if object_id('DeleteCustomer') is not null
	drop proc DeleteCustomer;
go
create proc DeleteCustomer
	(
		@CustomerID INT = NULL)
as
if not exists (select * from Customers where CustomerID = @CustomerID)
	throw 50001, 'Invalid CustomerID.', 1;
delete Customers
	where CustomerID = @CustomerID
go
exec DeleteCustomer 5

--Create ServiceType
use HotelDB;
if object_id('CreateServiceType') is not null
	drop proc CreateServiceType;
go
create proc CreateServiceType
	(
	@ServiceTypeID TINYINT = null, 
	@ServiceTypeName NVARCHAR(20) = null,
	@Hide BIT = 0)
as
if exists (select * from ServiceTypes where ServiceTypeID = @ServiceTypeID)
	throw 50001, 'Invalid ServiceTypeID.', 1;
if(@ServiceTypeName is null)
	throw 50001, 'Invalid ServiceTypeName.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
insert into ServiceTypes(ServiceTypeID, ServiceTypeName, Hide)
values (@ServiceTypeID, @ServiceTypeName, @Hide)
go
exec CreateServiceType 2,'abc',1
--Update ServiceType
use HotelDB;
if object_id('UpdateServiceType') is not null
	drop proc UpdateServiceType;
go
create proc UpdateServiceType
	(
	@ServiceTypeID TINYINT = null, 
	@ServiceTypeName NVARCHAR(20) = null,
	@Hide BIT = 0)
as
if not exists (select * from ServiceTypes where ServiceTypeID = @ServiceTypeID)
	throw 50001, 'Invalid ServiceTypeID.', 1;
if(@ServiceTypeName is null)
	throw 50001, 'Invalid ServiceTypeName.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
update ServiceTypes
set
	ServiceTypeName = @ServiceTypeName, 
	Hide = @Hide
	where ServiceTypeID = @ServiceTypeID 
go
exec UpdateServiceType 1, 'KARAOKE'
--Delete ServiceType
use HotelDB;
if object_id('DeleteServiceType') is not null
	drop proc DeleteServiceType;
go
create proc DeleteServiceType
	(@ServiceTypeID TINYINT = null)
as
if not exists (select * from ServiceTypes where ServiceTypeID = @ServiceTypeID)
	throw 50001, 'Invalid ServiceTypeID.', 1;
delete ServiceTypes
	where ServiceTypeID = @ServiceTypeID 
go
exec DeleteServiceType 2

--Create Hotel Service
use HotelDB;
if object_id('CreateHotelService') is not null
	drop proc CreateHotelService;
go
create proc CreateHotelService
	(
	@ServiceID INT = null,
	@ServiceName NVARCHAR(20) = null,
	@ServiceTypeID TINYINT = null,
	@Price smallmoney = NULL,
	@Hide BIT = 0)
as
if exists (select * from HotelServices where ServiceID = @ServiceID)
	throw 50001, 'Invalid ServiceID.', 1;
if(@ServiceName is null)
	throw 50001, 'Invalid ServiceName.', 1;
if not exists (select * from ServiceTypes where ServiceTypeID = @ServiceTypeID)
	throw 50001, 'Invalid ServiceTypeID.', 1;
if(@Price is null)
	throw 50001, 'Invalid Price.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
insert into HotelServices(ServiceID, ServiceName, ServiceTypeID, Price, Hide)
values (@ServiceID, @ServiceName, @ServiceTypeID, @Price, @Hide)
go
exec CreateHotelService 5,'abcd',2, 3000,0
--Update HotelService
use HotelDB;
if object_id('UpdateHotelService') is not null
	drop proc UpdateHotelService;
go
create proc UpdateHotelService
	(
	@ServiceID INT = null,
	@ServiceName NVARCHAR(20) = null,
	@ServiceTypeID TINYINT = null,
	@Price smallmoney = null,
	@Hide BIT = 0)
as
if not exists (select * from HotelServices where ServiceID = @ServiceID)
	throw 50001, 'Invalid ServiceID.', 1;
if(@ServiceName is null)
	throw 50001, 'Invalid ServiceName.', 1;
if not exists (select * from ServiceTypes where ServiceTypeID = @ServiceTypeID)
	throw 50001, 'Invalid ServiceTypeID.', 1;
if(@Price is null)
	throw 50001, 'Invalid Price.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
update HotelServices
set
	ServiceName = @ServiceName, 
	ServiceTypeID = @ServiceTypeID, 
	Price = @Price, 
	Hide = @Hide
	where ServiceID = @ServiceID 
go
exec UpdateHotelService 1,'none',2
--Delete HotelService
use HotelDB;
if object_id('DeleteHotelService') is not null
	drop proc DeleteHotelService;
go
create proc DeleteHotelService
	(
	@ServiceID INT = null)
as
if not exists (select * from HotelServices where ServiceID = @ServiceID)
	throw 50001, 'Invalid ServiceID.', 1;
delete HotelServices
	where ServiceID = @ServiceID 
go
exec DeleteHotelService 5
--Create SalePhase
use HotelDB;
if object_id('CreateSalePhase') is not null
	drop proc CreateSalePhase;
go
create proc CreateSalePhase
	(
	@SalePhaseID INT = null,
	@ServiceTypeID TINYINT = NULL,
	@StartDate date = NULL,
	@EndDate date = null,
	@Hide BIT = 0)
as
if exists (select * from SalePhases where SalePhaseID = @SalePhaseID)
	throw 50001, 'Invalid SalePhaseID.', 1;
if not exists (select * from ServiceTypes where ServiceTypeID = @ServiceTypeID)
	throw 50001, 'Invalid ServiceTypeID.', 1;
if(@StartDate is null or @StartDate > getdate() or datediff(dd, @StartDate, getdate()) > 30)
	throw 50001, 'Invalid StartDate.', 1;
if(@EndDate is null or datediff(dd, @EndDate, getdate()) > 30 or @EndDate < @StartDate) 
	throw 50001, 'Invalid EndDate.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
insert into SalePhases(SalePhaseID, ServiceTypeID, StartDate, EndDate, Hide)
values (@SalePhaseID, @ServiceTypeID, @StartDate, @EndDate, @Hide)
go
exec CreateSalePhase 1,2,'2010-3-10','2010-4-1',0
--Update SalePhase
use HotelDB;
if object_id('UpdateSalePhase') is not null
	drop proc UpdateSalePhase;
go
create proc UpdateSalePhase
	(
	@SalePhaseID INT = null,
	@ServiceTypeID TINYINT = NULL,
	@StartDate date = NULL,
	@EndDate date = null,
	@Hide BIT = 0)
as
if not exists (select * from SalePhases where SalePhaseID = @SalePhaseID)
	throw 50001, 'Invalid SalePhaseID.', 1;
if not exists (select * from ServiceTypes where ServiceTypeID = @ServiceTypeID)
	throw 50001, 'Invalid ServiceTypeID.', 1;
if(@StartDate is null or @StartDate > getdate() or datediff(dd, @StartDate, getdate()) > 30)
	throw 50001, 'Invalid StartDate.', 1;
if(@EndDate is null or datediff(dd, @EndDate, getdate()) > 30 or @EndDate < @StartDate) 
	throw 50001, 'Invalid EndDate.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
update SalePhases
set 
	ServiceTypeID = @ServiceTypeID, 
	StartDate = @StartDate, 
	EndDate = @EndDate, 
	Hide = @Hide
	where 	SalePhaseID = @SalePhaseID
go
exec UpdateSalePhase 1,null,'2010-9-10','2010-4-1',1
--Delete SalePhase
use HotelDB;
if object_id('DeleteSalePhase') is not null
	drop proc DeleteSalePhase;
go
create proc DeleteSalePhase
	(
	@SalePhaseID INT = null)
as
if not exists (select * from SalePhases where SalePhaseID = @SalePhaseID)
	throw 50001, 'Invalid SalePhaseID.', 1;
delete SalePhases
	where 	SalePhaseID = @SalePhaseID
go

--Create Employee Type
use HotelDB;
if object_id('CreateEmployeeType') is not null
	drop proc CreateEmployeeType;
go
create proc CreateEmployeeType
	(
	@EmployeeTypeID TINYINT = NULL,
	@EmployeeTypeName NVARCHAR(30) = NULL,
	@Hide BIT = 0)
as
if exists (select * from EmployeeTypes where EmployeeTypeID = @EmployeeTypeID)
	throw 50001, 'Invalid EmployeeTypeID.', 1;
if (@EmployeeTypeName is null)
	throw 50001, 'Invalid EmployeeTypeName.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
insert into EmployeeTypes(EmployeeTypeID, EmployeeTypeName, Hide)
values (@EmployeeTypeID, @EmployeeTypeName, @Hide)
go
exec CreateEmployeeType 1,'abcd',1
--Update Employee Type
use HotelDB;
if object_id('UpdateEmployeeType') is not null
	drop proc UpdateEmployeeType;
go
create proc UpdateEmployeeType
	(
	@EmployeeTypeID TINYINT = NULL,
	@EmployeeTypeName NVARCHAR(30) = NULL,
	@Hide BIT = 0)
as
if not exists (select * from EmployeeTypes where EmployeeTypeID = @EmployeeTypeID)
	throw 50001, 'Invalid EmployeeTypeID.', 1;
if (@EmployeeTypeName is null)
	throw 50001, 'Invalid EmployeeTypeName.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
update EmployeeTypes
set 
	@EmployeeTypeName = @EmployeeTypeName, 
	Hide = @Hide
	where 	EmployeeTypeID = @EmployeeTypeID
go
exec UpdateEmployeeType 1,'abcde',0
--Delete Employee Type
use HotelDB;
if object_id('DeleteEmployeeType') is not null
	drop proc DeleteEmployeeType;
go
create proc DeleteEmployeeType
	(
	@EmployeeTypeID TINYINT = NULL)
as
if not exists (select * from EmployeeTypes where EmployeeTypeID = @EmployeeTypeID)
	throw 50001, 'Invalid EmployeeTypeID.', 1;
delete EmployeeTypes
where EmployeeTypeID = @EmployeeTypeID
go

--Create Employee
use HotelDB;
if object_id('CreateEmployee') is not null
	drop proc CreateEmployee;
go
create proc CreateEmployee
	(
	@EmployeeID VARCHAR(5) = NULL,
	@EmployeeName NVARCHAR(30) = NULL,
	@EmployeeTypeID TINYINT = NULL,
	@PhoneNumber INT = NULL,
	@IndetityCard INT =  NULL,
	@PassWord NVARCHAR(20) = NULL,
	@Hide BIT = 0)
as
if exists (select * from Employees where EmployeeID = @EmployeeID)
	throw 50001, 'Invalid EmployeeID.', 1;
if (@EmployeeName is null)
	throw 50001, 'Invalid EmployeeName.',1;
if not exists (select * from EmployeeTypes where EmployeeTypeID = @EmployeeTypeID)
	throw 50001, 'Invalid EmplyeeTypeID.', 1;
if (@PhoneNumber is null)
	throw 50001, 'Invalid PhoneNumber.',1;
if (@IndetityCard is null)
	throw 50001, 'Invalid IndetityCard.',1;
if (@PassWord is null)
	throw 50001, 'Invalid PassWord.',1;
if (@Hide is null)
	throw 50001, 'Invalid Hide.',1;
insert into Employees(EmployeeID, EmployeeName, EmployeeTypeID, PhoneNumber, IndetityCard, PassWord, Hide)
values (@EmployeeID, @EmployeeName, @EmployeeTypeID, @PhoneNumber, @IndetityCard, @PassWord, @Hide)
go
exec CreateEmployee '0001', 'Binh', 1, 0923123921, 3, 'abcdxyz', 0
--Update Employee
use HotelDB;
if object_id('UpdateEmployee') is not null
	drop proc UpdateEmployee;
go
create proc UpdateEmployee
	(
	@EmployeeID VARCHAR(5) = NULL,
	@EmployeeName NVARCHAR(30) = NULL,
	@EmployeeTypeID TINYINT = NULL,
	@PhoneNumber INT = NULL,
	@IndetityCard INT =  NULL,
	@PassWord NVARCHAR(20) = NULL,
	@Hide BIT = 0)
as
if not exists (select * from Employees where EmployeeID = @EmployeeID)
	throw 50001, 'Invalid EmployeeID.', 1;
if (@EmployeeName is null)
	throw 50001, 'Invalid EmployeeName.',1;
if not exists (select * from EmployeeTypes where EmployeeTypeID = @EmployeeTypeID)
	throw 50001, 'Invalid EmplyeeTypeID.', 1;
if (@PhoneNumber is null)
	throw 50001, 'Invalid PhoneNumber.',1;
if (@IndetityCard is null)
	throw 50001, 'Invalid IndetityCard.',1;
if (@PassWord is null)
	throw 50001, 'Invalid PassWord.',1;
if (@Hide is null)
	throw 50001, 'Invalid Hide.',1;
update Employees
set 
	EmployeeName = @EmployeeName, 
	EmployeeTypeID = @EmployeeTypeID, 
	PhoneNumber = @PhoneNumber, 
	IndetityCard = @IndetityCard, 
	PassWord = @PassWord, 
	Hide = @Hide
	where 	EmployeeID = @EmployeeID
go
exec UpdateEmployee '0001', 'Binh', 1, 0923123921, 3, 'abcdxyz00', 0
--Delete Employee
use HotelDB;
if object_id('DeleteEmployee') is not null
	drop proc DeleteEmployee;
go
create proc DeleteEmployee
	(
	@EmployeeID VARCHAR(5) = NULL)
as
if not exists (select * from Employees where EmployeeID = @EmployeeID)
	throw 50001, 'Invalid EmployeeID.', 1;
delete Employees
where 	EmployeeID = @EmployeeID
go

--Create Booking
use HotelDB;
if object_id('CreateBooking') is not null
	drop proc CreateBooking;
go
create proc CreateBooking
	(
	@CustomerID INT = NULL,
	@RoomID VARCHAR(5) = NULL,
	@AppoinmentDate smalldatetime = NULL,
	@Hide BIT = 0)
as
if exists (select * from Booking where CustomerID = @CustomerID and RoomID = @RoomID)
	throw 50001, 'Invalid CustomerID and RoomID.', 1;
if not exists (select * from Customers where CustomerID = @CustomerID)
	throw 50001, 'Invalid CustomerID.',1;
if not exists (select * from Rooms where RoomID = @RoomID)
	throw 50001, 'Invalid RoomID.',1;
if(@AppoinmentDate is null or @AppoinmentDate > getdate() or datediff(dd, @AppoinmentDate, getdate()) > 30)
	throw 50001, 'Invalid AppoinmentDate.', 1;
if (@Hide is null)
	throw 50001, 'Invalid Hide.',1;
insert into Booking(CustomerID, RoomID, AppoinmentDate, Hide)
values (@CustomerID, @RoomID, @AppoinmentDate, @Hide)
go
exec CreateBooking 2,'00003','2010-3-10', 0
--Update Booking
use HotelDB;
if object_id('UpdateBooking') is not null
	drop proc UpdateBooking;
go
create proc UpdateBooking
	(
	@CustomerID INT = NULL,
	@RoomID VARCHAR(5) = NULL,
	@AppoinmentDate smalldatetime = NULL,
	@Hide BIT = 0)
as
if not exists (select * from Booking where CustomerID = @CustomerID and RoomID = @RoomID)
	throw 50001, 'Invalid CustomerID and RoomID.',1;
if(@AppoinmentDate is null or @AppoinmentDate > getdate() or datediff(dd, @AppoinmentDate, getdate()) > 30)
	throw 50001, 'Invalid AppoinmentDate.', 1;
if (@Hide is null)
	throw 50001, 'Invalid Hide.',1;
update Booking
set
	AppoinmentDate = @AppoinmentDate, 
	Hide = @Hide
	where CustomerID = @CustomerID and RoomID = @RoomID 
go
exec UpdateBooking 2,'00003','2010-3-11', 1
--Delete Booking
use HotelDB;
if object_id('DeleteBooking') is not null
	drop proc DeleteBooking;
go
create proc DeleteBooking
	(
	@CustomerID INT = NULL,
	@RoomID VARCHAR(5) = NULL)
as
if not exists (select * from Booking where CustomerID = @CustomerID and RoomID = @RoomID)
	throw 50001, 'Invalid CustomerID and RoomID.',1;
delete Booking
where CustomerID = @CustomerID and RoomID = @RoomID 
go
exec DeleteBooking 2,'00003'

--Create Invoice
use HotelDB;
if object_id('CreateInvoice') is not null
	drop proc CreateInvoice;
go
create proc CreateInvoice
	(
	@InvoiceID INT = NULL,
	@CustomerID INT = NULL,
	@RoomID VARCHAR(5) = NULL,
	@NumberOfDay TINYINT = NULL,
	@EmployeeID VARCHAR(5) = NULL,
	@InvoiceTotal SMALLMONEY = NULL,
	@CheckInDate smalldatetime = NULL,
	@CheckOutDate smalldatetime =null,
	@Hide BIT = 0)
as
if exists (select * from Invoices where InvoiceID = @InvoiceID)
	throw 50001, 'Invalid InvoiceID.',1;
if not exists (select * from Customers where CustomerID = @CustomerID)
	throw 50001, 'Invalid CustomerID.',1;
if not exists (select * from Rooms where RoomID = @RoomID)
	throw 50001, 'Invalid RoomID.',1;
if not exists (select * from Booking where CustomerID = @CustomerID and RoomID = @RoomID)
	throw 50001, 'Invalid CustomerID and RoomID because they does not exist on Booking table.',1;
if (@NumberOfDay is null)
	throw 50001, 'Invalid NumberOfDay.', 1;
if not exists (select * from Employees where EmployeeID = @EmployeeID)
	throw 50001, 'Invalid EmployeeID.', 1;
if(@InvoiceTotal is null or @InvoiceTotal < 0)
	throw 50001, 'Invalid InvoiceTotal', 1;
if(@CheckInDate is null or @CheckInDate >= getdate() or datediff(dd, @CheckInDate, getdate()) > 30)
	throw 50001, 'Invalid CheckInDate.', 1;
if(@CheckOutDate is null or @CheckOutDate < @CheckInDate or @CheckOutDate > getdate() or datediff(dd, @CheckOutDate, getdate()) > 30)
	throw 50001, 'Invalid CheckOutDate.', 1;
if (@Hide is null)
	throw 50001, 'Invalid Hide.',1;	
insert into Invoices(InvoiceID, CustomerID, RoomID, NumberOfDay, EmployeeID, InvoiceTotal, CheckInDate, CheckOutDate, Hide)
values (@InvoiceID, @CustomerID, @RoomID, @NumberOfDay, @EmployeeID, @InvoiceTotal, @CheckInDate, @CheckOutDate, @Hide)
go
exec CreateInvoice 1,2,'00003',3,'0001',3000,4000,'2010-3-10',0
--Update Invoice
use HotelDB;
if object_id('UpdateInvoice') is not null
	drop proc UpdateInvoice;
go
create proc UpdateInvoice
	(
	@InvoiceID INT = NULL,
	@CustomerID INT = NULL,
	@RoomID VARCHAR(5) = NULL,
	@NumberOfDay TINYINT = NULL,
	@EmployeeID VARCHAR(5) = NULL,
	@InvoiceTotal SMALLMONEY = NULL,
	@CheckInDate smalldatetime = NULL,
	@CheckOutDate smalldatetime = NULL,
	@Hide BIT = 0)
as
if not exists (select * from Invoices where InvoiceID = @InvoiceID)
	throw 50001, 'Invalid InvoiceID.',1;
if not exists (select * from Customers where CustomerID = @CustomerID)
	throw 50001, 'Invalid CustomerID.',1;
if not exists (select * from Rooms where RoomID = @RoomID)
	throw 50001, 'Invalid RoomID.',1;
if not exists (select * from Booking where CustomerID = @CustomerID and RoomID = @RoomID)
	throw 50001, 'Invalid CustomerID and RoomID because they does not exist on Booking table.',1;
if (@NumberOfDay is null)
	throw 50001, 'Invalid NumberOfDay.', 1;
if not exists (select * from Employees where EmployeeID = @EmployeeID)
	throw 50001, 'Invalid EmployeeID.', 1;
if(@InvoiceTotal is null or @InvoiceTotal < 0)
	throw 50001, 'Invalid InvoiceTotal', 1;
if(@CheckInDate is null or @CheckInDate < 0)
	throw 50001, 'Invalid CheckInDate.', 1;
if(@CheckOutDate is null or @CheckOutDate > getdate() or datediff(dd, @CheckOutDate, getdate()) > 30)
	throw 50001, 'Invalid CheckOutDate.', 1;
if (@Hide is null)
	throw 50001, 'Invalid Hide.',1;	
update Invoices
set 
	CustomerID = @CustomerID, 
	RoomID = @RoomID, 
	NumberOfDay = @NumberOfDay, 
	EmployeeID = @EmployeeID, 
	InvoiceTotal = @InvoiceTotal, 
	CheckInDate = @CheckInDate, 
	CheckOutDate = @CheckOutDate, 
	Hide = @Hide
	where InvoiceID = @InvoiceID
go
exec UpdateInvoice 1,2,'00003',3,'0001',3500,4500,'2010-10-10',0
--Delete Invoice
use HotelDB;
if object_id('DeleteInvoice') is not null
	drop proc DeleteInvoice;
go
create proc DeleteInvoice
	(
	@InvoiceID INT = NULL)
as
if not exists (select * from Invoices where InvoiceID = @InvoiceID)
	throw 50001, 'Invalid InvoiceID.',1;
delete Invoices
	where InvoiceID = @InvoiceID
go
exec DeleteInvoice 1

--Create Invoice_Service
use HotelDB;
if object_id('CreateInvoice_Service') is not null
	drop proc CreateInvoice_Service;
go
create proc CreateInvoice_Service
	(
	@InvoiceID INT = NULL,
	@ServiceID int = NULL,
	@Times INT = 1,
	@Hide BIT = 0)
as
if exists (select * from Invoices_Services where InvoiceID = @InvoiceID and ServiceID = @ServiceID)
	throw 50001, 'Invalid InvoiceID and ServiceID.', 1;
if not exists (select * from Invoices where InvoiceID = @InvoiceID)
	throw 50001, 'Invalid InvoiceID.',1;
if not exists (select * from HotelServices where ServiceID = @ServiceID)
	throw 50001, 'Invalid ServiceID.',1;
if (@Times is null)
	throw 50001, 'Invalid Times.', 1;
if (@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
insert into Invoices_Services(InvoiceID, ServiceID, Times, Hide)
values (@InvoiceID, @ServiceID, @Times, @Hide)
go
exec CreateInvoice_Service 1,1

--Update Invoice_Service
use HotelDB;
if object_id('UpdateInvoice_Service') is not null
	drop proc UpdateInvoice_Service;
go
create proc UpdateInvoice_Service
	(
	@InvoiceID INT = NULL,
	@ServiceID int = NULL,
	@Times INT = 1,
	@Hide BIT = 0)
as
if not exists (select * from Invoices_Services where InvoiceID = @InvoiceID and ServiceID = @ServiceID)
	throw 50001, 'Invalid InvoiceID and ServiceID.', 1;
if not exists (select * from Invoices where InvoiceID = @InvoiceID)
	throw 50001, 'Invalid InvoiceID.',1;
if not exists (select * from HotelServices where ServiceID = @ServiceID)
	throw 50001, 'Invalid ServiceID.',1;
if (@Times is null)
	throw 50001, 'Invalid Times.', 1;
if (@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
update Invoices_Services
set 
	Times = @Times, 
	Hide = @Hide
	where 	InvoiceID = @InvoiceID and ServiceID = @ServiceID
go
exec UpdateInvoice_Service 1,1,5,1
--Delete Invoice_Service
use HotelDB;
if object_id('DeleteInvoice_Service') is not null
	drop proc DeleteInvoice_Service;
go
create proc DeleteInvoice_Service
	(
	@InvoiceID INT = NULL,
	@ServiceID int = NULL)
as
if not exists (select * from Invoices_Services where InvoiceID = @InvoiceID and ServiceID = @ServiceID)
	throw 50001, 'Invalid InvoiceID and ServiceID.', 1;
delete Invoices_Services
where InvoiceID = @InvoiceID and ServiceID = @ServiceID
go
exec DeleteInvoice_Service 1,1

---------------UNDO - REDO-----------------
drop table UndoTable
drop table RedoTable
create table UndoTable
(
	iID int identity,
	RoomID VARCHAR(5) null,
	RoomTypeID TINYINT null,
	OnFloor INT null,
	Hide BIT DEFAULT(0) NULL,
	iStatus varchar(10)
)
go
create table RedoTable
(
	iID int identity,
	RoomID VARCHAR(5) null,
	RoomTypeID TINYINT null,
	OnFloor INT null,
	Hide BIT DEFAULT(0) NULL,
	iStatus varchar(10)
)
go
drop trigger Undo_Rooms_Insert
drop trigger Undo_Rooms_Delete
drop trigger Undo_Rooms_Update
go
create trigger Undo_Rooms_Insert on Rooms
after insert
as
declare
	@RoomID varchar(5),
	@RoomTypeID TINYINT,
	@OnFloor INT,
	@Hide BIT;
select @RoomID = RoomID, @RoomTypeID = RoomTypeID, @OnFloor = Onfloor, @Hide = Hide
from inserted
insert UndoTable
values (@RoomID, @RoomTypeID, @OnFloor, @Hide,'inserted');
go

create trigger Undo_Rooms_Update on Rooms
instead of update
as
declare
	@RoomID varchar(5),
	@RoomTypeID TINYINT,
	@OnFloor INT,
	@Hide BIT;
select @RoomID = RoomID, @RoomTypeID = RoomTypeID, @OnFloor = Onfloor, @Hide = Hide
from inserted
insert UndoTable
select RoomID, RoomTypeID, OnFloor, Hide, 'updated' from Rooms where RoomID = @RoomID
update Rooms set RoomTypeID = @RoomTypeID, OnFloor = @OnFloor, Hide = @Hide where RoomID = @RoomID
go
create trigger Undo_Rooms_Delete on Rooms
after delete
as
declare
	@RoomID varchar(5),
	@RoomTypeID TINYINT,
	@OnFloor INT,
	@Hide BIT;
select @RoomID = RoomID, @RoomTypeID = RoomTypeID, @OnFloor = Onfloor, @Hide = Hide
from deleted
insert UndoTable
values (@RoomID, @RoomTypeID, @OnFloor, @Hide,'deleted');
go
exec CreateRoom 0009,1,9,1;
exec CreateRoom 0109,1,7,1;
exec CreateRoom 0105,1,7,1;
exec DeleteRoom 19;
go
drop proc UndoRooms
go
create proc UndoRooms
as
exec ('DISABLE TRIGGER Undo_Rooms_Insert ON Rooms')
exec ('DISABLE TRIGGER Undo_Rooms_Delete ON Rooms')
declare
	@RoomID varchar(5),
	@RoomTypeID TINYINT,
	@OnFloor INT,
	@Hide BIT,
	@iStatus varchar (10);
select top 1 @RoomID = RoomID, @RoomTypeID = RoomTypeID, @OnFloor = OnFloor, @Hide = Hide, @iStatus = iStatus from UndoTable order by iID desc
if((select top 1 iStatus from UndoTable order by iID desc) = 'inserted')
begin
	delete Rooms
	where RoomID = @RoomID;
	insert RedoTable
	values (@RoomID, @RoomTypeID, @OnFloor, @Hide, @iStatus);
	with t as (select top 1 * from UndoTable order by iID desc )
	delete from t;

end
else if((select top 1 iStatus from UndoTable order by iID desc) = 'deleted')
begin
	insert Rooms
	values (@RoomID, @RoomTypeID, @OnFloor, @Hide)
	insert RedoTable
	values (@RoomID, @RoomTypeID, @OnFloor, @Hide, @iStatus);
	with t as (select top 1 * from UndoTable order by iID desc )
	delete from t;

end
else if((select top 1 iStatus from UndoTable order by iID desc) = 'updated')
begin
	insert RedoTable
	select RoomID, RoomTypeID, OnFloor, Hide, 'updated' from Rooms where RoomID = @RoomID;
	delete Rooms
	where RoomID = @RoomID;
	insert Rooms
	values(@RoomID, @RoomTypeID, @OnFloor, @Hide);

	with t as (select top 1 * from UndoTable order by iID desc )
	delete from t;
end
exec ('ENABLE TRIGGER Undo_Rooms_Insert ON Rooms')
exec ('ENABLE TRIGGER Undo_Rooms_Delete ON Rooms')
go

drop proc RedoRooms
go
create proc RedoRooms
as
exec ('DISABLE TRIGGER Undo_Rooms_Insert ON Rooms')
exec ('DISABLE TRIGGER Undo_Rooms_Delete ON Rooms')
declare
	@RoomID varchar(5),
	@RoomTypeID TINYINT,
	@OnFloor INT,
	@Hide BIT,
	@iStatus varchar (10);
select top 1 @RoomID = RoomID, @RoomTypeID = RoomTypeID, @OnFloor = OnFloor, @Hide = Hide, @iStatus = iStatus from RedoTable order by iID desc
if((select top 1 iStatus from RedoTable order by iID desc) = 'inserted')
begin
	insert Rooms
	values (@RoomID, @RoomTypeID, @OnFloor, @Hide);
	insert UndoTable
	values (@RoomID, @RoomTypeID, @OnFloor, @Hide, @iStatus);
	with t as (select top 1 * from RedoTable order by iID desc )
	delete from t;
end
else if((select top 1 iStatus from RedoTable order by iID desc) = 'deleted')
begin
	delete Rooms
	where RoomID = @RoomID
	insert UndoTable
	values (@RoomID, @RoomTypeID, @OnFloor, @Hide, @iStatus);
	with t as (select top 1 * from RedoTable order by iID desc )
	delete from t;
end
else if((select top 1 iStatus from RedoTable order by iID desc) = 'updated')
begin
	insert UndoTable
	select RoomID, RoomTypeID, OnFloor, Hide, 'updated' from Rooms where RoomID = @RoomID;
	delete Rooms
	where RoomID = @RoomID
	insert Rooms
	values (@RoomID, @RoomTypeID, @OnFloor, @Hide);
	
	with t as (select top 1 * from RedoTable order by iID desc )
	delete from t;
end
exec ('ENABLE TRIGGER Undo_Rooms_Insert ON Rooms')
exec ('ENABLE TRIGGER Undo_Rooms_Delete ON Rooms')
go

exec RedoRooms
select * from rooms
select * from UndoTable
select * from RedoTable

exec UndoRooms
select * from rooms
select * from UndoTable
select * from RedoTable
go
exec UpdateRoom 4,1,10,0
exec CreateRoom 13,1,6,1
exec DeleteRoom 13