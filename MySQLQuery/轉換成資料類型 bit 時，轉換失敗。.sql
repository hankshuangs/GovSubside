
DECLARE @TempStr nvarchar(Max) SET @TempStr  = '105'
DECLARE @strDate nvarchar(10) SET @strDate = '2017-10-06'
DECLARE @endDate nvarchar(10) SET @endDate = '2017-10-06'
DECLARE @tmpTable TABLE (
序號 nvarchar(10),
日期 nvarchar(10),
去回 nvarchar(10),
班次 nvarchar(10), 
車牌 nvarchar(10),
佐證類別 nvarchar(10),
RouteCode nvarchar(10))

;with
cte1 as
(
	--本機上的
	SELECT [SchdlDate]
		  ,[CarLic]
		  ,[DynamicSchdlTime]
		  ,[DynamicStartStand]
		  ,[RouteCode]
	FROM [GovSubsidy].[dbo].[DynamicQualified]
	where [RouteCode]= @TempStr
	and [SchdlDate]  between @strDate and @endDate
),
cte2 as
(
	--公司上的
	SELECT replace(B.BDate,'/','-') as SchdlDate
		   ,case when Direction = '1' then '0' when Direction = '2' then '1' end as DynamicStartStand
		   ,BTime+':00' as DynamicSchdlTime
		   ,BusNum as CarLic
		   ,B1.[CityLineId] as RouteCode
	FROM [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_BusSchedule] B
	left join [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_TrafficLine] B1 on B.[LineId] = B1.[LineId] and B1.City in('仁友','中鹿')
	where CityLineId = @TempStr
	and B.BDate  between replace(@strDate,'-','/') and replace(@endDate,'-','/')
),
cte3 as
(
	--本機上的
	SELECT [SchdlDate]
		  ,[DynamicStartStand]
		  ,[DynamicSchdlTime]
		  ,[CarLic]	  		  
		  ,[RouteCode]
	FROM [GovSubsidy].[dbo].[DynamicQualified]
	where [RouteCode]= @TempStr
	and [SchdlDate]  between @strDate and @endDate and isMatchSchdl = '0' --不合格
)
--取得cte1跟cte2沒有交集的部分資料
INSERT INTO @tmpTable (序號,日期,去回,班次,車牌,佐證類別,RouteCode)
select '',T.SchdlDate,T.DynamicStartStand,T.DynamicSchdlTime, T.CarLic,'',RouteCode from
		(
		SELECT * FROM cte1
		EXCEPT
		(	SELECT * FROM cte1
			INTERSECT
			SELECT * FROM cte2
		)
		UNION 
		SELECT * FROM cte2
		EXCEPT
		(	SELECT * FROM cte1
			INTERSECT
			SELECT * FROM cte2
		)
		UNION
		SELECT * FROM cte3
		) as T


		select ROW_NUMBER() OVER(ORDER BY 去回,班次) AS 序號,日期,case when 去回 = '0' then '去程' when 去回 = '1' then '回程' end as '去回',班次,車牌,佐證類別 
		from @tmpTable M
		left join [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_TrafficLine] B2 on B2.CityLineId = M.RouteCode and B2.City in('仁友','中鹿')
		left join [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_BusSchedule] B3 on B3.LineId = B2.LineId
		order by 日期,去回,班次
		
