USE [AnyStore]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_products]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_products]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[category] [int] NOT NULL,
	[description] [text] NOT NULL,
	[rate] [decimal](18, 2) NOT NULL,
	[qty] [decimal](18, 2) NOT NULL,
	[added_date] [datetime] NOT NULL,
	[added_by] [int] NOT NULL,
 CONSTRAINT [PK__tbl_prod__3213E83F3C9516FE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


