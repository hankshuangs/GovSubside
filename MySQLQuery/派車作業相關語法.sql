--出車日期 仕業代碼
SELECT  A.Bus_M_Id,A.BDate,A.ShNo,A1.BusNUm,A1.EmployeeNo,C.EmployeeName 
FROM Des_Bus_M A 
LEFT OUTER JOIN Des_Bus_D A1 ON A.Bus_M_Id=A1.Bus_M_Id 
LEFT OUTER JOIN Des_Program B ON A.PrNo=B.PrNo 
LEFT OUTER JOIN ZLHR.dbo.Employee C ON A1.EmployeeNo=C.EmployeeNo WHERE A.BDate='2017/11/14' 
AND A.Router in ('','漢33','漢72','漢35','漢92','漢77','漢76','漢0南','漢0北','漢168東','漢168西','中南9117','中南9188','中南9127','中南9117A','中南9188A','中南9127A','漢72延','漢77區間','漢35(物產)','漢紅35B','中南0918','中南0927','漢82A','漢82B','0南雙向','0北雙向','168東雙向','168西雙向','','仁021路','仁030路','仁045路','仁105路','仁日月潭','仁283路','仁123路','仁405路','仁32路','仁52路','仁932路','仁933路','仁045繞','仁045延','仁045延2','仁045區1','仁045區2','仁358路','仁617路','仁21路延2','仁21路延1','仁45延1','中鹿617','仁045區(105.10.05)','仁045延1路(105.10.05)','仁045區(105.11.03)','仁045延1路(105.11.03)','仁19路','中鹿655路','中鹿74路','仁045延(106.08.23)','仁045延1路(106.08.23)','仁045延1路(106.08.23)','' ) 
AND A1.DelStatus='0' --AND A.ShNo LIKE '%01901%' AND A.Duty LIKE '%D%' AND B.PrName LIKE '%平日一%' 
ORDER BY A.ShNo,A.EmployeeNo,A.BusNum

SELECT  A.Bus_M_Id,A.BDate,A.ShNo,A1.BusNUm,A1.EmployeeNo,C.EmployeeName 
FROM Des_Bus_M A 
LEFT OUTER JOIN Des_Bus_D A1 ON A.Bus_M_Id=A1.Bus_M_Id 
LEFT OUTER JOIN Des_Program B ON A.PrNo=B.PrNo 
LEFT OUTER JOIN ZLHR.dbo.Employee C ON A1.EmployeeNo=C.EmployeeNo WHERE A.BDate='2017/11/14' 
AND A.Router in ('','仁021路','仁030路','仁045路','仁105路','仁日月潭','仁283路','仁123路','仁405路','仁32路','仁52路','仁932路','仁933路','仁045繞','仁045延','仁045延2','仁045區1','仁045區2','仁358路','仁617路','仁21路延2','仁21路延1','仁45延1','中鹿617','仁045區(105.10.05)','仁045延1路(105.10.05)','仁045區(105.11.03)','仁045延1路(105.11.03)','仁19路','中鹿655路','中鹿74路','仁045延(106.08.23)','仁045延1路(106.08.23)','仁045延1路(106.08.23)','' ) 
AND A1.DelStatus='0' ORDER BY A.ShNo,A.EmployeeNo,A.BusNum 
 

SELECT A.Bus_M_Id,A.BDate,A.ShNo,A.Duty,A.PrNo,A.Router,A.Hours,A.Memo,A.MoDt, A.MoEmp,B.PrName,A1.BusNum,A1.EmployeeNo,C.EmployeeName 
FROM Des_Bus_M A 
LEFT OUTER JOIN Des_Bus_D A1 ON A.Bus_M_Id=A1.Bus_M_Id 
LEFT OUTER JOIN Des_Program B ON A.PrNo=B.PrNo 
LEFT OUTER JOIN ZLHR.DBO.EMPLOYEE C ON A1.EmployeeNo=C.EmployeeNo 
WHERE  A.Bus_M_Id='20171114-0306' AND  A1.BusNum='KKA-6278' AND  A1.EmployeeNo='10605512' 

SELECT PrName FROM Des_Program ORDER BY PrNo 

