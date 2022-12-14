USE [master]
GO
/****** Object:  Database [BookStore]    Script Date: 11/14/2022 5:23:20 PM ******/
CREATE DATABASE [BookStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookStore', FILENAME = N'C:\Users\thien\Downloads\Root\MSSQL10_50.SQL2008\MSSQL\DATA\BookStore.mdf' , SIZE = 3392KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BookStore_log', FILENAME = N'C:\Users\thien\Downloads\Root\MSSQL10_50.SQL2008\MSSQL\DATA\BookStore_log.ldf' , SIZE = 896KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BookStore] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BookStore] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BookStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookStore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BookStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BookStore] SET  MULTI_USER 
GO
ALTER DATABASE [BookStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BookStore]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 11/14/2022 5:23:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[ID] [varchar](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Author] [varchar](50) NOT NULL,
	[Description] [varchar](200) NOT NULL,
	[ImgUrl] [varchar](100) NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 11/14/2022 5:23:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderID] [varchar](20) NOT NULL,
	[BookID] [varchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ordered]    Script Date: 11/14/2022 5:23:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ordered](
	[OrderID] [varchar](20) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[TotalPayment] [int] NOT NULL,
 CONSTRAINT [PK_Ordered] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 11/14/2022 5:23:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Registration](
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Role] [bit] NOT NULL,
	[FullName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Book] ([ID], [Name], [Author], [Description], [ImgUrl], [Price]) VALUES (N'DQ', N'New Star', N'Miguel', N'NAH', N'img/6.jpg', 143000)
INSERT [dbo].[Book] ([ID], [Name], [Author], [Description], [ImgUrl], [Price]) VALUES (N'KD', N'Kingdom', N'Sowtech', N'NAH', N'img/KD.jpg', 310000)
INSERT [dbo].[Book] ([ID], [Name], [Author], [Description], [ImgUrl], [Price]) VALUES (N'KVH', N'Mau Nuoc Mat', N'Nguyen Tran Trung Quan', N'NAH', N'img/KVH.png', 54000)
INSERT [dbo].[Book] ([ID], [Name], [Author], [Description], [ImgUrl], [Price]) VALUES (N'NSCD', N'Ngoi Sao Co Don', N'Jack', N'NAH', N'img/NSCD.png', 108000)
INSERT [dbo].[Book] ([ID], [Name], [Author], [Description], [ImgUrl], [Price]) VALUES (N'TCOTW', N'The Call of the Wild', N'Jack London', N'NAH', N'img/COW.jpg', 236000)
INSERT [dbo].[Book] ([ID], [Name], [Author], [Description], [ImgUrl], [Price]) VALUES (N'VN', N'Vo Nhat', N'Vu Trong Phung', N'NAH', N'img/7.jpg', 870000)
INSERT [dbo].[OrderDetail] ([OrderID], [BookID], [Quantity]) VALUES (N'S010', N'DQ', 2)
INSERT [dbo].[OrderDetail] ([OrderID], [BookID], [Quantity]) VALUES (N'S010', N'TCOTW', 3)
INSERT [dbo].[OrderDetail] ([OrderID], [BookID], [Quantity]) VALUES (N'S010', N'VN', 4)
INSERT [dbo].[OrderDetail] ([OrderID], [BookID], [Quantity]) VALUES (N'S011', N'DQ', 46)
INSERT [dbo].[OrderDetail] ([OrderID], [BookID], [Quantity]) VALUES (N'S011', N'TCOTW', 8)
INSERT [dbo].[OrderDetail] ([OrderID], [BookID], [Quantity]) VALUES (N'S011', N'VN', 6)
INSERT [dbo].[OrderDetail] ([OrderID], [BookID], [Quantity]) VALUES (N'S012', N'TCOTW', 8)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S001', CAST(N'2022-07-10' AS Date), N'admin', 286000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S002', CAST(N'2022-07-10' AS Date), N'admin', 286000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S003', CAST(N'2022-07-10' AS Date), N'admin', 286000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S004', CAST(N'2022-07-10' AS Date), N'admin2', 286000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S005', CAST(N'2022-07-10' AS Date), N'admin', 26470000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S006', CAST(N'2022-07-10' AS Date), N'admin', 286000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S007', CAST(N'2022-07-10' AS Date), N'admin2', 236000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S008', CAST(N'2022-07-10' AS Date), N'admin', 286000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S009', CAST(N'2022-07-10' AS Date), N'thienadmin', 2234000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S010', CAST(N'2022-07-10' AS Date), N'thienadmin', 2234000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S011', CAST(N'2022-07-10' AS Date), N'thienadmin', 10434000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S012', CAST(N'2022-07-10' AS Date), N'thienadmin', 10434000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S013', CAST(N'2022-07-10' AS Date), N'thienadmin', 1860000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S014', CAST(N'2022-10-07' AS Date), N'thienadmin', 931000)
INSERT [dbo].[Ordered] ([OrderID], [OrderDate], [Username], [TotalPayment]) VALUES (N'S015', CAST(N'2022-10-31' AS Date), N'thienadmin', 143000)
INSERT [dbo].[Registration] ([Username], [Password], [Role], [FullName]) VALUES (N'3TL', N'thuduc22', 0, N'TL')
INSERT [dbo].[Registration] ([Username], [Password], [Role], [FullName]) VALUES (N'admin', N'1', 1, N'Toi la admin')
INSERT [dbo].[Registration] ([Username], [Password], [Role], [FullName]) VALUES (N'admin2', N'1', 0, N'Hoang Hai')
INSERT [dbo].[Registration] ([Username], [Password], [Role], [FullName]) VALUES (N'Johnny', N'12345', 1, N'Dang Tuan')
INSERT [dbo].[Registration] ([Username], [Password], [Role], [FullName]) VALUES (N'thienadmin', N'1234', 0, N'Van Thien')
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Book] FOREIGN KEY([BookID])
REFERENCES [dbo].[Book] ([ID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Book]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Ordered] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Ordered] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Ordered]
GO
ALTER TABLE [dbo].[Ordered]  WITH CHECK ADD  CONSTRAINT [FK_Ordered_Registration] FOREIGN KEY([Username])
REFERENCES [dbo].[Registration] ([Username])
GO
ALTER TABLE [dbo].[Ordered] CHECK CONSTRAINT [FK_Ordered_Registration]
GO
USE [master]
GO
ALTER DATABASE [BookStore] SET  READ_WRITE 
GO
