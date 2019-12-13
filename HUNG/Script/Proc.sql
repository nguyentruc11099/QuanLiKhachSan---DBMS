use HotelDB
go

if object_id('sp_Create') is not null
drop proc sp_Create
go
create proc sp_Create
(
	@TableName NVARCHAR(30)
)
as
BEGIN
	DECLARE @InfoColTempTable TABLE (ID INT IDENTITY(1,1) PRIMARY KEY,ColName sysname,ColType NVARCHAR(128), CharacterLength NVARCHAR(max))
	INSERT INTO @InfoColTempTable
	SELECT COLUMN_NAME,DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
	FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME= @TableName

	DECLARE @count INT = (SELECT COUNT(ID)
	FROM @InfoColTempTable)
	
	DECLARE @delsql AS NVARCHAR(max) = ' if object_id(''sp_Create'+@TableName+''') is not null
	drop proc sp_Create'+@TableName+';';
	PRINT @delsql;
	EXEC sp_executesql
		@stmt = @delsql;

	DECLARE @sql AS NVARCHAR(max) = 
	' Create procedure sp_Create' + @TableName + '(';
	DECLARE @cnt INT = 2
	WHILE @cnt <= @count
	BEGIN
		DECLARE @ColName AS NVARCHAR(20) =  (SELECT  ColName FROM @InfoColTempTable WHERE ID = @cnt); 
		DECLARE @ColType AS NVARCHAR(20) =  (SELECT  ColType FROM @InfoColTempTable WHERE ID = @cnt);
		DECLARE @CharacterLength AS NVARCHAR(20) =  (SELECT CharacterLength FROM @InfoColTempTable WHERE ID = @cnt);
		IF(@ColType = 'nvarchar' or @ColType = 'varchar')
			BEGIN
				SET  @sql += CHAR(13) +'@'+ @ColName +' '+@ColType+'('+@CharacterLength+') = NULL';
			END
		ELSE
			SET  @sql += CHAR(13) +'@'+ @ColName +' '+@ColType +' = NULL';
		IF(@cnt < @count)
			BEGIN
				SET @sql += ',';
			END
		SET @cnt = @cnt +1;
	END
	SET @sql += Char(13) + ')' + 
				char(13) + 'as' + CHAR(13) +'BEGIN'+ 
				char(13) + 'insert ' + @TableName + 
				char(13) + 'values ('
	SET @cnt = 2
	WHILE @cnt <= @count
		BEGIN
			SET @ColName = (select ColName from @InfoColTempTable where ID = @cnt );
			SET @sql +=  '@' + @ColName ;
			IF(@cnt < @count)
				BEGIN
					SET @sql += ',';
				END
			ELSE
				BEGIN
					SET @sql += ')';
				END
			SET @cnt = @cnt +1;
		END
	SET @sql += CHAR(13) +'END';
	print @sql
	exec sys.sp_executesql @sql
END
go

if object_id('sp_Update') is not null
drop proc sp_Update
go
create proc sp_Update
(
	@TableName NVARCHAR(30)
)
as
BEGIN
	DECLARE @InfoColTempTable TABLE (ID INT IDENTITY(1,1) PRIMARY KEY,ColName sysname,ColType NVARCHAR(128), CharacterLength NVARCHAR(max))
	INSERT INTO @InfoColTempTable
	SELECT COLUMN_NAME,DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
	FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME= @TableName

	DECLARE @delsql AS NVARCHAR(max) = ' if object_id(''sp_Update'+@TableName+''') is not null
	drop proc sp_Update'+@TableName+';';
	PRINT @delsql;
	EXEC sp_executesql
		@stmt = @delsql;

	DECLARE @count INT = (SELECT COUNT(ID)
	FROM @InfoColTempTable)
	DECLARE @sql AS NVARCHAR(max) = 'create procedure sp_Update' + @TableName + '(';
	DECLARE @cnt INT = 1
	WHILE @cnt <= @count
	BEGIN
		DECLARE @ColName AS NVARCHAR(20) =  (SELECT  ColName FROM @InfoColTempTable WHERE ID = @cnt); 
		DECLARE @ColType AS NVARCHAR(20) =  (SELECT  ColType FROM @InfoColTempTable WHERE ID = @cnt);
		DECLARE @CharacterLength AS NVARCHAR(20) =  (SELECT CharacterLength FROM @InfoColTempTable WHERE ID = @cnt);
		IF(@ColType = 'nvarchar' or @ColType = 'varchar')
			BEGIN
				SET  @sql += CHAR(13) +'@'+ @ColName +' '+@ColType+'('+@CharacterLength+') = NULL';
			END
		ELSE
			SET  @sql += CHAR(13) +'@'+ @ColName +' '+@ColType + '= NULL';
		IF(@cnt < @count)
			BEGIN
				SET @sql += ',';
			END
		SET @cnt = @cnt +1;
	END
	SET @ColName = (select ColName from @InfoColTempTable where ID = 1);
	SET @sql += Char(13) + ')' + 
				char(13) + 'as' + CHAR(13)+'BEGIN'+
				CHAR(13) + 'if not exists (select * from '+@TableName+' where '+@ColName+' = @'+@ColName+')
		throw 50001, ''Invalid RoomTypeID.'' , 1;'+
				char(13) + 'update ' + @TableName + 
				char(13) + 'set' 
	SET @cnt = 2
	WHILE @cnt <= @count
		BEGIN
			SET @ColName = (select ColName from @InfoColTempTable where ID = @cnt );
			SET @sql +=  char(13) + @ColName + '= @' + @ColName ;
			IF(@cnt < @count)
				BEGIN
					SET @sql += ',';
				END
			ELSE
				BEGIN
					SET @ColName = (Select ColName from @InfoColTempTable where ID = 1);
					SET @sql += char(13) + 'where ' + @ColName+ '= @' + @ColName + CHAR(13)+'END';
				END
			SET @cnt = @cnt +1;
		END
	print @sql
	exec sys.sp_executesql @sql
END
GO


