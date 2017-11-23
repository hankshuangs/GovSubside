using System;
using System.IO;
using System.Data;
using System.Text;
using System.Collections.Generic;
namespace DistSubside.DataReader
{
    class CSVReader
    {
        private DataTable dt;
		private DataTable Mydt = new DataTable();
		public String[] TitleName;
		public String[] MyTitleName;
		public int StartLineIndex = 4;
        private List<String> DataSet;
        private String Last_Date = "";
        private String Last_Route = "";
        public int DataLengh = 0;
        private bool IsFirstData = true;
        public String[] DateRange;
        public List<String> RouteArray;
        public CSVReader(String _Path)
        {
            RouteArray = new List<string>();
            try
            {
				using (FileStream st = new FileStream(_Path, FileMode.Open))
				{
					using (StreamReader reader = new StreamReader(st, System.Text.Encoding.Default))
					{
						#region 資料處理
						DataSet = new List<string>();
						dt = new DataTable();
						string TempStringLine;

						//前面跳過
						for (int i = 1; i < StartLineIndex; i++)
						{
							TempStringLine = reader.ReadLine();
							if (i == 2)
							{
								TempStringLine = TempStringLine.Replace(",", "");
								String[] temp1 = TempStringLine.Split(':');
								string time_range = temp1[temp1.Length - 1];
								time_range = time_range.Replace(" ", ""); //取代空白
								DateRange = time_range.Split('~');  //這樣就會傳出長度為2的時間陣列
							}
							Console.WriteLine(TempStringLine);
						}
						//讀TITLE
						TempStringLine = reader.ReadLine();
						TitleName = TempStringLine.Split(',');
						foreach (String eachTitle in TitleName)
						{
							dt.Columns.Add(eachTitle, typeof(string));
						}
						dt.Columns.Add("IsFirst", typeof(int));
						//讀Data
						while (!reader.EndOfStream)
						{
							TempStringLine = reader.ReadLine();
							TempStringLine = TempStringLine.Replace(@"=", "");
							TempStringLine = TempStringLine.Replace("\"", "");
							DataSet.Add(TempStringLine);
							String[] eachData = TempStringLine.Split(',');
							DataRow dr = dt.NewRow();
							for (int i = 0; i < TitleName.Length; i++)
							{
								dr[TitleName[i]] = eachData[i].ToString();
							}
								dt.Rows.Add(dr);
							DataLengh++;
						}
						#endregion

						//以上是把檔到讀到dt中,做些欄位的格式處理與增加欄位
						//1.接下來是把dt做排序dt.DefaultView.Sort = "營運日期,路線,上車時間";
						//2.另外煩惱每次場商檔案有可能新增欄位,想辦法只抓出程式需要的欄位資料
						//3.最後設定dr["IsFirst"] =1 or 0 ,然後加RouteArray.Add(dr["路線"].ToString());

						//1.排序
						dt.DefaultView.Sort = "營運日期,路線,上車時間";
						dt = dt.DefaultView.ToTable();
						int count = dt.Rows.Count;

						//2.建立必要的欄位
						MyTitleName = "營運日期,路線,路線起站,路線迄站,車牌號,票證公司,票種,卡號,上車時間,上車消費應扣,上車轉乘金額,上車票差金額,上車站站序,上車站,上車計費站,上車轉乘碼,下車時間,下車消費應扣,下車轉乘金額,下車票差金額,下車站站序,下車站,下車計費站,下車轉乘碼,方向,小計".Split(',');
						
						foreach (String eachTitle in MyTitleName)
						{
							Mydt.Columns.Add(eachTitle, typeof(string));
						}
						Mydt.Columns.Add("IsFirst", typeof(int));
						//MyTitleName2欄位名後面要加上IsFirst
						String[] MyTitleName2 = "營運日期,路線,路線起站,路線迄站,車牌號,票證公司,票種,卡號,上車時間,上車消費應扣,上車轉乘金額,上車票差金額,上車站站序,上車站,上車計費站,上車轉乘碼,下車時間,下車消費應扣,下車轉乘金額,下車票差金額,下車站站序,下車站,下車計費站,下車轉乘碼,方向,小計,IsFirst".Split(',');

						for (int i = 0; i < count; i++)
						{
							Mydt.Rows.Add(Mydt.NewRow());
						}

						//抓取必要的欄位
						foreach (string titlename in MyTitleName2)
						{
							//IsFirstData = true;
							for (int i = 0; i < count; i++)
							{						
								if (titlename.Equals("IsFirst"))
								{
									if (IsFirstData) //資料堆中的第一筆
									{
										Last_Date = Mydt.Rows[i]["營運日期"].ToString();
										Last_Route = Mydt.Rows[i]["路線"].ToString();
										Mydt.Rows[i]["IsFirst"] = 1;
										IsFirstData = false;
									}
									else // 不是第一筆就要開始判斷是否有跟上一筆的日期是相同
									{
										if (Mydt.Rows[i]["營運日期"].ToString() == Last_Date && Mydt.Rows[i]["路線"].ToString() == Last_Route) //判斷日期或路線有跟之前的第一筆是否相同
										{
											Mydt.Rows[i]["IsFirst"] = 0;
										}
										else
										{
											Mydt.Rows[i]["IsFirst"] = 1;
											Last_Date = Mydt.Rows[i]["營運日期"].ToString();
											Last_Route = Mydt.Rows[i]["路線"].ToString();
										}
									}
									if (Mydt.Rows[i]["IsFirst"].ToString() == "1")
									{
										//只要是第一筆，就要看看路線單裡面有沒有該路的資料，沒有就加，有的話就不用再增加
										bool isAdd = true;
										if (DataLengh != 0)
										{
											for (int j = 0; j < RouteArray.Count; j++)
											{
												if (RouteArray[j].ToString() == Mydt.Rows[i]["路線"].ToString())  //遍歷法，找到相等就把旗標改false
												{
													isAdd = false;
												}
											}
										}
										if (isAdd)
										{
											RouteArray.Add(Mydt.Rows[i]["路線"].ToString());
										}
									}
								}

								else if (titlename.Equals("上車站站序") || titlename.Equals("下車站站序"))
								{
									if (dt.Rows[i][titlename].ToString() == "" || dt.Rows[i][titlename].ToString() == String.Empty)
									{
										Mydt.Rows[i][titlename] = "-1";
									}
									else
									{
										Mydt.Rows[i][titlename] = dt.Rows[i][titlename];
									}							
								}
								else if (titlename.Equals("營運日期") || titlename.Equals("上車時間") || titlename.Equals("下車時間"))
								{
									Mydt.Rows[i][titlename] = dt.Rows[i][titlename].ToString().Replace(@"/", "-");
								}
								else if (titlename.Equals("上車消費應扣") || titlename.Equals("上車轉乘金額") || titlename.Equals("上車票差金額") || titlename.Equals("下車消費應扣") || titlename.Equals("下車轉乘金額") || titlename.Equals("下車票差金額"))
								{
									if (dt.Rows[i][titlename].ToString() == "")
									{
										Mydt.Rows[i][titlename] = 0;
									}
									else
									{
										Mydt.Rows[i][titlename] = Decimal.Parse(dt.Rows[i][titlename].ToString());
									}
								}
								else
								{
									Mydt.Rows[i][titlename] = dt.Rows[i][titlename];
								}
				
							}

						}
					}
				}
			}
			catch (IOException ioex)
            {
                throw ioex;
            }

		}
        public DataTable getDataTable()
        {
			return Mydt;
		}

	}
}
