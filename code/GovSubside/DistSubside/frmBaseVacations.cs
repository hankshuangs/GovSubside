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
    public partial class frmBaseVacations : Form
    {
        public frmBaseVacations()
        {
            InitializeComponent();
        }
        private Vacations v;
        private List<TextBox> UIList;
        private void frmBaseVacations_Load(object sender, EventArgs e)
        {
            v = new Vacations();
            dataGridView1.DataSource = v.dt;
            UIList = new List<TextBox>() { Year_TB,SummerST_TB,SummerED_TB,WinterST_TB,WinterED_TB};
            TitleName_English = v.TitleNameEnglish;
            TitleName_Chinese = v.TitleNameChinese;
        }

        private void Insert_BT_Click(object sender, EventArgs e)
        {
            String[] p = GetTextBoxText();
            int result = v.Insert(p[0], p[1], p[2], p[3], p[4]);
            switch (result)
            {
                case 1:
                    dataGridView1.DataSource = null;
                    v = new Vacations();
                    dataGridView1.DataSource = v.dt;
                    break;
                case -1:
                    MessageBox.Show("發生資料庫錯誤\n請先確定您輸入的資料都有符合格式\nYYYY-MM-DD\n若還是無法解解決請回報資訊室");
                    break;
                case -2:
                    MessageBox.Show("發生程式錯誤\n請先確定您輸入的資料都有符合格式\nYYYY-MM-DD\n網路是否可以連線\n若還是無法解解決請回報資訊室");
                    break;
            }
        }

        private void Update_BT_Click(object sender, EventArgs e)
        {
            String[] p = GetTextBoxText();
            int result = v.Update(p[0], p[1], p[2], p[3], p[4]);
            switch (result)
            {
                case 1:
                    dataGridView1.DataSource = null;
                    v = new Vacations();
                    dataGridView1.DataSource = v.dt;
                    break;
                case -1:
                    MessageBox.Show("發生資料庫錯誤\n請先確定您輸入的資料都有符合格式\nYYYY-MM-DD\n若還是無法解解決請回報資訊室");
                    break;
                case -2:
                    MessageBox.Show("發生程式錯誤\n請先確定您輸入的資料都有符合格式\nYYYY-MM-DD\n網路是否可以連線\n若還是無法解解決請回報資訊室");
                    break;
            }
        }

        private void Clean_BT_Click(object sender, EventArgs e)
        {
            Index = 0;
            for (int i = 0; i < 5; i++)
            {
                UIList[i].Text = "";
            }
        }
        private String[] GetTextBoxText()
        {
            string[] strarray = new string[5];
            for (int i = 0; i < 5; i++)
            {
                strarray[i] = UIList[i].Text.ToString();
            }
            return strarray;
        }
        private string[] TitleName_Chinese;
        private string[] TitleName_English;
        private int Index = 0;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Index = e.RowIndex;
            DataRow dr = v.dt.Rows[e.RowIndex];
            for (int i = 0; i < 5; i++)
            {
                UIList[i].Text = dr[TitleName_Chinese[i]].ToString();
            }
        }
    }
}