if object_id('sp_Delete') is not null
drop proc sp_Delete
go
create proc sp_Delete
(
	@TableName NVARCHAR(30)
)
as
BEGIN
	DECLARE @InfoColTempTable TABLE (ID INT IDENTITY(1,1) PRIMARY KEY,ColName sysname,ColType NVARCHAR(128))
	INSERT INTO @InfoColTempTable
	SELECT COLUMN_NAME,DATA_TYPE
	FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME= @TableName

	DECLARE @delsql AS NVARCHAR(max) = ' if object_id(''sp_Delete'+@TableName+''') is not null
	drop proc sp_Delete'+@TableName+';';
	PRINT @delsql;
	EXEC sp_executesql
		@stmt = @delsql;

	DECLARE @sql AS NVARCHAR(max) = 'create procedure sp_Delete'+@TableName+'(';
	DECLARE @ColName AS NVARCHAR(20) =  (SELECT top (1) ColName FROM @InfoColTempTable ORDER BY ID ASC); 
	DECLARE @ColType AS NVARCHAR(20) =  (SELECT top (1) ColType FROM @InfoColTempTable ORDER BY ID ASC);  
	SET @sql += CHAR(13) +'@'+ @ColName +' '+@ColType + 
				Char(13)+ ')';
				SET @ColName = (select ColName from @InfoColTempTable where ID = 1);
				SET @sql += char(13) + 'as' + CHAR(13)+'BEGIN'+
				CHAR(13) + 'if not exists (select * from '+@TableName+' where '+@ColName+' = @'+@ColName+')
				throw 50001, ''Invalid RoomTypeID.'' , 1;'+
				char(13)+ 'delete ' + @TableName + 
				char(13) +'where '
	SET @ColName = (select top (1) ColName from @InfoColTempTable ORDER BY ID ASC);
	SET @sql +=  @ColName+ ' = @' + @ColName+CHAR(13)+ 'END';

	print @sql
	exec sys.sp_executesql
	@stmt = @sql;
END
GO

exec sp_Create @TableName = N'Rooms'
exec sp_Create @TableName = N'Employees'
exec sp_Create @TableName = N'Customers'
exec sp_Create @TableName = N'RoomTypes'
exec sp_Create @TableName = N'EmployeeTypes'
exec sp_Create @TableName = N'Booking'
exec sp_Create @TableName = N'Invoices'
exec sp_Create @TableName = N'HotelServices'
exec sp_Create @TableName = N'Invoices_Services'
go

exec sp_Update @TableName = N'Rooms'
exec sp_Update @TableName = N'Employees'
exec sp_Update @TableName = N'Customers'
exec sp_Update @TableName = N'RoomTypes'
exec sp_Update @TableName = N'EmployeeTypes'
exec sp_Update @TableName = N'Booking'
exec sp_Update @TableName = N'Invoices'
exec sp_Update @TableName = N'HotelServices'
exec sp_Update @TableName = N'Invoices_Services'
go

exec sp_Delete @TableName = N'Rooms'
exec sp_Delete @TableName = N'Employees'
exec sp_Delete @TableName = N'Customers'
exec sp_Delete @TableName = N'RoomTypes'
exec sp_Delete @TableName = N'EmployeeTypes'
exec sp_Delete @TableName = N'Booking'
exec sp_Delete @TableName = N'Invoices'
exec sp_Delete @TableName = N'HotelServices'
exec sp_Delete @TableName = N'Invoices_Services'
GO

-----------------------------------Undo_Redo_Table-----------------------
if object_id ('sp_Create_Undo_Table') is not null
	drop proc sp_Create_Undo_Table
GO
create proc sp_Create_Undo_Table
(
	@TableName NVARCHAR(100)
)
AS
BEGIN
	
	 DECLARE @InfoColTempTable TABLE (ID INT IDENTITY(1,1) PRIMARY KEY,ColName sysname,ColType NVARCHAR(128), CharLength NVARCHAR(100))
	 INSERT INTO @InfoColTempTable
	 SELECT COLUMN_NAME,DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
	 FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME= @TableName

	 DECLARE @count INT = (SELECT COUNT(ID)
	 FROM @InfoColTempTable)
	 DECLARE @delsql AS NVARCHAR(max) = ' if object_id(''Undo_'+@TableName+''') is not null
	 drop table Undo_'+@TableName+';';
	 PRINT @delsql;
	 EXEC sp_executesql
	 @stmt = @delsql;
	 DECLARE @sql AS NVARCHAR(max) =	'create table Undo_' + @TableName + char(13)+ 
										'(' + char(13) +
										'iID INT IDENTITY, ';
	declare @cnt INT = 1;
	while @cnt <= @count
	begin
		DECLARE @ColName as nvarchar(100) = (select ColName from @InfoColTempTable where ID = @cnt);
		DECLARE @ColType as nvarchar(100) = (select ColType from @InfoColTempTable where ID = @cnt);
		DECLARE @CharLength as nvarchar(100) = (select CharLength from @InfoColTempTable where ID = @cnt);
		SET @sql += char(13) +@ColName + ' ' + @ColType ;
		if(@ColType = 'nvarchar' or @ColType = 'varchar')
		begin
			SET @sql += '('+@CharLength+')';
		end
		if(@cnt <= @count)
		begin
			SET @sql += ',';
		end
		SET @cnt = @cnt +1;
	end
	SET @sql += char(13) + 'iStatus nvarchar(20)' + char(13) + ')';
	print @sql;
	exec sys.sp_executesql @sql
END
GO
if object_id ('sp_Create_Redo_Table') is not null
	drop proc sp_Create_Redo_Table
