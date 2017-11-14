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
    class Holidays
    {
        public DataTable dt;
        private String GovSubsidyConnString = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
        public String[] TitleName_Chinese = new String[] { "日期","是否是假日","描述"};
        public String[] TitleName_English = new String[] { "Holiday", "isHoliday", "Descript" };
        public Holidays()
        {
            dt = new DataTable();
            dt.Columns.Add(TitleName_Chinese[0], typeof(String));
            dt.Columns.Add(TitleName_Chinese[1], typeof(String));
            dt.Columns.Add(TitleName_Chinese[2], typeof(String));
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Holidays_Select";
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
                                DataRow dr = dt.NewRow();
                                for (int i = 0; i < 3; i++)
                                {
                                    dr[TitleName_Chinese[i]] = reader[TitleName_English[i]].ToString();
                                }
                                dt.Rows.Add(dr);
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

        public int Insert(String Holiday, String isHoliday, String Descript)
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Holidays_Insert";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@NewHoliday", SqlDbType.NVarChar).Value = Holiday;
                    comm.Parameters.Add("@NewisHoliday", SqlDbType.Int).Value = isHoliday;
                    comm.Parameters.Add("@NewDescript", SqlDbType.NVarChar).Value = Descript;
                    SqlParameter p = comm.Parameters.Add("@ReturnValue",SqlDbType.Int);
                    p.Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        ReturnValue = Int16.Parse(p.Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        ReturnValue = -2;
                    }
                }
            }
            return ReturnValue;
        }

        public int Update(String Holiday, String isHoliday, String Descript)
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Holidays_Update";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@NewHoliday", SqlDbType.NVarChar).Value = Holiday;
                    comm.Parameters.Add("@NewisHoliday", SqlDbType.Int).Value = isHoliday;
                    comm.Parameters.Add("@NewDescript", SqlDbType.NVarChar).Value = Descript;
                    SqlParameter p = comm.Parameters.Add("@ReturnValue", SqlDbType.Int);
                    p.Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        ReturnValue = Int16.Parse(p.Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        ReturnValue = -2;
                    }
                }
            }
            return ReturnValue;
        }

        public int Delete(String Holiday)
        {
            int ReturnValue = 0;
            using (SqlConnection  conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Holidays_Delete";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@NewHoliday", SqlDbType.NVarChar).Value = Holiday;
                    SqlParameter p = comm.Parameters.Add("@ReturnValue", SqlDbType.Int);
                    p.Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        ReturnValue = Int16.Parse(p.Value.ToString());
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
