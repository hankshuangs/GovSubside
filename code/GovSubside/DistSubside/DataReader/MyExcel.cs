using System;
using System.Text;
using MyEXCEL = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Runtime.InteropServices;

namespace DistSubside.DataReader
{
    class MyExcel
    {
        private String Excel_Path = "";
        private MyEXCEL.Application App;
        private MyEXCEL.Workbook workbook;
        private MyEXCEL.Worksheet sheet;
        public int Col_Count = 0, Row_Count = 0;
        private DataTable dt;
        public string RouteID = "";
        private String Last_Date = "";
        public MyExcel(String _Path)
        {
            //DataTable初始化
            dt = new DataTable("Dynamic_Data");
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("DynamicSchdlTime", typeof(string));//趟次時間
            dt.Columns["DynamicSchdlTime"].MaxLength = 30;
            dt.Columns.Add("RealTime", typeof(string)); // typeof(string)); //班表時間
            dt.Columns["RealTime"].MaxLength = 30;
            dt.Columns.Add("CarLic", typeof(string));
            dt.Columns["CarLic"].MaxLength = 10;
            dt.Columns.Add("DynamicStartStand", typeof(string));
            dt.Columns["DynamicStartStand"].MaxLength = 4;
            dt.Columns.Add("isMatchSchdl", typeof(string));
            dt.Columns["isMatchSchdl"].MaxLength = 10;
            //未觸發站點因為用不到暫時不吃
            //dt.Columns.Add("unTrigerSt", typeof(string));
            ///dt.Columns["unTrigerSt"].MaxLength = int.MaxValue;
            dt.Columns.Add("SchdlDate", typeof(string)); // 不論是班表還是趟次都可以
            dt.Columns["SchdlDate"].MaxLength = 20;
            dt.Columns.Add("RouteCode", typeof(string));
            dt.Columns["RouteCode"].MaxLength = 3;
            dt.Columns.Add("IsFirst",typeof(int));
            //Excel初始化
            App = new MyEXCEL.Application();
            this.Excel_Path = _Path;
            workbook = App.Workbooks.Open(this.Excel_Path);
            sheet = (MyEXCEL.Worksheet)workbook.Sheets.get_Item(1);
            Col_Count = sheet.UsedRange.Columns.Count;
            Row_Count = sheet.UsedRange.Rows.Count;
            //把資料塞到DataTable
            int count = 0;
            String TitleString = sheet.Cells[1, 1].Text;
            int index = TitleString.IndexOf(']');
            RouteID = TitleString.Substring(1, index - 1); //從[的位子開始抓字到]的位子-1
            for (int i = 3; i <= Row_Count; i++)
            {
                int SN = Int32.Parse(sheet.Cells[i, 1].Text);
                String BT = sheet.Cells[i, 2].Text;
                String TT = sheet.Cells[i, 3].Text;
                String CarNum = sheet.Cells[i, 4].Text;
                String Go_Back_Code = sheet.Cells[i, 5].Text;
                String IsOK = sheet.Cells[i, 6].Text;
                DataRow dr = dt.NewRow();
                dr["ID"] = SN;
                dr["DynamicSchdlTime"] = BT;
                dr["RealTime"] = TT;
                dr["CarLic"] = CarNum.Trim();
                dr["DynamicStartStand"] = Go_Back_Code.Trim();
                dr["isMatchSchdl"] = IsOK.Trim();
                dr["SchdlDate"] = "";
                dr["RouteCode"] = RouteID ;
                if (    (SN == 1)  ||   (BT.Substring(8,2) != Last_Date.Substring(8,2)) )
                {
                    Last_Date = BT;
                    dr["IsFirst"] = 1;
                }
                else
                {
                    dr["IsFirst"] = 0;
                }
                dt.Rows.Add(dr);
                count++;
            }
            Console.WriteLine(count);
        }
        public DataTable getDT()
        {
            return this.dt;
        }
        public string print()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                sb.Append(row["ID"] + "\t" + row["SchdlDate"].ToString() + row["RealTime"].ToString() + "\t" + row["CarLic"].ToString() + "\t" + row["isMatchSchdl"].ToString() + "\t" + row["DynamicSchdlTime"].ToString() + "\t" + row["DynamicStartStand"].ToString() + Environment.NewLine);
            }
            return sb.ToString();
        }
        public void Depose()
        {
            workbook.Close();
            App.Quit();
            Marshal.ReleaseComObject(sheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(App);
        }
    }
}
