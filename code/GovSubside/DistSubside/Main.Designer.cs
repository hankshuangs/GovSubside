namespace DistSubside
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.muiBase = new System.Windows.Forms.ToolStripMenuItem();
			this.ddiOpsCorps = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ddiOpsRoute = new System.Windows.Forms.ToolStripMenuItem();
			this.ddiOpsStation = new System.Windows.Forms.ToolStripMenuItem();
			this.ddiOpsStdSchdl = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ddiOpsVacations = new System.Windows.Forms.ToolStripMenuItem();
			this.ddiOpsHoliday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ddiOpsClose = new System.Windows.Forms.ToolStripMenuItem();
			this.muiQualified = new System.Windows.Forms.ToolStripMenuItem();
			this.ddiOpsDailySchdlImp = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.ddiOpsDynamicImp = new System.Windows.Forms.ToolStripMenuItem();
			this.ddiOpsTicketProof = new System.Windows.Forms.ToolStripMenuItem();
			this.ddiOpsDrivingProof = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.muiReport = new System.Windows.Forms.ToolStripMenuItem();
			this.EKReport = new System.Windows.Forms.ToolStripMenuItem();
			this.Dynamiclmp_Report = new System.Windows.Forms.ToolStripMenuItem();
			this.Tick_Repoer = new System.Windows.Forms.ToolStripMenuItem();
			this.不合格報表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.月總表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.電子票證附件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.muiAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.muiWindows = new System.Windows.Forms.ToolStripMenuItem();
			this.ddiCascad = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.ddiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.DesingerLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muiBase,
            this.muiQualified,
            this.muiReport,
            this.muiAdmin,
            this.muiWindows});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// muiBase
			// 
			this.muiBase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddiOpsCorps,
            this.toolStripSeparator1,
            this.ddiOpsRoute,
            this.ddiOpsStation,
            this.ddiOpsStdSchdl,
            this.toolStripSeparator2,
            this.ddiOpsVacations,
            this.ddiOpsHoliday,
            this.toolStripSeparator3,
            this.ddiOpsClose});
			this.muiBase.Name = "muiBase";
			this.muiBase.Size = new System.Drawing.Size(68, 20);
			this.muiBase.Text = "基本資料";
			// 
			// ddiOpsCorps
			// 
			this.ddiOpsCorps.Name = "ddiOpsCorps";
			this.ddiOpsCorps.Size = new System.Drawing.Size(148, 22);
			this.ddiOpsCorps.Text = "公司資料維護";
			this.ddiOpsCorps.Click += new System.EventHandler(this.ddiOpsCorps_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
			// 
			// ddiOpsRoute
			// 
			this.ddiOpsRoute.Name = "ddiOpsRoute";
			this.ddiOpsRoute.Size = new System.Drawing.Size(148, 22);
			this.ddiOpsRoute.Text = "路線資料維護";
			this.ddiOpsRoute.Click += new System.EventHandler(this.ddiOpsRoute_Click);
			// 
			// ddiOpsStation
			// 
			this.ddiOpsStation.Name = "ddiOpsStation";
			this.ddiOpsStation.Size = new System.Drawing.Size(148, 22);
			this.ddiOpsStation.Text = "站址表設定";
			this.ddiOpsStation.Click += new System.EventHandler(this.ddiOpsStation_Click);
			// 
			// ddiOpsStdSchdl
			// 
			this.ddiOpsStdSchdl.Name = "ddiOpsStdSchdl";
			this.ddiOpsStdSchdl.Size = new System.Drawing.Size(148, 22);
			this.ddiOpsStdSchdl.Text = "標準班表維護";
			this.ddiOpsStdSchdl.Click += new System.EventHandler(this.ddiOpsStdSchdl_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
			// 
			// ddiOpsVacations
			// 
			this.ddiOpsVacations.Name = "ddiOpsVacations";
			this.ddiOpsVacations.Size = new System.Drawing.Size(148, 22);
			this.ddiOpsVacations.Text = "寒暑假設定";
			this.ddiOpsVacations.Click += new System.EventHandler(this.ddiOpsVacations_Click);
			// 
			// ddiOpsHoliday
			// 
			this.ddiOpsHoliday.Name = "ddiOpsHoliday";
			this.ddiOpsHoliday.Size = new System.Drawing.Size(148, 22);
			this.ddiOpsHoliday.Text = "國定假日設定";
			this.ddiOpsHoliday.Click += new System.EventHandler(this.ddiOpsHoliday_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
			// 
			// ddiOpsClose
			// 
			this.ddiOpsClose.Name = "ddiOpsClose";
			this.ddiOpsClose.Size = new System.Drawing.Size(148, 22);
			this.ddiOpsClose.Text = "結束系統";
			this.ddiOpsClose.Click += new System.EventHandler(this.ddiOpsClose_Click);
			// 
			// muiQualified
			// 
			this.muiQualified.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddiOpsDailySchdlImp,
            this.toolStripSeparator4,
            this.ddiOpsDynamicImp,
            this.ddiOpsTicketProof,
            this.ddiOpsDrivingProof,
            this.toolStripSeparator5});
			this.muiQualified.Name = "muiQualified";
			this.muiQualified.Size = new System.Drawing.Size(68, 20);
			this.muiQualified.Text = "佐證作業";
			// 
			// ddiOpsDailySchdlImp
			// 
			this.ddiOpsDailySchdlImp.Name = "ddiOpsDailySchdlImp";
			this.ddiOpsDailySchdlImp.Size = new System.Drawing.Size(172, 22);
			this.ddiOpsDailySchdlImp.Text = "路線每日班表維護";
			this.ddiOpsDailySchdlImp.Click += new System.EventHandler(this.ddiOpsDailySchdlImp_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(169, 6);
			// 
			// ddiOpsDynamicImp
			// 
			this.ddiOpsDynamicImp.Name = "ddiOpsDynamicImp";
			this.ddiOpsDynamicImp.Size = new System.Drawing.Size(172, 22);
			this.ddiOpsDynamicImp.Text = "動態合格資料匯入";
			this.ddiOpsDynamicImp.Click += new System.EventHandler(this.ddiOpsDynamicImp_Click);
			// 
			// ddiOpsTicketProof
			// 
			this.ddiOpsTicketProof.Name = "ddiOpsTicketProof";
			this.ddiOpsTicketProof.Size = new System.Drawing.Size(172, 22);
			this.ddiOpsTicketProof.Text = "票證資料匯入";
			this.ddiOpsTicketProof.Click += new System.EventHandler(this.ddiOpsTicketProof_Click);
			// 
			// ddiOpsDrivingProof
			// 
			this.ddiOpsDrivingProof.Name = "ddiOpsDrivingProof";
			this.ddiOpsDrivingProof.Size = new System.Drawing.Size(172, 22);
			this.ddiOpsDrivingProof.Text = "軌跡佐證資料維護";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(169, 6);
			// 
			// muiReport
			// 
			this.muiReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EKReport,
            this.Dynamiclmp_Report,
            this.Tick_Repoer,
            this.不合格報表ToolStripMenuItem,
            this.月總表ToolStripMenuItem,
            this.電子票證附件ToolStripMenuItem});
			this.muiReport.Name = "muiReport";
			this.muiReport.Size = new System.Drawing.Size(68, 20);
			this.muiReport.Text = "報表作業";
			// 
			// EKReport
			// 
			this.EKReport.Name = "EKReport";
			this.EKReport.Size = new System.Drawing.Size(152, 22);
			this.EKReport.Text = "延人公里報表";
			this.EKReport.Click += new System.EventHandler(this.EKReport_Click);
			// 
			// Dynamiclmp_Report
			// 
			this.Dynamiclmp_Report.Name = "Dynamiclmp_Report";
			this.Dynamiclmp_Report.Size = new System.Drawing.Size(152, 22);
			this.Dynamiclmp_Report.Text = "動態作證報表";
			this.Dynamiclmp_Report.Click += new System.EventHandler(this.Dynamiclmp_Report_Click);
			// 
			// Tick_Repoer
			// 
			this.Tick_Repoer.Name = "Tick_Repoer";
			this.Tick_Repoer.Size = new System.Drawing.Size(152, 22);
			this.Tick_Repoer.Text = "票證佐證報表";
			// 
			// 不合格報表ToolStripMenuItem
			// 
			this.不合格報表ToolStripMenuItem.Name = "不合格報表ToolStripMenuItem";
			this.不合格報表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.不合格報表ToolStripMenuItem.Text = "不合格報表";
			this.不合格報表ToolStripMenuItem.Click += new System.EventHandler(this.ddiFailedTable_Click);
			// 
			// 月總表ToolStripMenuItem
			// 
			this.月總表ToolStripMenuItem.Name = "月總表ToolStripMenuItem";
			this.月總表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.月總表ToolStripMenuItem.Text = "月總表";
			// 
			// 電子票證附件ToolStripMenuItem
			// 
			this.電子票證附件ToolStripMenuItem.Name = "電子票證附件ToolStripMenuItem";
			this.電子票證附件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.電子票證附件ToolStripMenuItem.Text = "電子票證附件";
			// 
			// muiAdmin
			// 
			this.muiAdmin.Name = "muiAdmin";
			this.muiAdmin.Size = new System.Drawing.Size(68, 20);
			this.muiAdmin.Text = "系統管理";
			// 
			// muiWindows
			// 
			this.muiWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddiCascad,
            this.toolStripSeparator6,
            this.ddiAbout});
			this.muiWindows.Name = "muiWindows";
			this.muiWindows.Size = new System.Drawing.Size(44, 20);
			this.muiWindows.Text = "視窗";
			// 
			// ddiCascad
			// 
			this.ddiCascad.Name = "ddiCascad";
			this.ddiCascad.Size = new System.Drawing.Size(124, 22);
			this.ddiCascad.Text = "重疊顯示";
			this.ddiCascad.Click += new System.EventHandler(this.ddiCascad_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(121, 6);
			// 
			// ddiAbout
			// 
			this.ddiAbout.Name = "ddiAbout";
			this.ddiAbout.Size = new System.Drawing.Size(124, 22);
			this.ddiAbout.Text = "關於";
			this.ddiAbout.Click += new System.EventHandler(this.ddiAbout_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DesingerLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 719);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// DesingerLabel
			// 
			this.DesingerLabel.Name = "DesingerLabel";
			this.DesingerLabel.Size = new System.Drawing.Size(180, 17);
			this.DesingerLabel.Text = "System Desinger : Harold Sheu";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 741);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmMain";
			this.Text = "車公里補貼管理系統";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem muiBase;
        private System.Windows.Forms.ToolStripMenuItem ddiOpsCorps;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ddiOpsRoute;
        private System.Windows.Forms.ToolStripMenuItem ddiOpsStdSchdl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ddiOpsVacations;
        private System.Windows.Forms.ToolStripMenuItem ddiOpsHoliday;
        private System.Windows.Forms.ToolStripMenuItem ddiOpsClose;
        private System.Windows.Forms.ToolStripMenuItem muiQualified;
        private System.Windows.Forms.ToolStripMenuItem ddiOpsDailySchdlImp;
        private System.Windows.Forms.ToolStripMenuItem ddiOpsDynamicImp;
        private System.Windows.Forms.ToolStripMenuItem ddiOpsTicketProof;
        private System.Windows.Forms.ToolStripMenuItem muiReport;
        private System.Windows.Forms.ToolStripMenuItem muiAdmin;
        private System.Windows.Forms.ToolStripMenuItem muiWindows;
        private System.Windows.Forms.ToolStripMenuItem ddiCascad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel DesingerLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ddiOpsDrivingProof;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ddiAbout;
        private System.Windows.Forms.ToolStripMenuItem EKReport;
        private System.Windows.Forms.ToolStripMenuItem Dynamiclmp_Report;
        private System.Windows.Forms.ToolStripMenuItem Tick_Repoer;
        private System.Windows.Forms.ToolStripMenuItem ddiOpsStation;
		private System.Windows.Forms.ToolStripMenuItem 不合格報表ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 月總表ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 電子票證附件ToolStripMenuItem;
	}
}

