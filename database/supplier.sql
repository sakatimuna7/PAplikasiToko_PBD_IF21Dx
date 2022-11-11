USE [db_toko_if21dx]
GO

/****** Object:  Table [dbo].[supplier]    Script Date: 10/24/2022 21:03:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[supplier](
	[kd_sup] [varchar](10) NOT NULL,
	[nm_per] [varchar](20) NULL,
	[nm_pen] [varchar](20) NULL,
	[No_telp] [varchar](15) NULL,
	[email] [varchar](20) NULL,
	[alamat] [varchar](30) NULL,
 CONSTRAINT [PK_supplier] PRIMARY KEY CLUSTERED 
(
	[kd_sup] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

