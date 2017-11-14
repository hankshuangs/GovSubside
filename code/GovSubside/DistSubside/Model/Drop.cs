using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
//
using System.Data;
using System.Data.SqlClient;


namespace DistSubside.Model
{
    class Drop
    {
        /// <summary>
        /// 建立路線資料下拉清單
        /// </summary>
        /// <returns></returns>
        public DataTable selectRoute()
        {
            try
            {
                DataTable dttemp;
                String conn = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
                //SqlDataReader reader;
                using (SqlConnection cn = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = cn.CreateCommand())
                    {
                        dttemp = new DataTable();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "usp_Route_Select";
                        cmd.Connection = cn;
                        int s = cn.ConnectionTimeout;
                        try { cn.Open(); } catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.ToString()); }

                        /*
                        reader = cmd.ExecuteReader();
                        dttemp.Columns.Add("RouteId", typeof(String));
                        dttemp.Columns["RouteId"].MaxLength=10;
                        dttemp.Columns.Add("RouteDiscript", typeof(String));
                        dttemp.Columns["RouteDiscript"].MaxLength = 20;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DataRow row = dttemp.NewRow();
                                row["RouteId"] = reader["RouteId"].ToString();
                                row["RouteDiscript"] = reader["RouteDiscript"].ToString();
                                dttemp.Rows.Add(row);
                            }
                        }
                        */
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dttemp);
                    }
                }
                return dttemp;
            }
            catch
            {
                //MessageBox.Show("錯誤代碼：" + ex.Message.ToString());
                return null;
            }
        }


    }
}
