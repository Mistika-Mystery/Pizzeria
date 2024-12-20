USE [master]
GO
/****** Object:  Database [Pizzeria]    Script Date: 05.12.2024 16:21:08 ******/
CREATE DATABASE [Pizzeria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pizzeria', FILENAME = N'C:\Users\10220439\Pizzeria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pizzeria_log', FILENAME = N'C:\Users\10220439\Pizzeria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Pizzeria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pizzeria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pizzeria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pizzeria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pizzeria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pizzeria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pizzeria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pizzeria] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Pizzeria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pizzeria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pizzeria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pizzeria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pizzeria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pizzeria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pizzeria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pizzeria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pizzeria] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Pizzeria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pizzeria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pizzeria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pizzeria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pizzeria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pizzeria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pizzeria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pizzeria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Pizzeria] SET  MULTI_USER 
GO
ALTER DATABASE [Pizzeria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pizzeria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pizzeria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pizzeria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pizzeria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Pizzeria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Pizzeria] SET QUERY_STORE = OFF
GO
USE [Pizzeria]
GO
/****** Object:  Table [dbo].[Deliveries]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deliveries](
	[DeliveryID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[DeliveryAddress] [nvarchar](255) NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
 CONSTRAINT [PK__Deliveri__626D8FEEA1D574F0] PRIMARY KEY CLUSTERED 
(
	[DeliveryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingredients]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients](
	[IngredientID] [int] IDENTITY(1,1) NOT NULL,
	[IngredientName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IngredientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[PizzaID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK__OrderDet__D3B9D30CBFBDCD8D] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
 CONSTRAINT [PK__Orders__C3905BAF3567F608] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[PaymentMethod] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Payments__9B556A589D23130D] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PizzaCategories]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PizzaCategories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PizzaIngredients]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PizzaIngredients](
	[PizzaID] [int] NOT NULL,
	[IngredientID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PizzaID] ASC,
	[IngredientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pizzas]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pizzas](
	[PizzaID] [int] IDENTITY(1,1) NOT NULL,
	[PizzaName] [nvarchar](100) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK__Pizzas__0B6012FD89057CCF] PRIMARY KEY CLUSTERED 
(
	[PizzaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PromotionPizzas]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PromotionPizzas](
	[PromotionID] [int] NOT NULL,
	[PizzaID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PromotionID] ASC,
	[PizzaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promotions]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotions](
	[PromotionID] [int] IDENTITY(1,1) NOT NULL,
	[PromotionName] [nvarchar](100) NOT NULL,
	[DiscountPercentage] [decimal](5, 2) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
 CONSTRAINT [PK__Promotio__52C42F2FF59C3654] PRIMARY KEY CLUSTERED 
(
	[PromotionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[ReviewID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[PizzaID] [int] NOT NULL,
	[Rating] [int] NOT NULL,
	[Comment] [nvarchar](255) NOT NULL,
	[ReviewDate] [datetime] NOT NULL,
 CONSTRAINT [PK__Reviews__74BC79AE7DB3943C] PRIMARY KEY CLUSTERED 
(
	[ReviewID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](100) NOT NULL,
	[ContactName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK__Supplier__4BE666946FD68074] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplies]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplies](
	[SupplyID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NOT NULL,
	[IngredientID] [int] NOT NULL,
	[SupplyDate] [date] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK__Supplies__7CDD6C8EB56BB1B1] PRIMARY KEY CLUSTERED 
(
	[SupplyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 05.12.2024 16:21:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Phone] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[PositionID] [bit] NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK__Customer__A4AE64B803041D83] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Deliveries] ON 

INSERT [dbo].[Deliveries] ([DeliveryID], [OrderID], [DeliveryAddress], [DeliveryDate]) VALUES (1, 1, N'123 Main St', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Deliveries] ([DeliveryID], [OrderID], [DeliveryAddress], [DeliveryDate]) VALUES (2, 2, N'456 Elm St', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Deliveries] ([DeliveryID], [OrderID], [DeliveryAddress], [DeliveryDate]) VALUES (3, 3, N'789 Oak St', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Deliveries] ([DeliveryID], [OrderID], [DeliveryAddress], [DeliveryDate]) VALUES (4, 4, N'101 Pine St', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Deliveries] ([DeliveryID], [OrderID], [DeliveryAddress], [DeliveryDate]) VALUES (5, 5, N'202 Maple St', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Deliveries] ([DeliveryID], [OrderID], [DeliveryAddress], [DeliveryDate]) VALUES (6, 6, N'303 Birch St', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Deliveries] ([DeliveryID], [OrderID], [DeliveryAddress], [DeliveryDate]) VALUES (7, 7, N'404 Cedar St', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Deliveries] ([DeliveryID], [OrderID], [DeliveryAddress], [DeliveryDate]) VALUES (8, 8, N'505 Walnut St', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Deliveries] ([DeliveryID], [OrderID], [DeliveryAddress], [DeliveryDate]) VALUES (9, 9, N'606 Cherry St', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Deliveries] ([DeliveryID], [OrderID], [DeliveryAddress], [DeliveryDate]) VALUES (10, 10, N'707 Spruce St', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
SET IDENTITY_INSERT [dbo].[Deliveries] OFF
GO
SET IDENTITY_INSERT [dbo].[Ingredients] ON 

INSERT [dbo].[Ingredients] ([IngredientID], [IngredientName]) VALUES (1, N'Tomato Sauce')
INSERT [dbo].[Ingredients] ([IngredientID], [IngredientName]) VALUES (2, N'Mozzarella Cheese')
INSERT [dbo].[Ingredients] ([IngredientID], [IngredientName]) VALUES (3, N'Pepperoni')
INSERT [dbo].[Ingredients] ([IngredientID], [IngredientName]) VALUES (4, N'Mushrooms')
INSERT [dbo].[Ingredients] ([IngredientID], [IngredientName]) VALUES (5, N'Onions')
INSERT [dbo].[Ingredients] ([IngredientID], [IngredientName]) VALUES (6, N'Green Peppers')
INSERT [dbo].[Ingredients] ([IngredientID], [IngredientName]) VALUES (7, N'Olives')
INSERT [dbo].[Ingredients] ([IngredientID], [IngredientName]) VALUES (8, N'Bacon')
INSERT [dbo].[Ingredients] ([IngredientID], [IngredientName]) VALUES (9, N'Chicken')
INSERT [dbo].[Ingredients] ([IngredientID], [IngredientName]) VALUES (10, N'Pineapple')
SET IDENTITY_INSERT [dbo].[Ingredients] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [PizzaID], [Quantity]) VALUES (1, 1, 1, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [PizzaID], [Quantity]) VALUES (2, 2, 2, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [PizzaID], [Quantity]) VALUES (3, 3, 3, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [PizzaID], [Quantity]) VALUES (4, 4, 4, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [PizzaID], [Quantity]) VALUES (5, 5, 5, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [PizzaID], [Quantity]) VALUES (6, 6, 6, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [PizzaID], [Quantity]) VALUES (7, 7, 7, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [PizzaID], [Quantity]) VALUES (8, 8, 8, 4)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [PizzaID], [Quantity]) VALUES (9, 9, 9, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [PizzaID], [Quantity]) VALUES (10, 10, 10, 1)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [TotalAmount]) VALUES (1, 1, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(29.99 AS Decimal(10, 2)))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [TotalAmount]) VALUES (2, 2, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(19.99 AS Decimal(10, 2)))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [TotalAmount]) VALUES (3, 3, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(39.99 AS Decimal(10, 2)))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [TotalAmount]) VALUES (4, 4, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(49.99 AS Decimal(10, 2)))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [TotalAmount]) VALUES (5, 5, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(24.99 AS Decimal(10, 2)))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [TotalAmount]) VALUES (6, 6, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(34.99 AS Decimal(10, 2)))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [TotalAmount]) VALUES (7, 7, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(44.99 AS Decimal(10, 2)))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [TotalAmount]) VALUES (8, 8, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(54.99 AS Decimal(10, 2)))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [TotalAmount]) VALUES (9, 9, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(14.99 AS Decimal(10, 2)))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [OrderDate], [TotalAmount]) VALUES (10, 10, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(59.99 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Payments] ON 

INSERT [dbo].[Payments] ([PaymentID], [OrderID], [PaymentDate], [Amount], [PaymentMethod]) VALUES (1, 1, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(29.99 AS Decimal(10, 2)), N'Credit Card')
INSERT [dbo].[Payments] ([PaymentID], [OrderID], [PaymentDate], [Amount], [PaymentMethod]) VALUES (2, 2, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(19.99 AS Decimal(10, 2)), N'Cash')
INSERT [dbo].[Payments] ([PaymentID], [OrderID], [PaymentDate], [Amount], [PaymentMethod]) VALUES (3, 3, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(39.99 AS Decimal(10, 2)), N'PayPal')
INSERT [dbo].[Payments] ([PaymentID], [OrderID], [PaymentDate], [Amount], [PaymentMethod]) VALUES (4, 4, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(49.99 AS Decimal(10, 2)), N'Credit Card')
INSERT [dbo].[Payments] ([PaymentID], [OrderID], [PaymentDate], [Amount], [PaymentMethod]) VALUES (5, 5, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(24.99 AS Decimal(10, 2)), N'Cash')
INSERT [dbo].[Payments] ([PaymentID], [OrderID], [PaymentDate], [Amount], [PaymentMethod]) VALUES (6, 6, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(34.99 AS Decimal(10, 2)), N'PayPal')
INSERT [dbo].[Payments] ([PaymentID], [OrderID], [PaymentDate], [Amount], [PaymentMethod]) VALUES (7, 7, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(44.99 AS Decimal(10, 2)), N'Credit Card')
INSERT [dbo].[Payments] ([PaymentID], [OrderID], [PaymentDate], [Amount], [PaymentMethod]) VALUES (8, 8, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(54.99 AS Decimal(10, 2)), N'Cash')
INSERT [dbo].[Payments] ([PaymentID], [OrderID], [PaymentDate], [Amount], [PaymentMethod]) VALUES (9, 9, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(14.99 AS Decimal(10, 2)), N'PayPal')
INSERT [dbo].[Payments] ([PaymentID], [OrderID], [PaymentDate], [Amount], [PaymentMethod]) VALUES (10, 10, CAST(N'2024-11-15T13:58:15.630' AS DateTime), CAST(59.99 AS Decimal(10, 2)), N'Credit Card')
SET IDENTITY_INSERT [dbo].[Payments] OFF
GO
SET IDENTITY_INSERT [dbo].[PizzaCategories] ON 

INSERT [dbo].[PizzaCategories] ([CategoryID], [CategoryName]) VALUES (1, N'Classic')
INSERT [dbo].[PizzaCategories] ([CategoryID], [CategoryName]) VALUES (2, N'Specialty')
INSERT [dbo].[PizzaCategories] ([CategoryID], [CategoryName]) VALUES (3, N'Vegan')
INSERT [dbo].[PizzaCategories] ([CategoryID], [CategoryName]) VALUES (4, N'Gluten-Free')
INSERT [dbo].[PizzaCategories] ([CategoryID], [CategoryName]) VALUES (5, N'Dessert')
SET IDENTITY_INSERT [dbo].[PizzaCategories] OFF
GO
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (1, 1)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (1, 2)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (2, 1)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (2, 2)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (2, 3)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (3, 1)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (3, 2)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (3, 4)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (4, 1)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (4, 2)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (5, 1)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (5, 2)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (5, 3)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (6, 1)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (6, 2)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (6, 5)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (7, 1)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (7, 2)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (7, 6)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (8, 1)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (8, 2)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (8, 7)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (9, 1)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (9, 2)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (9, 8)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (10, 1)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (10, 2)
INSERT [dbo].[PizzaIngredients] ([PizzaID], [IngredientID]) VALUES (10, 9)
GO
SET IDENTITY_INSERT [dbo].[Pizzas] ON 

INSERT [dbo].[Pizzas] ([PizzaID], [PizzaName], [CategoryID], [Price]) VALUES (1, N'Margherita', 1, CAST(9.99 AS Decimal(10, 2)))
INSERT [dbo].[Pizzas] ([PizzaID], [PizzaName], [CategoryID], [Price]) VALUES (2, N'Pepperoni', 1, CAST(11.99 AS Decimal(10, 2)))
INSERT [dbo].[Pizzas] ([PizzaID], [PizzaName], [CategoryID], [Price]) VALUES (3, N'BBQ Chicken', 2, CAST(12.99 AS Decimal(10, 2)))
INSERT [dbo].[Pizzas] ([PizzaID], [PizzaName], [CategoryID], [Price]) VALUES (4, N'Veggie', 1, CAST(10.99 AS Decimal(10, 2)))
INSERT [dbo].[Pizzas] ([PizzaID], [PizzaName], [CategoryID], [Price]) VALUES (5, N'Hawaiian', 1, CAST(11.49 AS Decimal(10, 2)))
INSERT [dbo].[Pizzas] ([PizzaID], [PizzaName], [CategoryID], [Price]) VALUES (6, N'Meat Lovers', 2, CAST(13.99 AS Decimal(10, 2)))
INSERT [dbo].[Pizzas] ([PizzaID], [PizzaName], [CategoryID], [Price]) VALUES (7, N'Buffalo Chicken', 2, CAST(12.49 AS Decimal(10, 2)))
INSERT [dbo].[Pizzas] ([PizzaID], [PizzaName], [CategoryID], [Price]) VALUES (8, N'Cheese', 1, CAST(8.99 AS Decimal(10, 2)))
INSERT [dbo].[Pizzas] ([PizzaID], [PizzaName], [CategoryID], [Price]) VALUES (9, N'Supreme', 2, CAST(14.99 AS Decimal(10, 2)))
INSERT [dbo].[Pizzas] ([PizzaID], [PizzaName], [CategoryID], [Price]) VALUES (10, N'Spinach & Feta', 1, CAST(10.49 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Pizzas] OFF
GO
INSERT [dbo].[PromotionPizzas] ([PromotionID], [PizzaID]) VALUES (1, 1)
INSERT [dbo].[PromotionPizzas] ([PromotionID], [PizzaID]) VALUES (1, 2)
INSERT [dbo].[PromotionPizzas] ([PromotionID], [PizzaID]) VALUES (2, 3)
INSERT [dbo].[PromotionPizzas] ([PromotionID], [PizzaID]) VALUES (2, 4)
INSERT [dbo].[PromotionPizzas] ([PromotionID], [PizzaID]) VALUES (3, 5)
INSERT [dbo].[PromotionPizzas] ([PromotionID], [PizzaID]) VALUES (3, 6)
INSERT [dbo].[PromotionPizzas] ([PromotionID], [PizzaID]) VALUES (4, 7)
INSERT [dbo].[PromotionPizzas] ([PromotionID], [PizzaID]) VALUES (4, 8)
INSERT [dbo].[PromotionPizzas] ([PromotionID], [PizzaID]) VALUES (5, 9)
INSERT [dbo].[PromotionPizzas] ([PromotionID], [PizzaID]) VALUES (5, 10)
GO
SET IDENTITY_INSERT [dbo].[Promotions] ON 

INSERT [dbo].[Promotions] ([PromotionID], [PromotionName], [DiscountPercentage], [StartDate], [EndDate]) VALUES (1, N'Summer Sale', CAST(20.00 AS Decimal(5, 2)), CAST(N'2024-06-01' AS Date), CAST(N'2024-06-30' AS Date))
INSERT [dbo].[Promotions] ([PromotionID], [PromotionName], [DiscountPercentage], [StartDate], [EndDate]) VALUES (2, N'Winter Special', CAST(15.00 AS Decimal(5, 2)), CAST(N'2024-12-01' AS Date), CAST(N'2024-12-31' AS Date))
INSERT [dbo].[Promotions] ([PromotionID], [PromotionName], [DiscountPercentage], [StartDate], [EndDate]) VALUES (3, N'Buy One Get One', CAST(50.00 AS Decimal(5, 2)), CAST(N'2024-01-01' AS Date), CAST(N'2024-01-31' AS Date))
INSERT [dbo].[Promotions] ([PromotionID], [PromotionName], [DiscountPercentage], [StartDate], [EndDate]) VALUES (4, N'Holiday Discount', CAST(25.00 AS Decimal(5, 2)), CAST(N'2024-11-01' AS Date), CAST(N'2024-11-30' AS Date))
INSERT [dbo].[Promotions] ([PromotionID], [PromotionName], [DiscountPercentage], [StartDate], [EndDate]) VALUES (5, N'New Year Offer', CAST(30.00 AS Decimal(5, 2)), CAST(N'2024-01-01' AS Date), CAST(N'2024-01-15' AS Date))
SET IDENTITY_INSERT [dbo].[Promotions] OFF
GO
SET IDENTITY_INSERT [dbo].[Reviews] ON 

INSERT [dbo].[Reviews] ([ReviewID], [CustomerID], [PizzaID], [Rating], [Comment], [ReviewDate]) VALUES (1, 1, 1, 5, N'Delicious!', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [CustomerID], [PizzaID], [Rating], [Comment], [ReviewDate]) VALUES (2, 2, 2, 4, N'Very good!', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [CustomerID], [PizzaID], [Rating], [Comment], [ReviewDate]) VALUES (3, 3, 3, 3, N'It was okay.', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [CustomerID], [PizzaID], [Rating], [Comment], [ReviewDate]) VALUES (4, 4, 4, 5, N'Loved it!', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [CustomerID], [PizzaID], [Rating], [Comment], [ReviewDate]) VALUES (5, 5, 5, 2, N'Not my favorite.', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [CustomerID], [PizzaID], [Rating], [Comment], [ReviewDate]) VALUES (6, 6, 6, 4, N'Pretty good!', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [CustomerID], [PizzaID], [Rating], [Comment], [ReviewDate]) VALUES (7, 7, 7, 5, N'Excellent!', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [CustomerID], [PizzaID], [Rating], [Comment], [ReviewDate]) VALUES (8, 8, 8, 3, N'Average.', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [CustomerID], [PizzaID], [Rating], [Comment], [ReviewDate]) VALUES (9, 9, 9, 4, N'Tasty!', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [CustomerID], [PizzaID], [Rating], [Comment], [ReviewDate]) VALUES (10, 10, 10, 5, N'Best pizza ever!', CAST(N'2024-11-15T13:58:15.630' AS DateTime))
SET IDENTITY_INSERT [dbo].[Reviews] OFF
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone]) VALUES (1, N'Supplier A', N'Alice', N'1112223333')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone]) VALUES (2, N'Supplier B', N'Bob', N'2223334444')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone]) VALUES (3, N'Supplier C', N'Charlie', N'3334445555')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone]) VALUES (4, N'Supplier D', N'David', N'4445556666')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone]) VALUES (5, N'Supplier E', N'Eva', N'5556667777')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone]) VALUES (6, N'Supplier F', N'Frank', N'6667778888')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone]) VALUES (7, N'Supplier G', N'Grace', N'7778889999')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone]) VALUES (8, N'Supplier H', N'Hank', N'8889990000')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone]) VALUES (9, N'Supplier I', N'Ivy', N'9990001111')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone]) VALUES (10, N'Supplier J', N'Jack', N'0001112222')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
SET IDENTITY_INSERT [dbo].[Supplies] ON 

INSERT [dbo].[Supplies] ([SupplyID], [SupplierID], [IngredientID], [SupplyDate], [Quantity]) VALUES (1, 1, 1, CAST(N'2024-11-15' AS Date), 100)
INSERT [dbo].[Supplies] ([SupplyID], [SupplierID], [IngredientID], [SupplyDate], [Quantity]) VALUES (2, 2, 2, CAST(N'2024-11-15' AS Date), 200)
INSERT [dbo].[Supplies] ([SupplyID], [SupplierID], [IngredientID], [SupplyDate], [Quantity]) VALUES (3, 3, 3, CAST(N'2024-11-15' AS Date), 150)
INSERT [dbo].[Supplies] ([SupplyID], [SupplierID], [IngredientID], [SupplyDate], [Quantity]) VALUES (4, 4, 4, CAST(N'2024-11-15' AS Date), 120)
INSERT [dbo].[Supplies] ([SupplyID], [SupplierID], [IngredientID], [SupplyDate], [Quantity]) VALUES (5, 5, 5, CAST(N'2024-11-15' AS Date), 180)
INSERT [dbo].[Supplies] ([SupplyID], [SupplierID], [IngredientID], [SupplyDate], [Quantity]) VALUES (6, 6, 6, CAST(N'2024-11-15' AS Date), 160)
INSERT [dbo].[Supplies] ([SupplyID], [SupplierID], [IngredientID], [SupplyDate], [Quantity]) VALUES (7, 7, 7, CAST(N'2024-11-15' AS Date), 140)
INSERT [dbo].[Supplies] ([SupplyID], [SupplierID], [IngredientID], [SupplyDate], [Quantity]) VALUES (8, 8, 8, CAST(N'2024-11-15' AS Date), 130)
INSERT [dbo].[Supplies] ([SupplyID], [SupplierID], [IngredientID], [SupplyDate], [Quantity]) VALUES (9, 9, 9, CAST(N'2024-11-15' AS Date), 110)
INSERT [dbo].[Supplies] ([SupplyID], [SupplierID], [IngredientID], [SupplyDate], [Quantity]) VALUES (10, 10, 10, CAST(N'2024-11-15' AS Date), 90)
SET IDENTITY_INSERT [dbo].[Supplies] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (1, N'John', N'Doe', N'1234567890', N'john.doe@example.com', 1, N'aaa', N'aaa')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (2, N'Jane', N'Smith', N'0987654321', N'jane.smith@example.com', 0, N'janesmith', N'password2')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (3, N'Alice', N'Johnson', N'5555555555', N'alice.johnson@example.com', 1, N'alicej', N'password3')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (4, N'Bob', N'Brown', N'4444444444', N'bob.brown@example.com', 0, N'bobb', N'password4')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (5, N'Charlie', N'Davis', N'3333333333', N'charlie.davis@example.com', 1, N'charlied', N'password5')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (6, N'David', N'Wilson', N'2222222222', N'david.wilson@example.com', 0, N'davidw', N'password6')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (7, N'Eva', N'Garcia', N'1111111111', N'eva.garcia@example.com', 0, N'evag', N'password7')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (8, N'Frank', N'Martinez', N'6666666666', N'frank.martinez@example.com', 0, N'frankm', N'password8')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (9, N'Grace', N'Lopez', N'7777777777', N'grace.lopez@example.com', 1, N'gracel', N'password9')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (10, N'Hank', N'Gonzalez', N'8888888888', N'hank.gonzalez@example.com', 0, N'hankg', N'password10')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (11, NULL, NULL, NULL, NULL, 0, N'ddd', N'ddd')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (12, NULL, NULL, NULL, NULL, 0, N'sss', N'sss')
INSERT [dbo].[Users] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [PositionID], [Login], [Password]) VALUES (13, NULL, NULL, NULL, NULL, 0, N'333', N'333')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Deliveries]  WITH CHECK ADD  CONSTRAINT [FK__Deliverie__Order__3D5E1FD2] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[Deliveries] CHECK CONSTRAINT [FK__Deliverie__Order__3D5E1FD2]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK__OrderDeta__Order__398D8EEE] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK__OrderDeta__Order__398D8EEE]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK__OrderDeta__Pizza__3A81B327] FOREIGN KEY([PizzaID])
REFERENCES [dbo].[Pizzas] ([PizzaID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK__OrderDeta__Pizza__3A81B327]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__Customer__36B12243] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Users] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__Customer__36B12243]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK__Payments__OrderI__4AB81AF0] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK__Payments__OrderI__4AB81AF0]
GO
ALTER TABLE [dbo].[PizzaIngredients]  WITH CHECK ADD FOREIGN KEY([IngredientID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[PizzaIngredients]  WITH CHECK ADD  CONSTRAINT [FK__PizzaIngr__Pizza__32E0915F] FOREIGN KEY([PizzaID])
REFERENCES [dbo].[Pizzas] ([PizzaID])
GO
ALTER TABLE [dbo].[PizzaIngredients] CHECK CONSTRAINT [FK__PizzaIngr__Pizza__32E0915F]
GO
ALTER TABLE [dbo].[Pizzas]  WITH CHECK ADD  CONSTRAINT [FK__Pizzas__Category__2E1BDC42] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[PizzaCategories] ([CategoryID])
GO
ALTER TABLE [dbo].[Pizzas] CHECK CONSTRAINT [FK__Pizzas__Category__2E1BDC42]
GO
ALTER TABLE [dbo].[PromotionPizzas]  WITH CHECK ADD  CONSTRAINT [FK__Promotion__Pizza__47DBAE45] FOREIGN KEY([PizzaID])
REFERENCES [dbo].[Pizzas] ([PizzaID])
GO
ALTER TABLE [dbo].[PromotionPizzas] CHECK CONSTRAINT [FK__Promotion__Pizza__47DBAE45]
GO
ALTER TABLE [dbo].[PromotionPizzas]  WITH CHECK ADD  CONSTRAINT [FK__Promotion__Promo__46E78A0C] FOREIGN KEY([PromotionID])
REFERENCES [dbo].[Promotions] ([PromotionID])
GO
ALTER TABLE [dbo].[PromotionPizzas] CHECK CONSTRAINT [FK__Promotion__Promo__46E78A0C]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK__Reviews__Custome__412EB0B6] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Users] ([CustomerID])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK__Reviews__Custome__412EB0B6]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK__Reviews__PizzaID__4222D4EF] FOREIGN KEY([PizzaID])
REFERENCES [dbo].[Pizzas] ([PizzaID])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK__Reviews__PizzaID__4222D4EF]
GO
ALTER TABLE [dbo].[Supplies]  WITH CHECK ADD  CONSTRAINT [FK__Supplies__Ingred__5070F446] FOREIGN KEY([IngredientID])
REFERENCES [dbo].[Ingredients] ([IngredientID])
GO
ALTER TABLE [dbo].[Supplies] CHECK CONSTRAINT [FK__Supplies__Ingred__5070F446]
GO
ALTER TABLE [dbo].[Supplies]  WITH CHECK ADD  CONSTRAINT [FK__Supplies__Suppli__4F7CD00D] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Supplies] CHECK CONSTRAINT [FK__Supplies__Suppli__4F7CD00D]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [CK__Reviews__Rating__403A8C7D] CHECK  (([Rating]>=(1) AND [Rating]<=(5)))
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [CK__Reviews__Rating__403A8C7D]
GO
USE [master]
GO
ALTER DATABASE [Pizzeria] SET  READ_WRITE 
GO
