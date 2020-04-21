USE [$DatabaseName$]
CREATE TABLE [dbo].[User](
	[Id] [uniqueidentifier] NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Lastname] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO