using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
//引入IO
using System.IO;
using System.Data.SqlClient;
//引入Model
using DistSubside.Model;
//引入自訂讀檔器
using DistSubside.DataReader;
//引入SQL

namespace DistSubside
{
    public partial class frmOpsDynamicImp : DistSubside.frmBaseDialog
    {
        public frmOpsDynamicImp()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private Color ColorRecord;
        //選取檔案載入excel
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //載入excel 
            this.BackColor = Color.Red;
            string fileName = string.Empty;
            //限制副檔名為 *.xls
            openFileDialog1.Filter = "Excel 97-2003 活頁簿|*.xls|Excel 2003以上|*.xlsx";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //將路徑顯示在 TextBox上
                fileName = this.openFileDialog1.FileName;
                MessageBox.Show("匯入時間較長，請勿終止程式\n按下確定後開始");
                txtFileName.Text = fileName;
                //strPath = FileName.Replace(OpenFileDig.SafeFileName.ToString(), "");
                //阿見修改
                MyExcel myexcel = new MyExcel(fileName);
                dt = myexcel.getDT();
                lblRouteId.Text = myexcel.RouteID;
                //cboRouteDiscript.Enabled = false;
                myexcel.Depose();
                //dt = ReadExcel3(fileName);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count>0)
                {
                    //修改datatable欄位名稱與增加欄位
                    dt = EdtToDBdt(dt);
                    dataGridView1.DataSource = dt;
                }
                this.BackColor = ColorRecord;
            }
        }

        //將datatble資料寫入到資料庫的DynamicQualified表
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //阿見修改
            this.BackColor = Color.Red;
            MessageBox.Show("按下確定後開始","確定後開始", MessageBoxButtons.OK,MessageBoxIcon.None);
            SQL.Dynamic_SQL Dynamic_SQL_Object = new SQL.Dynamic_SQL();
            int StatusCode = Dynamic_SQL_Object.Insert(dt);
            if (StatusCode == 1)
            {
                MessageBox.Show("資料新增完畢", "完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.BackColor = ColorRecord;
            }
            else
            {
                MessageBox.Show("發生錯誤:" + StatusCode.ToString(), "發生錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BackColor = ColorRecord;
            }
        }

        /// <summary>
        /// 將Edt整理成DB格式的Table
        /// </summary>
        /// <param name="Edt">將excel讀取的資料轉成datatble</param>
        /// <returns></returns>
        public static DataTable EdtToDBdt(DataTable Edt)
        {
            AddDataColumn Column = new AddDataColumn();
            try
            {
                //更改欄位名稱
                for (int i = 0; i < Edt.Columns.Count; i++)
                {
                    switch (Edt.Columns[i].ColumnName)
                    {
                        case "序號":
                            Edt.Columns[i].ColumnName = "ID";
                            break;
                        case "班表時間":
                            Edt.Columns[i].ColumnName = "DynamicSchdlTime";
                            break;
                        case "趟次時間":
                            Edt.Columns[i].ColumnName = "RealTime";
                            break;
                        case "車牌":
                            Edt.Columns[i].ColumnName = "CarLic";
                            break;
                        case "去回程":
                            Edt.Columns[i].ColumnName = "DynamicStartStand";
                            break;
                        case "Column1":
                            Edt.Columns[i].ColumnName = "isMatchSchdl";
                            break;
                    }
                }
                
                //將欄位加入表格中
                //阿見修改
                //Edt.Columns.Add(Column.NewColumn("SchdlDate", "System.DateTime", true,null,null));
                //Edt.Columns.Add(Column.NewColumn("RouteCode", "System.String", true, null, ""));
                
                
                return Edt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Excel格式錯誤或者Excel正開啟中");
                MessageBox.Show("錯誤代碼：" + ex.Message.ToString());
                return null;
            }
        }

        private void frmOpsDynamicImp_Load(object sender, EventArgs e)
        {
            ColorRecord = this.BackColor;
        }
    }
}
