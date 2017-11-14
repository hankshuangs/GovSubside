namespace DistSubside
{
    partial class frmBaseStdSchedule
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
            this.Route_CB = new System.Windows.Forms.ComboBox();
            this.MyDataView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.GoBack_CB = new System.Windows.Forms.ComboBox();
            this.CreateData_BT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "路線：";
            // 
            // Route_CB
            // 
            this.Route_CB.FormattingEnabled = true;
            this.Route_CB.Location = new System.Drawing.Point(60, 10);
            this.Route_CB.Name = "Route_CB";
            this.Route_CB.Size = new System.Drawing.Size(121, 20);
            this.Route_CB.TabIndex = 1;
            // 
            // MyDataView
            // 
            this.MyDataView.AllowUserToAddRows = false;
            this.MyDataView.AllowUserToDeleteRows = false;
            this.MyDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyDataView.Location = new System.Drawing.Point(15, 36);
            this.MyDataView.Name = "MyDataView";
            this.MyDataView.ReadOnly = true;
            this.MyDataView.RowTemplate.Height = 24;
            this.MyDataView.Size = new System.Drawing.Size(858, 356);
            this.MyDataView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "去回程：";
            // 
            // GoBack_CB
            // 
            this.GoBack_CB.FormattingEnabled = true;
            this.GoBack_CB.Items.AddRange(new object[] {
            "去程",
            "回程"});
            this.GoBack_CB.Location = new System.Drawing.Point(246, 10);
            this.GoBack_CB.Name = "GoBack_CB";
            this.GoBack_CB.Size = new System.Drawing.Size(121, 20);
            this.GoBack_CB.TabIndex = 4;
            // 
            // CreateData_BT
            // 
            this.CreateData_BT.Location = new System.Drawing.Point(373, 7);
            this.CreateData_BT.Name = "CreateData_BT";
            this.CreateData_BT.Size = new System.Drawing.Size(75, 23);
            this.CreateData_BT.TabIndex = 5;
            this.CreateData_BT.Text = "產生";
            this.CreateData_BT.UseVisualStyleBackColor = true;
            this.CreateData_BT.Click += new System.EventHandler(this.CreateData_BT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(665, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "很抱歉，如果有新增、刪除、修改、等等資訊要調整，請聯絡資訊室，這邊如果改錯了可能導致整個系統無法運作，還請包涵";
            // 
            // frmBaseStdSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 420);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateData_BT);
            this.Controls.Add(this.GoBack_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MyDataView);
            this.Controls.Add(this.Route_CB);
            this.Controls.Add(this.label1);
            this.Name = "frmBaseStdSchedule";
            this.Text = "標準班表維護";
            this.Load += new System.EventHandler(this.frmBaseStdSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Route_CB;
        private System.Windows.Forms.DataGridView MyDataView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GoBack_CB;
        private System.Windows.Forms.Button CreateData_BT;
        private System.Windows.Forms.Label label3;
    }
}