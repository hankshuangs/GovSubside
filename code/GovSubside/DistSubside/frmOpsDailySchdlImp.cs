using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace DistSubside
{
    public partial class frmOpsDailySchdlImp : frmBaseDialog
    {
        public frmOpsDailySchdlImp()
        {
            InitializeComponent();
        }
        private DateTime Start = DateTime.Now, End = DateTime.Now;
        private void Calendar_Start_DateChanged(object sender, DateRangeEventArgs e)
        {
            Start = Calendar_Start.SelectionRange.Start;
            StartDate.Text = Start.Date.ToString("yyyy-MM-dd");
        }

        private void frmOpsDailySchdlImp_Load(object sender, EventArgs e)
        {
            StartDate.Text = Start.Date.ToString("yyyy-MM-dd");
            EndDate.Text = End.Date.ToString("yyyy-MM-dd");
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("您輸入的日期是\n從："+Start.ToString("yyyy-MM-dd")+"\n到："+End.ToString("yyyy-MM-dd")+"\n請確定以上訊息是否正確", "確認維護日期", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.OK)
            {
                TimeSpan span = End - Start;
                int CountDay = span.Days;
                for (int i = 0; i <= CountDay; i++)
                {
                    DateTime eachDate = Start.AddDays(i);
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString))
                    {
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = "usp_RouteSchedule_CreateByDay";
                            comm.CommandType = CommandType.StoredProcedure;
                            comm.Connection = conn;
                            comm.Parameters.Add("@SchdlDate", SqlDbType.NVarChar).Value = eachDate.ToString("yyyy-MM-dd");
                            try
                            {
                                conn.Open();
                                comm.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                MessageBox.Show("共產生  " + (CountDay+1) + " 天   完成");
            }
        }

        private void Calendar_End_DateChanged(object sender, DateRangeEventArgs e)
        {
            End = Calendar_End.SelectionRange.Start;
            EndDate.Text = End.Date.ToString("yyyy-MM-dd");
        }
    }
}
