USE [AnyStore]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_categories]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_categories]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[description] [text] NOT NULL,
	[added_date] [datetime] NOT NULL,
	[added_by] [int] NOT NULL,
 CONSTRAINT [PK__tbl_cate__3213E83FC4B3AA41] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
