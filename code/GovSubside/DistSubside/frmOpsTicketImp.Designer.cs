namespace DistSubside
{
    partial class frmOpsTicketImp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFileCSV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowTimeRange = new System.Windows.Forms.Label();
            this.ComboForRoute = new System.Windows.Forms.ComboBox();
            this.DamgerImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(932, 419);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1029, 419);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 341);
            this.dataGridView1.TabIndex = 11;
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(15, 41);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(1101, 23);
            this.txtFileName.TabIndex = 10;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(0, 0);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectFileCSV
            // 
            this.btnSelectFileCSV.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectFileCSV.Location = new System.Drawing.Point(119, 7);
            this.btnSelectFileCSV.Name = "btnSelectFileCSV";
            this.btnSelectFileCSV.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFileCSV.TabIndex = 15;
            this.btnSelectFileCSV.Text = "選擇檔案";
            this.btnSelectFileCSV.UseVisualStyleBackColor = true;
            this.btnSelectFileCSV.Click += new System.EventHandler(this.btnSelectFileCSV_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(18, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = ".csv格式匯入：";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(200, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // ShowTimeRange
            // 
            this.ShowTimeRange.AutoSize = true;
            this.ShowTimeRange.Location = new System.Drawing.Point(201, 13);
            this.ShowTimeRange.Name = "ShowTimeRange";
            this.ShowTimeRange.Size = new System.Drawing.Size(42, 15);
            this.ShowTimeRange.TabIndex = 24;
            this.ShowTimeRange.Text = "label4";
            // 
            // ComboForRoute
            // 
            this.ComboForRoute.FormattingEnabled = true;
            this.ComboForRoute.Location = new System.Drawing.Point(379, 7);
            this.ComboForRoute.Name = "ComboForRoute";
            this.ComboForRoute.Size = new System.Drawing.Size(121, 23);
            this.ComboForRoute.TabIndex = 25;
            // 
            // DamgerImport
            // 
            this.DamgerImport.BackColor = System.Drawing.Color.Red;
            this.DamgerImport.Location = new System.Drawing.Point(985, 10);
            this.DamgerImport.Name = "DamgerImport";
            this.DamgerImport.Size = new System.Drawing.Size(131, 23);
            this.DamgerImport.TabIndex = 26;
            this.DamgerImport.Text = "匯入多筆資料(危險)";
            this.DamgerImport.UseVisualStyleBackColor = false;
            this.DamgerImport.Click += new System.EventHandler(this.DamgerImport_Click);
            // 
            // frmOpsTicketImp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1128, 456);
            this.Controls.Add(this.DamgerImport);
            this.Controls.Add(this.ComboForRoute);
            this.Controls.Add(this.ShowTimeRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectFileCSV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmOpsTicketImp";
            this.Text = "票證資料匯入";
            this.Load += new System.EventHandler(this.frmOpsTicketImp_Load);
            this.Controls.SetChildIndex(this.btnConfirm, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSelectFile, 0);
            this.Controls.SetChildIndex(this.txtFileName, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnSelectFileCSV, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ShowTimeRange, 0);
            this.Controls.SetChildIndex(this.ComboForRoute, 0);
            this.Controls.SetChildIndex(this.DamgerImport, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectFileCSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ShowTimeRange;
        private System.Windows.Forms.ComboBox ComboForRoute;
        private System.Windows.Forms.Button DamgerImport;
    }
}
