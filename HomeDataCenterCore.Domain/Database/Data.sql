USE [master]
GO
/****** Object:  Database [HomeData]    Script Date: 2019/11/11 0:27:17 ******/
CREATE DATABASE [HomeData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HomeData', FILENAME = N'/var/opt/mssql/data/HomeData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HomeData_log', FILENAME = N'/var/opt/mssql/data/HomeData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HomeData] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HomeData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HomeData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HomeData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HomeData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HomeData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HomeData] SET ARITHABORT OFF 
GO
ALTER DATABASE [HomeData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HomeData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HomeData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HomeData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HomeData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HomeData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HomeData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HomeData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HomeData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HomeData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HomeData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HomeData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HomeData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HomeData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HomeData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HomeData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HomeData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HomeData] SET RECOVERY FULL 
GO
ALTER DATABASE [HomeData] SET  MULTI_USER 
GO
ALTER DATABASE [HomeData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HomeData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HomeData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HomeData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HomeData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HomeData] SET QUERY_STORE = OFF
GO
USE [HomeData]
GO
/****** Object:  Table [dbo].[BodyData]    Script Date: 2019/11/11 0:27:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BodyData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RecordTime] [datetime] NULL,
	[Shape] [nvarchar](50) NULL,
	[Weight] [float] NULL,
	[BMI] [float] NULL,
	[BodyFatPercentage] [float] NULL,
	[BodyMoisture] [float] NULL,
	[SkeletalMuscleRate] [float] NULL,
	[MuscleMass] [float] NULL,
	[FatFreeBodyWeight] [float] NULL,
	[Protein] [float] NULL,
	[SubcutaneousFat] [float] NULL,
	[VisceralFatGrade] [int] NULL,
	[BodyAge] [float] NULL,
	[BasalMetabolism] [float] NULL,
	[BoneMass] [float] NULL,
 CONSTRAINT [PK_BodyData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BodyData] ON 

INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (1, CAST(N'2019-10-27T22:32:49.000' AS DateTime), N'肥胖型', 79.6500015258789, 26, 26.299999237060547, 53.200000762939453, 42, 55.770000457763672, 58.669998168945312, 16.799999237060547, 23.399999618530273, 9, 24, 1637, 2.9300000667572021)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (2, CAST(N'2019-10-27T12:15:24.000' AS DateTime), N'肥胖型', 80.800003051757812, 26.399999618530273, 27, 52.700000762939453, 41.599998474121094, 56.029998779296875, 59.020000457763672, 16.600000381469727, 24.100000381469727, 9, 24, 1644, 2.9500000476837158)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (3, CAST(N'2019-10-28T07:55:00.000' AS DateTime), N'肥胖型', 79.550003051757812, 26, 27.600000381469727, 52.299999237060547, 41.299999237060547, 54.709999084472656, 57.619998931884766, 16.5, 24.700000762939453, 9, 24, 1614, 2.880000114440918)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (4, CAST(N'2019-10-29T07:31:22.000' AS DateTime), N'肥胖型', 79.449996948242188, 25.899999618530273, 27, 52.700000762939453, 41.599998474121094, 55.099998474121094, 58, 16.600000381469727, 24.299999237060547, 8, 24, 1622, 2.9000000953674316)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (5, CAST(N'2019-10-30T09:06:46.000' AS DateTime), N'肥胖型', 79.300003051757812, 25.899999618530273, 25.5, 53.799999237060547, 42.5, 56.119998931884766, 59.119998931884766, 16.899999618530273, 22.799999237060547, 8, 24, 1646, 2.9600000381469727)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (7, CAST(N'2019-11-02T08:19:11.060' AS DateTime), N'肥胖型', 79.25, 25.899999618530273, 25.399999618530273, 53.900001525878906, 42.5, 56.169998168945312, 59.110000610351562, 17, 22.799999237060547, 8, 24, 1647, 2.9600000381469727)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (8, CAST(N'2019-11-01T07:23:37.767' AS DateTime), N'肥胖型', 79.800003051757812, 26.100000381469727, 26.399999618530273, 53.099998474121094, 41.900001525878906, 55.799999237060547, 58.700000762939453, 16.799999237060547, 23.5, 9, 24, 1638, 2.940000057220459)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (9, CAST(N'2019-10-31T09:58:13.237' AS DateTime), N'肥胖型', 80.949996948242188, 26.399999618530273, 23.899999618530273, 54.900001525878906, 43.400001525878906, 58.520000457763672, 61.599998474121094, 17.399999618530273, 21.100000381469727, 9, 24, 1700, 3.0799999237060547)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (11, CAST(N'2019-11-02T23:55:48.777' AS DateTime), N'肥胖型', 80.75, 26.399999618530273, 23.899999618530273, 55, 43.400001525878906, 58.380001068115234, 61.470001220703125, 17.299999237060547, 21.100000381469727, 9, 24, 1697, 3.0699999332427979)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (12, CAST(N'2019-11-03T10:53:56.877' AS DateTime), N'肥胖型', 79.800003051757812, 26.100000381469727, 25, 54.200000762939453, 42.799999237060547, 56.860000610351562, 59.860000610351562, 17.100000381469727, 22.100000381469727, 9, 24, 1662, 2.9900000095367432)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (13, CAST(N'2019-11-04T07:31:32.180' AS DateTime), N'肥胖型', 80.0999984741211, 26.200000762939453, 25.799999237060547, 53.599998474121094, 42.299999237060547, 56.459999084472656, 59.409999847412109, 16.899999618530273, 22.899999618530273, 9, 24, 1653, 2.9700000286102295)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (14, CAST(N'2019-11-05T00:08:42.367' AS DateTime), N'肥胖型', 79.699996948242188, 26, 25.600000381469727, 53.700000762939453, 42.400001525878906, 56.330001831054688, 59.319999694824219, 16.899999618530273, 22.700000762939453, 9, 24, 1650, 2.9700000286102295)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (1012, CAST(N'2019-11-05T19:55:40.483' AS DateTime), N'肥胖型', 79.0999984741211, 25.799999237060547, 26.899999618530273, 52.799999237060547, 41.700000762939453, 54.930000305175781, 57.849998474121094, 16.600000381469727, 24.200000762939453, 8, 24, 1618, 2.8900001049041748)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (1013, CAST(N'2019-11-05T20:56:02.297' AS DateTime), N'肥胖型', 80.9000015258789, 26.399999618530273, 25.399999618530273, 53.900001525878906, 42.5, 57.330001831054688, 60.340000152587891, 17, 22.5, 9, 24, 1673, 3.0199999809265137)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (1014, CAST(N'2019-11-05T21:54:32.887' AS DateTime), N'肥胖型', 80.050003051757812, 26.100000381469727, 24.799999237060547, 54.299999237060547, 42.900001525878906, 57.189998626708984, 60.200000762939453, 17.100000381469727, 22, 9, 24, 1670, 3.0099999904632568)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (1015, CAST(N'2019-11-06T07:24:51.657' AS DateTime), N'肥胖型', 79.0999984741211, 25.799999237060547, 26.399999618530273, 53.200000762939453, 42, 55.310001373291016, 58.2400016784668, 16.799999237060547, 23.700000762939453, 8, 24, 1627, 2.9100000858306885)
INSERT [dbo].[BodyData] ([Id], [RecordTime], [Shape], [Weight], [BMI], [BodyFatPercentage], [BodyMoisture], [SkeletalMuscleRate], [MuscleMass], [FatFreeBodyWeight], [Protein], [SubcutaneousFat], [VisceralFatGrade], [BodyAge], [BasalMetabolism], [BoneMass]) VALUES (1016, CAST(N'2019-11-06T20:35:11.857' AS DateTime), N'肥胖型', 80.550003051757812, 26.299999237060547, 23.200000762939453, 55.5, 43.799999237060547, 58.770000457763672, 61.869998931884766, 17.5, 20.399999618530273, 9, 24, 1706, 3.0899999141693115)
SET IDENTITY_INSERT [dbo].[BodyData] OFF
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'RecordTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'Shape'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体重，单位：kg' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'Weight'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'BMI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'BMI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体脂率，%' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'BodyFatPercentage'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体水分，%' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'BodyMoisture'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'骨骼肌率，%' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'SkeletalMuscleRate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'肌肉量，单位：kg' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'MuscleMass'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'去脂体重，单位：kg' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'FatFreeBodyWeight'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'蛋白质，%' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'Protein'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'皮下脂肪，%' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'SubcutaneousFat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内脏脂肪等级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'VisceralFatGrade'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'体年龄，单位：岁/year' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'BodyAge'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'基础代谢，单位：kcal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BodyData', @level2type=N'COLUMN',@level2name=N'BasalMetabolism'
GO
USE [master]
GO
ALTER DATABASE [HomeData] SET  READ_WRITE 
GO
