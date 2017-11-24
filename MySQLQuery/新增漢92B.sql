--新增漢92B
--1.
USE [ZLdes]
update [ZLdes].[dbo].[Des_Area] set [LineId_Str] =',漢33,漢72,漢35,漢92,漢92B,漢77,漢76,漢0南,漢0北,漢168東,漢168西,中南9117,中南9188,中南9127,中南9117A,中南9188A,中南9127A,漢72延,漢77區間,漢35(物產),漢紅35B,中南0918,中南0927,漢82A,漢82B,0南雙向,0北雙向,168東雙向,168西雙向,' 
where AreaNo = '02'
--2.

INSERT [dbo].[Loc_TrafficLine] ([LineId], [LineName], [Router], [RouterType], [Direction], [StartStation], [MidGroup], [EndStation], [BackLineId], [C_Count], [ControlStation], [ControlMm], [City], [CityLineId], [TravelTime], [RCount], [Type]) VALUES (N'R0132', N'漢92B-去程', N'漢92B', N'1', N'1', N'0N001', N',0N007,', N'0N006', N'', NULL, NULL, CAST(0 AS Decimal(3, 0)), N'漢程', N'92B自由幹線', CAST(75 AS Decimal(4, 0)), NULL, NULL)
INSERT [dbo].[Loc_TrafficLine] ([LineId], [LineName], [Router], [RouterType], [Direction], [StartStation], [MidGroup], [EndStation], [BackLineId], [C_Count], [ControlStation], [ControlMm], [City], [CityLineId], [TravelTime], [RCount], [Type]) VALUES (N'R0133', N'漢92B-回程', N'漢92B', N'1', N'2', N'0N006', N',0N007,', N'0N001', N'', NULL, NULL, CAST(0 AS Decimal(3, 0)), N'漢程', N'92B自由幹線', CAST(75 AS Decimal(4, 0)), NULL, NULL)

GO
/****** Object:  Table [dbo].[Router]    Script Date: 2017/11/20 16:13:31 ******/
INSERT [dbo].[Router] ([RouterID], [RouterName], [Company], [IsEnable]) VALUES (N'漢92B', N'92B', N'HanCheng', 1)

--3.增加去返站點資料
INSERT [dbo].[BusStation] ([StationID], [StationName], [Latitude], [Longitude], [IsEnable]) VALUES (N'4170', N'捷運凹子底站', 22.657317, 120.303138, 1)
INSERT [dbo].[BusStation] ([StationID], [StationName], [Latitude], [Longitude], [IsEnable]) VALUES (N'4171', N'捷運凹子底站', 22.656878, 120.303109, 1)

--4.INSERT [dbo].[RouterSeq]
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