GO
create proc sp_Create_Redo_Table
(
	@TableName NVARCHAR(100)
)
AS
BEGIN
	
	 DECLARE @InfoColTempTable TABLE (ID INT IDENTITY(1,1) PRIMARY KEY,ColName sysname,ColType NVARCHAR(128), CharLength NVARCHAR(100))
	 INSERT INTO @InfoColTempTable
	 SELECT COLUMN_NAME,DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
	 FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME= @TableName

	 DECLARE @count INT = (SELECT COUNT(ID)
	 FROM @InfoColTempTable)
	 DECLARE @delsql AS NVARCHAR(max) = ' if object_id(''Redo_'+@TableName+''') is not null
	 drop table Redo_'+@TableName+';';
	 PRINT @delsql;
	 EXEC sp_executesql
	 @stmt = @delsql;
	 DECLARE @sql AS NVARCHAR(max) =	'create table Redo_' + @TableName + char(13)+ 
										'(' + char(13) +
										'iID INT IDENTITY, ';
	declare @cnt INT = 1;
	while @cnt <= @count
	begin
		DECLARE @ColName as nvarchar(100) = (select ColName from @InfoColTempTable where ID = @cnt);
		DECLARE @ColType as nvarchar(100) = (select ColType from @InfoColTempTable where ID = @cnt);
		DECLARE @CharLength as nvarchar(100) = (select CharLength from @InfoColTempTable where ID = @cnt);
		SET @sql += char(13) +@ColName + ' ' + @ColType ;
		if(@ColType = 'nvarchar' or @ColType = 'varchar')
		begin
			SET @sql += '('+@CharLength+')';
		end
		if(@cnt <= @count)
		begin
			SET @sql += ',';
		end
		SET @cnt = @cnt +1;
	end
	SET @sql += char(13) + 'iStatus nvarchar(20)' + char(13) + ')';
	print @sql;
	exec sys.sp_executesql @sql
END
GO

exec sp_Create_Undo_Table @TableName = N'Rooms'
exec sp_Create_Undo_Table @TableName = N'Employees'
exec sp_Create_Undo_Table @TableName = N'Customers'
exec sp_Create_Undo_Table @TableName = N'RoomTypes'
exec sp_Create_Undo_Table @TableName = N'EmployeeTypes'
exec sp_Create_Undo_Table @TableName = N'Booking'
exec sp_Create_Undo_Table @TableName = N'Invoices'
exec sp_Create_Undo_Table @TableName = N'HotelServices'
exec sp_Create_Undo_Table @TableName = N'Invoices_Services'
go

exec sp_Create_Redo_Table @TableName = N'Rooms'
exec sp_Create_Redo_Table @TableName = N'Employees'
exec sp_Create_Redo_Table @TableName = N'Customers'
exec sp_Create_Redo_Table @TableName = N'RoomTypes'
exec sp_Create_Redo_Table @TableName = N'EmployeeTypes'
exec sp_Create_Redo_Table @TableName = N'Booking'
exec sp_Create_Redo_Table @TableName = N'Invoices'
exec sp_Create_Redo_Table @TableName = N'HotelServices'
exec sp_Create_Redo_Table @TableName = N'Invoices_Services'
GO

if object_id('sp_Create_Trigger_Delete') is not null
	drop proc sp_Create_Trigger_Delete
go
create proc sp_Create_Trigger_Delete
(
	@TableName NVARCHAR(100)
)
AS
BEGIN
	
	 DECLARE @InfoColTempTable TABLE (ID INT IDENTITY(1,1) PRIMARY KEY,ColName sysname,ColType NVARCHAR(128), CharLength NVARCHAR(100))
	 INSERT INTO @InfoColTempTable
	 SELECT COLUMN_NAME,DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
	 FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME= @TableName

	 DECLARE @count INT = (SELECT COUNT(ID)
	 FROM @InfoColTempTable)

	 DECLARE @delsql AS NVARCHAR(max) = ' if object_id('''+@TableName+'_DELETE'') is not null
	 drop trigger '+@TableName+'_DELETE;';
	 PRINT @delsql;
	 EXEC sp_executesql
	 @stmt = @delsql;

	 DECLARE @sql AS NVARCHAR(max) =	'create trigger ' + @TableName + '_DELETE on ' + @TableName + char(13)+
										'after delete' + char(13)+
										'as' + char(13)+'Begin'+char(13)+'Begin try'+char(13)+'Begin tran;'+char(13)+
										'declare';
	declare @cnt INT = 1;
	while @cnt <= @count
	begin
		DECLARE @ColName as nvarchar(100) = (select ColName from @InfoColTempTable where ID = @cnt);
		DECLARE @ColType as nvarchar(100) = (select ColType from @InfoColTempTable where ID = @cnt);
		DECLARE @CharLength as nvarchar(100) = (select CharLength from @InfoColTempTable where ID = @cnt)
		SET @sql += char(13) + '@'+@ColName + ' ' + @ColType;
		if(@ColType = 'nvarchar' or @ColType = 'varchar')
		begin
			SET @sql += '('+@CharLength+')';
		end
		if(@cnt < @count)
		begin
			SET @sql += ',';
		end
		SET @cnt = @cnt +1;
	end
	SET @cnt = 1;
	SET @sql += char(13) + 'select '
	while @cnt <= @count
	begin
		SET @ColName = (select ColName from @InfoColTempTable where ID = @cnt);
		SET @sql += '@'+@ColName +' = ' +@ColName
		if(@cnt < @count)
		begin
			SET @sql += ','
		end
		SET @cnt = @cnt +1
	end
	SET @sql += char(13) + 'from deleted'+char(13)+
				'insert Undo_' + @TableName + char(13)+
				'values ('
	SET @cnt = 1;
	while @cnt <= @count
	begin
		SET @ColName = (select ColName from @InfoColTempTable where ID = @cnt);
		SET @sql += '@'+@ColName
		if(@cnt <= @count)
		begin
			SET @sql += ','
		end
		SET @cnt = @cnt +1
	end
	SET @sql += '''deleted'');'+char(13)+'commit tran;'+char(13)+'end try'+char(13)+'begin catch'+char(13)+'rollback tran;'+char(13)+'end catch'+char(13)+'end';
	print @sql
	exec sys.sp_executesql @sql
END
go

exec sp_Create_Trigger_Delete @TableName = N'Rooms'
exec sp_Create_Trigger_Delete @TableName = N'Employees'
exec sp_Create_Trigger_Delete @TableName = N'Customers'
exec sp_Create_Trigger_Delete @TableName = N'RoomTypes'
exec sp_Create_Trigger_Delete @TableName = N'EmployeeTypes'
exec sp_Create_Trigger_Delete @TableName = N'Booking'
exec sp_Create_Trigger_Delete @TableName = N'Invoices'
exec sp_Create_Trigger_Delete @TableName = N'HotelServices'
exec sp_Create_Trigger_Delete @TableName = N'Invoices_Services'
GO

if object_id('sp_Create_Trigger_Create') is not null
	drop proc sp_Create_Trigger_Create
go
create proc sp_Create_Trigger_Create
(
	@TableName NVARCHAR(100)
)
AS
BEGIN
	
	 DECLARE @InfoColTempTable TABLE (ID INT IDENTITY(1,1) PRIMARY KEY,ColName sysname,ColType NVARCHAR(128), CharLength NVARCHAR(100))
	 INSERT INTO @InfoColTempTable
	 SELECT COLUMN_NAME,DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
	 FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME= @TableName

	 DECLARE @count INT = (SELECT COUNT(ID)
	 FROM @InfoColTempTable)

	  DECLARE @delsql AS NVARCHAR(max) = ' if object_id('''+@TableName+'_CREATE'') is not null
	 drop trigger '+@TableName+'_CREATE;';
	 PRINT @delsql;
	 EXEC sp_executesql
	 @stmt = @delsql;

	 DECLARE @sql AS NVARCHAR(max) =	'create trigger ' + @TableName + '_CREATE on ' + @TableName + char(13)+
										'after insert' + char(13)+
										'as' + char(13)+'Begin'+char(13)+'Begin try'+char(13)+'Begin tran;'+char(13)+
										'declare';
	declare @cnt INT = 1;
	while @cnt <= @count
	begin
		DECLARE @ColName as nvarchar(100) = (select ColName from @InfoColTempTable where ID = @cnt);
		DECLARE @ColType as nvarchar(100) = (select ColType from @InfoColTempTable where ID = @cnt);
		DECLARE @CharLength as nvarchar(100) = (select CharLength from @InfoColTempTable where ID = @cnt)
		SET @sql += char(13) + '@'+@ColName + ' ' + @ColType;
		if(@ColType = 'nvarchar' or @ColType = 'varchar')
		begin
			SET @sql += '('+@CharLength+')';
		end
		if(@cnt < @count)
		begin
			SET @sql += ',';
		end
		SET @cnt = @cnt +1;
	end
	SET @cnt = 1;
	SET @sql += char(13) + 'select '

	while @cnt <= @count
	begin
		SET @ColName = (select ColName from @InfoColTempTable where ID = @cnt);
		SET @sql += '@'+@ColName +' = ' +@ColName
		if(@cnt < @count)
		begin
			SET @sql += ','
		end
		SET @cnt = @cnt +1
	end
	SET @sql += char(13) + 'from inserted'+char(13)+
				'insert Undo_' + @TableName + char(13)+
				'values ('
	SET @cnt = 1;
	while @cnt <= @count
	begin
		SET @ColName = (select ColName from @InfoColTempTable where ID = @cnt);
		SET @sql += '@'+@ColName
		if(@cnt <= @count)
		begin
			SET @sql += ','
		end
		SET @cnt = @cnt +1
	end
	SET @sql += '''inserted'');'+char(13)+'commit tran;'+char(13)+'end try'+char(13)+'begin catch'+char(13)+'rollback tran;'+char(13)+'end catch'+char(13)+'end';
	print @sql
	exec sys.sp_executesql @sql
END
go
exec sp_Create_Trigger_Create @TableName = N'Rooms'
exec sp_Create_Trigger_Create @TableName = N'Employees'
exec sp_Create_Trigger_Create @TableName = N'Customers'
exec sp_Create_Trigger_Create @TableName = N'RoomTypes'
exec sp_Create_Trigger_Create @TableName = N'EmployeeTypes'
exec sp_Create_Trigger_Create @TableName = N'Booking'
exec sp_Create_Trigger_Create @TableName = N'Invoices'
exec sp_Create_Trigger_Create @TableName = N'HotelServices'
exec sp_Create_Trigger_Create @TableName = N'Invoices_Services'
GO

if object_id('sp_Create_Trigger_Update') is not null
	drop proc sp_Create_Trigger_Update
go
create proc sp_Create_Trigger_Update
(
	@TableName NVARCHAR(100)
)
AS
BEGIN
	
	 DECLARE @InfoColTempTable TABLE (ID INT IDENTITY(1,1) PRIMARY KEY,ColName sysname,ColType NVARCHAR(128), CharLength NVARCHAR(100))
	 INSERT INTO @InfoColTempTable
	 SELECT COLUMN_NAME,DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
	 FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME= @TableName

	 DECLARE @count INT = (SELECT COUNT(ID)
	 FROM @InfoColTempTable)

	 DECLARE @delsql AS NVARCHAR(max) = ' if object_id('''+@TableName+'_UPDATE'') is not null
	 drop trigger '+@TableName+'_UPDATE;';
	 PRINT @delsql;
	 EXEC sp_executesql
	 @stmt = @delsql;

	 DECLARE @sql AS NVARCHAR(max) =	'create trigger ' + @TableName + '_UPDATE on ' + @TableName + char(13)+
										'instead of update' + char(13)+
										'as' + char(13)+'Begin'+char(13)+'Begin try'+char(13)+'Begin tran;'+char(13)+
										'declare';
	declare @cnt INT = 1;
	while @cnt <= @count
	begin
		DECLARE @ColName as nvarchar(100) = (select ColName from @InfoColTempTable where ID = @cnt);
		DECLARE @ColType as nvarchar(100) = (select ColType from @InfoColTempTable where ID = @cnt);
		DECLARE @CharLength as nvarchar(100) = (select CharLength from @InfoColTempTable where ID = @cnt)
		SET @sql += char(13) + '@'+@ColName + ' ' + @ColType;
		if(@ColType = 'nvarchar' or @ColType = 'varchar')
		begin
			SET @sql += '('+@CharLength+')';
		end
		if(@cnt < @count)
		begin
			SET @sql += ',';
		end
		SET @cnt = @cnt +1;
	end
	SET @cnt = 1;
	SET @sql += char(13) + 'select '
	while @cnt <= @count
	begin
		SET @ColName = (select ColName from @InfoColTempTable where ID = @cnt);
		SET @sql += '@'+@ColName +' = ' +@ColName
		if(@cnt < @count)
		begin
			SET @sql += ','
		end
		SET @cnt = @cnt +1
	end
	SET @sql += char(13) + 'from inserted'+char(13)+
				'insert Undo_' + @TableName + char(13)+
				'select '
	SET @cnt = 1;
	while @cnt <= @count
	begin
		SET @ColName = (select ColName from @InfoColTempTable where ID = @cnt);
		SET @sql += @ColName
		if(@cnt <= @count)
		begin
			SET @sql += ','
		end
		SET @cnt = @cnt +1
	end
	SET @ColName = (select ColName from @InfoColTempTable where ID = 1);
	SET @sql += '''updated'' from '+@TableName+' where '+ @ColName +' = @' +@ColName+char(13)+
				'update '+@TableName+' set ';
	SET @cnt = 2;
	while @cnt <= @count
	begin
		SET @ColName = (select ColName from @InfoColTempTable where ID = @cnt);
		SET @sql += @ColName +' = @' +@ColName 
		if(@cnt < @count)
		begin
			SET @sql += ','
		end
		SET @cnt = @cnt +1
	end
	SET @ColName = (select ColName from @InfoColTempTable where ID = 1);
	SET @sql += ' where ' + @ColName+ ' = @' + @ColName; 
	Set @sql += char(13)+'commit tran;'+char(13)+'end try'+char(13)+'begin catch'+char(13)+'rollback tran;'+char(13)+'end catch'+char(13)+'end';
	print @sql
	exec sys.sp_executesql @sql
END
go
exec sp_Create_Trigger_Update @TableName = N'Rooms'
exec sp_Create_Trigger_Update @TableName = N'Employees'
exec sp_Create_Trigger_Update @TableName = N'Customers'
exec sp_Create_Trigger_Update @TableName = N'RoomTypes'
exec sp_Create_Trigger_Update @TableName = N'EmployeeTypes'
exec sp_Create_Trigger_Update @TableName = N'Booking'
exec sp_Create_Trigger_Update @TableName = N'Invoices'
exec sp_Create_Trigger_Update @TableName = N'HotelServices'
exec sp_Create_Trigger_Update @TableName = N'Invoices_Services'
GO

use HotelDB;
if object_id('sp_Create_Undo') is not null
	drop proc sp_Create_Undo;
go
CREATE PROC sp_Create_Undo
(
	@TableName NVARCHAR(30)
)
AS
BEGIN
	
	 DECLARE @InfoColTempTable TABLE (ID INT IDENTITY(1,1) PRIMARY KEY,ColName sysname,ColType NVARCHAR(128), CharLength NVARCHAR(100))
	 INSERT INTO @InfoColTempTable
	 SELECT COLUMN_NAME,DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
	 FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME= @TableName

	 DECLARE @count INT = (SELECT COUNT(ID)
	 FROM @InfoColTempTable)

	 DECLARE @delsql AS NVARCHAR(max) = ' if object_id(''sp_Undo_'+@TableName+''') is not null
	 drop proc sp_Undo_'+@TableName+';';
	 PRINT @delsql;
	 EXEC sp_executesql
	 @stmt = @delsql;

	 DECLARE @sql AS NVARCHAR(max) = N'create procedure sp_Undo_'+@TableName+char(13)+
	 'as'+char(13)+
	 'BEGIN'+char(13)+
	 'SET IDENTITY_INSERT '+@TableName+ ' ON'+char(13)+
	 'exec (''DISABLE TRIGGER '+@TableName+'_Create ON '+@TableName+''')'+ char(13)+
	 'exec (''DISABLE TRIGGER '+@TableName+'_Delete ON '+@TableName+''')' + char(13)+
	 'exec (''DISABLE TRIGGER '+@TableName+'_Update ON '+@TableName+''')'+ char(13)+
	 
	 
	 'declare';

	 DECLARE @cnt INT = 1;
	 WHILE @cnt <= @count
	 BEGIN	
		DECLARE @ColName AS NVARCHAR(20) =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
	 	DECLARE @ColType AS NVARCHAR(20) =  (SELECT ColType FROM @InfoColTempTable WHERE ID = @cnt);  
		DECLARE @CharLength AS NVARCHAR(20) =  (SELECT CharLength FROM @InfoColTempTable WHERE ID = @cnt);  
		SET @sql += CHAR(13) +'	@'+ @ColName +' '+@ColType ;
		if(@ColType = 'varchar' or @ColType = 'nvarchar')
		begin
			SET @sql += '('+@CharLength+')';
		end
		SET @sql += ', '
		SET @cnt = @cnt + 1;
	 END;
		SET @sql += CHAR(13) + '	@iStatus varchar(10);' + CHAR(13);

	 SET @sql += 'select top 1';
	 SET @cnt = 1;
	 WHILE @cnt <= @count
	 BEGIN
	 	set @ColName = (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
		SET @sql += ' @'+ @ColName +'='+@ColName+',';
		SET @cnt = @cnt + 1;
	 END;
		SET @sql +='@iStatus = iStatus from Undo_'+@TableName+' order by iID desc'+char(13);
	
	SET @ColName = (select ColName from @InfoColTempTable where ID = 1)
	SET @sql += 'IF((select top 1 iStatus from Undo_'+@TableName+' order by iID desc) = ''inserted'')'+char(13)+
	'begin'+ char(13)+'begin try'+ char(13)+'begin tran;'+char(13)+
		'	delete '+ @TableName +char(13)+
		'	where '+ @ColName +' = @' + @ColName+ char(13)+
		'	insert Redo_'+ @TableName + char(13)+
		'	values ('
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += '@'+@ColName + ', ';
			SET @cnt = @cnt + 1;
		END
		SET @sql +=	'@iStatus);' +char(13)+
					'	with t as (select top 1 * from Undo_'+@TableName+' order by iID desc)'+char(13)+
					'	delete from t'+char(13)+'commit tran;'+char(13)+'end try'+ char(13)+'begin catch'+char(13)+'rollback tran;'+char(13)+'end catch'+char(13)+
	'end'+char(13)+
	'else if((select top 1 iStatus from Undo_'+@TableName+' order by iID desc) = ''deleted'')'+char(13)+
	'begin'+char(13)+'begin try'+ char(13)+'begin tran;'+char(13)+
		'	insert '+ @TableName+'('
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += @ColName;
			if(@cnt < @count)
			begin
				SET @sql += ', '
			end
			SET @cnt = @cnt + 1;
		END
		SET @sql +=	')' +char(13)+
		'	values ('
		SET @cnt =1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += '@'+@ColName;
			if(@cnt < @count)
			begin
				SET @sql += ', '
			end
			SET @cnt = @cnt + 1;
		END
		SET @sql +=	')' +char(13)+
		'	insert Redo_'+ @TableName+char(13)+
		'	values ('
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += '@'+@ColName + ', ';
			SET @cnt = @cnt + 1;
		END
		SET @sql +=	'@iStatus);' +char(13)+
					'	with t as (select top 1 * from Undo_'+@TableName+' order by iID desc )'+char(13)+
					'	delete from t;'+char(13)+'commit tran;'+char(13)+'end try'+ char(13)+'begin catch'+char(13)+'rollback tran;'+char(13)+'end catch'+char(13)+
	'end'+char(13)+
	'else if((select top 1 iStatus from Undo_'+@TableName+' order by iID desc) = ''updated'')'+char(13)+	
	'begin'+char(13)+'begin try'+ char(13)+'begin tran;'+char(13)+
		'	insert Redo_'+ @TableName +char(13)+
		'	select ' 
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += @ColName + ', ';
			SET @cnt = @cnt + 1;
		END
		SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = 1); 
		SET @sql +=	'''updated'' from '+@TableName+ ' where '+ @ColName + ' = @'+@ColName+';'+char(13)+
		'	delete '+ @TableName+ char(13)+
		'	where ' + @ColName + ' = @'+@ColName+';'+char(13)+
		'	insert '+ @TableName+'(';
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += @ColName;
			if(@cnt < @count)
			begin
				SET @sql += ', '
			end
			SET @cnt = @cnt + 1;
		END
		SET @sql+=')'+char(13)+
		'	values('
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += '@'+@ColName;
			if(@cnt < @count)
			begin
				SET @sql += ', '
			end
			SET @cnt = @cnt + 1;
		END
		SET @sql +=	');' +char(13)+
		'	with t as (select top 1 * from Undo_'+@TableName+' order by iID desc )'+char(13)+
		'	delete from t;' + char(13)+'commit tran;'+char(13)+'end try'+ char(13)+'begin catch'+char(13)+'rollback tran;'+char(13)+'end catch'+char(13)+
	'end'+char(13)+
	'exec (''ENABLE TRIGGER '+@TableName+'_Create ON ' + @TableName+ ''')'+char(13)+
	'exec (''ENABLE TRIGGER '+@TableName+'_Delete ON ' + @TableName+ ''')'+char(13)+
	'exec (''ENABLE TRIGGER '+@TableName+'_Update ON ' + @TableName+ ''')'+char(13)+
	'SET IDENTITY_INSERT '+@TableName+ ' OFF'+char(13)+
	'END';
	print @sql
	exec sys.sp_executesql @sql
END
go

if object_id('sp_Create_Redo') is not null
	drop proc sp_Create_Redo;
go
CREATE PROC sp_Create_Redo
(
	@TableName NVARCHAR(30)
)
AS
BEGIN
	
	 DECLARE @InfoColTempTable TABLE (ID INT IDENTITY(1,1) PRIMARY KEY,ColName sysname,ColType NVARCHAR(128), CharLength NVARCHAR(100))
	 INSERT INTO @InfoColTempTable
	 SELECT COLUMN_NAME,DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
	 FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME= @TableName

	 DECLARE @count INT = (SELECT COUNT(ID)
	 FROM @InfoColTempTable)

	  DECLARE @delsql AS NVARCHAR(max) = ' if object_id(''sp_Redo_'+@TableName+''') is not null
	 drop proc sp_Redo_'+@TableName+';';
	 PRINT @delsql;
	 EXEC sp_executesql
	 @stmt = @delsql;

	 DECLARE @sql AS NVARCHAR(max) = N'create procedure sp_Redo_'+@TableName+char(13)+
	 'as'+char(13)+
	 'BEGIN'+char(13)+
	 'SET IDENTITY_INSERT '+@TableName+ ' ON'+char(13)+
	 'exec (''DISABLE TRIGGER '+@TableName+'_Create ON '+@TableName+''')'+ char(13)+
	 'exec (''DISABLE TRIGGER '+@TableName+'_Delete ON '+@TableName+''')' + char(13)+
	 'exec (''DISABLE TRIGGER '+@TableName+'_Update ON '+@TableName+''')'+ char(13)+
	 
	 
	 'declare';

	 DECLARE @cnt INT = 1;
	 WHILE @cnt <= @count
	 BEGIN	
		DECLARE @ColName AS NVARCHAR(20) =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
	 	DECLARE @ColType AS NVARCHAR(20) =  (SELECT ColType FROM @InfoColTempTable WHERE ID = @cnt);  
		DECLARE @CharLength AS NVARCHAR(20) =  (SELECT CharLength FROM @InfoColTempTable WHERE ID = @cnt);  
		SET @sql += CHAR(13) +'	@'+ @ColName +' '+@ColType ;
		if(@ColType = 'varchar' or @ColType = 'nvarchar')
		begin
			SET @sql += '('+@CharLength+')';
		end
		SET @sql += ', '
		SET @cnt = @cnt + 1;
	 END;
		SET @sql += CHAR(13) + '	@iStatus varchar(10);' + CHAR(13);

	 SET @sql += 'select top 1';
	 SET @cnt = 1;
	 WHILE @cnt <= @count
	 BEGIN
	 	set @ColName = (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
		SET @sql += ' @'+ @ColName +'='+@ColName+',';
		SET @cnt = @cnt + 1;
	 END;
		SET @sql +='@iStatus = iStatus from Redo_'+@TableName+' order by iID desc'+char(13);
	
	SET @ColName = (select ColName from @InfoColTempTable where ID = 1)
	SET @sql += 'IF((select top 1 iStatus from Redo_'+@TableName+' order by iID desc) = ''inserted'')'+char(13)+
	'begin'+char(13)+'begin try'+ char(13)+'begin tran;'+char(13)+
	'	insert '+ @TableName+'('
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += @ColName;
			if(@cnt < @count)
			begin
				SET @sql += ', '
			end
			SET @cnt = @cnt + 1;
		END
		SET @sql +=	')' +char(13)+
		'	values ('
		SET @cnt =1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += '@'+@ColName;
			if(@cnt < @count)
			begin
				SET @sql += ', '
			end
			SET @cnt = @cnt + 1;
		END
		SET @sql +=	')' +char(13)+
		'	insert Undo_'+ @TableName + char(13)+
		'	values ('
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += '@'+@ColName + ', ';
			SET @cnt = @cnt + 1;
		END
		SET @sql +=	'@iStatus);' +char(13)+
					'	with t as (select top 1 * from Redo_'+@TableName+' order by iID desc)'+char(13)+
					'	delete from t'+ char(13)+'commit tran;'+char(13)+'end try'+ char(13)+'begin catch'+char(13)+'rollback tran;'+char(13)+'end catch'+char(13)+
	'end'+char(13)+
	'else if((select top 1 iStatus from Redo_'+@TableName+' order by iID desc) = ''deleted'')'+char(13)+
		'begin'+char(13)+'begin try'+ char(13)+'begin tran;'+char(13);
		SET @ColName = (select ColName from @InfoColTempTable where ID = 1)
		SET @sql += '	delete '+ @TableName +char(13)+
		'	where '+ @ColName +' = @' + @ColName+ char(13)+
		'	insert Undo_'+ @TableName+char(13)+
		'	values ('
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += '@'+@ColName + ', ';
			SET @cnt = @cnt + 1;
		END
		SET @sql +=	'@iStatus);' +char(13)+
					'	with t as (select top 1 * from Redo_'+@TableName+' order by iID desc )'+char(13)+
					'	delete from t;'+char(13)+'commit tran;'+char(13)+'end try'+ char(13)+'begin catch'+char(13)+'rollback tran;'+char(13)+'end catch'+char(13)+
	'end'+char(13)+
	'else if((select top 1 iStatus from Redo_'+@TableName+' order by iID desc) = ''updated'')'+char(13)+	
	'begin'+char(13)+'begin try'+ char(13)+'begin tran;'+char(13)+
		'	insert Undo_'+ @TableName +char(13)+
		'	select ' 
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += @ColName + ', ';
			SET @cnt = @cnt + 1;
		END
		SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = 1); 
		SET @sql +=	'''updated'' from '+@TableName+ ' where '+ @ColName + ' = @'+@ColName+';'+char(13)+
		'	delete '+ @TableName+ char(13)+
		'	where ' + @ColName + ' = @'+@ColName+';'+char(13)+
		'	insert '+ @TableName+'(';
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += @ColName;
			if(@cnt < @count)
			begin
				SET @sql += ', '
			end
			SET @cnt = @cnt + 1;
		END
		SET @sql+=')'+char(13)+
		'	values('
		SET @cnt = 1
		WHILE @cnt <= @count
		BEGIN
			SET @ColName =  (SELECT ColName FROM @InfoColTempTable WHERE ID = @cnt); 
			SET @sql += '@'+@ColName;
			if(@cnt < @count)
			begin
				SET @sql += ', '
			end
			SET @cnt = @cnt + 1;
		END
		SET @sql +=	');' +char(13)+
		'	with t as (select top 1 * from Redo_'+@TableName+' order by iID desc )'+char(13)+
		'	delete from t;'+char(13)+'commit tran;'+char(13)+'end try'+ char(13)+'begin catch'+char(13)+'rollback tran;'+char(13)+'end catch'+char(13)+
	'end'+char(13)+
	'exec (''ENABLE TRIGGER '+@TableName+'_Create ON ' + @TableName+ ''')'+char(13)+
	'exec (''ENABLE TRIGGER '+@TableName+'_Delete ON ' + @TableName+ ''')'+char(13)+
	'exec (''ENABLE TRIGGER '+@TableName+'_Update ON ' + @TableName+ ''')'+char(13)+
	'SET IDENTITY_INSERT '+@TableName+ ' OFF'+char(13)+
	'END';
	print @sql
	exec sys.sp_executesql @sql
END
GO

EXEC dbo.sp_Create_Undo @TableName = N'Rooms'
exec dbo.sp_Create_Undo @TableName = N'Employees'
exec dbo.sp_Create_Undo @TableName = N'Customers'
exec dbo.sp_Create_Undo @TableName = N'RoomTypes'
exec dbo.sp_Create_Undo @TableName = N'EmployeeTypes'
exec dbo.sp_Create_Undo @TableName = N'Booking'
exec dbo.sp_Create_Undo @TableName = N'Invoices'
exec dbo.sp_Create_Undo @TableName = N'HotelServices'
exec dbo.sp_Create_Undo @TableName = N'Invoices_Services'
go

EXEC dbo.sp_Create_Redo @TableName = N'Rooms'
exec dbo.sp_Create_Redo @TableName = N'Employees'
exec dbo.sp_Create_Redo @TableName = N'Customers'
exec dbo.sp_Create_Redo @TableName = N'RoomTypes'
exec dbo.sp_Create_Redo @TableName = N'EmployeeTypes'
exec dbo.sp_Create_Redo @TableName = N'Booking'
exec dbo.sp_Create_Redo @TableName = N'Invoices'
exec dbo.sp_Create_Redo @TableName = N'HotelServices'
exec dbo.sp_Create_Redo @TableName = N'Invoices_Services'
GO





--Other Function 

-- LoadRoom for booking and checkin form 
use HotelDB;
if object_id('sp_LoadRoom') is not null
	drop PROCEDURE sp_LoadRoom;
go
create PROCEDURE sp_LoadRoom
AS 
BEGIN 
	SELECT RoomID,Rooms.RoomTypeID,OnFloor,Status,dbo.RoomTypes.Name 
	FROM Rooms INNER JOIN dbo.RoomTypes ON Rooms.RoomTypeID = RoomTypes.RoomTypeID 
	ORDER BY OnFloor ASC 
END 
go
 

-- FindRoom
use HotelDB;
if object_id('sp_FindRoom') is not null
	drop PROCEDURE sp_FindRoom;
go
create PROCEDURE sp_FindRoom
(
	@RoomID INT
)
AS 
BEGIN 
	SELECT RoomID,Rooms.RoomTypeID,OnFloor,Status,dbo.RoomTypes.Name AS Type 
	FROM Rooms INNER JOIN dbo.RoomTypes ON Rooms.RoomTypeID = RoomTypes.RoomTypeID 
	WHERE RoomID = @RoomID;
END 
go


--Employee Table

-- Authenication User
use HotelDB;
if object_id('sp_LoginEmployee') is not null
	drop proc sp_LoginEmployee;
go
create proc sp_LoginEmployee
	(
		@Account int,
		@Password NVARCHAR(20),
		@EmployeeType TINYINT
	)
as
BEGIN
	DECLARE @id AS INT;
	DECLARE @sql AS NVARCHAR(200) = 'SELECT @EmpID=EmployeeID FROM dbo.Employees WHERE EmployeeTypeID = @type and IdentityCard = @acc AND PassWord = @pass';
	DECLARE @params AS NVARCHAR(100)= '@acc int,@pass nvarchar(20),@type tinyint, @EmpID int output';
	EXEC sys.sp_executesql @sql, @params , @acc = @Account, @pass = @Password, @type = @EmployeeType, @EmpID = @id OUTPUT;
	SELECT @id
END
go

-- Find Employee
use HotelDB;
if object_id('sp_FindEmployee') is not null
	drop Proc sp_FindEmployee;
go
create proc sp_FindEmployee
(
	@EmployeeID int
)
as
Begin
	SELECT * FROM dbo.Employees WHERE EmployeeID = @EmployeeID;
END
go

--Find Booking for checkin form 
use HotelDB;
if object_id('fn_FindBooking') is not null
	drop FUNCTION fn_FindBooking;
go
create FUNCTION fn_FindBooking
	(
		@RoomID INT = NULL
	)
RETURNS TABLE

RETURN (SELECT BookingID,Booking.CustomerID,CustomerName,Booking.RoomID FROM ( Booking INNER JOIN dbo.Customers ON Booking.CustomerID = Customers.CustomerID ) INNER JOIN dbo.Rooms ON Booking.RoomID = Rooms.RoomID WHERE Booking.RoomID = 5);
go

-- Booking method 
use HotelDB;
if object_id('sp_Booking') is not null
	drop proc sp_Booking;
go
create proc sp_Booking
	(
		@CustomerID INT = NULL,
		@RoomID INT = NULL,
		@AppoinmentDate SMALLDATETIME = NULL
	)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			insert into dbo.Booking(CustomerID, RoomID, AppoinmentDate)
			values (@CustomerID, @RoomID, @AppoinmentDate);			
			UPDATE dbo.Rooms SET Status=2 WHERE RoomID=@RoomID; 
		COMMIT TRAN
	END TRY 
	BEGIN CATCH
		rollback tran;
		throw 50001, 'Failed ', 1;
	END CATCH
END
GO


-- Checkin method
use HotelDB;
if object_id('sp_CheckIn') is not null
	drop proc sp_CheckIn;
go
create proc sp_CheckIn
	(
		@CustomerID INT = NULL,
		@RoomID INT = NULL,
		@EmployeeID INT = NULL 
	)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			insert into dbo.Invoices (CustomerID, RoomID, EmployeeID, InvoiceTotal, CheckInDate, CheckOutDate,HasPaid)
				VALUES (@CustomerID, @RoomID, null, @EmployeeID, CAST(CAST(GETDATE() AS DATE) AS SMALLDATETIME),NULL,0)
			UPDATE dbo.Rooms SET Status = 1 WHERE RoomID = @RoomID; 
			
			IF( EXISTS(SELECT BookingID FROM dbo.Booking WHERE CustomerID=@CustomerID AND RoomID = RoomID))
			BEGIN
				DECLARE @ID AS INT = (SELECT BookingID FROM dbo.Booking WHERE CustomerID=@CustomerID AND RoomID = RoomID); 
				DELETE dbo.Booking WHERE BookingID = @ID;
			END 
		COMMIT TRAN
	END TRY 
	BEGIN CATCH
		rollback tran;
		throw 50001, 'Failed ', 1;
	END CATCH
END
GO

-- Checkout method 
use HotelDB;
if object_id('sp_CheckOut') is not null
	drop proc sp_CheckOut;
go
create proc sp_CheckOut
	(
		@RoomID INT = NULL
	)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN	
			UPDATE dbo.Invoices SET InvoiceTotal = dbo.fn_RoomPrice(@RoomID) + dbo.fn_ServicePrice(@RoomID), CheckOutDate = CAST(CAST(GETDATE() AS DATE) AS SMALLDATETIME), HasPaid = 1 WHERE RoomID = @RoomID AND HasPaid = 0;  
			UPDATE dbo.Rooms SET Status = 0 WHERE RoomID = @RoomID; 
		COMMIT TRAN
	END TRY 
	BEGIN CATCH
		rollback tran;
		throw 50001, 'Failed ', 1;
	END CATCH
END
GO


-- Cal Room Price
use HotelDB;
if object_id('fn_RoomPrice') is not null
	drop FUNCTION fn_RoomPrice;
go
create FUNCTION fn_RoomPrice
	(
		@RoomID INT = NULL
	)
RETURNS Money
BEGIN
	DECLARE @startdate AS SMALLDATETIME

	SET @startdate = (SELECT CheckInDate FROM dbo.Invoices WHERE RoomID = @RoomID AND HasPaid = 0);

	DECLARE @Price AS MONEY = ( SELECT c.Price FROM dbo.Invoices a INNER JOIN dbo.Rooms b ON a.RoomID = b.RoomID INNER JOIN dbo.RoomTypes c ON b.RoomTypeID = c.RoomTypeID WHERE a.RoomID = @RoomID AND a.HasPaid = 0); 

	DECLARE @pay AS MONEY = DATEDIFF(day, @startdate,getdate()) * @Price

	RETURN @pay;
END
go

-- Cal ServicePrice  
use HotelDB;
if object_id('fn_ServicePrice') is not null
	drop FUNCTION fn_ServicePrice;
go
create FUNCTION fn_ServicePrice
	(
		@RoomID INT = NULL
	)
RETURNS Money
BEGIN
	DECLARE @ID AS INT = (SELECT InvoiceID FROM dbo.Invoices WHERE RoomID= @RoomID AND HasPaid = 0);
	DECLARE @pay AS MONEY =0;
	SET @pay += (SELECT Sum(Times*Price) AS Price FROM dbo.Invoices_Services INNER JOIN dbo.HotelServices ON HotelServices.ServiceID = Invoices_Services.ServiceID WHERE InvoiceID = @ID);
	RETURN @pay;
END
GO

-- Get data about room of an invoice  
use HotelDB;
if object_id('sp_FindInvoiceRoomPrice') is not null
	drop Proc sp_FindInvoiceRoomPrice;
go
create proc sp_FindInvoiceRoomPrice
(
	@RoomID INT = NULL
)
as
Begin
	SELECT a.InvoiceID,a.CustomerID, d.CustomerName, a.CheckInDate,a.CheckOutDate,c.Name,c.Price FROM (SELECT * FROM dbo.Invoices WHERE RoomID = @RoomID AND HasPaid=0) a INNER JOIN dbo.Rooms b ON a.RoomID = b.RoomID INNER JOIN dbo.RoomTypes c ON c.RoomTypeID= b.RoomTypeID INNER JOIN dbo.Customers d ON a.CustomerID = d.CustomerID;
END
GO


-- Get data about service of an invoice  
use HotelDB;
if object_id('sp_FindInvoiceServicePrice') is not null
	drop Proc sp_FindInvoiceServicePrice;
go
create proc sp_FindInvoiceServicePrice
(
	@RoomID INT = NULL
)
as
Begin
	SELECT A.InvoiceID,b.ServiceID,c.ServiceName,b.Times, c.Price FROM (SELECT * FROM dbo.Invoices WHERE RoomID= @RoomID AND HasPaid=0) a INNER JOIN dbo.Invoices_Services b ON a.InvoiceID = b.InvoiceID INNER JOIN dbo.HotelServices c ON b.ServiceID = c.ServiceID 
END
GO

-- Calculate the total money in each month
if object_id('fn_Revenue') is not null
drop function fn_Revenue
go
create function fn_Revenue(@month nvarchar(50), @year nvarchar(50))
returns smallmoney
begin
	if(@month != 'None')
	begin
	return(select sum(InvoiceTotal) 
			from Invoices
			where	FORMAT(CheckOutDate - 1,'MMM', 'en-US') = @month and 
					year(cast(CheckOutDate as nvarchar(50))) = @year)
	end
	return(select sum(InvoiceTotal) 
		from Invoices
		where year(cast(CheckOutDate as nvarchar(50))) = @year)
end
go


use HotelDB;
if object_id('sp_Revenue5Month') is not null
drop Proc sp_Revenue5Month
go
create Proc sp_Revenue5Month
AS
begin
	DECLARE @month as nvarchar(20) = month(cast(getdate() as nvarchar(50)));
	DECLARE @year as int = year(cast(getdate() as nvarchar(50)));
	DECLARE @TempTable TABLE (ID INT identity(1,1) PRIMARY KEY, [Month] int, Revenue decimal);
	Declare @cnt INT = 0;
		If(@month<=4)
		begin 
			while @cnt < @month
			begin
				INSERT INTO @TempTable
				SELECT (@month-@cnt) as Month, SUM(InvoiceTotal) as Total 			 
				FROM Invoices WHERE month(cast(CheckOutDate as nvarchar(50))) = @month-@cnt and 
									year(cast(CheckOutDate as nvarchar(50))) = @year and HasPaid=1;
				SET @cnt = @cnt +1;
			end
		end
		else 
		begin
			while @cnt < 5
			begin
				INSERT INTO @TempTable
				SELECT (@month-@cnt) as Month, SUM(InvoiceTotal) as Total 			 
				FROM Invoices WHERE month(cast(CheckOutDate as nvarchar(50))) = @month-@cnt and 
									year(cast(CheckOutDate as nvarchar(50))) = @year and HasPaid=1;
				SET @cnt = @cnt +1;
			end
		end 
	Select Month,Revenue from @TempTable;
end
go


USE HotelDB;
IF OBJECT_ID(N'dbo.sp_SearchCustomer', N'P') IS NOT NULL DROP PROC dbo.sp_SearchCustomer;
GO
CREATE PROC dbo.sp_SearchCustomer
(
	@CustomerName AS nvarchar(30) = NULL,
	@IdentityCard AS nvarchar(10) = NULL
)
AS
BEGIN
	if @CustomerName is not null
	SET @CustomerName = @CustomerName + '%';

	if @IdentityCard is not null
	SET @IdentityCard = @IdentityCard + '%'

	DECLARE @sql AS NVARCHAR(1000);
	SET @sql =
	N'SELECT CustomerID, CustomerName,IdentityCard, PhoneNumber'
	+ N' FROM dbo.Customers where 1=1 '
	+ CASE WHEN @CustomerName IS NOT NULL THEN
	N'AND CustomerName like @cna ' ELSE N'' END
	+ CASE WHEN @IdentityCard IS NOT NULL THEN
	N'AND IdentityCard like @cid ' ELSE N'' END
	print @sql;
	EXEC sp_executesql
	@stmt = @sql,
	@params = N'@cna AS nvarchar(30), @cid AS nvarchar(10)',
	@cna = @CustomerName,
	@cid = @IdentityCard
END
GO

IF OBJECT_ID(N'dbo.sp_OutDateBooking', N'P') IS NOT NULL DROP PROC dbo.sp_OutDateBooking;
go
CREATE PROC dbo.sp_OutDateBooking
AS
BEGIN
	begin try 
		begin tran;
			select * from Booking Where AppoinmentDate < CAST(CAST(GETDATE() AS DATE) AS SMALLDATETIME);
			delete dbo.Booking where AppoinmentDate < CAST(CAST(GETDATE() AS DATE) AS SMALLDATETIME);
		commit tran;
	end try
	begin catch
		 rollback tran;
	end catch 
END
GO
