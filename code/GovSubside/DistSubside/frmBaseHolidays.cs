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
    public partial class frmBaseHolidays : Form
    {
        public frmBaseHolidays()
        {
            InitializeComponent();
        }
        private int Index = 0;
        private String[] TitleName_Chinese;
        private String[] TitleName_English;
        private Holidays h;
        private List<TextBox> UILust;
        private void Insert_BT_Click(object sender, EventArgs e)
        {
            String[] v = GetTextboxText();
            int Result = h.Insert(v[0], v[1], v[2]);
            switch (Result)
            {
                case 1:
                    dataGridView1.DataSource = null;
                    h = new Holidays();
                    dataGridView1.DataSource = h.dt;
                    break;
                case -1:
                    MessageBox.Show("發生資料庫錯誤\n請先確定您輸入的資料都有符合格式\nYYYY-MM-DD\n若還是無法解解決請回報資訊室");
                    break;
                case -2:
                    MessageBox.Show("發生程式錯誤\n請先確定您輸入的資料都有符合格式\nYYYY-MM-DD\n網路是否可以連線\n若還是無法解解決請回報資訊室");
                    break;
            }
        }

        private void Delete_BT_Click(object sender, EventArgs e)
        {
            String[] v = GetTextboxText();
            int Result = h.Delete(Date_TB.Text.ToString());
            switch (Result)
            {
                case 1:
                    dataGridView1.DataSource = null;
                    h = new Holidays();
                    dataGridView1.DataSource = h.dt;
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
            String[] v = GetTextboxText();
            int Result = h.Update(v[0], v[1], v[2]);
            switch (Result)
            {
                case 1:
                    dataGridView1.DataSource = null;
                    h = new Holidays();
                    dataGridView1.DataSource = h.dt;
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
            for (int i = 0; i < 3; i++)
            {
                UILust[i].Text = "";
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Index = e.RowIndex;
            DataRow dr = h.dt.Rows[e.RowIndex];
            for (int i = 0; i < 3; i++)
            {
                UILust[i].Text = dr[TitleName_Chinese[i]].ToString();
            }
        }

        private void frmBaseHolidays_Load(object sender, EventArgs e)
        {
            UILust = new List<TextBox>() { Date_TB,IsOK_TB,Name_TB};
            h = new Holidays();
            dataGridView1.DataSource = h.dt;
            TitleName_Chinese = h.TitleName_Chinese;
            TitleName_English = h.TitleName_English;
        }
        private String[] GetTextboxText()
        {
            String[] value = new string[3];
            for (int i = 0; i < 3; i++)
            {
                value[i] = UILust[i].Text.ToString();
            }
            return value;
        }
    }
}
