using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DistSubside.SQL
{
    class Ticket_SQL
    {
        private String GovSubsidyConnString = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
        private int IsProcess; //放是否已產生報表
        private int alreadyhasData; //放是否已有資料在資料庫裡
        public int Insert(DataTable DT)
        {
            int Count = 0;
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                DataRow dr = DT.Rows[i];
				if (Int32.Parse(dr["IsFirst"].ToString()) == 1) //判斷是否是第一筆
                {
                    #region 如果是第一筆資料
                    #region 是否有資料在資料庫裡
                    using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
                    {
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = "usp_TicketQualified_HasData";
                            comm.CommandType = CommandType.StoredProcedure;
                            comm.Connection = conn;
                            comm.Parameters.Add("@InputDate", SqlDbType.Date).Value = dr[0].ToString();
                            comm.Parameters.Add("@RouteID", SqlDbType.NVarChar).Value = dr[1].ToString();
                            try
                            {
                                conn.Open();
                                SqlDataReader reader = comm.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        alreadyhasData = 1;
                                        String temp = reader["isProcessed"].ToString();
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
                                Console.WriteLine("Ticket_SQL_usp_TicketQualified_HasData::" + ex.ToString());
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
                            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
                            {
                                using (SqlCommand comm = new SqlCommand())
                                {
                                    comm.CommandText = "usp_TicketQualified_DeleteData";
                                    comm.CommandType = CommandType.StoredProcedure;
                                    comm.Connection = conn;
                                    comm.Parameters.Add("@InputDate", SqlDbType.Date).Value = dr[0];
                                    comm.Parameters.Add("@InputRoute", SqlDbType.NVarChar).Value = dr[1];
                                    try
                                    {
                                        conn.Open();
                                        comm.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Ticket_SQL_usp_TicketQualified_DeleteData::" + ex.ToString());
                                    }
                                }
                            }
                            #endregion
                            #region 新增
                            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
                            {
                                using (SqlCommand comm = new SqlCommand())
                                {
                                    comm.CommandText = "usp_TicketQualified_InsertByRow";
                                    comm.CommandType = CommandType.StoredProcedure;
                                    comm.Connection = conn;
                                    comm.Parameters.Add("@Col1", SqlDbType.NVarChar).Value = dr[0].ToString();
                                    comm.Parameters.Add("@Col2", SqlDbType.NVarChar).Value = dr[1].ToString();
                                    comm.Parameters.Add("@Col3", SqlDbType.NVarChar).Value = dr[2].ToString();
                                    comm.Parameters.Add("@Col4", SqlDbType.NVarChar).Value = dr[3].ToString();
                                    comm.Parameters.Add("@Col5", SqlDbType.NVarChar).Value = dr[4].ToString();
                                    comm.Parameters.Add("@Col6", SqlDbType.NVarChar).Value = dr[5].ToString();
                                    comm.Parameters.Add("@Col7", SqlDbType.NVarChar).Value = dr[6].ToString();
                                    comm.Parameters.Add("@Col8", SqlDbType.NVarChar).Value = dr[7].ToString();
                                    comm.Parameters.Add("@Col9", SqlDbType.NVarChar).Value = dr[8].ToString();
                                    comm.Parameters.Add("@Col10", SqlDbType.Money).Value = float.Parse(dr[9].ToString());
                                    comm.Parameters.Add("@Col11", SqlDbType.Money).Value = float.Parse(dr[10].ToString());
                                    comm.Parameters.Add("@Col12", SqlDbType.Money).Value = float.Parse(dr[11].ToString());
                                    comm.Parameters.Add("@Col13", SqlDbType.Int).Value = Int32.Parse(dr[12].ToString());
                                    comm.Parameters.Add("@Col14", SqlDbType.NVarChar).Value = dr[13].ToString();
                                    comm.Parameters.Add("@Col15", SqlDbType.NVarChar).Value = dr[14].ToString();
                                    comm.Parameters.Add("@Col16", SqlDbType.NVarChar).Value = dr[15].ToString();
                                    comm.Parameters.Add("@Col17", SqlDbType.NVarChar).Value = dr[16].ToString();
                                    comm.Parameters.Add("@Col18", SqlDbType.Money).Value = float.Parse(dr[17].ToString());
                                    comm.Parameters.Add("@Col19", SqlDbType.Money).Value = float.Parse(dr[18].ToString());
                                    comm.Parameters.Add("@Col20", SqlDbType.Money).Value = float.Parse(dr[19].ToString());
                                    comm.Parameters.Add("@Col21", SqlDbType.Int).Value = Int32.Parse(dr[20].ToString());
                                    comm.Parameters.Add("@Col22", SqlDbType.NVarChar).Value = dr[21].ToString();
                                    comm.Parameters.Add("@Col23", SqlDbType.NVarChar).Value = dr[22].ToString();
                                    comm.Parameters.Add("@Col24", SqlDbType.NVarChar).Value = dr[23].ToString();
                                    comm.Parameters.Add("@Col25", SqlDbType.Int).Value = Int32.Parse(dr[24].ToString());
                                    comm.Parameters.Add("@Col26", SqlDbType.Money).Value = float.Parse(dr[25].ToString());
                                    comm.Parameters.Add("@Col27", SqlDbType.Int).Value = Int32.Parse(dr[26].ToString());
                                    try
                                    {
                                        conn.Open();
                                        comm.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Ticket_SQL_usp_TicketQualified_InsertByRow::" + ex.ToString());
                                    }
                                }
                            }
                            #endregion
                            Count += 1;
                            #endregion
                        }
                        else
                        {
                            return -1; //若資料表顯示已產生報表，則迴圈也不用處理
                        }
                    }
                    else //是第一筆，但沒資料
                    {
                        #region 新增
                        using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
                        {
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = "usp_TicketQualified_InsertByRow";
                                comm.CommandType = CommandType.StoredProcedure;
                                comm.Connection = conn;
                                comm.Parameters.Add("@Col1", SqlDbType.Date).Value = dr[0].ToString();
                                comm.Parameters.Add("@Col2", SqlDbType.NVarChar).Value = dr[1].ToString();
                                comm.Parameters.Add("@Col3", SqlDbType.NVarChar).Value = dr[2].ToString();
                                comm.Parameters.Add("@Col4", SqlDbType.NVarChar).Value = dr[3].ToString();
                                comm.Parameters.Add("@Col5", SqlDbType.NVarChar).Value = dr[4].ToString();
                                comm.Parameters.Add("@Col6", SqlDbType.NVarChar).Value = dr[5].ToString();
                                comm.Parameters.Add("@Col7", SqlDbType.NVarChar).Value = dr[6].ToString();
                                comm.Parameters.Add("@Col8", SqlDbType.NVarChar).Value = dr[7].ToString();
                                comm.Parameters.Add("@Col9", SqlDbType.NVarChar).Value = dr[8].ToString();
                                comm.Parameters.Add("@Col10", SqlDbType.Int).Value = float.Parse(dr[9].ToString());
                                comm.Parameters.Add("@Col11", SqlDbType.Money).Value = float.Parse(dr[10].ToString());
                                comm.Parameters.Add("@Col12", SqlDbType.Money).Value = float.Parse(dr[11].ToString());
                                comm.Parameters.Add("@Col13", SqlDbType.Int).Value = Int32.Parse(dr[12].ToString());
                                comm.Parameters.Add("@Col14", SqlDbType.NVarChar).Value = dr[13].ToString();
                                comm.Parameters.Add("@Col15", SqlDbType.NVarChar).Value = dr[14].ToString();
                                comm.Parameters.Add("@Col16", SqlDbType.NVarChar).Value = dr[15].ToString();
                                comm.Parameters.Add("@Col17", SqlDbType.NVarChar).Value = dr[16].ToString();
                                comm.Parameters.Add("@Col18", SqlDbType.Int).Value = float.Parse(dr[17].ToString());
                                comm.Parameters.Add("@Col19", SqlDbType.Money).Value = float.Parse(dr[18].ToString());
                                comm.Parameters.Add("@Col20", SqlDbType.Money).Value = float.Parse(dr[19].ToString());
                                comm.Parameters.Add("@Col21", SqlDbType.Int).Value = Int32.Parse(dr[20].ToString());
                                comm.Parameters.Add("@Col22", SqlDbType.NVarChar).Value = dr[21].ToString();
                                comm.Parameters.Add("@Col23", SqlDbType.NVarChar).Value = dr[22].ToString();
                                comm.Parameters.Add("@Col24", SqlDbType.NVarChar).Value = dr[23].ToString();
                                comm.Parameters.Add("@Col25", SqlDbType.Int).Value = Int32.Parse(dr[24].ToString());
                                comm.Parameters.Add("@Col26", SqlDbType.Money).Value = float.Parse(dr[25].ToString());
                                comm.Parameters.Add("@Col27", SqlDbType.Int).Value = Int32.Parse(dr[26].ToString());
                                try
                                {
                                    conn.Open();
                                    comm.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Ticket_SQL_usp_TicketQualified_InsertByRow::" + ex.ToString());
                                }
                            }
                        }
                        #endregion
                        Count += 1;
                    }
                    #endregion
                }
                else //不是第一筆就仿照第一筆的處理方式
                {
                    if (IsProcess != 1)
                    {
                        #region 新增
                        using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
                        {
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = "usp_TicketQualified_InsertByRow";
                                comm.CommandType = CommandType.StoredProcedure;
                                comm.Connection = conn;
                                comm.Parameters.Add("@Col1", SqlDbType.NVarChar).Value = dr[0].ToString();
                                comm.Parameters.Add("@Col2", SqlDbType.NVarChar).Value = dr[1].ToString();
                                comm.Parameters.Add("@Col3", SqlDbType.NVarChar).Value = dr[2].ToString();
                                comm.Parameters.Add("@Col4", SqlDbType.NVarChar).Value = dr[3].ToString();
                                comm.Parameters.Add("@Col5", SqlDbType.NVarChar).Value = dr[4].ToString();
                                comm.Parameters.Add("@Col6", SqlDbType.NVarChar).Value = dr[5].ToString();
                                comm.Parameters.Add("@Col7", SqlDbType.NVarChar).Value = dr[6].ToString();
                                comm.Parameters.Add("@Col8", SqlDbType.NVarChar).Value = dr[7].ToString();
                                comm.Parameters.Add("@Col9", SqlDbType.NVarChar).Value = dr[8].ToString();
                                comm.Parameters.Add("@Col10", SqlDbType.Money).Value = float.Parse(dr[9].ToString());
                                comm.Parameters.Add("@Col11", SqlDbType.Money).Value = float.Parse(dr[10].ToString());
                                comm.Parameters.Add("@Col12", SqlDbType.Money).Value = float.Parse(dr[11].ToString());
                                comm.Parameters.Add("@Col13", SqlDbType.Int).Value =dr[12].ToString();
                                comm.Parameters.Add("@Col14", SqlDbType.NVarChar).Value = dr[13].ToString();
                                comm.Parameters.Add("@Col15", SqlDbType.NVarChar).Value = dr[14].ToString();
                                comm.Parameters.Add("@Col16", SqlDbType.NVarChar).Value = dr[15].ToString();
                                comm.Parameters.Add("@Col17", SqlDbType.NVarChar).Value = dr[16].ToString();
                                comm.Parameters.Add("@Col18", SqlDbType.Money).Value = float.Parse(dr[17].ToString());
                                comm.Parameters.Add("@Col19", SqlDbType.Money).Value = float.Parse(dr[18].ToString());
                                comm.Parameters.Add("@Col20", SqlDbType.Money).Value = float.Parse(dr[19].ToString());
                                comm.Parameters.Add("@Col21", SqlDbType.Int).Value = (dr[20].ToString() != ""? Int32.Parse(dr[20].ToString()) : -1);
                                comm.Parameters.Add("@Col22", SqlDbType.NVarChar).Value = dr[21].ToString();
                                comm.Parameters.Add("@Col23", SqlDbType.NVarChar).Value = dr[22].ToString();
                                comm.Parameters.Add("@Col24", SqlDbType.NVarChar).Value = dr[23].ToString();
                                comm.Parameters.Add("@Col25", SqlDbType.Int).Value = (dr[24].ToString() != "" ? Int32.Parse(dr[24].ToString()) :-1);
                                comm.Parameters.Add("@Col26", SqlDbType.Money).Value = float.Parse(dr[25].ToString());
                                comm.Parameters.Add("@Col27", SqlDbType.Int).Value = dr[26].ToString();
                                try
                                {
                                    conn.Open();
                                    comm.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Ticket_SQL_usp_TicketQualified_InsertByRow::" + ex.ToString());
                                }
                            }
                        }
                        #endregion
                        Count += 1;
                    }
                }
            }
            Console.WriteLine("跑的次數"+ Count);
            return 1;
        }
        public int Comfirm(String RouteID,String StartDate,String EndDate)
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_TicketCheck";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.Parameters.Add("@RouteID",SqlDbType.NVarChar).Value = RouteID;
                    comm.Parameters.Add("@StartDatestr", SqlDbType.NVarChar).Value = StartDate;
                    comm.Parameters.Add("@EndDatestr", SqlDbType.NVarChar).Value = EndDate;
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
        public int CaculateEK()
        {
            int ReturnValue = 0;
            using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = "usp_CalculateEK";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;
                    comm.CommandTimeout = 0;
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
    }
}
