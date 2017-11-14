using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DistSubside.SQL;

namespace DistSubside
{
    public partial class frmBaseStation : Form
    {
         
        public frmBaseStation()
        {
            InitializeComponent();
        }
        private Route r;
        private String[] All_RouteName;
        private Station s;
        private DataTable StationTableByRouteName;
        private int Index = 0;
        private Control[] UIList;
        private void frmBaseStation_Load(object sender, EventArgs e)
        {
            r = new Route();
            All_RouteName = r.GetRouteName();
            Route_ID_CB.DataSource = All_RouteName;
            UIList = new Control[] { Route_ID, SEQ, Station_Name, Go_Km, Back_Km, Start_Time, End_Time };
        }

        private void ShowRouteStation_BT_Click(object sender, EventArgs e)
        {
            s = new Station();
            StationTableByRouteName = s.GetStationByRouteID(r.GetRouteCodeByRouteName(Route_ID_CB.Text));
            Station_DataGridView.DataSource = StationTableByRouteName;
        }

        private void Station_DataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Index = e.RowIndex;
            DataRow dr = StationTableByRouteName.Rows[Index];
            for (int i = 0; i < UIList.Length; i++)
            {
                UIList[i].Text = dr[s.TitleNameChinese[i]].ToString();
            }
        }

        private void Insert_BT_Click(object sender, EventArgs e)
        {
            int record = s.Insert(Route_ID.Text, SEQ.Text, Station_Name.Text, Go_Km.Text, Back_Km.Text, Start_Time.Text, End_Time.Text);
            switch (record)
            {
                case 1:
                    MessageBox.Show("新增成功");
                    StationTableByRouteName = s.GetStationByRouteID(r.GetRouteCodeByRouteName(Route_ID_CB.Text));
                    Station_DataGridView.DataSource = StationTableByRouteName;
                    break;
                case -1:
                    MessageBox.Show("請確認您輸入資料是否有誤\n錯誤代碼:-1", "資料庫錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case -2:
                    MessageBox.Show("請確認您輸入資料是否有誤\n錯誤代碼:-2", "程式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Update_BT_Click(object sender, EventArgs e)
        {
            DataRow tempdr = StationTableByRouteName.Rows[Index];
            if (tempdr[s.TitleNameChinese[0]].ToString() == Route_ID.Text && tempdr[s.TitleNameChinese[1]].ToString() == SEQ.Text)
            {
                int tempnumber = s.UpDate(Route_ID.Text, SEQ.Text, Station_Name.Text, Go_Km.Text, Back_Km.Text, Start_Time.Text, End_Time.Text, tempdr["唯一識別碼"].ToString());
                switch (tempnumber)
                {
                    case 1:
                        MessageBox.Show("更改成功");
                        StationTableByRouteName = s.GetStationByRouteID(r.GetRouteCodeByRouteName(Route_ID_CB.Text));
                        Station_DataGridView.DataSource = StationTableByRouteName;
                        break;
                    case -1:
                        MessageBox.Show("請確認您輸入資料是否有誤\n錯誤代碼:-1", "資料庫錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -2:
                        MessageBox.Show("請確認您輸入資料是否有誤\n錯誤代碼:-2", "程式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("路線ID跟站序是不能更改");
                Route_ID.Text = tempdr["路線ID"].ToString();
                SEQ.Text = tempdr["站序"].ToString();
            }
            
        }
        private void Clean_BT_Click(object sender, EventArgs e)
        {
            Index = 0;
            foreach (Control each in UIList)
            {
                each.Text = "";
            }
        }
    }
}
