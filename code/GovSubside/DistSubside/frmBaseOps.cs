using System;
using System.Windows.Forms;
using System.Configuration;

namespace DistSubside
{
    public partial class frmBaseOps : Form
    {
        internal string strConnString
        {
            get { return ConfigurationManager.ConnectionStrings["GovSubsidyConnString"].ConnectionString; }
            set { this.strConnString = value; }
        } 

        public frmBaseOps()
        {
            InitializeComponent();
        }

        #region 建立虛擬方法，以利繼承時實作方法。

        /// <summary>
        /// 建立虛擬方法，以利繼承時實作方法。
        /// </summary>
        public virtual void AddNew() { }
        public virtual void Modify() { }
        public virtual void Abandon() { }
        public virtual void Query() { }
        public virtual void Import() { }
        public virtual void Print() { }
        public virtual void ToFirst() { }
        public virtual void ToPrior() { }
        public virtual void ToNext() { }
        public virtual void ToLast() { }
        
        #endregion


        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void tsbModify_Click(object sender, EventArgs e)
        {
            Modify();
        }

        private void tsbAbandon_Click(object sender, EventArgs e)
        {
            Abandon();
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void tsbToFirst_Click(object sender, EventArgs e)
        {
            ToFirst();
        }

        private void tsbToPrior_Click(object sender, EventArgs e)
        {
            ToPrior();
        }

        private void tsbToNext_Click(object sender, EventArgs e)
        {
            ToNext();
        }

        private void tsbToLast_Click(object sender, EventArgs e)
        {
            ToLast();
        }
    }
}
