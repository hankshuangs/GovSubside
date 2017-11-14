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
    class Vacations
    {
        private String GovSubsidyConnString = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
        public DataTable dt;
        public String[] TitleNameChinese = new String[] {"年度"," 暑假開始日期","暑假結束日期","寒假開始日期","寒假結束日期"};
        public String[] TitleNameEnglish = new String[] { "VacAnnual", "SummerStart", "SummerEnd", "WinterStart", "WinterEnd" };
        public Vacations()
        {
            dt = new DataTable();
            foreach (String s in TitleNameChinese)
            {
                dt.Columns.Add(s, typeof(String));
            }
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Vacations_Get";
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
                                for (int i = 0; i < TitleNameEnglish.Length; i++)
                                {
                                    dr[TitleNameChinese[i]] = reader[TitleNameEnglish[i]].ToString();
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

        public int Insert(String _VacAnnual, String _SummerStart, String _SummerEnd, String _WinterStart, String _WinterEnd)
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Vacations_Insert";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@NewVacAnnual", SqlDbType.NVarChar).Value = _VacAnnual;
                    comm.Parameters.Add("@NewSummerStart", SqlDbType.NVarChar).Value = _SummerStart;
                    comm.Parameters.Add("@NewSummerEnd", SqlDbType.NVarChar).Value = _SummerEnd;
                    comm.Parameters.Add("@NewWinterStart", SqlDbType.NVarChar).Value = _WinterStart;
                    comm.Parameters.Add("@NewWinterEnd", SqlDbType.NVarChar).Value = _WinterEnd;
                    SqlParameter p = comm.Parameters.Add("@ResultValue", SqlDbType.Int);
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

        public int Update(String _VacAnnual, String _SummerStart, String _SummerEnd, String _WinterStart, String _WinterEnd)
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Vacations_Update";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@NewVacAnnual", SqlDbType.NVarChar).Value = _VacAnnual;
                    comm.Parameters.Add("@NewSummerStart", SqlDbType.NVarChar).Value = _SummerStart;
                    comm.Parameters.Add("@NewSummerEnd", SqlDbType.NVarChar).Value = _SummerEnd;
                    comm.Parameters.Add("@NewWinterStart", SqlDbType.NVarChar).Value = _WinterStart;
                    comm.Parameters.Add("@NewWinterEnd", SqlDbType.NVarChar).Value = _WinterEnd;
                    SqlParameter p = comm.Parameters.Add("@ResultValue", SqlDbType.Int);
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
