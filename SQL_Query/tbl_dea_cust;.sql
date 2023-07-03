USE [AnyStore]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_dea_cust]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_dea_cust]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_dea_cust](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[name] [varchar](150) NOT NULL,
	[email] [varchar](150) NOT NULL,
	[contact] [varchar](15) NOT NULL,
	[address] [text] NOT NULL,
	[added_date] [datetime] NOT NULL,
	[added_by] [int] NOT NULL,
 CONSTRAINT [PK__tbl_dea___3213E83F6381E6DD] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


