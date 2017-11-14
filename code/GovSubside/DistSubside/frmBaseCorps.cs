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
    public partial class frmBaseCorps : Form
    {
        public frmBaseCorps()
        {
            InitializeComponent();
        }
        private DataTable dt;
        private Corps corps;
        private void frmBaseCorps_Load(object sender, EventArgs e)
        {
            corps = new Corps();
            dt = corps.GetAllCompany();
            MyDataGridView.DataSource = dt;
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            String[] p = new String[4];
            p[0] = Company_Code.Text;
            p[1] = Company_Full_Name.Text;
            p[2] = Company_Short_Name.Text;
            p[3] = Company_EIN.Text;
            switch (corps.InsertNewData(p[0],p[1],p[2],p[3]))
            {
                case 1:
                    MessageBox.Show("新增完成");
                    ReLoadData();
                    break;
                case -1:
                    MessageBox.Show("請確定您輸入的資料正確\n英文字半形大寫\n若無法排除請通知資訊室");
                    break;
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要刪除嗎?\n公司代號:" + Company_Code.Text + "  的相關資料嗎?\n此行為一旦執行便無法恢復", "刪除確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.OK:
                    corps.DeleteData(Company_Code.Text);
                    ReLoadData();
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("您按了取消，所以資料庫並沒有更動");
                    break;
            }
            
        }

        private void UpDateBTN_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows[Index];
            if (dr["公司代號"].ToString() == Company_Code.Text)
            {
                switch (corps.UpDateData(Company_Code.Text, Company_Full_Name.Text, Company_Short_Name.Text, Company_EIN.Text))
                {
                    case 1:
                        MessageBox.Show("變更成功");
                        ReLoadData();
                        break;
                    case -1:
                        MessageBox.Show("請確定您輸入的資料正確\n英文字半形大寫\n若無法排除請通知資訊室","錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("公司代號不允許更改\n若您需要變更，請使用「刪除」後再新增\n本次操作會把公司代號替換回原本的代號\n請不要再變更噢~~");
                Company_Code.Text = dr["公司代號"].ToString() ;
            }
        }
        private int Index = 0;
        private void MyDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Index = e.RowIndex; //取得目前使用者選取的列索引，索引值從0開始
            DataRow dr = dt.Rows[Index];
            Company_Code.Text = dr[corps.TitleName_Chinese[0]].ToString();
            Company_Full_Name.Text = dr[corps.TitleName_Chinese[1]].ToString();
            Company_Short_Name.Text = dr[corps.TitleName_Chinese[2]].ToString();
            Company_EIN.Text = dr[corps.TitleName_Chinese[3]].ToString();
        }

        private void ReLoadData()
        {
            dt = null;
            MyDataGridView.DataSource = null;
            dt = corps.GetAllCompany();
            MyDataGridView.DataSource = dt;
        }

        private void CleanBTN_Click(object sender, EventArgs e)
        {
            Index = 0;
            Company_Code.Text = "";
            Company_Full_Name.Text = "";
            Company_Short_Name.Text = "";
            Company_EIN.Text = "";
            ReLoadData();
        }
    }
}
