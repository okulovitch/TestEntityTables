USE [kursach]
GO

/****** Object:  Table [dbo].[���� ��������]    Script Date: 15.05.2017 0:28:57 ******/
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

/****** Object:  Table [dbo].[������]    Script Date: 15.05.2017 0:29:08 ******/
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

/****** Object:  Table [dbo].[��������]    Script Date: 15.05.2017 0:29:19 ******/
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

/****** Object:  Table [dbo].[����������]    Script Date: 15.05.2017 0:29:28 ******/
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

/****** Object:  Table [dbo].[�����������]    Script Date: 15.05.2017 0:29:43 ******/
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

/****** Object:  Table [dbo].[�������������]    Script Date: 15.05.2017 0:29:53 ******/
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

/****** Object:  Table [dbo].[������������������]    Script Date: 15.05.2017 0:30:03 ******/
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

/****** Object:  Table [dbo].[�������������]    Script Date: 15.05.2017 0:30:13 ******/
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

/****** Object:  Table [dbo].[��������]    Script Date: 15.05.2017 0:30:26 ******/
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

/****** Object:  Table [dbo].[������� ��������]    Script Date: 15.05.2017 0:30:37 ******/
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






