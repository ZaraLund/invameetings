USE [$DatabaseName$]
GO
CREATE TABLE [dbo].[Event](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Description] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO