USE [AnyStore]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_transactions]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_transactions]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](10) NOT NULL,
	[dea_cust_id] [int] NOT NULL,
	[grandTotal] [decimal](18, 2) NOT NULL,
	[transaction_date] [datetime] NOT NULL,
	[tax] [decimal](18, 2) NOT NULL,
	[discount] [decimal](18, 2) NOT NULL,
	[added_by] [int] NOT NULL,
 CONSTRAINT [PK__tbl_tran__3213E83F627087AC] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


