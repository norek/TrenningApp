IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Phone] [varchar](8) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

delete from dbo.Customers

INSERT [dbo].[Customers] ( [FirstName], [LastName], [Phone]) VALUES ( N'Are', N'Kowalski', N'123')
INSERT [dbo].[Customers] ([FirstName], [LastName], [Phone]) VALUES ( N'Are', N'Nowak', N'12323')
INSERT [dbo].[Customers] ([FirstName], [LastName], [Phone]) VALUES ( N'Ola', N'Nowak', N'12323')
INSERT [dbo].[Customers] ([FirstName], [LastName], [Phone]) VALUES ( N'Jakub', N'Nowak', N'12323')
INSERT [dbo].[Customers] ([FirstName], [LastName], [Phone]) VALUES ( N'Jakub', N'Rozmus', N'12323')

