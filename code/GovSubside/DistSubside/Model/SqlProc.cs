using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
//
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace DistSubside.Model
{
    class SqlProc
    {
        String conn = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
        public DataTable SqlProcTableDBGovSubsidy(string ProcName, int forint, string[] ArrayVariable, string[] ArrayValue, string strView)
        //public DataTable SqlProcTable(string connDataMS, string ProcName, int forint, string[] ArrayVariable, string[] ArrayValue, string strView)
        {
            DataTable dt = new DataTable();
            using (SqlConnection Conn = new SqlConnection(conn)) //using (SqlConnection Conn = new SqlConnection(conn.connGovSubsidy))
            {
                Conn.Open();
                SqlCommand myCommand = new SqlCommand();
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = ProcName;
                myCommand.Connection = Conn;
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                for (int i = 0; i <= forint; i++)
                {
                    da.SelectCommand.Parameters.AddWithValue(ArrayVariable[i], ArrayValue[i]);
                    //Cmmd.Parameters.AddWithValue("@A_id", _Aid)
                }
                //da.SelectCommand.Parameters.Add("@RB_Oid", SqlDbType.VarChar).Value = strOid '
                try
                {
                    da.Fill(dt);
                    myCommand.Cancel();
                    myCommand.Dispose();
                    return dt;
                }
                catch (Exception ex)
                {
                    //"無編碼產生"
                    //ScriptManager.RegisterClientScriptBlock(Me, Me.GetType, "error", "alert('" & strView & "');", True)
                    //ScriptManager.RegisterClientScriptBlock(this, this.GetType, "error", "alert('" + strView + "！" + ex.ToString() + "');", true);                    
                    MessageBox.Show(strView + ex.ToString());
                    myCommand.Cancel();
                    myCommand.Dispose();
                    return dt;
                }

                
            }
        }

        /// <summary>
        /// 呼叫預存程序，執行ExecuteReader。注意：textbox要在函式內更改！
        /// </summary>        
        /// <param name="ProcName">預存程序名稱</param>
        /// <param name="forint">要丟的參數個數，從0開始</param>
        /// <param name="ArrayVariable">DB變數陣列</param>
        /// <param name="ArrayValue">丟變數值的陣列</param>
        /// <param name="StrResult">執行某動作要顯示的字(錯誤訊息的文字)</param>
        /// <returns></returns>
        public bool SqlProcExecuteNonQuery(string ProcName, int forint, string[] ArrayVariable, string[] ArrayValue, string StrResult)
        {
            //myConn為連結對象 /// <param name="connDataMS">要連線的資料庫(例car)</param>  string connDataMS, 
            //Dim car As New objConn("car")
            //objConn car = new objConn(connDataMS); using (SqlConnection Conn = new SqlConnection(car.Str))
            using (SqlConnection Conn = new SqlConnection(conn))
            {
                Conn.Open();
                SqlCommand myCommand = new SqlCommand();                
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = ProcName;
                myCommand.Connection = Conn;
                for (int i = 0; i <= forint; i++)
                {
                    myCommand.Parameters.AddWithValue(ArrayVariable[i], ArrayValue[i]);
                }

                try
                {
                    myCommand.ExecuteNonQuery();
                    myCommand.Cancel();
                    myCommand.Dispose();
                    return true;
                }
                catch (Exception ex)
                {
                    //ScriptManager.RegisterClientScriptBlock(this, this.GetType, "error", "alert('" + StrResult + "！');", true);
                    MessageBox.Show(StrResult + ex.ToString());
                    myCommand.Cancel();
                    myCommand.Dispose();
                    return false;
                }                
            }
        }

        //引用
        //using System.Windows.Forms;
        //C#跳出確定視窗
        //DialogResult result;
        //result = MessageBox.Show("你確定是" + searchName(1, textBox2.Text) + "本人", "員工確認", MessageBoxButtons.YesNo);
        //if (result == System.Windows.Forms.DialogResult.Yes)
        //{
        //    MessageBox.Show("Records Deleted Successfully");
        //    button1.Enabled = true;
        //    button2.Enabled = true;
        //}
        //else
        //{
        //    MessageBox.Show("請重新輸入工號");
        //}

    }
}
