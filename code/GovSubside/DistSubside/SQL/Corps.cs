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
    class Corps
    {
        private String GovSubsidyConnString = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
        private DataTable All_Data;
        private String[] TitleName;
        public String[] TitleName_Chinese;
        public Corps()
        {
            All_Data = new DataTable();
            All_Data.Columns.Add("公司代號", typeof(String));
            All_Data.Columns.Add("公司全名", typeof(String));
            All_Data.Columns.Add("公司縮寫", typeof(String));
            All_Data.Columns.Add("公司統編", typeof(String));
            TitleName_Chinese = new String[4];
            TitleName_Chinese[0] = "公司代號";
            TitleName_Chinese[1] = "公司全名";
            TitleName_Chinese[2] = "公司縮寫";
            TitleName_Chinese[3] = "公司統編";
            TitleName = new String[4];
            TitleName[0] = "CoID";
            TitleName[1] = "CoFullName";
            TitleName[2] = "CoAbbrName";
            TitleName[3] = "CoEIN";
        }
        public DataTable GetAllCompany()
        {
            All_Data.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Corps_Get";
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
                                DataRow row = All_Data.NewRow();
                                row["公司代號"] = reader[TitleName[0]].ToString();
                                row["公司全名"] = reader[TitleName[1]].ToString();
                                row["公司縮寫"] = reader[TitleName[2]].ToString();
                                row["公司統編"] = reader[TitleName[3]].ToString();
                                All_Data.Rows.Add(row);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    return All_Data;
                }
            }
        }
        public int InsertNewData(String _CoID, String _CoFullName, String _CoAbbrName, String _CoEIN)
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Corps_Insert";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@CoID", SqlDbType.NChar).Value = _CoID;
                    comm.Parameters.Add("@CoFullName", SqlDbType.NVarChar).Value = _CoFullName;
                    comm.Parameters.Add("@CoAbbrName", SqlDbType.NVarChar).Value = _CoAbbrName;
                    comm.Parameters.Add("@CoEIN", SqlDbType.NChar).Value = _CoEIN;
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        ReturnValue = 1;
                    }
                    catch
                    {
                        ReturnValue = -1;
                    }
                }
            }
            return ReturnValue;
        }
        public int DeleteData(String _CoID)
        {
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Corps_Delete";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@CoID", SqlDbType.NChar).Value = _CoID;
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        return 1;
                    }
                    catch
                    {
                        return -1;
                    }
                }
            }
        }
        public int UpDateData(String _CoID, String _CoFullName, String _CoAbbrName, String _CoEIN)
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_Corps_UpDate";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@CoID", SqlDbType.NChar).Value = _CoID;
                    comm.Parameters.Add("@CoFullName", SqlDbType.NVarChar).Value = _CoFullName;
                    comm.Parameters.Add("@CoAbbrName", SqlDbType.NVarChar).Value = _CoAbbrName;
                    comm.Parameters.Add("@CoEIN", SqlDbType.NChar).Value = _CoEIN;
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        ReturnValue = 1;
                    }
                    catch
                    {
                        ReturnValue = -1;
                    }
                    return ReturnValue;
                }
            }
        }
        public String[] GetAllCompanyName()
        {
            String[] ReturnValue = new String[All_Data.Rows.Count];
            for (int i = 0; i < All_Data.Rows.Count; i++)
            {
                DataRow dr = All_Data.Rows[i];
                ReturnValue[i] = dr["公司全名"].ToString();
            }
            return ReturnValue;
        }
    }
}
