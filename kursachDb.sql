USE [kursach]
GO

/****** Object:  Table [dbo].[Виды практики]    Script Date: 15.05.2017 0:28:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Виды практики](
	[IDпрактики] [int] NOT NULL,
	[Наименование] [varchar](50) NOT NULL,
	[IDПроведения] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Виды практики] PRIMARY KEY CLUSTERED 
(
	[IDпрактики] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Виды практики]  WITH CHECK ADD  CONSTRAINT [FK_Виды практики_ПроведениеПрактики] FOREIGN KEY([IDПроведения])
REFERENCES [dbo].[ПроведениеПрактики] ([IDПроведения])
GO

ALTER TABLE [dbo].[Виды практики] CHECK CONSTRAINT [FK_Виды практики_ПроведениеПрактики]
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[Группы]    Script Date: 15.05.2017 0:29:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Группы](
	[IDГруппы] [int] IDENTITY(1,1) NOT NULL,
	[НомерГруппы] [int] NOT NULL,
	[ФИОКуратора] [varchar](50) NOT NULL,
	[ФИОСтаросты] [varchar](50) NOT NULL,
	[IDСпециальности] [int] NOT NULL,
 CONSTRAINT [PK_Группы] PRIMARY KEY CLUSTERED 
(
	[IDГруппы] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Группы]  WITH CHECK ADD  CONSTRAINT [FK_Группы_Специальности] FOREIGN KEY([IDСпециальности])
REFERENCES [dbo].[Специальности] ([IDСпециальности])
GO

ALTER TABLE [dbo].[Группы] CHECK CONSTRAINT [FK_Группы_Специальности]
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[Договоры]    Script Date: 15.05.2017 0:29:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Договоры](
	[IDДоговора] [int] IDENTITY(1,1) NOT NULL,
	[НомерДоговора] [varchar](50) NOT NULL,
	[ДатаЗаключения] [varchar](50) NOT NULL,
	[ФИОИсполнителя] [varchar](50) NOT NULL,
	[ДолжностьИсполнителя] [varchar](50) NOT NULL,
	[НазваниеПредприятия] [varchar](50) NOT NULL,
	[УченаяСтепень] [varchar](50) NULL,
	[Звание] [varchar](50) NULL,
	[СерияПаспорта] [varchar](50) NOT NULL,
	[НомерПаспорта] [varchar](50) NOT NULL,
	[ДатаВыдачи] [varchar](50) NOT NULL,
	[ОрганВыдачи] [varchar](50) NOT NULL,
	[ИдентификационныйНомер] [varchar](50) NOT NULL,
	[НомерСтраховогоСвидетельства] [varchar](50) NULL,
	[ДомашнийАдрес] [varchar](50) NOT NULL,
	[ТелРабочий] [varchar](50) NOT NULL,
	[ТелДомашний] [varchar](50) NULL,
	[МестоОсновнойРаботы] [varchar](50) NULL,
	[IDСтудента] [int] NOT NULL,
	[ДатаПроведения] [varchar](50) NOT NULL,
	[КоличествоЧасов] [varchar](50) NOT NULL,
	[СтоимостьОдногоЧаса] [varchar](50) NOT NULL,
	[ОбщаяСумма] [varchar](50) NOT NULL,
	[НомерПриказа] [varchar](50) NOT NULL,
	[ДатаПриказа] [varchar](50) NOT NULL,
	[ФИООтделаКадров] [varchar](50) NULL,
	[ФИОЗавКафедрой] [varchar](50) NOT NULL,
	[НазваниеКафедры] [varchar](50) NOT NULL,
	[РуководительПрактики] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Договоры] PRIMARY KEY CLUSTERED 
(
	[IDДоговора] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Договоры]  WITH CHECK ADD  CONSTRAINT [FK_Договоры_Студенты] FOREIGN KEY([IDСтудента])
REFERENCES [dbo].[Студенты] ([IDСтудента])
GO

ALTER TABLE [dbo].[Договоры] CHECK CONSTRAINT [FK_Договоры_Студенты]
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[ПланНабора]    Script Date: 15.05.2017 0:29:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ПланНабора](
	[IDНабораНаГод] [int] IDENTITY(1,1) NOT NULL,
	[Год] [varchar](50) NOT NULL,
	[МаксКолвоСтудентов] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ПланНабора] PRIMARY KEY CLUSTERED 
(
	[IDНабораНаГод] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[Предприятия]    Script Date: 15.05.2017 0:29:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Предприятия](
	[ID предприятия] [int] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](50) NOT NULL,
	[УНП] [varchar](50) NOT NULL,
	[Адрес] [varchar](50) NOT NULL,
	[Телефон] [varchar](50) NOT NULL,
	[Эл. почта] [varchar](50) NOT NULL,
	[Контактное лицо] [varchar](50) NOT NULL,
	[IDЗаключенныхДоговоров] [int] NOT NULL,
	[IDНабораНаГод] [int] NOT NULL,
 CONSTRAINT [PK_Предприятия] PRIMARY KEY CLUSTERED 
(
	[ID предприятия] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Предприятия]  WITH CHECK ADD  CONSTRAINT [FK_Предприятия_Договоры] FOREIGN KEY([IDЗаключенныхДоговоров])
REFERENCES [dbo].[Договоры] ([IDДоговора])
GO

ALTER TABLE [dbo].[Предприятия] CHECK CONSTRAINT [FK_Предприятия_Договоры]
GO

ALTER TABLE [dbo].[Предприятия]  WITH CHECK ADD  CONSTRAINT [FK_Предприятия_ПланНабора] FOREIGN KEY([IDНабораНаГод])
REFERENCES [dbo].[ПланНабора] ([IDНабораНаГод])
GO

ALTER TABLE [dbo].[Предприятия] CHECK CONSTRAINT [FK_Предприятия_ПланНабора]
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[Преподаватели]    Script Date: 15.05.2017 0:29:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Преподаватели](
	[IDПреподавателя] [int] IDENTITY(1,1) NOT NULL,
	[ФИОПреподавателя] [varchar](50) NOT NULL,
	[Должность] [varchar](50) NOT NULL,
	[Кафедра] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Преподаватели] PRIMARY KEY CLUSTERED 
(
	[IDПреподавателя] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[ПроведениеПрактики]    Script Date: 15.05.2017 0:30:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ПроведениеПрактики](
	[IDПроведения] [int] IDENTITY(1,1) NOT NULL,
	[Год] [varchar](50) NOT NULL,
	[Производственная] [varchar](50) NOT NULL,
	[Преддипломная] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ПроведениеПрактики] PRIMARY KEY CLUSTERED 
(
	[IDПроведения] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[Специальности]    Script Date: 15.05.2017 0:30:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Специальности](
	[IDСпециальности] [int] IDENTITY(1,1) NOT NULL,
	[НомерСпециальности] [int] NOT NULL,
	[НазваниеСпециальности] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Специальности] PRIMARY KEY CLUSTERED 
(
	[IDСпециальности] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[Студенты]    Script Date: 15.05.2017 0:30:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Студенты](
	[IDСтудента] [int] IDENTITY(1,1) NOT NULL,
	[ФИОСтудента] [varchar](50) NOT NULL,
	[IDГруппы] [int] NOT NULL,
	[НомерТелефона] [varchar](50) NULL,
	[НомерЗачетки] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Студенты] PRIMARY KEY CLUSTERED 
(
	[IDСтудента] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Студенты]  WITH CHECK ADD  CONSTRAINT [FK_Студенты_Группы] FOREIGN KEY([IDГруппы])
REFERENCES [dbo].[Группы] ([IDГруппы])
GO

ALTER TABLE [dbo].[Студенты] CHECK CONSTRAINT [FK_Студенты_Группы]
GO

USE [kursach]
GO

/****** Object:  Table [dbo].[Текущая практика]    Script Date: 15.05.2017 0:30:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Текущая практика](
	[IDТекущейПрактики] [int] IDENTITY(1,1) NOT NULL,
	[IDДоговора] [int] NOT NULL,
	[IDВидаПрактики] [int] NOT NULL,
	[IDПреподавателя] [int] NOT NULL,
 CONSTRAINT [PK_Текущая практика] PRIMARY KEY CLUSTERED 
(
	[IDТекущейПрактики] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Текущая практика]  WITH CHECK ADD  CONSTRAINT [FK_Текущая практика_Виды практики] FOREIGN KEY([IDВидаПрактики])
REFERENCES [dbo].[Виды практики] ([IDпрактики])
GO

ALTER TABLE [dbo].[Текущая практика] CHECK CONSTRAINT [FK_Текущая практика_Виды практики]
GO

ALTER TABLE [dbo].[Текущая практика]  WITH CHECK ADD  CONSTRAINT [FK_Текущая практика_Договоры] FOREIGN KEY([IDДоговора])
REFERENCES [dbo].[Договоры] ([IDДоговора])
GO

ALTER TABLE [dbo].[Текущая практика] CHECK CONSTRAINT [FK_Текущая практика_Договоры]
GO

ALTER TABLE [dbo].[Текущая практика]  WITH CHECK ADD  CONSTRAINT [FK_Текущая практика_Преподаватели] FOREIGN KEY([IDПреподавателя])
REFERENCES [dbo].[Преподаватели] ([IDПреподавателя])
GO

ALTER TABLE [dbo].[Текущая практика] CHECK CONSTRAINT [FK_Текущая практика_Преподаватели]
GO






