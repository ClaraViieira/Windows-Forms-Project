create database BancoNotas;

use BancoNotas;

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notas](
	[id] [int] identity(1,1) not null,
	[nota1] [varchar] (5) null,
	[nota2] [varchar] (5) null,
	[nota3] [varchar] (5) null,
	[nota4] [varchar] (5) null,
 CONSTRAINT [PK_Notass] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, 
ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO