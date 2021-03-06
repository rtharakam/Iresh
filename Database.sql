USE [MainDatabase]
GO
ALTER TABLE [dbo].[ProductSubType] DROP CONSTRAINT [FK_ProductSubType_ProductType]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_Supplier]
GO
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [FK_Product_Model]
GO
ALTER TABLE [dbo].[Note] DROP CONSTRAINT [FK_Note_Product]
GO
ALTER TABLE [dbo].[Model] DROP CONSTRAINT [FK_Model_ProductType]
GO
ALTER TABLE [dbo].[Model] DROP CONSTRAINT [FK_Model_ProductSubType]
GO
ALTER TABLE [dbo].[Model] DROP CONSTRAINT [FK_Model_Model]
GO
ALTER TABLE [dbo].[Model] DROP CONSTRAINT [FK_Model_Manufature]
GO
ALTER TABLE [dbo].[LocationChange] DROP CONSTRAINT [FK_LocationChange_Product]
GO
ALTER TABLE [dbo].[LocationChange] DROP CONSTRAINT [FK_LocationChange_Location]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 5/1/2016 4:08:32 PM ******/
DROP TABLE [dbo].[Supplier]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 5/1/2016 4:08:32 PM ******/
DROP TABLE [dbo].[ProductType]
GO
/****** Object:  Table [dbo].[ProductSubType]    Script Date: 5/1/2016 4:08:32 PM ******/
DROP TABLE [dbo].[ProductSubType]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 5/1/2016 4:08:32 PM ******/
DROP TABLE [dbo].[Product]
GO
/****** Object:  Table [dbo].[Note]    Script Date: 5/1/2016 4:08:32 PM ******/
DROP TABLE [dbo].[Note]
GO
/****** Object:  Table [dbo].[Model]    Script Date: 5/1/2016 4:08:32 PM ******/
DROP TABLE [dbo].[Model]
GO
/****** Object:  Table [dbo].[Manufature]    Script Date: 5/1/2016 4:08:32 PM ******/
DROP TABLE [dbo].[Manufature]
GO
/****** Object:  Table [dbo].[LocationChange]    Script Date: 5/1/2016 4:08:32 PM ******/
DROP TABLE [dbo].[LocationChange]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 5/1/2016 4:08:32 PM ******/
DROP TABLE [dbo].[Location]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 5/1/2016 4:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[Location_Id] [int] NOT NULL,
	[Location_Code] [nvarchar](20) NULL,
	[Location_Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[Location_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LocationChange]    Script Date: 5/1/2016 4:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocationChange](
	[LocChng_ProductId] [int] NULL,
	[LocChng_LocationId] [int] NULL,
	[LocChng_ChangedDate] [datetime] NULL,
	[LocChng_Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Manufature]    Script Date: 5/1/2016 4:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Manufature](
	[Manufacture_Id] [int] IDENTITY(1,1) NOT NULL,
	[Manufacture_Name] [varchar](50) NULL,
 CONSTRAINT [PK_Manufature] PRIMARY KEY CLUSTERED 
(
	[Manufacture_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Model]    Script Date: 5/1/2016 4:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Model](
	[Model_Id] [int] IDENTITY(1,1) NOT NULL,
	[Model_SKU] [nvarchar](20) NULL,
	[Model_Type] [int] NULL,
	[Model_Name] [nvarchar](50) NULL,
	[Model_SubType] [int] NULL,
	[Model_Manufaturer] [int] NULL,
 CONSTRAINT [PK_Model] PRIMARY KEY CLUSTERED 
(
	[Model_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Note]    Script Date: 5/1/2016 4:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Note](
	[Note_ProductId] [int] NULL,
	[Note_Description] [nvarchar](200) NULL,
	[Note_Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 5/1/2016 4:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[Product_Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductDate_Created] [datetime] NULL,
	[Product_Supplier] [int] NULL,
	[Product_WarrantyPeriod] [int] NULL,
	[Product_ModelId] [int] NULL,
	[Product_CurrentLoc] [varchar](20) NULL,
	[OS] [nchar](10) NULL,
	[OSType] [nchar](10) NULL,
	[OfficeVersion] [nchar](10) NULL,
	[BattaryState] [nchar](10) NULL,
	[IsLicense] [nchar](10) NULL,
 CONSTRAINT [PK_Product_1] PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductSubType]    Script Date: 5/1/2016 4:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductSubType](
	[ProductSubType_Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductSubType_Name] [varchar](20) NULL,
	[ProductSubType_MainType] [int] NOT NULL,
 CONSTRAINT [PK_ProductSubType] PRIMARY KEY CLUSTERED 
(
	[ProductSubType_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 5/1/2016 4:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductType](
	[ProductType_Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductType_Name] [varchar](20) NULL,
 CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED 
(
	[ProductType_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 5/1/2016 4:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[Supplier_Id] [int] IDENTITY(1,1) NOT NULL,
	[Suppliers_Name] [varchar](50) NULL,
	[Suppliers_JoinedDate] [datetime] NULL,
	[Suppliers_IsActive] [bit] NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Supplier_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Manufature] ON 

INSERT [dbo].[Manufature] ([Manufacture_Id], [Manufacture_Name]) VALUES (1, N'Apple')
INSERT [dbo].[Manufature] ([Manufacture_Id], [Manufacture_Name]) VALUES (2, N'HTC')
INSERT [dbo].[Manufature] ([Manufacture_Id], [Manufacture_Name]) VALUES (3, N'Lenovo')
INSERT [dbo].[Manufature] ([Manufacture_Id], [Manufacture_Name]) VALUES (4, N'Cannon')
SET IDENTITY_INSERT [dbo].[Manufature] OFF
SET IDENTITY_INSERT [dbo].[Model] ON 

INSERT [dbo].[Model] ([Model_Id], [Model_SKU], [Model_Type], [Model_Name], [Model_SubType], [Model_Manufaturer]) VALUES (1, NULL, 1, N'Asus K55dv', 1, NULL)
INSERT [dbo].[Model] ([Model_Id], [Model_SKU], [Model_Type], [Model_Name], [Model_SubType], [Model_Manufaturer]) VALUES (2, NULL, 1, N'Lenovo Thinkpad', 2, NULL)
INSERT [dbo].[Model] ([Model_Id], [Model_SKU], [Model_Type], [Model_Name], [Model_SubType], [Model_Manufaturer]) VALUES (3, NULL, 6, N'Huwai-TCL234', 4, NULL)
INSERT [dbo].[Model] ([Model_Id], [Model_SKU], [Model_Type], [Model_Name], [Model_SubType], [Model_Manufaturer]) VALUES (4, NULL, 6, N'Cisco 345k', 3, NULL)
SET IDENTITY_INSERT [dbo].[Model] OFF
SET IDENTITY_INSERT [dbo].[ProductSubType] ON 

INSERT [dbo].[ProductSubType] ([ProductSubType_Id], [ProductSubType_Name], [ProductSubType_MainType]) VALUES (1, N'Laptop', 1)
INSERT [dbo].[ProductSubType] ([ProductSubType_Id], [ProductSubType_Name], [ProductSubType_MainType]) VALUES (2, N'Desktop', 1)
INSERT [dbo].[ProductSubType] ([ProductSubType_Id], [ProductSubType_Name], [ProductSubType_MainType]) VALUES (3, N'Wired', 6)
INSERT [dbo].[ProductSubType] ([ProductSubType_Id], [ProductSubType_Name], [ProductSubType_MainType]) VALUES (4, N'Wireless', 6)
SET IDENTITY_INSERT [dbo].[ProductSubType] OFF
SET IDENTITY_INSERT [dbo].[ProductType] ON 

INSERT [dbo].[ProductType] ([ProductType_Id], [ProductType_Name]) VALUES (1, N'PC')
INSERT [dbo].[ProductType] ([ProductType_Id], [ProductType_Name]) VALUES (2, N'Monitor')
INSERT [dbo].[ProductType] ([ProductType_Id], [ProductType_Name]) VALUES (3, N'Printer')
INSERT [dbo].[ProductType] ([ProductType_Id], [ProductType_Name]) VALUES (4, N'Scanner')
INSERT [dbo].[ProductType] ([ProductType_Id], [ProductType_Name]) VALUES (5, N'UPS')
INSERT [dbo].[ProductType] ([ProductType_Id], [ProductType_Name]) VALUES (6, N'Network Card')
SET IDENTITY_INSERT [dbo].[ProductType] OFF
ALTER TABLE [dbo].[LocationChange]  WITH CHECK ADD  CONSTRAINT [FK_LocationChange_Location] FOREIGN KEY([LocChng_Id])
REFERENCES [dbo].[Location] ([Location_Id])
GO
ALTER TABLE [dbo].[LocationChange] CHECK CONSTRAINT [FK_LocationChange_Location]
GO
ALTER TABLE [dbo].[LocationChange]  WITH CHECK ADD  CONSTRAINT [FK_LocationChange_Product] FOREIGN KEY([LocChng_ProductId])
REFERENCES [dbo].[Product] ([Product_Id])
GO
ALTER TABLE [dbo].[LocationChange] CHECK CONSTRAINT [FK_LocationChange_Product]
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD  CONSTRAINT [FK_Model_Manufature] FOREIGN KEY([Model_Manufaturer])
REFERENCES [dbo].[Manufature] ([Manufacture_Id])
GO
ALTER TABLE [dbo].[Model] CHECK CONSTRAINT [FK_Model_Manufature]
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD  CONSTRAINT [FK_Model_Model] FOREIGN KEY([Model_Id])
REFERENCES [dbo].[Model] ([Model_Id])
GO
ALTER TABLE [dbo].[Model] CHECK CONSTRAINT [FK_Model_Model]
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD  CONSTRAINT [FK_Model_ProductSubType] FOREIGN KEY([Model_SubType])
REFERENCES [dbo].[ProductSubType] ([ProductSubType_Id])
GO
ALTER TABLE [dbo].[Model] CHECK CONSTRAINT [FK_Model_ProductSubType]
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD  CONSTRAINT [FK_Model_ProductType] FOREIGN KEY([Model_Type])
REFERENCES [dbo].[ProductType] ([ProductType_Id])
GO
ALTER TABLE [dbo].[Model] CHECK CONSTRAINT [FK_Model_ProductType]
GO
ALTER TABLE [dbo].[Note]  WITH CHECK ADD  CONSTRAINT [FK_Note_Product] FOREIGN KEY([Note_ProductId])
REFERENCES [dbo].[Product] ([Product_Id])
GO
ALTER TABLE [dbo].[Note] CHECK CONSTRAINT [FK_Note_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Model] FOREIGN KEY([Product_ModelId])
REFERENCES [dbo].[Model] ([Model_Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Model]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([Product_Supplier])
REFERENCES [dbo].[Supplier] ([Supplier_Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
ALTER TABLE [dbo].[ProductSubType]  WITH CHECK ADD  CONSTRAINT [FK_ProductSubType_ProductType] FOREIGN KEY([ProductSubType_MainType])
REFERENCES [dbo].[ProductType] ([ProductType_Id])
GO
ALTER TABLE [dbo].[ProductSubType] CHECK CONSTRAINT [FK_ProductSubType_ProductType]
GO
