USE [AnyStore]
GO

/****** Object:  Table [dbo].[tbl_users]    Script Date: 7/3/2023 8:18:25 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_users]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_users]
GO

/****** Object:  Table [dbo].[tbl_users]    Script Date: 7/3/2023 8:18:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[contact] [varchar](15) NOT NULL,
	[address] [text] NOT NULL,
	[gender] [varchar](10) NOT NULL,
	[user_type] [varchar](15) NOT NULL,
	[added_date] [datetime] NOT NULL,
	[added_by] [int] NOT NULL,
	[modify_date] [datetime] NOT NULL,
 CONSTRAINT [PK__tbl_user__3213E83F44910166] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
