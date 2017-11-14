namespace DistSubside
{
    partial class frmOpsDailySchdlImp
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
            this.StartDate = new System.Windows.Forms.Label();
            this.Calendar_Start = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.Calendar_End = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(29, 403);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(126, 403);
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Location = new System.Drawing.Point(86, 13);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(55, 15);
            this.StartDate.TabIndex = 0;
            this.StartDate.Text = "起始日期";
            // 
            // Calendar_Start
            // 
            this.Calendar_Start.Location = new System.Drawing.Point(15, 34);
            this.Calendar_Start.Name = "Calendar_Start";
            this.Calendar_Start.TabIndex = 1;
            this.Calendar_Start.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_Start_DateChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(8, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 2);
            this.label2.TabIndex = 2;
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Location = new System.Drawing.Point(89, 207);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(55, 15);
            this.EndDate.TabIndex = 3;
            this.EndDate.Text = "結束日期";
            // 
            // Calendar_End
            // 
            this.Calendar_End.Location = new System.Drawing.Point(13, 228);
            this.Calendar_End.Name = "Calendar_End";
            this.Calendar_End.TabIndex = 4;
            this.Calendar_End.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_End_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "起始日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "結束日期：";
            // 
            // frmOpsDailySchdlImp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(253, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calendar_End);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calendar_Start);
            this.Controls.Add(this.StartDate);
            this.Name = "frmOpsDailySchdlImp";
            this.Text = "路線每日班表維護";
            this.Load += new System.EventHandler(this.frmOpsDailySchdlImp_Load);
            this.Controls.SetChildIndex(this.StartDate, 0);
            this.Controls.SetChildIndex(this.Calendar_Start, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.EndDate, 0);
            this.Controls.SetChildIndex(this.Calendar_End, 0);
            this.Controls.SetChildIndex(this.btnConfirm, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.MonthCalendar Calendar_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.MonthCalendar Calendar_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