SELECT Router 
FROM Loc_TrafficLine 
WHERE Direction='1' 
AND Router in ('','漢33','漢72','漢35','漢92','漢77','漢76','漢0南','漢0北','漢168東','漢168西','中南9117','中南9188','中南9127','中南9117A','中南9188A','中南9127A','漢72延','漢77區間','漢35(物產)','漢紅35B','中南0918','中南0927','漢82A','漢82B','0南雙向','0北雙向','168東雙向','168西雙向','','仁021路','仁030路','仁045路','仁105路','仁日月潭','仁283路','仁123路','仁405路','仁32路','仁52路','仁932路','仁933路','仁045繞','仁045延','仁045延2','仁045區1','仁045區2','仁358路','仁617路','仁21路延2','仁21路延1','仁45延1','中鹿617','仁045區(105.10.05)','仁045延1路(105.10.05)','仁045區(105.11.03)','仁045延1路(105.11.03)','仁19路','中鹿655路','中鹿74路','仁045延(106.08.23)','仁045延1路(106.08.23)','仁045延1路(106.08.23)','' ) 
ORDER BY LineId

SELECT '' AS LineName 
UNION 
SELECT LineName 
FROM Loc_TrafficLine  
WHERE Router in ('','漢33','漢72','漢35','漢92','漢77','漢76','漢0南','漢0北','漢168東','漢168西','中南9117','中南9188','中南9127','中南9117A','中南9188A','中南9127A','漢72延','漢77區間','漢35(物產)','漢紅35B','中南0918','中南0927','漢82A','漢82B','0南雙向','0北雙向','168東雙向','168西雙向','','仁021路','仁030路','仁045路','仁105路','仁日月潭','仁283路','仁123路','仁405路','仁32路','仁52路','仁932路','仁933路','仁045繞','仁045延','仁045延2','仁045區1','仁045區2','仁358路','仁617路','仁21路延2','仁21路延1','仁45延1','中鹿617','仁045區(105.10.05)','仁045延1路(105.10.05)','仁045區(105.11.03)','仁045延1路(105.11.03)','仁19路','中鹿655路','中鹿74路','仁045延(106.08.23)','仁045延1路(106.08.23)','仁045延1路(106.08.23)','' ) 
ORDER BY LineName

--派車時間,班表 --駕駛憑單
SELECT A.BusScheduleId
,CASE WHEN A.BDate<>'2017/11/14' THEN 1 ELSE 0 END AS NextDay 
,replace(A.BTime,':','') as BTime,B.LineName,C1.StationName AS SName 
,C2.StationName AS EName 
,CASE WHEN A.Special='1' THEN '專車' WHEN A.Special='2' THEN '包車' WHEN A.Special='3' THEN '空駛' WHEN A.Special='4' THEN '未完整' ELSE '一般' END AS SpecialName 
,D.PNum 
,A.Memo FROM Loc_BusSchedule A LEFT OUTER JOIN Loc_TrafficLine B ON A.LineId=B.LineId 
LEFT OUTER JOIN Loc_Station C1 ON A.StartStation=C1.StationId 
LEFT OUTER JOIN Loc_Station C2 ON A.EndStation=C2.StationId 
LEFT OUTER JOIN Des_Bus_M_2 D ON A.BusScheduleId=D.BusScheduleId 
WHERE  A.Bus_M_Id='20171114-0306' 
AND  A.BusNum='KKA-6278' AND  A.EmployeeNo='10605512' AND A.DelStatus='0' 
ORDER BY A.BDate,A.BTime


SELECT  A.Bus_M_Id,A.BDate,A.ShNo,A1.BusNUm,A1.EmployeeNo,C.EmployeeName 
FROM Des_Bus_M A 
LEFT OUTER JOIN Des_Bus_D A1 ON A.Bus_M_Id=A1.Bus_M_Id 
LEFT OUTER JOIN Des_Program B ON A.PrNo=B.PrNo 
LEFT OUTER JOIN ZLHR.dbo.Employee C ON A1.EmployeeNo=C.EmployeeNo WHERE A.BDate='2017/11/14' 
AND A.Router in ('','漢33','漢72','漢35','漢92','漢77','漢76','漢0南','漢0北','漢168東','漢168西','中南9117','中南9188','中南9127','中南9117A','中南9188A','中南9127A','漢72延','漢77區間','漢35(物產)','漢紅35B','中南0918','中南0927','漢82A','漢82B','0南雙向','0北雙向','168東雙向','168西雙向','','仁021路','仁030路','仁045路','仁105路','仁日月潭','仁283路','仁123路','仁405路','仁32路','仁52路','仁932路','仁933路','仁045繞','仁045延','仁045延2','仁045區1','仁045區2','仁358路','仁617路','仁21路延2','仁21路延1','仁45延1','中鹿617','仁045區(105.10.05)','仁045延1路(105.10.05)','仁045區(105.11.03)','仁045延1路(105.11.03)','仁19路','中鹿655路','中鹿74路','仁045延(106.08.23)','仁045延1路(106.08.23)','仁045延1路(106.08.23)','' ) 
AND A1.DelStatus='0' 
ORDER BY A.ShNo,A.EmployeeNo,A.BusNum

