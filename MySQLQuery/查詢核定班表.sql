SELECT A.BusScheduleId,replace(A.BTime,':','') as BTime
,A.BusNum,A.EmployeeNo,B.employeename,B.Staff_MoveTel 
,C1.StationName AS SName ,C2.StationName AS EName 
,CASE WHEN A.Special='1' THEN '專車' WHEN A.Special='2' THEN '包車' WHEN A.Special='3' THEN '空駛' WHEN A.Special='4' THEN '未完整' ELSE '一般' END AS SpecialName 
,A.Memo ,0 as Status,A.Bus_M_Id ,A.MaxStatus 
FROM Loc_BusSchedule A 
LEFT OUTER JOIN zlhr.dbo.employee B ON A.EmployeeNo=B.employeeno 
LEFT OUTER JOIN Loc_Station C1 ON A.StartStation=C1.StationId 
LEFT OUTER JOIN Loc_Station C2 ON A.EndStation=C2.StationId 
WHERE A.Bdate='2017/10/01' AND A.LineId in('R0025','R0026') AND A.DelStatus='0' 
AND A.Special IN ('0','1','2','3','4','') ORDER BY A.BTime 

