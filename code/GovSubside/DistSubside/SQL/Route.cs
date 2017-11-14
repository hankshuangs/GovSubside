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
    class Route
    {
        private String GovSubsidyConnString = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
        public DataTable All_Data_Table;
        public String[] TitleName;
        public Route()
        {
            TitleName = new string[] { "路線代碼", "票證資料對應用代碼", "路線的群組代碼", "路線名稱", "動態資料對應用的名稱",
                                        "路線起站","路線中間站","路線終點站","去程路線長度(Km)","回程路線長度(Km)",
                                        "每趟行駛時間(min)","平日班次","假日班次","是否為循環","公司代碼",
                                        "營運日期","停駛日期" };
            All_Data_Table = new DataTable();
            All_Data_Table.Columns.Add(TitleName[0], typeof(string));
            All_Data_Table.Columns.Add(TitleName[1], typeof(string));
            All_Data_Table.Columns.Add(TitleName[2], typeof(string));
            All_Data_Table.Columns.Add(TitleName[3], typeof(string));
            All_Data_Table.Columns.Add(TitleName[4], typeof(string));
            All_Data_Table.Columns.Add(TitleName[5], typeof(string));
            All_Data_Table.Columns.Add(TitleName[6], typeof(string));
            All_Data_Table.Columns.Add(TitleName[7], typeof(string));
            All_Data_Table.Columns.Add(TitleName[8], typeof(double));
            All_Data_Table.Columns.Add(TitleName[9], typeof(double));
            All_Data_Table.Columns.Add(TitleName[10], typeof(int));
            All_Data_Table.Columns.Add(TitleName[11], typeof(int));
            All_Data_Table.Columns.Add(TitleName[12], typeof(int));
            All_Data_Table.Columns.Add(TitleName[13], typeof(int));
            All_Data_Table.Columns.Add(TitleName[14], typeof(string));
            All_Data_Table.Columns.Add(TitleName[15], typeof(string));
            All_Data_Table.Columns.Add(TitleName[16], typeof(string));
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Route_Get";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DataRow dr = All_Data_Table.NewRow();
                                dr[TitleName[0]] = reader["RouteId"].ToString();
                                dr[TitleName[1]] = reader["RouteGPSCode"].ToString();
                                dr[TitleName[2]] = reader["RouteCode"].ToString();
                                dr[TitleName[3]] = reader["RouteName"].ToString();
                                dr[TitleName[4]] = reader["RouteExtName"].ToString();
                                dr[TitleName[5]] = reader["RouteDiscriptSt"].ToString();
                                dr[TitleName[6]] = reader["RouteDiscriptMd"].ToString();
                                dr[TitleName[7]] = reader["RouteDiscriptEd"].ToString();
                                dr[TitleName[8]] = Double.Parse(reader["MileageGo"].ToString());
                                dr[TitleName[9]] = Double.Parse(reader["MileageReturn"].ToString());
                                dr[TitleName[10]] = Int32.Parse(reader["RunningTime"].ToString());
                                dr[TitleName[11]] = Int32.Parse(reader["WeekdaysTimes"].ToString());
                                dr[TitleName[12]] = Int32.Parse(reader["HolidayTimes"].ToString());
                                dr[TitleName[13]] = (reader["isLoop"].ToString() == "True" || reader["isLoop"].ToString() == "true" ? 1 : 0);
                                dr[TitleName[14]] = reader["CoID"].ToString() ;
                                dr[TitleName[15]] = reader["StartDate"].ToString();
                                dr[TitleName[16]] = reader["StopDate"].ToString();
                                All_Data_Table.Rows.Add(dr);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
        public String[] GetRouteName()
        {
            String[] RouterName = new String[All_Data_Table.Rows.Count];
            for(int i =0;i< All_Data_Table.Rows.Count; i++)
            {
                DataRow dr = All_Data_Table.Rows[i];
                RouterName[i] = dr[TitleName[3]].ToString();
            }
            return RouterName;
        }
        public String GetRouteCodeByRouteName(String _RouteName)
        {
            for (int i = 0; i < All_Data_Table.Rows.Count; i++)
            {
                DataRow dr = All_Data_Table.Rows[i];
                if (dr[TitleName[3]].ToString() == _RouteName)
                {
                    return dr[0].ToString();
                }
            }
            return "Error";
        }
        public int Insert(String RouteId, String RouteGPSCode, String RouteCode, String RouteName, String RouteExtName, String RouteDiscriptSt, String RouteDiscriptMd, String RouteDiscriptEd
            , String MileageGo, String MileageReturn, String RunningTime, String WeekdaysTimes, String HolidayTimes, String isLoop, String CoID, String StartDate, String StopDate)
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Route_Insert";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@P_RouteId", SqlDbType.NChar).Value = RouteId;
                    comm.Parameters.Add("@P_RouteGPSCode", SqlDbType.Int).Value = RouteGPSCode;
                    comm.Parameters.Add("@P_RouteCode", SqlDbType.NChar).Value = RouteCode;
                    comm.Parameters.Add("@P_RouteName", SqlDbType.NVarChar).Value = RouteName;
                    comm.Parameters.Add("@P_RouteExtName", SqlDbType.NVarChar).Value = RouteExtName;
                    comm.Parameters.Add("@P_RouteDiscriptSt", SqlDbType.NVarChar).Value = RouteDiscriptSt;
                    comm.Parameters.Add("@P_RouteDiscriptMd", SqlDbType.NVarChar).Value = RouteDiscriptMd;
                    comm.Parameters.Add("@P_RouteDiscriptEd", SqlDbType.NVarChar).Value = RouteDiscriptEd;
                    comm.Parameters.Add("@P_MileageGo", SqlDbType.Decimal).Value = MileageGo;
                    comm.Parameters.Add("@P_MileageReturn", SqlDbType.Decimal).Value = MileageReturn;
                    comm.Parameters.Add("@P_RunningTime", SqlDbType.Int).Value = RunningTime;
                    comm.Parameters.Add("@P_WeekdaysTimes", SqlDbType.SmallInt).Value = WeekdaysTimes;
                    comm.Parameters.Add("@P_HolidayTimes", SqlDbType.SmallInt).Value = HolidayTimes;
                    if (isLoop == "1")
                    {
                        comm.Parameters.Add("@P_isLoop", SqlDbType.Bit).Value = true;
                    }
                    else
                    {
                        comm.Parameters.Add("@P_isLoop", SqlDbType.Bit).Value = false;
                    }
                    comm.Parameters.Add("@P_CoID", SqlDbType.NChar).Value = CoID;
                    comm.Parameters.Add("@P_StartDate", SqlDbType.NVarChar).Value = StartDate;
                    comm.Parameters.Add("@P_StopDate", SqlDbType.NVarChar).Value = StopDate;
                    SqlParameter p = comm.Parameters.Add("@ReturnValue", SqlDbType.Int);
                    p.Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        ReturnValue = Int32.Parse(p.Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        ReturnValue = -2;
                    }
                }
            }
            return ReturnValue;
        }
        public int Update(String RouteId, String RouteGPSCode, String RouteCode, String RouteName, String RouteExtName, String RouteDiscriptSt, String RouteDiscriptMd, String RouteDiscriptEd
            , String MileageGo, String MileageReturn, String RunningTime, String WeekdaysTimes, String HolidayTimes, String isLoop, String CoID, String StartDate, String StopDate)
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Route_Update";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@P_RouteId", SqlDbType.NChar).Value = RouteId;
                    comm.Parameters.Add("@P_RouteGPSCode", SqlDbType.Int).Value = RouteGPSCode;
                    comm.Parameters.Add("@P_RouteCode", SqlDbType.NChar).Value = RouteCode;
                    comm.Parameters.Add("@P_RouteName", SqlDbType.NVarChar).Value = RouteName;
                    comm.Parameters.Add("@P_RouteExtName", SqlDbType.NVarChar).Value = RouteExtName;
                    comm.Parameters.Add("@P_RouteDiscriptSt", SqlDbType.NVarChar).Value = RouteDiscriptSt;
                    comm.Parameters.Add("@P_RouteDiscriptMd", SqlDbType.NVarChar).Value = RouteDiscriptMd;
                    comm.Parameters.Add("@P_RouteDiscriptEd", SqlDbType.NVarChar).Value = RouteDiscriptEd;
                    comm.Parameters.Add("@P_MileageGo", SqlDbType.Decimal).Value = MileageGo;
                    comm.Parameters.Add("@P_MileageReturn", SqlDbType.Decimal).Value = MileageReturn;
                    comm.Parameters.Add("@P_RunningTime", SqlDbType.Int).Value = RunningTime;
                    comm.Parameters.Add("@P_WeekdaysTimes", SqlDbType.SmallInt).Value = WeekdaysTimes;
                    comm.Parameters.Add("@P_HolidayTimes", SqlDbType.SmallInt).Value = HolidayTimes;
                    if (isLoop == "1")
                    {
                        comm.Parameters.Add("@P_isLoop", SqlDbType.Bit).Value = true;
                    }
                    else
                    {
                        comm.Parameters.Add("@P_isLoop", SqlDbType.Bit).Value = false;
                    }
                    comm.Parameters.Add("@P_CoID", SqlDbType.NChar).Value = CoID;
                    comm.Parameters.Add("@P_StartDate", SqlDbType.NVarChar).Value = StartDate;
                    comm.Parameters.Add("@P_StopDate", SqlDbType.NVarChar).Value = StopDate;
                    SqlParameter p = comm.Parameters.Add("@ReturnValue", SqlDbType.Int);
                    p.Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        ReturnValue = Int32.Parse(p.Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        ReturnValue = -2;
                    }
                }
            }
            return ReturnValue;
        }
    }
}
