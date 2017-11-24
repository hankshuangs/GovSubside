
DECLARE @TempStr nvarchar(Max) SET @TempStr  = '105'
DECLARE @strDate nvarchar(10) SET @strDate = '2017-10-06'
DECLARE @endDate nvarchar(10) SET @endDate = '2017-10-06'
DECLARE @tmpTable TABLE (
序號 nvarchar(10),
日期 nvarchar(10),
去回 nvarchar(10),
班次 nvarchar(10), 
車牌 nvarchar(10),
佐證類別 nvarchar(10))

;with
cte1 as
(
	--本機上的
	SELECT [SchdlDate]
		  ,[RouteCode]
		  ,[CarLic]
		  ,[DynamicSchdlTime]
		  ,[DynamicStartStand]
	FROM [GovSubsidy].[dbo].[DynamicQualified]
	where [RouteCode]= @TempStr
	and [SchdlDate]  between @strDate and @endDate
),
cte2 as
(
	--公司上的
	SELECT replace(B.BDate,'/','-') as SchdlDate
	       ,B1.[CityLineId] as RouteCode
		   ,BusNum as CarLic
		   ,BTime+':00' as DynamicSchdlTime
		   ,case when Direction = '1' then '0' when Direction = '2' then '1' end as DynamicStartStand
	FROM [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_BusSchedule] B
	left join [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_TrafficLine] B1 on B.[LineId] = B1.[LineId] and B1.City in('仁友','中鹿')
	where CityLineId = @TempStr
	and B.BDate  between replace(@strDate,'-','/') and replace(@endDate,'-','/')
),
cte3 as
(
	--本機上的
	SELECT [SchdlDate]
		  ,[RouteCode]
		  ,[CarLic]
		  ,[DynamicSchdlTime]
		  ,[DynamicStartStand]
	FROM [GovSubsidy].[dbo].[DynamicQualified]
	where [RouteCode]= @TempStr
	and [SchdlDate]  between @strDate and @endDate and isMatchSchdl = '0' --不合格
)
--取得cte1跟cte2沒有交集的部分資料
INSERT INTO @tmpTable (序號,日期,去回,班次,車牌,佐證類別)
select '',T.SchdlDate,T.DynamicStartStand,T.DynamicSchdlTime, T.CarLic,'' from
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
		select * from @tmpTable order by 去回
		
