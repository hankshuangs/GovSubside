USE [GovSubsidy]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE usp_FailedTable_QueryByRow 
	--@routes nvarchar(Max) NULL,
	--@strDate nvarchar(10) NULL, --月初
	--@endDate nvarchar(10) NULL --月尾
AS
BEGIN
		--DECLARE @routes nvarchar(Max) SET @routes  = '105,123,19'
		--DECLARE @strDate nvarchar(10) SET @strDate = '2017-10-01'
		--DECLARE @endDate nvarchar(10) SET @endDate = '2017-10-31'
		
		DECLARE @TempStr nvarchar(Max)
		WHILE (CHARINDEX(',',@routes)>0)/*@routes有包含分割字元就一直執行迴圈*/
		BEGIN
			Set @TempStr= SUBSTRING(@routes,1,CHARINDEX(',',@routes)-1)/*取出最前面的route*/
			Set @routes = REPLACE(@routes,@TempStr+',','')/*把最前面的route加上分割字元後，取代為空字串再指派回給@@routes*/


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
		
		left join [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_TrafficLine] B1 on B.[LineId] = B1.[LineId] and B1.City in('仁友','中鹿')
		where CityLineId COLLATE Chinese_Taiwan_Stroke_CI_AS = @TempStr COLLATE Chinese_Taiwan_Stroke_CI_AS
		and B.BDate  between replace(@strDate,'-','/') COLLATE Chinese_Taiwan_Stroke_CI_AS and replace(@endDate,'-','/') COLLATE Chinese_Taiwan_Stroke_CI_AS


		COLLATE Chinese_Taiwan_Stroke_CI_AS


		END/*End While*/

		IF(LEN(RTRIM(LTRIM(@routes)))>0 And CHARINDEX(',',RTRIM(LTRIM(@routes)))=0) /*@routes有值但沒有分割字元，表示此為最後一個route*/
		Begin
			Set @TempStr=@routes /*取出word*/
	    
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
