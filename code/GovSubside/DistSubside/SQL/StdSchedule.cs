using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DistSubside.SQL
{
    class StdSchedule
    {
        private String GovSubsidyConnString = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
        public DataTable StdScheduleDataTable;
        public String[] TitleNameChinese = new string[] {"路線代碼","去回程","發車時間","平日發車","假日發車"
                                                        ,"星期五發車","暑假發車","暑假平日發車","暑假假日發車","寒假發車"
                                                        ,"寒假平日發車","寒假假日發車","營運日期","停駛日期"};
        public String[] TitleNameEnglish = new string[] {"RouteID","StartStand","SchdlTime","isWeekdaysSchdl","isHolidaySchdl"
                                                        ,"isExcFriSchdl","isSummerVac","isSummerWeekdays","isSummerHoliday","isWinterVac"
                                                        ,"isWinterWeekdays","isWinterHoliday","StartDate","StopDate"};
        public StdSchedule(String Routeid,String GoBack)
        {
            StdScheduleDataTable = new DataTable();
            foreach (String temp in TitleNameChinese)
            {
                StdScheduleDataTable.Columns.Add(temp, typeof(String));
            }
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_StdSchedule_Get";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@Routeid", SqlDbType.NVarChar).Value = Routeid;
                    char tempGB;
                    if (GoBack == "去程")
                    {
                        tempGB = '0';
                    }
                    else
                    {
                        tempGB = '1';
                    }
                    comm.Parameters.Add("@GoBack", SqlDbType.Char).Value = tempGB;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DataRow dr = StdScheduleDataTable.NewRow();
                                for (int i = 0; i < TitleNameEnglish.Length; i++)
                                {
                                    dr[TitleNameChinese[i]] = reader[TitleNameEnglish[i]].ToString();
                                }
                                StdScheduleDataTable.Rows.Add(dr);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
