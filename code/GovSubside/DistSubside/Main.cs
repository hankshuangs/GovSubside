using System;
using System.Windows.Forms;

namespace DistSubside
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ddiCascad_Click(object sender, EventArgs e)
        {
            // 重疊排列
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ddiOpsClose_Click(object sender, EventArgs e)
        {
            // 結束系統
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 檢查是否還有作業進行中
            Form frmChild = this.ActiveMdiChild;
            e.Cancel = false;

            if (frmChild != null)
            {
                if (MessageBox.Show("尚有作業進行中，是否仍要結束系統？", "結束系統",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        #region "判斷子表單是否正在執行"

        /// <summary>
        /// 判斷子表單是否正在執行
        /// </summary>
        /// <param name="strMdiChildren">子表單名稱</param>
        /// <returns></returns>
        public bool IsMdiChildrenRun(string strMdiChildren)
        {
            foreach (Form fm in MdiChildren)
            {
                if (strMdiChildren == fm.Name)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        private void ddiAbout_Click(object sender, EventArgs e)
        {
            // 關於本系統
            frmAboutBox fmAboutBox = new DistSubside.frmAboutBox();
            fmAboutBox.ShowDialog();
        }

        private void ddiOpsDailySchdlImp_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenRun("frmOpsDailySchdlImp"))
            {
                frmOpsDailySchdlImp fm = new frmOpsDailySchdlImp();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void ddiOpsDynamicImp_Click(object sender, EventArgs e)
        {
            //frmOpsDynamicImp 動態合格資料維護
            if (!IsMdiChildrenRun("frmOpsDynamicImp"))
            {
                frmOpsDynamicImp fm = new frmOpsDynamicImp();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void ddiOpsTicketProof_Click(object sender, EventArgs e)
        {
            //frmBaseDialog 票證資料匯入程式
            if (!IsMdiChildrenRun("frmOpsTicketImp"))
            {
                //Form fm = new frmTest();
                //frmTest fm = new frmTest();
                frmOpsTicketImp fm = new frmOpsTicketImp();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void ddiOpsCorps_Click(object sender, EventArgs e)
        {
            //frmBaseCorps 公司維護程式
            if (!IsMdiChildrenRun("frmBaseCorps"))
            {
                frmBaseCorps fm = new frmBaseCorps();
                fm.MdiParent = this;
                fm.Show();
            }

        }

        private void EKReport_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenRun("frmReportEK"))
            {
                frmReportEK ek = new frmReportEK();
                ek.MdiParent = this;
                ek.Show();
            }
        }

        private void ddiOpsVacations_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenRun("frmBaseVacations"))
            {
                frmBaseVacations fm = new frmBaseVacations();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void ddiOpsRoute_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenRun("frmBaseRoute"))
            {
                frmBaseRoute fm = new frmBaseRoute();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void Dynamiclmp_Report_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenRun("frmReportDynamiclmp"))
            {
                frmReportDynamiclmp fm = new frmReportDynamiclmp();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void ddiOpsStation_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenRun("frmBaseStation"))
            {
                frmBaseStation BS = new frmBaseStation();
                BS.MdiParent = this;
                BS.Show();
            }
        }

        private void ddiOpsStdSchdl_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenRun("frmBaseStdSchedule"))
            {
                frmBaseStdSchedule s = new frmBaseStdSchedule();
                s.MdiParent = this;
                s.Show();
            }
        }

        private void ddiOpsHoliday_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenRun("frmBaseHolidays"))
            {
                frmBaseHolidays h = new frmBaseHolidays();
                h.MdiParent = this;
                h.Show();
            }
        }

		private void ddiFailedTable_Click(object sender, EventArgs e)
		{
			if (!IsMdiChildrenRun("frmFailedTable"))
			{
				frmFailedTable f = new frmFailedTable();
				f.MdiParent = this;
				f.Show();
			}

		}
	}
}
