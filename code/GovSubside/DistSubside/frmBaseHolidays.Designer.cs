namespace DistSubside
{
    partial class frmBaseHolidays
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_TB = new System.Windows.Forms.TextBox();
            this.IsOK_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Insert_BT = new System.Windows.Forms.Button();
            this.Delete_BT = new System.Windows.Forms.Button();
            this.Update_BT = new System.Windows.Forms.Button();
            this.Clean_BT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(373, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "日期";
            // 
            // Date_TB
            // 
            this.Date_TB.Location = new System.Drawing.Point(394, 29);
            this.Date_TB.Name = "Date_TB";
            this.Date_TB.Size = new System.Drawing.Size(147, 22);
            this.Date_TB.TabIndex = 2;
            // 
            // IsOK_TB
            // 
            this.IsOK_TB.Location = new System.Drawing.Point(394, 70);
            this.IsOK_TB.Name = "IsOK_TB";
            this.IsOK_TB.Size = new System.Drawing.Size(147, 22);
            this.IsOK_TB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "是否當成假日處理(1是0不是)";
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(394, 111);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(147, 22);
            this.Name_TB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "描述";
            // 
            // Insert_BT
            // 
            this.Insert_BT.Location = new System.Drawing.Point(394, 256);
            this.Insert_BT.Name = "Insert_BT";
            this.Insert_BT.Size = new System.Drawing.Size(147, 23);
            this.Insert_BT.TabIndex = 7;
            this.Insert_BT.Text = "新增";
            this.Insert_BT.UseVisualStyleBackColor = true;
            this.Insert_BT.Click += new System.EventHandler(this.Insert_BT_Click);
            // 
            // Delete_BT
            // 
            this.Delete_BT.Location = new System.Drawing.Point(394, 285);
            this.Delete_BT.Name = "Delete_BT";
            this.Delete_BT.Size = new System.Drawing.Size(147, 23);
            this.Delete_BT.TabIndex = 8;
            this.Delete_BT.Text = "刪除";
            this.Delete_BT.UseVisualStyleBackColor = true;
            this.Delete_BT.Click += new System.EventHandler(this.Delete_BT_Click);
            // 
            // Update_BT
            // 
            this.Update_BT.Location = new System.Drawing.Point(394, 314);
            this.Update_BT.Name = "Update_BT";
            this.Update_BT.Size = new System.Drawing.Size(147, 23);
            this.Update_BT.TabIndex = 9;
            this.Update_BT.Text = "修改";
            this.Update_BT.UseVisualStyleBackColor = true;
            this.Update_BT.Click += new System.EventHandler(this.Update_BT_Click);
            // 
            // Clean_BT
            // 
            this.Clean_BT.Location = new System.Drawing.Point(394, 343);
            this.Clean_BT.Name = "Clean_BT";
            this.Clean_BT.Size = new System.Drawing.Size(147, 23);
            this.Clean_BT.TabIndex = 10;
            this.Clean_BT.Text = "清空";
            this.Clean_BT.UseVisualStyleBackColor = true;
            this.Clean_BT.Click += new System.EventHandler(this.Clean_BT_Click);
            // 
            // frmBaseHolidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 389);
            this.Controls.Add(this.Clean_BT);
            this.Controls.Add(this.Update_BT);
            this.Controls.Add(this.Delete_BT);
            this.Controls.Add(this.Insert_BT);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IsOK_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBaseHolidays";
            this.Text = "國定假日管理";
            this.Load += new System.EventHandler(this.frmBaseHolidays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Date_TB;
        private System.Windows.Forms.TextBox IsOK_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Insert_BT;
        private System.Windows.Forms.Button Delete_BT;
        private System.Windows.Forms.Button Update_BT;
        private System.Windows.Forms.Button Clean_BT;
    }
}