using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
//引入IO
using System.IO;
using System.Data.SqlClient;
//引入Model
using DistSubside.Model;
//引入自訂讀檔器
using DistSubside.DataReader;

namespace DistSubside
{
    public partial class frmOpsTicketImp : DistSubside.frmBaseDialog
    {
        public frmOpsTicketImp()
        {
            InitializeComponent();
        }
        private Color ColorRecord;
        private DataTable dt = new DataTable();
        private String conn = ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString;
        private String[] DateRange,RouteRange;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("已完成或無資料載入", "完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			this.BackColor = Color.Red;
            MessageBox.Show("按確定後開始執行");
            String Temp = this.Text;
            this.Text = "正在匯入票證資訊...";
            SQL.Ticket_SQL Ticket_SQL_Object = new SQL.Ticket_SQL();
            int ProcessCode = Ticket_SQL_Object.Insert(dt);		
            switch (ProcessCode)
            {
                case 1:
                    this.Text = "正在驗證票證資訊...";
                    foreach (String eachroute in RouteRange)
                    {
                        Ticket_SQL_Object.Comfirm(eachroute, DateRange[0], DateRange[1]);
                    }
                    MessageBox.Show("資料新增完畢", "完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Text = Temp;
                    this.BackColor = ColorRecord;
                    break;
                case -1:
                    MessageBox.Show("發生錯誤:" + ProcessCode.ToString(), "發生錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.BackColor = ColorRecord;
                    break;
            }

        }

        private void frmOpsTicketImp_Load(object sender, EventArgs e)
        {
            ColorRecord = this.BackColor;
        }

        private int[] ResultArray;
        private void DamgerImport_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("多重匯入對於電腦記憶體不夠大或是處理器不夠快的電腦負擔會非常大\n請在使用這個功能的時候先把其他應用程式存檔並關閉\n倘若因為使用此功能導致電腦當機或燒毀\n資訊室不負任何責任\n同意的話請按確定，或是選擇安全匯入", "危險功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                this.ColorRecord = this.BackColor;
                this.BackColor = Color.Red;
                OpenFileDialog FD = new OpenFileDialog();
                FD.Filter = "CSV檔案|*.csv";
                FD.Multiselect = true;
                FD.ShowDialog();
                ResultArray = new int[FD.FileNames.Length];
                ParameterizedThreadStart PTS = new ParameterizedThreadStart(InportLotFile);
                Thread t = new Thread(PTS);
                t.Start(FD.FileNames);
            }
        }

        private void btnSelectFileCSV_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            //載入csv
            string fileName = string.Empty;
            //限制副檔名為 *.csv
            openFileDialog1.Filter = "csv檔案|*.csv";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //將路徑顯示在 TextBox上
                fileName = this.openFileDialog1.FileName;
                txtFileName.Text = fileName;
                //阿見修改
                try
                {
                    CSVReader reader = new CSVReader(fileName);
                    dt = reader.getDataTable();
                    dataGridView1.DataSource = dt;
                    this.BackColor = ColorRecord;
                    this.DateRange = reader.DateRange;
                    this.RouteRange = reader.RouteArray.ToArray();
                    Console.Write("時間範圍: " + DateRange[0] + " ~ " + DateRange[1]);
                    Console.WriteLine("所有路線:");
                    foreach (String x in RouteRange)
                    {
                        Console.WriteLine(x);
                    }
                    Console.WriteLine("-----------------");
                    ShowTimeRange.Text = DateRange[0] + " ~ " + DateRange[1];
                    ComboForRoute.DataSource = RouteRange;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("您選擇的檔案不存在或是正在使用中，請關閉您其他的程式在試一次\n系統代碼:"+ex.Message);
                    this.BackColor = ColorRecord;
                }
            }
            else
            {
                this.BackColor = ColorRecord;
            }
        }

        //多執行續版本
        #region UI更新
        private delegate void ReFlashUI(String s, Control c);
        private void UpdateUIText(String s, Control c)
        {
            if (this.InvokeRequired)
            {
                ReFlashUI UI = new ReFlashUI(UpdateUIText);
                this.Invoke(UI, s, c);
            }
            else
            {
                c.Text = s;
            }
        }
        private delegate void SetBackColor(Color c1, Control c2);
        private void UpdateColor(Color c1, Control c2)
        {
            if (this.InvokeRequired)
            {
                SetBackColor s = new SetBackColor(UpdateColor);
                this.Invoke(s,c1,c2);
            }
            else
            {
                c2.BackColor = c1;
                MessageBox.Show("工作執行完成");
            }
        }
    
        #endregion

        private void InportLotFile(Object o)
        {
            String[] PathArray = (String[])o;
            for (int i = 0; i < PathArray.Length; i++)
            {
                UpdateUIText("正在處理 " + (i + 1) + "\\" + (PathArray.Length+1),this);
                CSVReader r = new CSVReader(PathArray[i]);
                DataTable t = r.getDataTable();
                SQL.Ticket_SQL T_sql = new SQL.Ticket_SQL();
                T_sql.Insert(t);
                /*
                ResultArray[i] = T_sql.Insert(t);
                RouteRange = r.RouteArray.ToArray();
                DateRange = r.DateRange;
                for (int j = 0; j < RouteRange.Length; i++)
                {
                    T_sql.Comfirm(RouteRange[j], DateRange[0], DateRange[1]);
                }
                */
                UpdateUIText("正在處理 " + (i + 1) + "\\" + (PathArray.Length + 1), this);
            }
            UpdateColor(ColorRecord, this);
        }
    }
}
