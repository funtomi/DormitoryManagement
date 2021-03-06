USE [susheSys]
 GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [susheSys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [susheSys] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [susheSys] SET ANSI_NULLS OFF
GO
ALTER DATABASE [susheSys] SET ANSI_PADDING OFF
GO
ALTER DATABASE [susheSys] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [susheSys] SET ARITHABORT OFF
GO
ALTER DATABASE [susheSys] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [susheSys] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [susheSys] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [susheSys] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [susheSys] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [susheSys] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [susheSys] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [susheSys] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [susheSys] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [susheSys] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [susheSys] SET  DISABLE_BROKER
GO
ALTER DATABASE [susheSys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [susheSys] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [susheSys] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [susheSys] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [susheSys] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [susheSys] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [susheSys] SET  READ_WRITE
GO
ALTER DATABASE [susheSys] SET RECOVERY FULL
GO
ALTER DATABASE [susheSys] SET  MULTI_USER
GO
ALTER DATABASE [susheSys] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [susheSys] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'susheSys', N'ON'
GO
USE [susheSys]
GO
/****** Object:  Table [dbo].[tbuser]    Script Date: 06/19/2016 22:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbuser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[pwd] [varchar](50) NULL,
	[sex] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[remark] [varchar](100) NULL,
	[uname] [varchar](50) NULL,
 CONSTRAINT [PK_tbmember] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbuser', @level2type=N'COLUMN',@level2name=N'name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbuser', @level2type=N'COLUMN',@level2name=N'pwd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbuser', @level2type=N'COLUMN',@level2name=N'sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbuser', @level2type=N'COLUMN',@level2name=N'phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbuser', @level2type=N'COLUMN',@level2name=N'address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电子邮箱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbuser', @level2type=N'COLUMN',@level2name=N'email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QQ号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbuser', @level2type=N'COLUMN',@level2name=N'remark'
GO
SET IDENTITY_INSERT [dbo].[tbuser] ON
INSERT [dbo].[tbuser] ([id], [name], [pwd], [sex], [phone], [address], [email], [remark], [uname]) VALUES (1, N'test', N'123456', N'男', N'1314455', N'家庭地址', N'lll@qq.com', N'语言', N'汤同学')
SET IDENTITY_INSERT [dbo].[tbuser] OFF
/****** Object:  Table [dbo].[tbsushe]    Script Date: 06/19/2016 22:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbsushe](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ssname] [varchar](50) NULL,
	[remark] [varchar](200) NULL,
	[pic] [varchar](50) NULL,
 CONSTRAINT [PK_tbsushe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbsushe] ON
INSERT [dbo].[tbsushe] ([id], [ssname], [remark], [pic]) VALUES (2, N'测试宿舍1', NULL, N'head.jpg')
INSERT [dbo].[tbsushe] ([id], [ssname], [remark], [pic]) VALUES (3, N'测试宿舍2', NULL, N'head.jpg')
INSERT [dbo].[tbsushe] ([id], [ssname], [remark], [pic]) VALUES (4, N'测试宿舍3', NULL, N'head.jpg')
INSERT [dbo].[tbsushe] ([id], [ssname], [remark], [pic]) VALUES (5, N'测试宿舍4', NULL, N'head.jpg')
INSERT [dbo].[tbsushe] ([id], [ssname], [remark], [pic]) VALUES (6, N'测试宿舍5', NULL, N'head.jpg')
INSERT [dbo].[tbsushe] ([id], [ssname], [remark], [pic]) VALUES (7, N'测试宿舍6', NULL, N'head.jpg')
INSERT [dbo].[tbsushe] ([id], [ssname], [remark], [pic]) VALUES (8, N'宿舍名称2', N'宿舍名称宿舍名称宿舍名称', N'23255037783.jpg')
SET IDENTITY_INSERT [dbo].[tbsushe] OFF
/****** Object:  Table [dbo].[tbruzhu]    Script Date: 06/19/2016 22:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbruzhu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[chuangid] [int] NULL,
	[userid] [int] NULL,
	[ruzhudate] [varchar](50) NULL,
	[tuchudate] [varchar](50) NULL,
	[state] [int] NULL,
 CONSTRAINT [PK_tbruzhu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbruzhu] ON
INSERT [dbo].[tbruzhu] ([id], [chuangid], [userid], [ruzhudate], [tuchudate], [state]) VALUES (3, 1, 1, N'2016-06-19', N'', 1)
SET IDENTITY_INSERT [dbo].[tbruzhu] OFF
/****** Object:  Table [dbo].[tbchuang]    Script Date: 06/19/2016 22:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbchuang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[chuangNum] [varchar](50) NULL,
	[susheid] [int] NULL,
	[remark] [varchar](200) NULL,
	[pic] [varchar](50) NULL,
 CONSTRAINT [PK_tbchuang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbchuang] ON
INSERT [dbo].[tbchuang] ([id], [chuangNum], [susheid], [remark], [pic]) VALUES (1, N'床位01', 2, N'床位01', N'')
INSERT [dbo].[tbchuang] ([id], [chuangNum], [susheid], [remark], [pic]) VALUES (2, N'测试06', 7, N'恩恩', N'')
SET IDENTITY_INSERT [dbo].[tbchuang] OFF
/****** Object:  Table [dbo].[Admin]    Script Date: 06/19/2016 22:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[pass] [varchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Admin] ON
INSERT [dbo].[Admin] ([ID], [Name], [pass]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Admin] OFF
