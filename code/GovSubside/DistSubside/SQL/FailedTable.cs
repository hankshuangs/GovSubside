using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DistSubside.SQL
{
	class FailedTable
	{
		private String GovSubsidyConnString = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
		//# 查詢範圍
		string routes = "105,123,19"; //路線
		string strDate = "2017-10-1"; //起日
		string endDate = "2017-10-31"; //迄日


		public System.Data.DataSet fTables()
		{
			int ReturnValue = 0;
			System.Data.DataSet ds = new System.Data.DataSet();
			using (SqlConnection conn = new SqlConnection(GovSubsidyConnString))
			{
			
				using (SqlCommand comm = new SqlCommand())
				{
					comm.CommandText = "usp_FailedTable_QueryByRow";
					comm.CommandType = CommandType.StoredProcedure;
					comm.Connection = conn;
					comm.CommandTimeout = 0;
					comm.Parameters.Add("@routes", SqlDbType.NVarChar).Value = routes;
					comm.Parameters.Add("@strDate", SqlDbType.NVarChar).Value = strDate;
					comm.Parameters.Add("@endDate", SqlDbType.NVarChar).Value = endDate;
					try
					{
						////作法1
						//conn.Open();
						////comm.ExecuteNonQuery();
						//using (SqlDataReader sdr =comm.ExecuteReader())
						//{
						//	DataTable tb = new DataTable();
						//	tb.Load(sdr);
						//	ds.Tables.Add(tb);
						//	while (sdr.NextResult())
						//	{
						//		tb = new DataTable();
						//		tb.Load(sdr);
						//		ds.Tables.Add(tb);
						//	}
						//}
						//conn.Close();


						//作法2
						SqlDataAdapter sda = new SqlDataAdapter(comm);
						sda.TableMappings.Add("Table","105");
						sda.TableMappings.Add("Table1", "123");
						sda.TableMappings.Add("Table2", "19");
						sda.Fill(ds);
						sda.Dispose();

						ReturnValue = 1;
					}
					catch(Exception ex)
					{
						ReturnValue = -1;
						Console.WriteLine("usp_FailedTable_QueryByRow::" + ex.ToString());
					}
				}
			}
			return ds;
		}
}
}
