CREATE TABLE [dbo].[Squads](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](255) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Logs](
	[Id] [uniqueidentifier] NOT NULL,
	[Operacao] [varchar](255) NULL,
	[Valor] [varchar](max) NULL,
	[Classe] [varchar](255) NULL,
	[DataHora] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ExceptionLogs](
	[Id] [uniqueidentifier] NOT NULL,
	[Class] [varchar](max) NULL,
	[Method] [varchar](max) NULL,
	[Data] [varchar](max) NULL,
	[HelpLink] [varchar](max) NULL,
	[HResult] [varchar](max) NULL,
	[InnerException] [varchar](max) NULL,
	[Message] [varchar](max) NULL,
	[Source] [varchar](max) NULL,
	[StackTrace] [varchar](max) NULL,
	[TargetSite] [varchar](max) NULL,
	[DateTime] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



