USE [GovSubsidy]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE usp_FailedTable_QueryByRow 
	--@routes nvarchar(Max) NULL,
	--@strDate nvarchar(10) NULL, --���
	--@endDate nvarchar(10) NULL --���
AS
BEGIN
		--DECLARE @routes nvarchar(Max) SET @routes  = '105,123,19'
		--DECLARE @strDate nvarchar(10) SET @strDate = '2017-10-01'
		--DECLARE @endDate nvarchar(10) SET @endDate = '2017-10-31'
		
		DECLARE @TempStr nvarchar(Max)
		WHILE (CHARINDEX(',',@routes)>0)/*@routes���]�t���Φr���N�@������j��*/
		BEGIN
			Set @TempStr= SUBSTRING(@routes,1,CHARINDEX(',',@routes)-1)/*���X�̫e����route*/
			Set @routes = REPLACE(@routes,@TempStr+',','')/*��̫e����route�[�W���Φr����A���N���Ŧr��A�����^��@@routes*/


		DECLARE @TempStr nvarchar(Max) SET @TempStr  = '105'
		DECLARE @strDate nvarchar(10) SET @strDate = '2017-10-01'
		DECLARE @endDate nvarchar(10) SET @endDate = '2017-10-01'

			SELECT [SchdlDate]
				  ,[RouteCode]
				  ,[CarLic]
				  ,[DynamicSchdlTime]
				  ,[DynamicStartStand]
			 FROM [dbo].[DynamicQualified]
			 where [RouteCode] COLLATE Chinese_Taiwan_Stroke_CI_AS = @TempStr COLLATE Chinese_Taiwan_Stroke_CI_AS
			 and [SchdlDate]  between @strDate COLLATE Chinese_Taiwan_Stroke_CI_AS and @endDate COLLATE Chinese_Taiwan_Stroke_CI_AS
EXCEPT

		SELECT replace(B.BDate,'/','-') as SchdlDate
		,B1.[CityLineId] as RouteCode
		,BusNum as CarLic
		,BTime+':00' as DynamicSchdlTime
		,case when Direction = '1' then '0' when Direction = '2' then '1' end as DynamicQualified
		
		FROM [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_BusSchedule] B
		
		left join [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_TrafficLine] B1 on B.[LineId] = B1.[LineId] and B1.City in('����','����')
		where CityLineId COLLATE Chinese_Taiwan_Stroke_CI_AS = @TempStr COLLATE Chinese_Taiwan_Stroke_CI_AS
		and B.BDate  between replace(@strDate,'-','/') COLLATE Chinese_Taiwan_Stroke_CI_AS and replace(@endDate,'-','/') COLLATE Chinese_Taiwan_Stroke_CI_AS


		COLLATE Chinese_Taiwan_Stroke_CI_AS


		END/*End While*/

		IF(LEN(RTRIM(LTRIM(@routes)))>0 And CHARINDEX(',',RTRIM(LTRIM(@routes)))=0) /*@routes���Ȧ��S�����Φr���A��ܦ����̫�@��route*/
		Begin
			Set @TempStr=@routes /*���Xword*/
	    
			SELECT [SchdlDate]
				  ,[RouteCode]
				  ,[RealTime]
				  ,[CarLic]
				  ,[isMatchSchdl]
				  ,[DynamicSchdlTime]
				  ,[DynamicStartStand]
				  ,[DynamicRouteName]
				  ,[DynamicStartStandNum]
				  ,[IsFind]
			 FROM [dbo].[DynamicQualified]
			 where [RouteCode] = @TempStr
			and [SchdlDate]  between @strDate and @endDate
		End /*End IF*/

END
