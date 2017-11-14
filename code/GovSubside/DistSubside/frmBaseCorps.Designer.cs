namespace DistSubside
{
    partial class frmBaseCorps
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
            this.MyDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Company_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Company_Full_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Company_Short_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Company_EIN = new System.Windows.Forms.TextBox();
            this.AddBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.UpDateBTN = new System.Windows.Forms.Button();
            this.CleanBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MyDataGridView
            // 
            this.MyDataGridView.AllowUserToAddRows = false;
            this.MyDataGridView.AllowUserToDeleteRows = false;
            this.MyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyDataGridView.Location = new System.Drawing.Point(13, 13);
            this.MyDataGridView.Name = "MyDataGridView";
            this.MyDataGridView.ReadOnly = true;
            this.MyDataGridView.RowTemplate.Height = 24;
            this.MyDataGridView.Size = new System.Drawing.Size(465, 345);
            this.MyDataGridView.TabIndex = 0;
            this.MyDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MyDataGridView_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "公司代號";
            // 
            // Company_Code
            // 
            this.Company_Code.Location = new System.Drawing.Point(488, 33);
            this.Company_Code.Name = "Company_Code";
            this.Company_Code.Size = new System.Drawing.Size(238, 27);
            this.Company_Code.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "公司全名";
            // 
            // Company_Full_Name
            // 
            this.Company_Full_Name.Location = new System.Drawing.Point(488, 83);
            this.Company_Full_Name.Name = "Company_Full_Name";
            this.Company_Full_Name.Size = new System.Drawing.Size(238, 27);
            this.Company_Full_Name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "公司縮寫";
            // 
            // Company_Short_Name
            // 
            this.Company_Short_Name.Location = new System.Drawing.Point(491, 137);
            this.Company_Short_Name.Name = "Company_Short_Name";
            this.Company_Short_Name.Size = new System.Drawing.Size(235, 27);
            this.Company_Short_Name.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "統一編號";
            // 
            // Company_EIN
            // 
            this.Company_EIN.Location = new System.Drawing.Point(491, 191);
            this.Company_EIN.Name = "Company_EIN";
            this.Company_EIN.Size = new System.Drawing.Size(235, 27);
            this.Company_EIN.TabIndex = 8;
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(488, 224);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(75, 29);
            this.AddBTN.TabIndex = 9;
            this.AddBTN.Text = "新增";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(488, 259);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 29);
            this.DeleteBTN.TabIndex = 10;
            this.DeleteBTN.Text = "刪除";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // UpDateBTN
            // 
            this.UpDateBTN.Location = new System.Drawing.Point(488, 294);
            this.UpDateBTN.Name = "UpDateBTN";
            this.UpDateBTN.Size = new System.Drawing.Size(75, 29);
            this.UpDateBTN.TabIndex = 11;
            this.UpDateBTN.Text = "修改";
            this.UpDateBTN.UseVisualStyleBackColor = true;
            this.UpDateBTN.Click += new System.EventHandler(this.UpDateBTN_Click);
            // 
            // CleanBTN
            // 
            this.CleanBTN.Location = new System.Drawing.Point(488, 329);
            this.CleanBTN.Name = "CleanBTN";
            this.CleanBTN.Size = new System.Drawing.Size(88, 29);
            this.CleanBTN.TabIndex = 13;
            this.CleanBTN.Text = "清空欄位";
            this.CleanBTN.UseVisualStyleBackColor = true;
            this.CleanBTN.Click += new System.EventHandler(this.CleanBTN_Click);
            // 
            // frmBaseCorps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 366);
            this.Controls.Add(this.CleanBTN);
            this.Controls.Add(this.UpDateBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.Company_EIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Company_Short_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Company_Full_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Company_Code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyDataGridView);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaseCorps";
            this.Text = "公司資料維護";
            this.Load += new System.EventHandler(this.frmBaseCorps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MyDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Company_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Company_Full_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Company_Short_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Company_EIN;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button UpDateBTN;
        private System.Windows.Forms.Button CleanBTN;
    }
}