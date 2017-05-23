USE [kursach]
GO

/****** Object:  Table [dbo].[���� ��������]    Script Date: 22.05.2017 1:21:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[���� ��������](
	[ID��������] [int] NOT NULL,
	[������������] [varchar](50) NOT NULL,
	[ID����������] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_���� ��������] PRIMARY KEY CLUSTERED 
(
	[ID��������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[���� ��������]  WITH CHECK ADD  CONSTRAINT [FK_���� ��������_������������������] FOREIGN KEY([ID����������])
REFERENCES [dbo].[������������������] ([ID����������])
GO

ALTER TABLE [dbo].[���� ��������] CHECK CONSTRAINT [FK_���� ��������_������������������]
GO


USE [kursach]
GO

/****** Object:  Table [dbo].[������]    Script Date: 22.05.2017 1:21:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[������](
	[ID������] [int] IDENTITY(1,1) NOT NULL,
	[�����������] [int] NOT NULL,
	[�����������] [varchar](50) NOT NULL,
	[�����������] [varchar](50) NOT NULL,
	[ID�������������] [int] NOT NULL,
 CONSTRAINT [PK_������] PRIMARY KEY CLUSTERED 
(
	[ID������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[������]  WITH CHECK ADD  CONSTRAINT [FK_������_�������������] FOREIGN KEY([ID�������������])
REFERENCES [dbo].[�������������] ([ID�������������])
GO

ALTER TABLE [dbo].[������] CHECK CONSTRAINT [FK_������_�������������]
GO


USE [kursach]
GO

/****** Object:  Table [dbo].[��������]    Script Date: 22.05.2017 1:21:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[��������](
	[ID��������] [int] IDENTITY(1,1) NOT NULL,
	[�������������] [varchar](50) NOT NULL,
	[��������������] [varchar](50) NOT NULL,
	[��������������] [varchar](50) NOT NULL,
	[��������������������] [varchar](50) NOT NULL,
	[�������������������] [varchar](50) NOT NULL,
	[�������������] [varchar](50) NULL,
	[������] [varchar](50) NULL,
	[�������������] [varchar](50) NOT NULL,
	[�������������] [varchar](50) NOT NULL,
	[����������] [varchar](50) NOT NULL,
	[�����������] [varchar](50) NOT NULL,
	[����������������������] [varchar](50) NOT NULL,
	[����������������������������] [varchar](50) NULL,
	[�������������] [varchar](50) NOT NULL,
	[����������] [varchar](50) NOT NULL,
	[�����������] [varchar](50) NULL,
	[�������������������] [varchar](50) NULL,
	[ID��������] [int] NOT NULL,
	[��������������] [varchar](50) NOT NULL,
	[���������������] [varchar](50) NOT NULL,
	[�������������������] [varchar](50) NOT NULL,
	[����������] [varchar](50) NOT NULL,
	[������������] [varchar](50) NOT NULL,
	[�����������] [varchar](50) NOT NULL,
	[���������������] [varchar](50) NULL,
	[��������������] [varchar](50) NOT NULL,
	[���������������] [varchar](50) NOT NULL,
	[��������������������] [varchar](50) NOT NULL,
 CONSTRAINT [PK_��������] PRIMARY KEY CLUSTERED 
(
	[ID��������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[��������]  WITH CHECK ADD  CONSTRAINT [FK_��������_��������] FOREIGN KEY([ID��������])
REFERENCES [dbo].[��������] ([ID��������])
GO

ALTER TABLE [dbo].[��������] CHECK CONSTRAINT [FK_��������_��������]
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[����������]    Script Date: 22.05.2017 1:21:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[����������](
	[ID�����������] [int] IDENTITY(1,1) NOT NULL,
	[���] [varchar](50) NOT NULL,
	[������������������] [varchar](50) NOT NULL,
 CONSTRAINT [PK_����������] PRIMARY KEY CLUSTERED 
(
	[ID�����������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[�����������]    Script Date: 22.05.2017 1:22:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[�����������](
	[ID �����������] [int] IDENTITY(1,1) NOT NULL,
	[��������] [varchar](50) NOT NULL,
	[���] [varchar](50) NOT NULL,
	[�����] [varchar](50) NOT NULL,
	[�������] [varchar](50) NOT NULL,
	[��. �����] [varchar](50) NOT NULL,
	[���������� ����] [varchar](50) NOT NULL,
	[ID��������������������] [int] NOT NULL,
	[ID�����������] [int] NOT NULL,
 CONSTRAINT [PK_�����������] PRIMARY KEY CLUSTERED 
(
	[ID �����������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[�����������]  WITH CHECK ADD  CONSTRAINT [FK_�����������_��������] FOREIGN KEY([ID��������������������])
REFERENCES [dbo].[��������] ([ID��������])
GO

ALTER TABLE [dbo].[�����������] CHECK CONSTRAINT [FK_�����������_��������]
GO

ALTER TABLE [dbo].[�����������]  WITH CHECK ADD  CONSTRAINT [FK_�����������_����������] FOREIGN KEY([ID�����������])
REFERENCES [dbo].[����������] ([ID�����������])
GO

ALTER TABLE [dbo].[�����������] CHECK CONSTRAINT [FK_�����������_����������]
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[�������������]    Script Date: 22.05.2017 1:22:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[�������������](
	[ID�������������] [int] IDENTITY(1,1) NOT NULL,
	[����������������] [varchar](50) NOT NULL,
	[���������] [varchar](50) NOT NULL,
	[�������] [varchar](50) NOT NULL,
 CONSTRAINT [PK_�������������] PRIMARY KEY CLUSTERED 
(
	[ID�������������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[������������������]    Script Date: 22.05.2017 1:22:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[������������������](
	[ID����������] [int] IDENTITY(1,1) NOT NULL,
	[���] [varchar](50) NOT NULL,
	[����������������] [varchar](50) NOT NULL,
	[�������������] [varchar](50) NOT NULL,
 CONSTRAINT [PK_������������������] PRIMARY KEY CLUSTERED 
(
	[ID����������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[�������������]    Script Date: 22.05.2017 1:22:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[�������������](
	[ID�������������] [int] IDENTITY(1,1) NOT NULL,
	[������������������] [int] NOT NULL,
	[���������������������] [varchar](50) NOT NULL,
 CONSTRAINT [PK_�������������] PRIMARY KEY CLUSTERED 
(
	[ID�������������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[��������]    Script Date: 22.05.2017 1:22:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[��������](
	[ID��������] [int] IDENTITY(1,1) NOT NULL,
	[�����������] [varchar](50) NOT NULL,
	[ID������] [int] NOT NULL,
	[�������������] [varchar](50) NULL,
	[������������] [varchar](50) NOT NULL,
 CONSTRAINT [PK_��������] PRIMARY KEY CLUSTERED 
(
	[ID��������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[��������]  WITH CHECK ADD  CONSTRAINT [FK_��������_������] FOREIGN KEY([ID������])
REFERENCES [dbo].[������] ([ID������])
GO

ALTER TABLE [dbo].[��������] CHECK CONSTRAINT [FK_��������_������]
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[������� ��������]    Script Date: 22.05.2017 1:22:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[������� ��������](
	[ID���������������] [int] IDENTITY(1,1) NOT NULL,
	[ID��������] [int] NOT NULL,
	[ID������������] [int] NOT NULL,
	[ID�������������] [int] NOT NULL,
 CONSTRAINT [PK_������� ��������] PRIMARY KEY CLUSTERED 
(
	[ID���������������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[������� ��������]  WITH CHECK ADD  CONSTRAINT [FK_������� ��������_���� ��������] FOREIGN KEY([ID������������])
REFERENCES [dbo].[���� ��������] ([ID��������])
GO

ALTER TABLE [dbo].[������� ��������] CHECK CONSTRAINT [FK_������� ��������_���� ��������]
GO

ALTER TABLE [dbo].[������� ��������]  WITH CHECK ADD  CONSTRAINT [FK_������� ��������_��������] FOREIGN KEY([ID��������])
REFERENCES [dbo].[��������] ([ID��������])
GO

ALTER TABLE [dbo].[������� ��������] CHECK CONSTRAINT [FK_������� ��������_��������]
GO

ALTER TABLE [dbo].[������� ��������]  WITH CHECK ADD  CONSTRAINT [FK_������� ��������_�������������] FOREIGN KEY([ID�������������])
REFERENCES [dbo].[�������������] ([ID�������������])
GO

ALTER TABLE [dbo].[������� ��������] CHECK CONSTRAINT [FK_������� ��������_�������������]
GO

