USE [master]
GO
/****** Object:  Database [student_accounting]    Script Date: 18.12.2024 16:57:22 ******/
CREATE DATABASE [student_accounting]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'student_accounting', FILENAME = N'C:\Users\10220463\student_accounting.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'student_accounting_log', FILENAME = N'C:\Users\10220463\student_accounting_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [student_accounting] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [student_accounting].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [student_accounting] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [student_accounting] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [student_accounting] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [student_accounting] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [student_accounting] SET ARITHABORT OFF 
GO
ALTER DATABASE [student_accounting] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [student_accounting] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [student_accounting] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [student_accounting] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [student_accounting] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [student_accounting] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [student_accounting] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [student_accounting] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [student_accounting] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [student_accounting] SET  DISABLE_BROKER 
GO
ALTER DATABASE [student_accounting] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [student_accounting] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [student_accounting] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [student_accounting] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [student_accounting] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [student_accounting] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [student_accounting] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [student_accounting] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [student_accounting] SET  MULTI_USER 
GO
ALTER DATABASE [student_accounting] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [student_accounting] SET DB_CHAINING OFF 
GO
ALTER DATABASE [student_accounting] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [student_accounting] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [student_accounting] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [student_accounting] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [student_accounting] SET QUERY_STORE = ON
GO
ALTER DATABASE [student_accounting] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [student_accounting]
GO
/****** Object:  Table [dbo].[control_types]    Script Date: 18.12.2024 16:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[control_types](
	[id_control_type] [int] IDENTITY(1,1) NOT NULL,
	[control_type_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_control_types] PRIMARY KEY CLUSTERED 
(
	[id_control_type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[entrance]    Script Date: 18.12.2024 16:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entrance](
	[id_entrance] [int] IDENTITY(1,1) NOT NULL,
	[id_role] [int] NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[date_last_login] [date] NULL,
	[id_entity] [int] NOT NULL,
 CONSTRAINT [PK_entrance] PRIMARY KEY CLUSTERED 
(
	[id_entrance] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[exams]    Script Date: 18.12.2024 16:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exams](
	[id_exam] [int] IDENTITY(1,1) NOT NULL,
	[id_student] [int] NOT NULL,
	[id_subject] [int] NOT NULL,
	[id_control_type] [int] NULL,
	[date] [date] NULL,
	[grade] [nvarchar](50) NULL,
 CONSTRAINT [PK_exams] PRIMARY KEY CLUSTERED 
(
	[id_exam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[faculties]    Script Date: 18.12.2024 16:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[faculties](
	[id_faculty] [int] IDENTITY(1,1) NOT NULL,
	[faculty_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_faculties] PRIMARY KEY CLUSTERED 
(
	[id_faculty] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[groups]    Script Date: 18.12.2024 16:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[groups](
	[id_group] [int] IDENTITY(1,1) NOT NULL,
	[group_number] [nvarchar](50) NOT NULL,
	[id_specialty] [int] NOT NULL,
	[course] [int] NOT NULL,
 CONSTRAINT [PK_groups] PRIMARY KEY CLUSTERED 
(
	[id_group] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 18.12.2024 16:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id_role] [int] IDENTITY(1,1) NOT NULL,
	[role_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[id_role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[specialties]    Script Date: 18.12.2024 16:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[specialties](
	[id_specialty] [int] IDENTITY(1,1) NOT NULL,
	[id_faculty] [int] NOT NULL,
	[specialty_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_specialties] PRIMARY KEY CLUSTERED 
(
	[id_specialty] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[students]    Script Date: 18.12.2024 16:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[students](
	[id_student] [int] IDENTITY(1,1) NOT NULL,
	[student_id_number] [nvarchar](50) NOT NULL,
	[full_name] [nvarchar](255) NOT NULL,
	[sex] [nvarchar](50) NOT NULL,
	[id_group] [int] NOT NULL,
	[date_birth] [date] NOT NULL,
 CONSTRAINT [PK_students] PRIMARY KEY CLUSTERED 
(
	[id_student] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subjects]    Script Date: 18.12.2024 16:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subjects](
	[id_subject] [int] IDENTITY(1,1) NOT NULL,
	[id_teacher] [int] NOT NULL,
	[subject_name] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_subjects] PRIMARY KEY CLUSTERED 
(
	[id_subject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[teachers]    Script Date: 18.12.2024 16:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teachers](
	[id_teacher] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [nvarchar](255) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[email] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_teachers] PRIMARY KEY CLUSTERED 
(
	[id_teacher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[control_types] ON 

INSERT [dbo].[control_types] ([id_control_type], [control_type_name]) VALUES (1, N'Экзамен')
INSERT [dbo].[control_types] ([id_control_type], [control_type_name]) VALUES (2, N'Диф. зачет')
SET IDENTITY_INSERT [dbo].[control_types] OFF
GO
SET IDENTITY_INSERT [dbo].[entrance] ON 

INSERT [dbo].[entrance] ([id_entrance], [id_role], [login], [password], [date_last_login], [id_entity]) VALUES (1, 2, N'maksimM', N'maksimM', CAST(N'2024-11-18' AS Date), 2)
INSERT [dbo].[entrance] ([id_entrance], [id_role], [login], [password], [date_last_login], [id_entity]) VALUES (2, 3, N'admin', N'admin', NULL, 0)
INSERT [dbo].[entrance] ([id_entrance], [id_role], [login], [password], [date_last_login], [id_entity]) VALUES (5, 1, N'123test', N'123test', NULL, 2)
INSERT [dbo].[entrance] ([id_entrance], [id_role], [login], [password], [date_last_login], [id_entity]) VALUES (6, 1, N'1202202', N'1202202', NULL, 2)
SET IDENTITY_INSERT [dbo].[entrance] OFF
GO
SET IDENTITY_INSERT [dbo].[exams] ON 

INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (3, 1, 2, 2, CAST(N'2024-06-22' AS Date), N'4')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (4, 1, 2, 2, CAST(N'2024-06-22' AS Date), N'2')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (5, 2, 3, 2, CAST(N'2024-11-20' AS Date), N'5')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (6, 2, 6, 1, CAST(N'2024-11-23' AS Date), N'4')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (7, 2, 3, 2, CAST(N'2024-11-20' AS Date), N'5')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (8, 1, 1, 1, CAST(N'2024-12-18' AS Date), N'2')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (9, 2, 2, 1, CAST(N'2024-12-18' AS Date), N'2')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (10, 4, 5, 1, CAST(N'2024-12-18' AS Date), N'2')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (11, 5, 5, 2, CAST(N'2024-12-18' AS Date), N'5')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (12, 5, 6, 1, CAST(N'2024-12-16' AS Date), N'4')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (13, 5, 3, 1, CAST(N'2024-12-01' AS Date), N'5')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (14, 6, 2, 1, CAST(N'2024-12-14' AS Date), N'5')
INSERT [dbo].[exams] ([id_exam], [id_student], [id_subject], [id_control_type], [date], [grade]) VALUES (15, 6, 5, 2, CAST(N'2024-12-09' AS Date), N'4')
SET IDENTITY_INSERT [dbo].[exams] OFF
GO
SET IDENTITY_INSERT [dbo].[faculties] ON 

INSERT [dbo].[faculties] ([id_faculty], [faculty_name]) VALUES (1, N'Факультет тестовый')
INSERT [dbo].[faculties] ([id_faculty], [faculty_name]) VALUES (2, N'ИТ технологий и дизайна')
INSERT [dbo].[faculties] ([id_faculty], [faculty_name]) VALUES (3, N'Экономический')
INSERT [dbo].[faculties] ([id_faculty], [faculty_name]) VALUES (4, N'Политологии')
INSERT [dbo].[faculties] ([id_faculty], [faculty_name]) VALUES (5, N'Юридический')
SET IDENTITY_INSERT [dbo].[faculties] OFF
GO
SET IDENTITY_INSERT [dbo].[groups] ON 

INSERT [dbo].[groups] ([id_group], [group_number], [id_specialty], [course]) VALUES (1, N'51-02', 1, 2)
INSERT [dbo].[groups] ([id_group], [group_number], [id_specialty], [course]) VALUES (2, N'52-02', 2, 3)
INSERT [dbo].[groups] ([id_group], [group_number], [id_specialty], [course]) VALUES (3, N'53-02', 2, 2)
INSERT [dbo].[groups] ([id_group], [group_number], [id_specialty], [course]) VALUES (4, N'52-03', 4, 3)
INSERT [dbo].[groups] ([id_group], [group_number], [id_specialty], [course]) VALUES (5, N'12-22', 10, 3)
INSERT [dbo].[groups] ([id_group], [group_number], [id_specialty], [course]) VALUES (6, N'22-21', 7, 3)
INSERT [dbo].[groups] ([id_group], [group_number], [id_specialty], [course]) VALUES (7, N'20-21', 7, 5)
INSERT [dbo].[groups] ([id_group], [group_number], [id_specialty], [course]) VALUES (8, N'30-51', 3, 5)
SET IDENTITY_INSERT [dbo].[groups] OFF
GO
SET IDENTITY_INSERT [dbo].[roles] ON 

INSERT [dbo].[roles] ([id_role], [role_name]) VALUES (1, N'Студент')
INSERT [dbo].[roles] ([id_role], [role_name]) VALUES (2, N'Преподаватель')
INSERT [dbo].[roles] ([id_role], [role_name]) VALUES (3, N'Администратор')
SET IDENTITY_INSERT [dbo].[roles] OFF
GO
SET IDENTITY_INSERT [dbo].[specialties] ON 

INSERT [dbo].[specialties] ([id_specialty], [id_faculty], [specialty_name]) VALUES (1, 1, N'Специальность тест')
INSERT [dbo].[specialties] ([id_specialty], [id_faculty], [specialty_name]) VALUES (2, 2, N'Программирование')
INSERT [dbo].[specialties] ([id_specialty], [id_faculty], [specialty_name]) VALUES (3, 2, N'Дизайн в промышленности')
INSERT [dbo].[specialties] ([id_specialty], [id_faculty], [specialty_name]) VALUES (4, 2, N'Web-Дизайн')
INSERT [dbo].[specialties] ([id_specialty], [id_faculty], [specialty_name]) VALUES (5, 5, N'Юриспруденция')
INSERT [dbo].[specialties] ([id_specialty], [id_faculty], [specialty_name]) VALUES (6, 5, N'Обеспечение законности и правопорядка')
INSERT [dbo].[specialties] ([id_specialty], [id_faculty], [specialty_name]) VALUES (7, 4, N'Политология')
INSERT [dbo].[specialties] ([id_specialty], [id_faculty], [specialty_name]) VALUES (8, 4, N'Международные отношения')
INSERT [dbo].[specialties] ([id_specialty], [id_faculty], [specialty_name]) VALUES (9, 4, N'Регионоведение России')
INSERT [dbo].[specialties] ([id_specialty], [id_faculty], [specialty_name]) VALUES (10, 3, N'Менеджмент')
INSERT [dbo].[specialties] ([id_specialty], [id_faculty], [specialty_name]) VALUES (11, 3, N'Экономика')
SET IDENTITY_INSERT [dbo].[specialties] OFF
GO
SET IDENTITY_INSERT [dbo].[students] ON 

INSERT [dbo].[students] ([id_student], [student_id_number], [full_name], [sex], [id_group], [date_birth]) VALUES (1, N'1202200', N'Смирнов Олег Владимирович', N'муж', 2, CAST(N'2005-03-11' AS Date))
INSERT [dbo].[students] ([id_student], [student_id_number], [full_name], [sex], [id_group], [date_birth]) VALUES (2, N'1202202', N'Жгулёва Александра Павловна', N'жен', 2, CAST(N'2004-12-22' AS Date))
INSERT [dbo].[students] ([id_student], [student_id_number], [full_name], [sex], [id_group], [date_birth]) VALUES (3, N'1202204', N'Чекин Леонтий Степанович', N'муж', 2, CAST(N'2005-01-11' AS Date))
INSERT [dbo].[students] ([id_student], [student_id_number], [full_name], [sex], [id_group], [date_birth]) VALUES (4, N'1202204', N'Брагин Адам Евгеньевич', N'муж', 2, CAST(N'2004-10-08' AS Date))
INSERT [dbo].[students] ([id_student], [student_id_number], [full_name], [sex], [id_group], [date_birth]) VALUES (5, N'1024000', N'Панфилов Кирилл Игоревич', N'муж', 5, CAST(N'2000-02-09' AS Date))
INSERT [dbo].[students] ([id_student], [student_id_number], [full_name], [sex], [id_group], [date_birth]) VALUES (6, N'1202210', N'Капитанова Ольга Сергеевна', N'жен', 2, CAST(N'1999-01-29' AS Date))
SET IDENTITY_INSERT [dbo].[students] OFF
GO
SET IDENTITY_INSERT [dbo].[subjects] ON 

INSERT [dbo].[subjects] ([id_subject], [id_teacher], [subject_name]) VALUES (1, 1, N'Основы алгоритмизации и программирования')
INSERT [dbo].[subjects] ([id_subject], [id_teacher], [subject_name]) VALUES (2, 2, N'Алгоритмизация и программирование')
INSERT [dbo].[subjects] ([id_subject], [id_teacher], [subject_name]) VALUES (3, 1, N'ДОП Классовое программирование')
INSERT [dbo].[subjects] ([id_subject], [id_teacher], [subject_name]) VALUES (4, 2, N'ДОП Функциональное программирование')
INSERT [dbo].[subjects] ([id_subject], [id_teacher], [subject_name]) VALUES (5, 1, N'Разработка программных модулей')
INSERT [dbo].[subjects] ([id_subject], [id_teacher], [subject_name]) VALUES (6, 1, N'Технология разработки и защиты баз данных')
SET IDENTITY_INSERT [dbo].[subjects] OFF
GO
SET IDENTITY_INSERT [dbo].[teachers] ON 

INSERT [dbo].[teachers] ([id_teacher], [full_name], [phone], [email]) VALUES (1, N'Максим Михайлович', N'111', N'maksim@y.ru')
INSERT [dbo].[teachers] ([id_teacher], [full_name], [phone], [email]) VALUES (2, N'Татьяна Сергеевна', N'222', N'tatyana@y.ru')
INSERT [dbo].[teachers] ([id_teacher], [full_name], [phone], [email]) VALUES (3, N'Алексей Сергеевич', N'89321153215', N'aleksS@y.ru')
INSERT [dbo].[teachers] ([id_teacher], [full_name], [phone], [email]) VALUES (4, N'Вениамин Валентинович', N'85683923444', N'vVal@y.ru')
INSERT [dbo].[teachers] ([id_teacher], [full_name], [phone], [email]) VALUES (5, N'test', N'38383', N'fjdka@jgklsjr.ru')
INSERT [dbo].[teachers] ([id_teacher], [full_name], [phone], [email]) VALUES (6, N'Коршунов Владислав Сергеевич', N'79021134522', N'kor@ff.ru')
SET IDENTITY_INSERT [dbo].[teachers] OFF
GO
ALTER TABLE [dbo].[entrance]  WITH CHECK ADD  CONSTRAINT [FK_entrance_roles] FOREIGN KEY([id_role])
REFERENCES [dbo].[roles] ([id_role])
GO
ALTER TABLE [dbo].[entrance] CHECK CONSTRAINT [FK_entrance_roles]
GO
ALTER TABLE [dbo].[exams]  WITH CHECK ADD  CONSTRAINT [FK_exams_control_types] FOREIGN KEY([id_control_type])
REFERENCES [dbo].[control_types] ([id_control_type])
GO
ALTER TABLE [dbo].[exams] CHECK CONSTRAINT [FK_exams_control_types]
GO
ALTER TABLE [dbo].[exams]  WITH CHECK ADD  CONSTRAINT [FK_exams_students] FOREIGN KEY([id_student])
REFERENCES [dbo].[students] ([id_student])
GO
ALTER TABLE [dbo].[exams] CHECK CONSTRAINT [FK_exams_students]
GO
ALTER TABLE [dbo].[exams]  WITH CHECK ADD  CONSTRAINT [FK_exams_subjects] FOREIGN KEY([id_subject])
REFERENCES [dbo].[subjects] ([id_subject])
GO
ALTER TABLE [dbo].[exams] CHECK CONSTRAINT [FK_exams_subjects]
GO
ALTER TABLE [dbo].[groups]  WITH CHECK ADD  CONSTRAINT [FK_groups_specialties] FOREIGN KEY([id_specialty])
REFERENCES [dbo].[specialties] ([id_specialty])
GO
ALTER TABLE [dbo].[groups] CHECK CONSTRAINT [FK_groups_specialties]
GO
ALTER TABLE [dbo].[specialties]  WITH CHECK ADD  CONSTRAINT [FK_specialties_faculties] FOREIGN KEY([id_faculty])
REFERENCES [dbo].[faculties] ([id_faculty])
GO
ALTER TABLE [dbo].[specialties] CHECK CONSTRAINT [FK_specialties_faculties]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_groups] FOREIGN KEY([id_group])
REFERENCES [dbo].[groups] ([id_group])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_groups]
GO
ALTER TABLE [dbo].[subjects]  WITH CHECK ADD  CONSTRAINT [FK_subjects_teachers] FOREIGN KEY([id_teacher])
REFERENCES [dbo].[teachers] ([id_teacher])
GO
ALTER TABLE [dbo].[subjects] CHECK CONSTRAINT [FK_subjects_teachers]
GO
USE [master]
GO
ALTER DATABASE [student_accounting] SET  READ_WRITE 
GO
