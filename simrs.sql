    USE [master]
GO
/****** Object:  Database [simrs]    Script Date: 14/01/2024 23:38:15 ******/
CREATE DATABASE [simrs]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'simrs', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\simrs.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'simrs_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\simrs_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [simrs] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [simrs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [simrs] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [simrs] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [simrs] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [simrs] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [simrs] SET ARITHABORT OFF 
GO
ALTER DATABASE [simrs] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [simrs] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [simrs] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [simrs] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [simrs] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [simrs] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [simrs] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [simrs] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [simrs] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [simrs] SET  DISABLE_BROKER 
GO
ALTER DATABASE [simrs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [simrs] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [simrs] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [simrs] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [simrs] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [simrs] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [simrs] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [simrs] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [simrs] SET  MULTI_USER 
GO
ALTER DATABASE [simrs] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [simrs] SET DB_CHAINING OFF 
GO
ALTER DATABASE [simrs] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [simrs] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [simrs] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [simrs] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [simrs] SET QUERY_STORE = ON
GO
ALTER DATABASE [simrs] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [simrs]
GO
/****** Object:  Table [dbo].[users]    Script Date: 14/01/2024 23:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](150) NOT NULL,
	[password] [binary](64) NOT NULL,
	[salt] [uniqueidentifier] NOT NULL,
	[default_role] [varchar](15) NOT NULL,
	[email] [varchar](150) NULL,
	[nomor_hp] [varchar](50) NULL,
	[nama_lengkap] [varchar](150) NULL,
	[jk] [char](1) NOT NULL,
	[tempat_lahir] [varchar](100) NULL,
	[tanggal_lahir] [date] NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_email] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_nomor_hp] UNIQUE NONCLUSTERED 
(
	[nomor_hp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_jk]  DEFAULT ('L') FOR [jk]
GO
/****** Object:  StoredProcedure [dbo].[uspAddUser]    Script Date: 14/01/2024 23:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspAddUser]
    @pUsername VARCHAR(150), 
    @pPassword VARCHAR(50), 
    @pDefaultRole VARCHAR(15), 
    @pEmail VARCHAR(150),
	@pNomorHP VARCHAR(50),
	@pNamaLengkap VARCHAR(150),
	@pJK CHAR(1),
	@pTempatLahir VARCHAR(100),
	@pTanggalLahir VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON
	DECLARE @salt UNIQUEIDENTIFIER=NEWID()
    BEGIN TRY

        INSERT INTO dbo.[users] (username, "password", salt, default_role, email, nomor_hp, nama_lengkap, jk, tempat_lahir, tanggal_lahir, created_at, updated_at)
        VALUES(@pUsername, HASHBYTES('SHA2_512', @pPassword+CAST(@salt AS NVARCHAR(36))), @salt, @pDefaultRole, @pEmail, @pNomorHP, @pNamaLengkap, @pJK, @pTempatLahir, @pTanggalLahir, GETDATE(), GETDATE())

    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);  
		DECLARE @ErrorSeverity INT;  
		DECLARE @ErrorState INT;  

		SELECT   
			@ErrorMessage = ERROR_MESSAGE(),  
			@ErrorSeverity = ERROR_SEVERITY(),  
			@ErrorState = ERROR_STATE();  

		-- Use RAISERROR inside the CATCH block to return error  
		-- information about the original error that caused  
		-- execution to jump to the CATCH block.  
		RAISERROR (@ErrorMessage, -- Message text.  
				   @ErrorSeverity, -- Severity.  
				   @ErrorState -- State.  
				 );   
		-- SELECT ERROR_NUMBER() AS ErrorNumber
		-- ,ERROR_SEVERITY() AS ErrorSeverity
		-- ,ERROR_STATE() AS ErrorState
		-- ,ERROR_PROCEDURE() AS ErrorProcedure
		-- ,ERROR_LINE() AS ErrorLine
		-- ,ERROR_MESSAGE() AS ErrorMessage;
    END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[uspUpdateUser]    Script Date: 19/01/2024 07:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspUpdateUser]
	@pOldUserid INT,
	@pUsername VARCHAR(150) = NULL, 
    @pPassword VARCHAR(50) = NULL,
    @pDefaultRole VARCHAR(15), 
    @pEmail VARCHAR(150),
	@pNomorHP VARCHAR(50),
	@pNamaLengkap VARCHAR(150),
	@pJK CHAR(1),
	@pTempatLahir VARCHAR(100),
	@pTanggalLahir VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON
	DECLARE @salt UNIQUEIDENTIFIER=NEWID()
    BEGIN TRY
		IF ISNULL(@pPassword, '') <> ''
		BEGIN
			UPDATE dbo.[users] SET "password"=HASHBYTES('SHA2_512', @pPassword+CAST(@salt AS NVARCHAR(36))), salt=@salt WHERE id=@pOldUserid
		END
		IF ISNULL(@pUsername, '') <> ''
		BEGIN
			UPDATE dbo.[users] SET username=@pUsername WHERE id=@pOldUserid
		END
		UPDATE dbo.[users] SET default_role=@pDefaultRole, email= @pEmail, nomor_hp=@pNomorHP, nama_lengkap=@pNamaLengkap, jk=@pJK, tempat_lahir=@pTempatLahir, tanggal_lahir=@pTanggalLahir, updated_at=GETDATE() WHERE id=@pOldUserid
    END TRY
    BEGIN CATCH

		DECLARE @ErrorMessage NVARCHAR(4000);  
		DECLARE @ErrorSeverity INT;  
		DECLARE @ErrorState INT;  

		SELECT   
			@ErrorMessage = ERROR_MESSAGE(),  
			@ErrorSeverity = ERROR_SEVERITY(),  
			@ErrorState = ERROR_STATE();  

		-- Use RAISERROR inside the CATCH block to return error  
		-- information about the original error that caused  
		-- execution to jump to the CATCH block.  
		RAISERROR (@ErrorMessage, -- Message text.  
				   @ErrorSeverity, -- Severity.  
				   @ErrorState -- State.  
				 );   
		-- SELECT ERROR_NUMBER() AS ErrorNumber
		-- ,ERROR_SEVERITY() AS ErrorSeverity
		-- ,ERROR_STATE() AS ErrorState
		-- ,ERROR_PROCEDURE() AS ErrorProcedure
		-- ,ERROR_LINE() AS ErrorLine
		-- ,ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspLogin]    Script Date: 14/01/2024 23:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspLogin]
    @pUsername NVARCHAR(254),
    @pPassword NVARCHAR(50),
    @responseMessage NVARCHAR(250)='' OUTPUT
AS
BEGIN

    SET NOCOUNT ON

    DECLARE @id INT

    IF EXISTS (SELECT TOP 1 id FROM [dbo].[users] WHERE username=@pUsername)
    BEGIN
        SET @id=(SELECT id FROM [dbo].[users] WHERE username=@pUsername AND "password"=HASHBYTES('SHA2_512', @pPassword+CAST(salt AS NVARCHAR(36))))

       IF(@id IS NULL)
           SET @responseMessage=0
       ELSE 
           SET @responseMessage=1
    END
    ELSE
       SET @responseMessage=0

END
GO
USE [master]
GO
ALTER DATABASE [simrs] SET  READ_WRITE 
GO
