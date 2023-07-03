USE [AnyStore]
GO

INSERT INTO [dbo].[tbl_users]
           ([first_name]
           ,[last_name]
           ,[email]
           ,[username]
           ,[password]
           ,[contact]
           ,[address]
           ,[gender]
           ,[user_type]
           ,[added_date]
           ,[added_by]
           ,[modify_date])
     VALUES
           ('Admin'
           ,'admin'
           ,'admin'
           ,'admin'
           ,'admin'
           ,'admin'
           ,'admin'
           ,'Male'
           ,'Admin'
           ,'2002-01-20 00:00:00.000'
           ,1
           ,'2002-01-20 00:00:00.000'
		   )
GO