SELECT '' AS LineName 
UNION SELECT LineName 
FROM Loc_TrafficLine  WHERE Router in ('','仁021路','仁030路','仁045路','仁105路','仁日月潭','仁283路','仁123路','仁405路','仁32路','仁52路','仁932路','仁933路','仁045繞','仁045延','仁045延2','仁045區1','仁045區2','仁358路','仁617路','仁21路延2','仁21路延1','仁45延1','中鹿617','仁045區(105.10.05)','仁045延1路(105.10.05)','仁045區(105.11.03)','仁045延1路(105.11.03)','仁19路','中鹿655路','中鹿74路','仁045延(106.08.23)','仁045延1路(106.08.23)','仁045延1路(106.08.23)','' ) 
ORDER BY LineName 

SELECT A.Bus_M_Id,A.BDate,A.ShNo,A.Duty,A.PrNo,A.Router,A.Hours,A.Memo,A.MoDt, A.MoEmp,B.PrName,A1.BusNum,A1.EmployeeNo,C.EmployeeName FROM Des_Bus_M A LEFT OUTER JOIN Des_Bus_D A1 ON A.Bus_M_Id=A1.Bus_M_Id LEFT OUTER JOIN Des_Program B ON A.PrNo=B.PrNo LEFT OUTER JOIN ZLHR.DBO.EMPLOYEE C ON A1.EmployeeNo=C.EmployeeNo WHERE  A.Bus_M_Id='20171114-0306' AND  A1.BusNum='KKA-6278' AND  A1.EmployeeNo='10605512'

--地區線路
SELECT LineId_Str FROM  Des_Area WHERE DeptNo_Str LIKE '%,Z06000,%' AND AreaNo <>'04'


--新增漢92B
--1.
USE [ZLdes]
update [ZLdes].[dbo].[Des_Area] set [LineId_Str] =',漢33,漢72,漢35,漢92,漢92B,漢77,漢76,漢0南,漢0北,漢168東,漢168西,中南9117,中南9188,中南9127,中南9117A,中南9188A,中南9127A,漢72延,漢77區間,漢35(物產),漢紅35B,中南0918,中南0927,漢82A,漢82B,0南雙向,0北雙向,168東雙向,168西雙向,' 
where AreaNo = '02'
--2.

GO
/****** Object:  Table [dbo].[Router]    Script Date: 2017/11/20 16:13:31 ******/
INSERT [dbo].[Router] ([RouterID], [RouterName], [Company], [IsEnable]) VALUES (N'漢92B', N'92B', N'HanCheng', 1)

--3.INSERT [dbo].[RouterSeq]
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'3633', 0, 1, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4442', 0, 2, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4145', 0, 3, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'5303', 0, 4, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'19188', 0, 5, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4294', 0, 6, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4295', 0, 7, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4300', 0, 8, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4301', 0, 9, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4302', 0, 10, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'13579', 0, 11, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4304', 0, 12, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4175', 0, 13, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4177', 0, 14, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4170', 0, 15, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'17872', 0, 16, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4268', 0, 17, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4180', 0, 18, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4181', 0, 19, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'2059', 0, 20, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'1556', 0, 21, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'1563', 0, 22, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'1575', 0, 23, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'1637', 0, 24, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'19194', 0, 25, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'1594', 0, 26, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'1607', 0, 27, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'15770', 1, 28, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'2904', 1, 29, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'1669', 1, 30, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'19195', 1, 31, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'2065', 1, 32, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'1705', 1, 33, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'2776', 1, 34, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'1729', 1, 35, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4316', 1, 36, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4200', 1, 37, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4201', 1, 38, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4271', 1, 39, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'17873', 1, 40, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4171', 1, 41, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'6233', 1, 42, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4205', 1, 43, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4313', 1, 44, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'13578', 1, 45, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4321', 1, 46, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4322', 1, 47, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'5517', 1, 48, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4323', 1, 49, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4328', 1, 50, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'19187', 1, 51, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'5264', 1, 52, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'5263', 1, 53, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'3734', 1, 54, 1)
INSERT [dbo].[RouterSeq] ([RouterID], [StationID], [Direction], [Seq], [IsEnable]) VALUES (N'漢92B', N'4446', 1, 55, 1)

--4.增加去返站點資料
INSERT [dbo].[BusStation] ([StationID], [StationName], [Latitude], [Longitude], [IsEnable]) VALUES (N'4170', N'捷運凹子底站', 22.657317, 120.303138, 1)
INSERT [dbo].[BusStation] ([StationID], [StationName], [Latitude], [Longitude], [IsEnable]) VALUES (N'4171', N'捷運凹子底站', 22.656878, 120.303109, 1)