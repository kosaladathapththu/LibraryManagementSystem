USE [Library]
GO
/****** Object:  Table [dbo].[Returnbooks]    Script Date: 7/27/2024 2:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Returnbooks](
	[ReturnID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[IssueID] [numeric](18, 0) NULL,
	[Membename] [nchar](100) NULL,
	[Bookname] [nchar](100) NULL,
	[Fine] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Returnbooks] PRIMARY KEY CLUSTERED 
(
	[ReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
