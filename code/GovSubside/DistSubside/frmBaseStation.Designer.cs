namespace DistSubside
{
    partial class frmBaseStation
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
            this.Station_DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Route_ID_CB = new System.Windows.Forms.ComboBox();
            this.ShowRouteStation_BT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Route_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SEQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Station_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Go_Km = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Back_Km = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Insert_BT = new System.Windows.Forms.Button();
            this.Update_BT = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Start_Time = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.End_Time = new System.Windows.Forms.TextBox();
            this.Clean_BT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Station_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Station_DataGridView
            // 
            this.Station_DataGridView.AllowUserToAddRows = false;
            this.Station_DataGridView.AllowUserToDeleteRows = false;
            this.Station_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Station_DataGridView.Location = new System.Drawing.Point(12, 32);
            this.Station_DataGridView.Name = "Station_DataGridView";
            this.Station_DataGridView.ReadOnly = true;
            this.Station_DataGridView.RowTemplate.Height = 24;
            this.Station_DataGridView.Size = new System.Drawing.Size(545, 320);
            this.Station_DataGridView.TabIndex = 0;
            this.Station_DataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Station_DataGridView_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "先選擇路線：";
            // 
            // Route_ID_CB
            // 
            this.Route_ID_CB.FormattingEnabled = true;
            this.Route_ID_CB.Location = new System.Drawing.Point(86, 5);
            this.Route_ID_CB.Name = "Route_ID_CB";
            this.Route_ID_CB.Size = new System.Drawing.Size(121, 20);
            this.Route_ID_CB.TabIndex = 2;
            // 
            // ShowRouteStation_BT
            // 
            this.ShowRouteStation_BT.Location = new System.Drawing.Point(213, 3);
            this.ShowRouteStation_BT.Name = "ShowRouteStation_BT";
            this.ShowRouteStation_BT.Size = new System.Drawing.Size(112, 23);
            this.ShowRouteStation_BT.TabIndex = 3;
            this.ShowRouteStation_BT.Text = "顯示該路線的站址";
            this.ShowRouteStation_BT.UseVisualStyleBackColor = true;
            this.ShowRouteStation_BT.Click += new System.EventHandler(this.ShowRouteStation_BT_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 2);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "路線ID";
            // 
            // Route_ID
            // 
            this.Route_ID.Location = new System.Drawing.Point(14, 385);
            this.Route_ID.Name = "Route_ID";
            this.Route_ID.Size = new System.Drawing.Size(100, 22);
            this.Route_ID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "站序";
            // 
            // SEQ
            // 
            this.SEQ.Location = new System.Drawing.Point(14, 429);
            this.SEQ.Name = "SEQ";
            this.SEQ.Size = new System.Drawing.Size(100, 22);
            this.SEQ.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "站牌名稱";
            // 
            // Station_Name
            // 
            this.Station_Name.Location = new System.Drawing.Point(14, 474);
            this.Station_Name.Name = "Station_Name";
            this.Station_Name.Size = new System.Drawing.Size(100, 22);
            this.Station_Name.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(120, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 136);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "去程時與上一站的距離";
            // 
            // Go_Km
            // 
            this.Go_Km.Location = new System.Drawing.Point(131, 388);
            this.Go_Km.Name = "Go_Km";
            this.Go_Km.Size = new System.Drawing.Size(100, 22);
            this.Go_Km.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "回程時與上一站的距離";
            // 
            // Back_Km
            // 
            this.Back_Km.Location = new System.Drawing.Point(131, 429);
            this.Back_Km.Name = "Back_Km";
            this.Back_Km.Size = new System.Drawing.Size(100, 22);
            this.Back_Km.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(257, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 136);
            this.label9.TabIndex = 16;
            // 
            // Insert_BT
            // 
            this.Insert_BT.Location = new System.Drawing.Point(482, 373);
            this.Insert_BT.Name = "Insert_BT";
            this.Insert_BT.Size = new System.Drawing.Size(75, 23);
            this.Insert_BT.TabIndex = 17;
            this.Insert_BT.Text = "新增";
            this.Insert_BT.UseVisualStyleBackColor = true;
            this.Insert_BT.Click += new System.EventHandler(this.Insert_BT_Click);
            // 
            // Update_BT
            // 
            this.Update_BT.Location = new System.Drawing.Point(482, 403);
            this.Update_BT.Name = "Update_BT";
            this.Update_BT.Size = new System.Drawing.Size(75, 23);
            this.Update_BT.TabIndex = 18;
            this.Update_BT.Text = "修改";
            this.Update_BT.UseVisualStyleBackColor = true;
            this.Update_BT.Click += new System.EventHandler(this.Update_BT_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "開始時間";
            // 
            // Start_Time
            // 
            this.Start_Time.Location = new System.Drawing.Point(265, 388);
            this.Start_Time.Name = "Start_Time";
            this.Start_Time.Size = new System.Drawing.Size(100, 22);
            this.Start_Time.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(266, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "結束時間";
            // 
            // End_Time
            // 
            this.End_Time.Location = new System.Drawing.Point(265, 429);
            this.End_Time.Name = "End_Time";
            this.End_Time.Size = new System.Drawing.Size(100, 22);
            this.End_Time.TabIndex = 23;
            // 
            // Clean_BT
            // 
            this.Clean_BT.Location = new System.Drawing.Point(482, 432);
            this.Clean_BT.Name = "Clean_BT";
            this.Clean_BT.Size = new System.Drawing.Size(75, 23);
            this.Clean_BT.TabIndex = 24;
            this.Clean_BT.Text = "清空輸入格";
            this.Clean_BT.UseVisualStyleBackColor = true;
            this.Clean_BT.Click += new System.EventHandler(this.Clean_BT_Click);
            // 
            // frmBaseStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 507);
            this.Controls.Add(this.Clean_BT);
            this.Controls.Add(this.End_Time);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Start_Time);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Update_BT);
            this.Controls.Add(this.Insert_BT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Back_Km);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Go_Km);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Station_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SEQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Route_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowRouteStation_BT);
            this.Controls.Add(this.Route_ID_CB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Station_DataGridView);
            this.Name = "frmBaseStation";
            this.Text = "站址表維護";
            this.Load += new System.EventHandler(this.frmBaseStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Station_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Station_DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Route_ID_CB;
        private System.Windows.Forms.Button ShowRouteStation_BT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Route_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SEQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Station_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Go_Km;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Back_Km;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Insert_BT;
        private System.Windows.Forms.Button Update_BT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Start_Time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox End_Time;
        private System.Windows.Forms.Button Clean_BT;
    }
}