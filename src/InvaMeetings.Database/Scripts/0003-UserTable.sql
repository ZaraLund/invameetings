USE [$DatabaseName$]
GO
CREATE TABLE [dbo].[Event](
	[ID] [uniqueidentifier] NOT NULL,
	[Firstname][nvarchar](50) NOT NULL,
	[Lastname] [nvarchar](50) NOT NULL,
    [Username] [nvarchar](50) NOT NULL,
) ON [PRIMARY]
GO