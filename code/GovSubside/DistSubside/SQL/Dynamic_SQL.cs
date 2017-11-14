using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DistSubside.SQL
{
    class Dynamic_SQL
    {
        private String GovSubsidyConnString = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
        private int IsProcess; //放是否已產生報表
        private int alreadyhasData; //放是否已有資料在資料庫裡
        public int Insert(DataTable DT) //這邊的DT一定是動態SQL讀檔器出來的DT
        {
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                DataRow dr = DT.Rows[i];
                if (Int32.Parse(dr["IsFirst"].ToString()) == 1)  //判斷是否是第一筆
                {
                    #region 如果是第一筆資料
                    #region 判斷有沒有資料在資料庫裡
                    using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
                    {
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = "usp_DynamicQualified_HasData";
                            comm.CommandType = CommandType.StoredProcedure;
                            comm.Connection = conn;
                            comm.Parameters.Add("@InputDateTime", SqlDbType.DateTime).Value = dr["DynamicSchdlTime"].ToString();
                            comm.Parameters.Add("@InputRoute", SqlDbType.NVarChar).Value = dr["RouteCode"].ToString();
                            SqlParameter p = comm.Parameters.Add("@ReturnValue", SqlDbType.Int);
                            p.Direction = ParameterDirection.ReturnValue;
                            try
                            {
                                conn.Open();
                                SqlDataReader reader = comm.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        //資料庫裡的bit型態傳出來會變成boolean
                                        alreadyhasData = 1;
                                        String temp = reader["isProcessed"].ToString();
                                        //C# 語法 (Bool ? if(True) :if(False) )
                                        IsProcess = (temp.ToLower() == "true" ? 1 : 0);
                                    }
                                }
                                else
                                {
                                    alreadyhasData = 0;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Dynamic_SQL_Insert_usp_DynamicQualified_HasData::" + ex.ToString());
                            }
                        }
                    }
                    #endregion
                    if (alreadyhasData == 1) //是第一筆，但有資料
                    {
                        if (IsProcess != 1)  //產生過報表就不讓新增資料
                        {
                            #region 更新資料庫裡的資料
                            #region 刪除
                            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString)) //先刪除
                            {
                                using (SqlCommand comm = new SqlCommand())
                                {
                                    comm.CommandText = "usp_DynamicQualified_DeleteData";
                                    comm.CommandType = CommandType.StoredProcedure;
                                    comm.Connection = conn;
                                    comm.Parameters.Add("@InputDateTime", SqlDbType.DateTime).Value = dr["DynamicSchdlTime"].ToString();
                                    comm.Parameters.Add("@RouteID", SqlDbType.NVarChar).Value = dr["RouteCode"].ToString();
                                    try
                                    {
                                        conn.Open();
                                        comm.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Dynamic_SQL_Insert_usp_DynamicQualified_DeleteData::" + ex.ToString());
                                    }
                                }
                                conn.Close();
                            }
                            #endregion
                            #region 新增
                            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString)) //再新增
                            {
                                conn.Open();
                                using (SqlCommand comm = new SqlCommand())
                                {
                                    comm.CommandText = "usp_DynamicQualified_InsertByRow";
                                    comm.CommandType = CommandType.StoredProcedure;
                                    comm.Connection = conn;
                                    comm.Parameters.Add("@ST", SqlDbType.DateTime).Value = dr["DynamicSchdlTime"].ToString();
                                    comm.Parameters.Add("@TT", SqlDbType.DateTime).Value = dr["RealTime"].ToString();
                                    comm.Parameters.Add("@CarNum", SqlDbType.NVarChar).Value = dr["CarLic"].ToString();
                                    comm.Parameters.Add("@Go_Back", SqlDbType.NVarChar).Value = dr["DynamicStartStand"].ToString();
                                    comm.Parameters.Add("@Is_Good", SqlDbType.NVarChar).Value = dr["isMatchSchdl"].ToString();
                                    comm.Parameters.Add("@RouteID", SqlDbType.NVarChar).Value = dr["RouteCode"].ToString();
                                    comm.Parameters.Add("@Is_First", SqlDbType.Int).Value = Int32.Parse(dr["IsFirst"].ToString());
                                    try
                                    {
                                        comm.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.Write("Dynamic_SQL_Insert_usp_DynamicQualified_InsertByRow::" + ex.ToString());
                                    }
                                }
                                conn.Close();
                            }
                            #endregion
                            #endregion
                        }
                        else
                        {
                            return -1;  //若資料表顯示已產生報表，則迴圈也不用處理
                        }
                    }
                    else //是第一筆，但沒資料
                    {
                        #region 新增
                        using (SqlConnection conn = new SqlConnection(GovSubsidyConnString)) //再新增
                        {
                            conn.Open();
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = "usp_DynamicQualified_InsertByRow";
                                comm.CommandType = CommandType.StoredProcedure;
                                comm.Connection = conn;
                                comm.Parameters.Add("@ST", SqlDbType.DateTime).Value = dr["DynamicSchdlTime"].ToString();
                                comm.Parameters.Add("@TT", SqlDbType.DateTime).Value = dr["RealTime"].ToString();
                                comm.Parameters.Add("@CarNum", SqlDbType.NVarChar).Value = dr["CarLic"].ToString();
                                comm.Parameters.Add("@Go_Back", SqlDbType.NVarChar).Value = dr["DynamicStartStand"].ToString();
                                comm.Parameters.Add("@Is_Good", SqlDbType.NVarChar).Value = dr["isMatchSchdl"].ToString();
                                comm.Parameters.Add("@RouteID", SqlDbType.NVarChar).Value = dr["RouteCode"].ToString();
                                comm.Parameters.Add("@Is_First", SqlDbType.Int).Value = Int32.Parse(dr["IsFirst"].ToString());
                                try
                                {
                                    comm.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    Console.Write("Dynamic_SQL_Insert_usp_DynamicQualified_InsertByRow::" + ex.ToString());
                                }
                            }
                            conn.Close();
                        }
                        #endregion
                    }
                    #endregion
                }
                else //不是第一筆就仿照第一筆的資料的處理模式
                {
                    if (IsProcess != 1)
                    {
                        #region 新增
                        using (SqlConnection conn = new SqlConnection(GovSubsidyConnString)) //再新增
                        {
                            conn.Open();
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = "usp_DynamicQualified_InsertByRow";
                                comm.CommandType = CommandType.StoredProcedure;
                                comm.Connection = conn;
                                comm.Parameters.Add("@ST", SqlDbType.DateTime).Value = dr["DynamicSchdlTime"].ToString();
                                comm.Parameters.Add("@TT", SqlDbType.DateTime).Value = dr["RealTime"].ToString();
                                comm.Parameters.Add("@CarNum", SqlDbType.NVarChar).Value = dr["CarLic"].ToString();
                                comm.Parameters.Add("@Go_Back", SqlDbType.NVarChar).Value = dr["DynamicStartStand"].ToString();
                                comm.Parameters.Add("@Is_Good", SqlDbType.NVarChar).Value = dr["isMatchSchdl"].ToString();
                                comm.Parameters.Add("@RouteID", SqlDbType.NVarChar).Value = dr["RouteCode"].ToString();
                                comm.Parameters.Add("@Is_First", SqlDbType.Int).Value = Int32.Parse(dr["IsFirst"].ToString());
                                try
                                {
                                    comm.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    Console.Write("Dynamic_SQL_Insert_usp_DynamicQualified_InsertByRow::" + ex.ToString());
                                }
                            }
                            conn.Close();
                        }
                        #endregion
                    }
                }
            }
            return 1; //資料都已經正常處理
        }
    }
}
