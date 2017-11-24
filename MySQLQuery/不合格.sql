
DECLARE @TempStr nvarchar(Max) SET @TempStr  = '105'
DECLARE @strDate nvarchar(10) SET @strDate = '2017-10-06'
DECLARE @endDate nvarchar(10) SET @endDate = '2017-10-06'
DECLARE @tmpTable TABLE (
�Ǹ� nvarchar(10),
��� nvarchar(10),
�h�^ nvarchar(10),
�Z�� nvarchar(10), 
���P nvarchar(10),
�������O nvarchar(10))

;with
cte1 as
(
	--�����W��
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
	--���q�W��
	SELECT replace(B.BDate,'/','-') as SchdlDate
	       ,B1.[CityLineId] as RouteCode
		   ,BusNum as CarLic
		   ,BTime+':00' as DynamicSchdlTime
		   ,case when Direction = '1' then '0' when Direction = '2' then '1' end as DynamicStartStand
	FROM [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_BusSchedule] B
	left join [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_TrafficLine] B1 on B.[LineId] = B1.[LineId] and B1.City in('����','����')
	where CityLineId = @TempStr
	and B.BDate  between replace(@strDate,'-','/') and replace(@endDate,'-','/')
),
cte3 as
(
	--�����W��
	SELECT [SchdlDate]
		  ,[RouteCode]
		  ,[CarLic]
		  ,[DynamicSchdlTime]
		  ,[DynamicStartStand]
	FROM [GovSubsidy].[dbo].[DynamicQualified]
	where [RouteCode]= @TempStr
	and [SchdlDate]  between @strDate and @endDate and isMatchSchdl = '0' --���X��
)
--���octe1��cte2�S���涰���������
INSERT INTO @tmpTable (�Ǹ�,���,�h�^,�Z��,���P,�������O)
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
		select * from @tmpTable order by �h�^
		
