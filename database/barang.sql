USE [db_toko_if21dx]
GO

/****** Object:  Table [dbo].[barang]    Script Date: 10/31/2022 19:23:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[barang](
	[kd_brg] [varchar](50) NOT NULL,
	[nm_barang] [varchar](50) NULL,
	[diskon] [float] NULL,
	[hrg_jual] [float] NULL,
	[jumlah] [float] NULL,
	[rusak] [float] NULL,
	[sisa] [float] NULL,
 CONSTRAINT [PK_barang] PRIMARY KEY CLUSTERED 
(
	[kd_brg] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

