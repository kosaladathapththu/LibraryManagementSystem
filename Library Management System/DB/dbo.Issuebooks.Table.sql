USE [Library]
GO
/****** Object:  Table [dbo].[Issuebooks]    Script Date: 7/27/2024 2:26:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Issuebooks](
	[IssueID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Membername] [nchar](100) NULL,
	[Bookname] [nchar](100) NULL,
	[IssueDate] [date] NULL,
	[ReturnDate] [date] NULL,
 CONSTRAINT [PK_Issuebooks] PRIMARY KEY CLUSTERED 
(
	[IssueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
