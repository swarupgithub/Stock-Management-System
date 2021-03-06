USE [master]
GO
/****** Object:  Database [StockMangementSystemDB]    Script Date: 20-Dec-17 10:53:02 PM ******/
CREATE DATABASE [StockMangementSystemDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockMangementSystemDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\StockMangementSystemDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StockMangementSystemDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\StockMangementSystemDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StockMangementSystemDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockMangementSystemDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockMangementSystemDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [StockMangementSystemDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockMangementSystemDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockMangementSystemDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StockMangementSystemDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockMangementSystemDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StockMangementSystemDB] SET  MULTI_USER 
GO
ALTER DATABASE [StockMangementSystemDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockMangementSystemDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockMangementSystemDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockMangementSystemDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [StockMangementSystemDB]
GO
/****** Object:  Table [dbo].[category]    Script Date: 20-Dec-17 10:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [varchar](100) NOT NULL,
	[user_id] [int] NULL,
	[created_at] [date] NULL,
	[updated_at] [date] NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[company]    Script Date: 20-Dec-17 10:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[company](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_name] [varchar](200) NOT NULL,
	[user_id] [int] NULL,
	[created_at] [date] NULL,
	[updated_at] [date] NULL,
 CONSTRAINT [PK_company] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[item]    Script Date: 20-Dec-17 10:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[item](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[item_name] [varchar](200) NOT NULL,
	[category_id] [int] NOT NULL,
	[company_id] [int] NOT NULL,
	[reorder_level] [int] NULL,
	[quantity] [int] NULL,
	[user_id] [int] NULL,
	[created_at] [date] NULL,
	[updated_at] [date] NULL,
 CONSTRAINT [PK_item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sales]    Script Date: 20-Dec-17 10:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[item_id] [int] NOT NULL,
	[sales_quantity] [int] NOT NULL,
	[user_id] [int] NULL,
	[created_at] [date] NOT NULL,
 CONSTRAINT [PK_sales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user]    Script Date: 20-Dec-17 10:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[created_at] [date] NULL,
	[updated_at] [date] NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[ItemViewModel]    Script Date: 20-Dec-17 10:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ItemViewModel]
as
SELECT i.id , i.category_id , i.company_id , i.item_name , i.quantity , i.reorder_level , i.created_at, i.updated_at , cat.id as categoryId , cat.category_name , com.id as companyId , com.company_name
FROM item as i 
INNER JOIN category as cat ON i.category_id = cat.id
INNER JOIN company as com on i.company_id = com.id
GO
/****** Object:  View [dbo].[SalesViewModel]    Script Date: 20-Dec-17 10:53:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SalesViewModel]
as
SELECT sal.id , sal.item_id , sal.sales_quantity , sal.created_at , i.id as itemId , i.item_name
FROM sales as sal
INNER JOIN item as i ON sal.item_id = i.id
GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([id], [category_name], [user_id], [created_at], [updated_at]) VALUES (1, N'stationary', NULL, NULL, NULL)
INSERT [dbo].[category] ([id], [category_name], [user_id], [created_at], [updated_at]) VALUES (3, N'Grossary', NULL, NULL, CAST(0xA63D0B00 AS Date))
INSERT [dbo].[category] ([id], [category_name], [user_id], [created_at], [updated_at]) VALUES (4, N'Hard metals', NULL, CAST(0xA63D0B00 AS Date), CAST(0xAA3D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[category] OFF
SET IDENTITY_INSERT [dbo].[company] ON 

INSERT [dbo].[company] ([id], [company_name], [user_id], [created_at], [updated_at]) VALUES (2, N'ACI', NULL, NULL, CAST(0xA63D0B00 AS Date))
INSERT [dbo].[company] ([id], [company_name], [user_id], [created_at], [updated_at]) VALUES (3, N'square', NULL, NULL, NULL)
INSERT [dbo].[company] ([id], [company_name], [user_id], [created_at], [updated_at]) VALUES (4, N'pran', NULL, NULL, NULL)
INSERT [dbo].[company] ([id], [company_name], [user_id], [created_at], [updated_at]) VALUES (5, N'spark', NULL, CAST(0xA63D0B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[company] OFF
SET IDENTITY_INSERT [dbo].[item] ON 

INSERT [dbo].[item] ([id], [item_name], [category_id], [company_id], [reorder_level], [quantity], [user_id], [created_at], [updated_at]) VALUES (2, N'Arif', 1, 2, 1, 10, NULL, NULL, CAST(0xAA3D0B00 AS Date))
INSERT [dbo].[item] ([id], [item_name], [category_id], [company_id], [reorder_level], [quantity], [user_id], [created_at], [updated_at]) VALUES (3, N'ola', 1, 2, 0, 0, NULL, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[item] ([id], [item_name], [category_id], [company_id], [reorder_level], [quantity], [user_id], [created_at], [updated_at]) VALUES (4, N'moduna', 3, 3, 5, 0, NULL, NULL, CAST(0xAA3D0B00 AS Date))
INSERT [dbo].[item] ([id], [item_name], [category_id], [company_id], [reorder_level], [quantity], [user_id], [created_at], [updated_at]) VALUES (7, N'chagol', 3, 2, 2, -1, NULL, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[item] ([id], [item_name], [category_id], [company_id], [reorder_level], [quantity], [user_id], [created_at], [updated_at]) VALUES (8, N'kollu', 3, 3, 1, 0, NULL, NULL, CAST(0xA83D0B00 AS Date))
INSERT [dbo].[item] ([id], [item_name], [category_id], [company_id], [reorder_level], [quantity], [user_id], [created_at], [updated_at]) VALUES (9, N'RFL', 1, 4, 1, 0, NULL, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[item] ([id], [item_name], [category_id], [company_id], [reorder_level], [quantity], [user_id], [created_at], [updated_at]) VALUES (10, N'boom', 1, 4, 1, 0, NULL, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[item] ([id], [item_name], [category_id], [company_id], [reorder_level], [quantity], [user_id], [created_at], [updated_at]) VALUES (12, N'uma', 4, 5, 5, 0, NULL, CAST(0xA73D0B00 AS Date), CAST(0xAA3D0B00 AS Date))
INSERT [dbo].[item] ([id], [item_name], [category_id], [company_id], [reorder_level], [quantity], [user_id], [created_at], [updated_at]) VALUES (15, N'yusra', 4, 5, 2, 0, NULL, CAST(0xA73D0B00 AS Date), CAST(0xA93D0B00 AS Date))
INSERT [dbo].[item] ([id], [item_name], [category_id], [company_id], [reorder_level], [quantity], [user_id], [created_at], [updated_at]) VALUES (17, N'bhola', 4, 2, 1, 0, NULL, CAST(0xAA3D0B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[item] OFF
SET IDENTITY_INSERT [dbo].[sales] ON 

INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (1, 2, 5, NULL, CAST(0xA53D0B00 AS Date))
INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (2, 4, 12, NULL, CAST(0xA73D0B00 AS Date))
INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (3, 8, 7, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (5, 2, 5, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (6, 12, 5, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (7, 12, 5, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (8, 12, 10, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (9, 2, 20, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (10, 2, 4, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (11, 12, 50, NULL, CAST(0xA93D0B00 AS Date))
INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (12, 12, 5, NULL, CAST(0xAA3D0B00 AS Date))
INSERT [dbo].[sales] ([id], [item_id], [sales_quantity], [user_id], [created_at]) VALUES (13, 12, 5, NULL, CAST(0xAA3D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[sales] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_category]    Script Date: 20-Dec-17 10:53:02 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_category] ON [dbo].[category]
(
	[category_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_company]    Script Date: 20-Dec-17 10:53:02 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_company] ON [dbo].[company]
(
	[company_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_item]    Script Date: 20-Dec-17 10:53:02 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_item] ON [dbo].[item]
(
	[item_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[category]  WITH CHECK ADD  CONSTRAINT [FK_category_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[category] CHECK CONSTRAINT [FK_category_user]
GO
ALTER TABLE [dbo].[company]  WITH CHECK ADD  CONSTRAINT [FK_company_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[company] CHECK CONSTRAINT [FK_company_user]
GO
ALTER TABLE [dbo].[item]  WITH CHECK ADD  CONSTRAINT [FK_item_category] FOREIGN KEY([category_id])
REFERENCES [dbo].[category] ([id])
GO
ALTER TABLE [dbo].[item] CHECK CONSTRAINT [FK_item_category]
GO
ALTER TABLE [dbo].[item]  WITH CHECK ADD  CONSTRAINT [FK_item_company] FOREIGN KEY([company_id])
REFERENCES [dbo].[company] ([id])
GO
ALTER TABLE [dbo].[item] CHECK CONSTRAINT [FK_item_company]
GO
ALTER TABLE [dbo].[sales]  WITH CHECK ADD  CONSTRAINT [FK_sales_item] FOREIGN KEY([item_id])
REFERENCES [dbo].[item] ([id])
GO
ALTER TABLE [dbo].[sales] CHECK CONSTRAINT [FK_sales_item]
GO
ALTER TABLE [dbo].[sales]  WITH CHECK ADD  CONSTRAINT [FK_sales_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[sales] CHECK CONSTRAINT [FK_sales_user]
GO
USE [master]
GO
ALTER DATABASE [StockMangementSystemDB] SET  READ_WRITE 
GO
