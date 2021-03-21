
GO

/****** Object:  Table [dbo].[SalesDetail]    Script Date: 3/14/2021 2:57:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SalesDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NULL,
	[CustomerName] [nvarchar](200) NULL,
	[Item] [nvarchar](200) NULL,
	[SetDetails] [nvarchar](200) NULL,
	[Weight] [decimal](18, 4) NULL,
	[Rate] [decimal](18, 4) NULL,
	[TotalAmount] [decimal](18, 4) NULL,
	[DRCR] [nvarchar](50) NULL,
	[Notes] [nvarchar](200) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_SalesDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


