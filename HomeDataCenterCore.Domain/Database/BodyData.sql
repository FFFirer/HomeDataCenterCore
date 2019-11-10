USE [HomeData]
GO

/****** Object:  Table [dbo].[BodyData]    Script Date: 2019/11/11 0:21:22 ******/
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


