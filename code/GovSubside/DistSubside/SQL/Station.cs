using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DistSubside.SQL
{
    class Station
    {
        private String GovSubsidyConnString = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
        private DataTable StationTable;
        public String[] TitleNameChinese;
        public String[] TitleNameEnglish;
        public Station()
        {
            TitleNameChinese = new String[8] { "路線ID", "站序", "站牌名稱", "去程時與上一站的距離", "回程時與上一站的距離", "開始時間", "結束時間", "唯一識別碼" };
            TitleNameEnglish = new String[8] { "RouteID", "StnOrdM", "StationID", "GoKm", "BkKm", "StartDate", "StopDate", "StOrdID" };
            StationTable = new DataTable();
            foreach (String each in TitleNameChinese)
            {
                StationTable.Columns.Add(each, typeof(String));
            }

        }
        public DataTable GetStationByRouteID(String RouteID)
        {
            StationTable.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Station_GetByRouteID";
                    comm.CommandType =CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@RouteID", SqlDbType.NVarChar).Value = RouteID;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DataRow dr = StationTable.NewRow();
                                for (int i = 0; i < TitleNameEnglish.Length; i++)
                                {
                                    dr[TitleNameChinese[i]] = reader[TitleNameEnglish[i]].ToString();
                                }
                                StationTable.Rows.Add(dr);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return StationTable;
        }
        public int Insert(String RouteID, String StnOrdM, String StationID, String GoKm, String BkKm, String StartDate,String StopDate)
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Station_Insert";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@RouteID", SqlDbType.NVarChar).Value = RouteID;
                    comm.Parameters.Add("@SEQ", SqlDbType.Int).Value = StnOrdM;
                    comm.Parameters.Add("@StationName", SqlDbType.NVarChar).Value = StationID;
                    comm.Parameters.Add("@GoKm", SqlDbType.Decimal).Value = GoKm;
                    comm.Parameters.Add("@BkKm", SqlDbType.Decimal).Value = BkKm;
                    comm.Parameters.Add("@startDate", SqlDbType.NVarChar).Value = StartDate;
                    comm.Parameters.Add("@endDate", SqlDbType.NVarChar).Value = StopDate;
                    SqlParameter p = comm.Parameters.Add("@MyReturnValue", SqlDbType.Int);
                    p.Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        ReturnValue = Int16.Parse(p.Value.ToString());
                    }
                    catch
                    {
                        ReturnValue = -2;
                    }
                }
            }
            return ReturnValue;
        }
        public int UpDate(String RouteID, String StnOrdM, String StationID, String GoKm, String BkKm, String StartDate, String StopDate, String StOrdID)
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Station_UpDateByUID";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@RouteID", SqlDbType.NVarChar).Value = RouteID;
                    comm.Parameters.Add("@SEQ", SqlDbType.Int).Value = StnOrdM;
                    comm.Parameters.Add("@StationName", SqlDbType.NVarChar).Value = StationID;
                    comm.Parameters.Add("@GoKm", SqlDbType.Decimal).Value = GoKm;
                    comm.Parameters.Add("@BkKm", SqlDbType.Decimal).Value = BkKm;
                    comm.Parameters.Add("@startDate", SqlDbType.NVarChar).Value = StartDate;
                    comm.Parameters.Add("@endDate", SqlDbType.NVarChar).Value = StopDate;
                    comm.Parameters.Add("@UID", SqlDbType.NVarChar).Value = StOrdID;
                    SqlParameter p = comm.Parameters.Add("@MyReturnValue", SqlDbType.Int);
                    p.Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        ReturnValue = Int16.Parse(p.Value.ToString());
                    }
                    catch
                    {
                        ReturnValue = -2;
                    }
                }
            }
            return ReturnValue;
        }
    }
}
