namespace DistSubside
{
    partial class frmReportDynamiclmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Start_DateTimePick = new System.Windows.Forms.DateTimePicker();
            this.End_DateTimePick = new System.Windows.Forms.DateTimePicker();
            this.Route_ComboBox = new System.Windows.Forms.ComboBox();
            this.Status_ComboBox = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OKBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "結束日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "選擇路線";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "狀態";
            // 
            // Start_DateTimePick
            // 
            this.Start_DateTimePick.Location = new System.Drawing.Point(14, 24);
            this.Start_DateTimePick.Name = "Start_DateTimePick";
            this.Start_DateTimePick.Size = new System.Drawing.Size(121, 22);
            this.Start_DateTimePick.TabIndex = 4;
            this.Start_DateTimePick.Value = new System.DateTime(2017, 7, 27, 0, 0, 0, 0);
            // 
            // End_DateTimePick
            // 
            this.End_DateTimePick.Location = new System.Drawing.Point(14, 64);
            this.End_DateTimePick.Name = "End_DateTimePick";
            this.End_DateTimePick.Size = new System.Drawing.Size(121, 22);
            this.End_DateTimePick.TabIndex = 5;
            this.End_DateTimePick.Value = new System.DateTime(2017, 6, 30, 0, 0, 0, 0);
            // 
            // Route_ComboBox
            // 
            this.Route_ComboBox.FormattingEnabled = true;
            this.Route_ComboBox.Location = new System.Drawing.Point(14, 104);
            this.Route_ComboBox.Name = "Route_ComboBox";
            this.Route_ComboBox.Size = new System.Drawing.Size(121, 20);
            this.Route_ComboBox.TabIndex = 6;
            // 
            // Status_ComboBox
            // 
            this.Status_ComboBox.FormattingEnabled = true;
            this.Status_ComboBox.Items.AddRange(new object[] {
            "動態驗證成功",
            "非動態驗證",
            "混和模式"});
            this.Status_ComboBox.Location = new System.Drawing.Point(14, 142);
            this.Status_ComboBox.Name = "Status_ComboBox";
            this.Status_ComboBox.Size = new System.Drawing.Size(121, 20);
            this.Status_ComboBox.TabIndex = 7;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(141, 9);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(691, 440);
            this.reportViewer1.TabIndex = 8;
            // 
            // OKBTN
            // 
            this.OKBTN.Location = new System.Drawing.Point(12, 426);
            this.OKBTN.Name = "OKBTN";
            this.OKBTN.Size = new System.Drawing.Size(123, 23);
            this.OKBTN.TabIndex = 9;
            this.OKBTN.Text = "產生報表";
            this.OKBTN.UseVisualStyleBackColor = true;
            this.OKBTN.Click += new System.EventHandler(this.OKBTN_Click);
            // 
            // frmReportDynamiclmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 461);
            this.Controls.Add(this.OKBTN);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Status_ComboBox);
            this.Controls.Add(this.Route_ComboBox);
            this.Controls.Add(this.End_DateTimePick);
            this.Controls.Add(this.Start_DateTimePick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReportDynamiclmp";
            this.Text = "frmReportDynamiclmp";
            this.Load += new System.EventHandler(this.frmReportDynamiclmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Start_DateTimePick;
        private System.Windows.Forms.DateTimePicker End_DateTimePick;
        private System.Windows.Forms.ComboBox Route_ComboBox;
        private System.Windows.Forms.ComboBox Status_ComboBox;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button OKBTN;
    }
}