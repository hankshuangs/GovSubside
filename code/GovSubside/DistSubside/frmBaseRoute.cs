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
    public partial class frmBaseRoute : Form
    {
        private int Select_Index = 0;
        private Route r;
        private DataTable dt;
        private List<Control> UIList;
        private String[] Title;
        public frmBaseRoute()
        {
            InitializeComponent();
        }
        private void frmBaseRoute_Load(object sender, EventArgs e)
        {
            UIList = new List<Control>();
            UIList.Add(RouteID_TB);
            UIList.Add(RouteTicket_TB);
            UIList.Add(GroupCode_TB);
            UIList.Add(RouteName_TB);
            UIList.Add(RouteDynamic_TB);
            UIList.Add(StationStart_TB);
            UIList.Add(StationMid_TB);
            UIList.Add(StationEnd_TB);
            UIList.Add(GoLength_TB);
            UIList.Add(BackLength_TB);
            UIList.Add(CostTime_TB);
            UIList.Add(WCount_TB);
            UIList.Add(HCount_TB);
            UIList.Add(IsLoop_CB);
            UIList.Add(CoID_CB);
            UIList.Add(StartTime_DTP);
            UIList.Add(EndTime_DTP);
            r = new Route();
            dt = r.All_Data_Table;
            MyDataGirdView.DataSource = dt;
            Title = r.TitleName;
        }

        private void MyDataGirdView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Select_Index = e.RowIndex;
            DataRow dr = dt.Rows[Select_Index];
            for (int i = 0; i < Title.Length; i++)
            {
                UIList[i].Text = dr[Title[i]].ToString();
            }
        }

        private void CleanUI_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Title.Length; i++)
            {
                UIList[i].Text = "";
            }
        }

        private void AddRoute_BTN_Click(object sender, EventArgs e)
        {
            String[] DataArray = new string[UIList.Count];
            bool IsPass = true;
            for (int i = 0; i < UIList.Count; i++)
            {
                if (UIList[i].Text == "" || UIList[i].Text == String.Empty)
                {
                    IsPass = false;
                }
                else
                {
                    DataArray[i] = UIList[i].Text;
                }
            }
            if (IsPass)
            {
                int Result = r.Insert(DataArray[0], DataArray[1], DataArray[2], DataArray[3], DataArray[4], DataArray[5], DataArray[6], DataArray[7], DataArray[8], DataArray[9], DataArray[10], DataArray[11], DataArray[12], DataArray[13], DataArray[14], DataArray[15], DataArray[16]);
                dt = null;
                MyDataGirdView.DataSource = null;
                r = new Route();
                dt = r.All_Data_Table;
                MyDataGirdView.DataSource = dt;
                Title = r.TitleName;
            }
            else
            {
                MessageBox.Show("偵測到有資料沒有填");
            }

        }

        private void UpDateRoute_BTN_Click(object sender, EventArgs e)
        {
            String[] DataArray = new string[UIList.Count];
            bool IsPass = true;
            DataRow dr = dt.Rows[Select_Index];
            for (int i = 0; i < UIList.Count; i++)
            {
                if (UIList[i].Text == "" || UIList[i].Text == String.Empty)
                {
                    IsPass = false;
                }
                else
                {
                    DataArray[i] = UIList[i].Text;
                }
            }
            if (DataArray[0] == dr[Title[0]].ToString())
            {
                int Result = r.Update(DataArray[0], DataArray[1], DataArray[2], DataArray[3], DataArray[4], DataArray[5], DataArray[6], DataArray[7], DataArray[8], DataArray[9], DataArray[10], DataArray[11], DataArray[12], DataArray[13], DataArray[14], DataArray[15], DataArray[16]);
                switch (Result)
                {
                    case 1:
                        dt = null;
                        MyDataGirdView.DataSource = null;
                        r = new Route();
                        dt = r.All_Data_Table;
                        MyDataGirdView.DataSource = dt;
                        Title = r.TitleName;
                        break;
                    case -1:
                        MessageBox.Show("請把你目前輸入的畫面截圖並且通知資訊室", "資料庫錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -2:
                        MessageBox.Show("請把你目前輸入的畫面截圖並且通知資訊室", "程式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("主鍵不能修改\n我已經幫你修正回來\n如果有需要請再按一次修改", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
