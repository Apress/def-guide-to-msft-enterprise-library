USE [master]
GO
/****** Object:  Database [ACMEDb]    Script Date: 5/5/2007 13:16:47 ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'ACMEDb')
DROP DATABASE [ACMEDb]
GO
/****** Object:  Database [ACMEDb]    Script Date: 5/5/2007 13:03:02 ******/
CREATE DATABASE [ACMEDb] ON  PRIMARY 
( NAME = N'ACMEDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\ACMEDb.mdf' , SIZE = 2240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ACMEDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\ACMEDb_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'ACMEDb', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ACMEDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ACMEDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ACMEDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ACMEDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ACMEDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ACMEDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ACMEDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ACMEDb] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ACMEDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ACMEDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ACMEDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ACMEDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ACMEDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ACMEDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ACMEDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ACMEDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ACMEDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ACMEDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ACMEDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ACMEDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ACMEDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ACMEDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ACMEDb] SET  READ_WRITE 
GO
ALTER DATABASE [ACMEDb] SET RECOVERY FULL 
GO
ALTER DATABASE [ACMEDb] SET  MULTI_USER 
GO
ALTER DATABASE [ACMEDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ACMEDb] SET DB_CHAINING OFF 
GO

USE [ACMEDb]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/5/2007 13:04:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[MemberSince] [datetime] NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Address]    Script Date: 5/5/2007 13:04:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[State] [varchar](2) NOT NULL,
	[ZipCode] [varchar](20) NOT NULL,
	[IsPrimaryShipping] [bit] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaymentMethod]    Script Date: 5/5/2007 13:04:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PaymentMethod](
	[PaymentMethodId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[PaymentMethodId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BillingMethod]    Script Date: 5/5/2007 13:04:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BillingMethod](
	[BillingMethodId] [int] IDENTITY(1,1) NOT NULL,
	[PaymentMethodId] [int] NOT NULL,
	[CreditCardNumber] [varchar](20) NULL,
	[CreditCardExpiration] [datetime] NULL,
	[CreditCardBillingAddressId] [int] NULL,
	[CustomerId] [int] NOT NULL,
	[NetTermDays] [int] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_BillingMethod] PRIMARY KEY CLUSTERED 
(
	[BillingMethodId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[RethrowError]    Script Date: 5/5/2007 13:04:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RethrowError] AS
    /* Return if there is no error information to retrieve. */
    IF ERROR_NUMBER() IS NULL
        RETURN;

    DECLARE
        @ErrorMessage    NVARCHAR(4000),
        @ErrorNumber     INT,
        @ErrorSeverity   INT,
        @ErrorState      INT,
        @ErrorLine       INT,
        @ErrorProcedure  NVARCHAR(200); 

    /* Assign variables to error-handling functions that
       capture information for RAISERROR. */

    SELECT
        @ErrorNumber = ERROR_NUMBER(),
        @ErrorSeverity = ERROR_SEVERITY(),
        @ErrorState = ERROR_STATE(),
        @ErrorLine = ERROR_LINE(),
        @ErrorProcedure = ISNULL(ERROR_PROCEDURE(), '-'); 

    /* Building the message string that will contain original
       error information. */

    SELECT @ErrorMessage = 
        N'Error %d, Level %d, State %d, Procedure %s, Line %d, ' + 
         'Message: '+ ERROR_MESSAGE(); 

    /* Raise an error: msg_str parameter of RAISERROR will contain
	   the original error information. */

    RAISERROR(@ErrorMessage, @ErrorSeverity, 1,
        @ErrorNumber,    /* parameter: original error number. */
        @ErrorSeverity,  /* parameter: original error severity. */
        @ErrorState,     /* parameter: original error state. */
        @ErrorProcedure, /* parameter: original error procedure name. */
        @ErrorLine       /* parameter: original error line number. */
        );
GO
/****** Object:  StoredProcedure [dbo].[usp_Customer_Save]    Script Date: 5/5/2007 13:04:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Customer_Save]
    @birthDate datetime,
	@customerId int OUT,
	@firstName varchar(50),
	@isActive bit = 1,
	@lastName varchar(50),
	@memberSince datetime
AS
BEGIN
	SET NOCOUNT ON
	
	BEGIN TRY
	
	IF(EXISTS(SELECT * FROM [dbo].[Customer] WHERE [CustomerId]=@customerId))
	BEGIN
		UPDATE [dbo].[Customer] 
		SET [BirthDate] = @birthDate, [FirstName] = @firstName, [IsActive] = @isActive, [LastName] = @lastName, [MemberSince] = @memberSince
		WHERE [CustomerId]=@customerId

		IF @@ROWCOUNT = 0
		BEGIN
			RAISERROR('Concurrent update error. Updated aborted.', 16, 2)
		END
	END
	ELSE
	BEGIN
		INSERT INTO [dbo].[Customer] ([BirthDate], [FirstName], [IsActive], [LastName], [MemberSince])
		VALUES (@birthDate, @firstName, @isActive, @lastName, @memberSince)
		SET @customerId = SCOPE_IDENTITY()
	END
	
    END TRY

    BEGIN CATCH
		EXEC RethrowError;
	END CATCH
    
    SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Customer_List]    Script Date: 5/5/2007 13:04:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Customer_List]    
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
	[customer].[BirthDate] AS 'BirthDate',
	[customer].[CustomerId] AS 'CustomerId',
	[customer].[FirstName] AS 'FirstName',
	[customer].[IsActive] AS 'IsActive',
	[customer].[LastName] AS 'LastName',
	[customer].[MemberSince] AS 'MemberSince'
FROM [dbo].[Customer] [customer]
WHERE [customer].[IsActive] = 1

	SET NOCOUNT OFF
END
GO

/****** Object:  StoredProcedure [dbo].[usp_Address_List]    Script Date: 5/5/2007 13:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Address_List]  
	@CustomerId int  
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
	[address].[AddressId] AS 'AddressId',
	[address].[CustomerId] AS 'CustomerId',
	[address].[Address] AS 'Address',
	[address].[City] AS 'City',
	[address].[State] AS 'State',
	[address].[ZipCode] AS 'ZipCode',
	[address].[IsPrimaryShipping] AS 'IsPrimaryShipping',
	[address].[IsActive] AS 'IsActive'
FROM [dbo].[Address] [address]
WHERE [address].[IsActive] = 1 AND [address].[CustomerId] = @CustomerId

	SET NOCOUNT OFF
END
GO

/****** Object:  StoredProcedure [dbo].[usp_BillingMethod_List]    Script Date: 5/5/2007 13:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_BillingMethod_List]  
	@CustomerId int  
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT
	[billingMethod].[BillingMethodId] AS 'BillingMethodId',
	[billingMethod].[CustomerId] AS 'CustomerId',
	[billingMethod].[PaymentMethodId] AS 'PaymentMethodId',
	[billingMethod].[CreditCardNumber] AS 'CreditCardNumber',
	[billingMethod].[CreditCardExpiration] AS 'CreditCardExpiration',
	[billingMethod].[CreditCardBillingAddressId] AS 'CreditCardBillingAddressId',
	[billingMethod].[NetTermDays] AS 'NetTermDays',
	[billingMethod].[IsActive] AS 'IsActive'
FROM [dbo].[BillingMethod] [billingMethod]
WHERE [billingMethod].[IsActive] = 1 AND [billingMethod].[CustomerId] = @CustomerId

	SET NOCOUNT OFF
END
GO

INSERT INTO [dbo].[PaymentMethod] ([PaymentMethodId], [Name])
VALUES (1, 'Credit Card')

INSERT INTO [dbo].[PaymentMethod] ([PaymentMethodId], [Name])
VALUES (2, 'Net Term')