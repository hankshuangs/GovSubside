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
        public String[] TitleName;
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
                                string time_range = temp1[temp1.Length-1];
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
                                try
                                {
                                    if (i == 0 || i == 8 || i == 16 || i == 9 || i == 10 || i == 11|| i==12 || i==20 || i == 17 || i == 18 || i == 19)
                                    {
                                        switch (i)
                                        {
                                            //把日期從yyyy/MM/dd改成yyyy-MM-dd
                                            case 0:
                                            case 8:
                                            case 16:
                                                eachData[i] = eachData[i].ToString().Replace(@"/", "-");
                                                dr[TitleName[i]] = eachData[i].ToString();
                                                break;
                                            //轉換成金錢欄位
                                            case 9:
                                            case 10:
                                            case 11:
                                            case 17:
                                            case 18:
                                            case 19:
                                                if (eachData[i] == "")
                                                {
                                                    dr[TitleName[i]] = 0;
                                                }
                                                else
                                                {
                                                    dr[TitleName[i]] = Decimal.Parse(eachData[i].ToString());
                                                }
                                                break;
                                            case 12:
                                            case 20:
                                                if (eachData[i] == "" || eachData[i] == String.Empty)
                                                {
                                                    dr[TitleName[i]] = "-1";
                                                }
                                                else
                                                {
                                                    dr[TitleName[i]] = eachData[i].ToString();
                                                }
                                                break;
                                        }

                                    }
                                    else
                                    {
                                        dr[TitleName[i]] = eachData[i].ToString();
                                    }
                                }
                                catch (FormatException Fex)
                                {
                                    //dr[TitleName[i]] = eachData[i].ToString();
                                    dr[TitleName[i]] = Fex.ToString();
                                }
                            }
                            if (IsFirstData) //資料堆中的第一筆
                            {
                                Last_Date = eachData[0];
                                Last_Route = eachData[1];
                                dr["IsFirst"] = 1;
                                IsFirstData = false;
                            }
                            else // 不是第一筆就要開始判斷是否有跟上一筆的日期是相同
                            {
                                if (eachData[0] == Last_Date && eachData[1] == Last_Route) //判斷日期或路線有跟之前的第一筆是否相同
                                {
                                    dr["IsFirst"] = 0;
                                }
                                else
                                {
                                    dr["IsFirst"] = 1;
                                    Last_Date = eachData[0];
                                    Last_Route = eachData[1];
                                }
                            }
                            if (dr["IsFirst"].ToString() == "1")
                            {
                                //只要是第一筆，就要看看路線單裡面有沒有該路的資料，沒有就加，有的話就不用再增加
                                bool isAdd = true;
                                if (DataLengh != 0)
                                {
                                    for (int i = 0; i < RouteArray.Count; i++)
                                    {
                                        if (RouteArray[i].ToString() == dr["路線"].ToString())  //遍歷法，找到相等就把旗標改false
                                        {
                                            isAdd = false;
                                        }
                                    }
                                }
                                if (isAdd)
                                {
                                    RouteArray.Add(dr["路線"].ToString());
                                }
                            }
                            dt.Rows.Add(dr);
                            DataLengh++;

                        }
                        #endregion
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
            return dt;
        }

    }
}
