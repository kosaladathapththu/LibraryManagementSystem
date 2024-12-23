USE [Library]
GO
/****** Object:  Table [dbo].[books]    Script Date: 7/27/2024 2:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[BookID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Title] [nchar](100) NULL,
	[Author] [nchar](100) NULL,
	[Genre] [nchar](100) NULL,
	[Availability] [nchar](10) NULL,
 CONSTRAINT [PK_books] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
