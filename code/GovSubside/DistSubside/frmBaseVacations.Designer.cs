﻿namespace DistSubside
{
    partial class frmBaseVacations
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
            this.Year_TB = new System.Windows.Forms.TextBox();
            this.SummerST_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SummerED_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WinterED_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WinterST_TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Insert_BT = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(412, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "年份";
            // 
            // Year_TB
            // 
            this.Year_TB.Location = new System.Drawing.Point(432, 27);
            this.Year_TB.Name = "Year_TB";
            this.Year_TB.Size = new System.Drawing.Size(100, 22);
            this.Year_TB.TabIndex = 2;
            // 
            // SummerST_TB
            // 
            this.SummerST_TB.Location = new System.Drawing.Point(432, 69);
            this.SummerST_TB.Name = "SummerST_TB";
            this.SummerST_TB.Size = new System.Drawing.Size(100, 22);
            this.SummerST_TB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "暑假開始日期";
            // 
            // SummerED_TB
            // 
            this.SummerED_TB.Location = new System.Drawing.Point(432, 109);
            this.SummerED_TB.Name = "SummerED_TB";
            this.SummerED_TB.Size = new System.Drawing.Size(100, 22);
            this.SummerED_TB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "暑假結束日期";
            // 
            // WinterED_TB
            // 
            this.WinterED_TB.Location = new System.Drawing.Point(432, 189);
            this.WinterED_TB.Name = "WinterED_TB";
            this.WinterED_TB.Size = new System.Drawing.Size(100, 22);
            this.WinterED_TB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "寒假結束日期";
            // 
            // WinterST_TB
            // 
            this.WinterST_TB.Location = new System.Drawing.Point(432, 149);
            this.WinterST_TB.Name = "WinterST_TB";
            this.WinterST_TB.Size = new System.Drawing.Size(100, 22);
            this.WinterST_TB.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "寒假開始日期";
            // 
            // Insert_BT
            // 
            this.Insert_BT.Location = new System.Drawing.Point(432, 217);
            this.Insert_BT.Name = "Insert_BT";
            this.Insert_BT.Size = new System.Drawing.Size(100, 23);
            this.Insert_BT.TabIndex = 13;
            this.Insert_BT.Text = "新增";
            this.Insert_BT.UseVisualStyleBackColor = true;
            this.Insert_BT.Click += new System.EventHandler(this.Insert_BT_Click);
            // 
            // Update_BT
            // 
            this.Update_BT.Location = new System.Drawing.Point(432, 246);
            this.Update_BT.Name = "Update_BT";
            this.Update_BT.Size = new System.Drawing.Size(100, 23);
            this.Update_BT.TabIndex = 14;
            this.Update_BT.Text = "修改";
            this.Update_BT.UseVisualStyleBackColor = true;
            this.Update_BT.Click += new System.EventHandler(this.Update_BT_Click);
            // 
            // Clean_BT
            // 
            this.Clean_BT.Location = new System.Drawing.Point(432, 275);
            this.Clean_BT.Name = "Clean_BT";
            this.Clean_BT.Size = new System.Drawing.Size(100, 23);
            this.Clean_BT.TabIndex = 15;
            this.Clean_BT.Text = "清空";
            this.Clean_BT.UseVisualStyleBackColor = true;
            this.Clean_BT.Click += new System.EventHandler(this.Clean_BT_Click);
            // 
            // frmBaseVacations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 421);
            this.Controls.Add(this.Clean_BT);
            this.Controls.Add(this.Update_BT);
            this.Controls.Add(this.Insert_BT);
            this.Controls.Add(this.WinterED_TB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WinterST_TB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SummerED_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SummerST_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Year_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBaseVacations";
            this.Text = "寒暑假維護";
            this.Load += new System.EventHandler(this.frmBaseVacations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Year_TB;
        private System.Windows.Forms.TextBox SummerST_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SummerED_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WinterED_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WinterST_TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Insert_BT;
        private System.Windows.Forms.Button Update_BT;
        private System.Windows.Forms.Button Clean_BT;
    }
}