USE [master]
GO
/****** Object:  Database [ShoppingMart]    Script Date: 04-08-2024 00:21:17 ******/
CREATE DATABASE [ShoppingMart]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Products', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Products.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Products_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Products_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ShoppingMart] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShoppingMart].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShoppingMart] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShoppingMart] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShoppingMart] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShoppingMart] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShoppingMart] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShoppingMart] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShoppingMart] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShoppingMart] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShoppingMart] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShoppingMart] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShoppingMart] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShoppingMart] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShoppingMart] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShoppingMart] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShoppingMart] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShoppingMart] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShoppingMart] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShoppingMart] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShoppingMart] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShoppingMart] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShoppingMart] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShoppingMart] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShoppingMart] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShoppingMart] SET  MULTI_USER 
GO
ALTER DATABASE [ShoppingMart] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShoppingMart] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShoppingMart] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShoppingMart] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShoppingMart] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ShoppingMart] SET QUERY_STORE = OFF
GO
USE [ShoppingMart]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [ShoppingMart]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 04-08-2024 00:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Description] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 04-08-2024 00:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[ContactNo] [varchar](100) NULL,
	[Address] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 04-08-2024 00:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Product Name] [varchar](100) NULL,
	[Quantity] [int] NULL,
	[DiscountOnProd] [int] NULL,
	[FlatDiscount] [int] NULL,
	[Total] [int] NULL,
	[Cust_Id] [int] NULL,
	[PaymentMode] [varchar](50) NULL,
	[Price] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 04-08-2024 00:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Description] [varchar](100) NULL,
	[Price] [int] NULL,
	[Quantity] [int] NULL,
	[Category] [varchar](100) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (4, N'eatables', N'chips,drinks')
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (2, N'Daily essentials', N'soap,shampoo')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Name], [Email], [ContactNo], [Address]) VALUES (7, N'aparna', N'a@gmail.com', N'9964899907', N'udupi')
INSERT [dbo].[Customers] ([Id], [Name], [Email], [ContactNo], [Address]) VALUES (2, N'rahul', N'rahul@gmail.com', N'8871152062', N'udupi')
INSERT [dbo].[Customers] ([Id], [Name], [Email], [ContactNo], [Address]) VALUES (3, N'drithin', N'd2@gmail.com', N'7844103132', N'mangalore')
INSERT [dbo].[Customers] ([Id], [Name], [Email], [ContactNo], [Address]) VALUES (4, N'dhanush', N'dhanush@gmail.com', N'7765432123', N'mangalore')
INSERT [dbo].[Customers] ([Id], [Name], [Email], [ContactNo], [Address]) VALUES (9, N'anuj', N'anuj@gmail.com', N'7654633243', N'udupi')
INSERT [dbo].[Customers] ([Id], [Name], [Email], [ContactNo], [Address]) VALUES (10, N'Anuj Nayak', N'2@gmail.com', N'6789721342', N'udupi')
INSERT [dbo].[Customers] ([Id], [Name], [Email], [ContactNo], [Address]) VALUES (12, N'jay', N'udupi', N'8971123452', N'udupi')
INSERT [dbo].[Customers] ([Id], [Name], [Email], [ContactNo], [Address]) VALUES (13, N'abhi', N'a@a.com', N'9964899912', N'a')
INSERT [dbo].[Customers] ([Id], [Name], [Email], [ContactNo], [Address]) VALUES (6, N'abhishek', N'nayakabhishek55@gmail.com', N'8971152062', N'mangalore')
INSERT [dbo].[Customers] ([Id], [Name], [Email], [ContactNo], [Address]) VALUES (8, N'ajith', N'ajith@gmail.com', N'9844103132', N'udupi')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (1, N'Shampoo', 100, 10, 0, 9990, 6, N'UPI', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (2, N'Soap', 100, 10, 0, 990, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (3, N'Shampoo', 1000, 10, 0, 99990, 6, N'UPI', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (4, N'oil', 100, 20, 0, 34980, 6, N'Card', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (5, N'Shampoo', 100, 10, 0, 9990, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (6, N'Soap', 100, 10, 0, 990, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (7, N'Soap', 100, 10, 0, 990, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (8, N'Chips', 10, 5, 0, 95, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (9, N'Shampoo', 100, 10, 0, 9990, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (10, N'Chips', 100, 10, 0, 990, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (11, N'oil', 12, 12, 0, 4188, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (12, N'Chips', 100, 0, 0, 1000, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (13, N'Shampoo', 100, 0, 0, 10000, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (14, N'Shampoo', 101, 10, 0, 10090, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (15, N'Soap', 100, 10, 0, 990, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (16, N'Shampoo', 100, 10, 0, 9990, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (17, N'Shampoo', 100, 10, 0, 9990, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (18, N'Shampoo', 10, 0, 100, 1000, 6, N'UPI', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (19, N'Soap', 100, 10, 10, 990, 6, N'UPI', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (20, N'Shampoo', 100, 10, 0, 9990, 6, N'UPI', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (21, N'Shampoo', 100, 10, 0, 9990, 6, N'UPI', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (22, N'Shampoo', 100, 10, 0, 9990, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (23, N'Shampoo', 100, 10, 0, 9990, 6, N'UPI', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (24, N'Soap', 100, 10, 10, 990, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (25, N'Shampoo', 100, 50, 10, 9950, 6, N'Cash', NULL)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (26, N'Soap', 100, 10, 0, 990, 6, N'Cash', 10)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (27, N'Soap', 10, 0, 10, 100, 6, N'Cash', 10)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (28, N'Chips', 10, 0, 10, 100, 6, N'Cash', 10)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (29, N'Shampoo', 10, 0, 10, 1000, 6, N'Cash', 100)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (30, N'Shampoo', 10, 10, 10, 990, 6, N'Cash', 100)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (31, N'Chips', 10, 10, 10, 90, 6, N'Cash', 10)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (32, N'oil', 20, 0, 10, 7000, 6, N'Cash', 350)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (33, N'Shampoo', 10, 10, 10, 990, 6, N'Cash', 100)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (34, N'Shampoo', 10, 10, 0, 990, 6, N'Cash', 100)
INSERT [dbo].[Invoice] ([Id], [Product Name], [Quantity], [DiscountOnProd], [FlatDiscount], [Total], [Cust_Id], [PaymentMode], [Price]) VALUES (35, N'Shampoo', 10, 10, 0, 990, 6, N'Cash', 100)
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [Quantity], [Category]) VALUES (1, N'Shampoo', N'Daily', 100, 10, N'Daily essentials')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [Quantity], [Category]) VALUES (2, N'Soap', N'Daily', 10, 100, N'Daily essentials')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [Quantity], [Category]) VALUES (3, N'Chips', N'Daily', 10, 130, N'Eatables')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [Quantity], [Category]) VALUES (5, N'oil', N'parachute', 350, 20, N'Daily essentials')
INSERT [dbo].[Products] ([Id], [Name], [Description], [Price], [Quantity], [Category]) VALUES (7, N'shave', N'a@a.com', 20, 0, N'medicine')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [prodc_name]    Script Date: 04-08-2024 00:21:17 ******/
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [prodc_name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Cust_name_phone]    Script Date: 04-08-2024 00:21:17 ******/
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [Cust_name_phone] UNIQUE NONCLUSTERED 
(
	[Name] ASC,
	[ContactNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [prodc_name_category]    Script Date: 04-08-2024 00:21:17 ******/
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [prodc_name_category] UNIQUE NONCLUSTERED 
(
	[Name] ASC,
	[Category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ShoppingMart] SET  READ_WRITE 
GO
