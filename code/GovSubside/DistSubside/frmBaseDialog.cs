using System;
using System.Windows.Forms;

namespace DistSubside
{
    public partial class frmBaseDialog : Form
    {
        // 允許關閉對話框
        bool bCanClose = false;

        //取得或設定是否允關閉對話框
        public bool CanClose
        {
            get { return bCanClose; }
            set { bCanClose = value; }
        }

        public frmBaseDialog()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bCanClose = true;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmBaseDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            //bCanClose = true; 自己加的
            bCanClose = true;
            e.Cancel = (!bCanClose);
        }
    }
}
