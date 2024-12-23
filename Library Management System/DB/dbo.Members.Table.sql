USE [Library]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 7/27/2024 2:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[MemberID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Name] [nchar](100) NULL,
	[Email] [nchar](100) NULL,
	[Phone] [nchar](100) NULL,
	[Address] [nchar](100) NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
