using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistSubside
{
    public partial class frmBase : Form
    {
        // 目前作業的程式
        //string strProgramID;
        // 程式操作狀態 0:瀏覽 1:新增 2:編輯
        byte btOpStatus = 0;

        // 取得來源物件
        BindingSource bsBindingSource;
        // 資料表
        //string strTableName;
        // 主鍵欄位名稱
        //string strPKFieldName;
        // 主鍵值
        //string strPKID;
        // 欲刪資料之主鍵值
        //string strDelPKID;

        // 操作權限
        bool bAllowAddNew = true;
        //bool bAllowEdit = true;
        //bool bAllowDelete = false;
        //bool bAllowPrint = false;

        public frmBase()
        {
            InitializeComponent();
            SetButton();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            bsBindingSource = new BindingSource();
            bsBindingSource.PositionChanged += new EventHandler(this.bsBindingSource_PositionChanged);
        }

        private void SetButton()
        {
            tsbFirst.Enabled = (btOpStatus == 0);
            tsbPrior.Enabled = (btOpStatus == 0);
            tsbNext.Enabled = (btOpStatus == 0);
            tsbLast.Enabled = (btOpStatus == 0);

            tsbAddNew.Enabled = (btOpStatus == 0) && (bAllowAddNew);

        }

        private void bsBindingSource_PositionChanged(Object sender, EventArgs e)
        {
        

        }
    }
}
