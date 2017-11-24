
DECLARE @TempStr nvarchar(Max) SET @TempStr  = '105'
DECLARE @strDate nvarchar(10) SET @strDate = '2017-10-06'
DECLARE @endDate nvarchar(10) SET @endDate = '2017-10-06'
DECLARE @tmpTable TABLE (
�Ǹ� nvarchar(10),
��� nvarchar(10),
�h�^ nvarchar(10),
�Z�� nvarchar(10), 
���P nvarchar(10),
�������O nvarchar(10),
RouteCode nvarchar(10))

;with
cte1 as
(
	--�����W��
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
	--���q�W��
	SELECT replace(B.BDate,'/','-') as SchdlDate
		   ,case when Direction = '1' then '0' when Direction = '2' then '1' end as DynamicStartStand
		   ,BTime+':00' as DynamicSchdlTime
		   ,BusNum as CarLic
		   ,B1.[CityLineId] as RouteCode
	FROM [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_BusSchedule] B
	left join [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_TrafficLine] B1 on B.[LineId] = B1.[LineId] and B1.City in('����','����')
	where CityLineId = @TempStr
	and B.BDate  between replace(@strDate,'-','/') and replace(@endDate,'-','/')
),
cte3 as
(
	--�����W��
	SELECT [SchdlDate]
		  ,[DynamicStartStand]
		  ,[DynamicSchdlTime]
		  ,[CarLic]	  		  
		  ,[RouteCode]
	FROM [GovSubsidy].[dbo].[DynamicQualified]
	where [RouteCode]= @TempStr
	and [SchdlDate]  between @strDate and @endDate and isMatchSchdl = '0' --���X��
)
--���octe1��cte2�S���涰���������
INSERT INTO @tmpTable (�Ǹ�,���,�h�^,�Z��,���P,�������O,RouteCode)
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


		select ROW_NUMBER() OVER(ORDER BY �h�^,�Z��) AS �Ǹ�,���,case when �h�^ = '0' then '�h�{' when �h�^ = '1' then '�^�{' end as '�h�^',�Z��,���P,�������O 
		from @tmpTable M
		left join [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_TrafficLine] B2 on B2.CityLineId = M.RouteCode and B2.City in('����','����')
		left join [DB.IBUS.LOCAL].[ZLdes].[dbo].[Loc_BusSchedule] B3 on B3.LineId = B2.LineId
		order by ���,�h�^,�Z��
		
