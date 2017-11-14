namespace DistSubside
{
    partial class frmBaseRoute
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
            this.MyDataGirdView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.RouteID_TB = new System.Windows.Forms.TextBox();
            this.RouteTicket_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupCode_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RouteName_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RouteDynamic_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StationStart_TB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StationMid_TB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StationEnd_TB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GoLength_TB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BackLength_TB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CostTime_TB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WCount_TB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HCount_TB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.AddRoute_BTN = new System.Windows.Forms.Button();
            this.UpDateRoute_BTN = new System.Windows.Forms.Button();
            this.StartTime_DTP = new System.Windows.Forms.TextBox();
            this.EndTime_DTP = new System.Windows.Forms.TextBox();
            this.CoID_CB = new System.Windows.Forms.TextBox();
            this.IsLoop_CB = new System.Windows.Forms.TextBox();
            this.CleanUI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGirdView)).BeginInit();
            this.SuspendLayout();
            // 
            // MyDataGirdView
            // 
            this.MyDataGirdView.AllowUserToAddRows = false;
            this.MyDataGirdView.AllowUserToDeleteRows = false;
            this.MyDataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyDataGirdView.Location = new System.Drawing.Point(12, 12);
            this.MyDataGirdView.Name = "MyDataGirdView";
            this.MyDataGirdView.ReadOnly = true;
            this.MyDataGirdView.RowTemplate.Height = 24;
            this.MyDataGirdView.Size = new System.Drawing.Size(897, 198);
            this.MyDataGirdView.TabIndex = 0;
            this.MyDataGirdView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MyDataGirdView_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "路線代碼";
            // 
            // RouteID_TB
            // 
            this.RouteID_TB.Location = new System.Drawing.Point(12, 228);
            this.RouteID_TB.Name = "RouteID_TB";
            this.RouteID_TB.Size = new System.Drawing.Size(100, 22);
            this.RouteID_TB.TabIndex = 2;
            // 
            // RouteTicket_TB
            // 
            this.RouteTicket_TB.Location = new System.Drawing.Point(12, 268);
            this.RouteTicket_TB.Name = "RouteTicket_TB";
            this.RouteTicket_TB.Size = new System.Drawing.Size(100, 22);
            this.RouteTicket_TB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "票證資料對應用代碼";
            // 
            // GroupCode_TB
            // 
            this.GroupCode_TB.Location = new System.Drawing.Point(12, 309);
            this.GroupCode_TB.Name = "GroupCode_TB";
            this.GroupCode_TB.Size = new System.Drawing.Size(100, 22);
            this.GroupCode_TB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "路線的群組代碼";
            // 
            // RouteName_TB
            // 
            this.RouteName_TB.Location = new System.Drawing.Point(12, 349);
            this.RouteName_TB.Name = "RouteName_TB";
            this.RouteName_TB.Size = new System.Drawing.Size(100, 22);
            this.RouteName_TB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "路線名稱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "動態資料對應用的名稱";
            // 
            // RouteDynamic_TB
            // 
            this.RouteDynamic_TB.Location = new System.Drawing.Point(12, 387);
            this.RouteDynamic_TB.Name = "RouteDynamic_TB";
            this.RouteDynamic_TB.Size = new System.Drawing.Size(100, 22);
            this.RouteDynamic_TB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(137, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 200);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "路線起站";
            // 
            // StationStart_TB
            // 
            this.StationStart_TB.Location = new System.Drawing.Point(145, 228);
            this.StationStart_TB.Name = "StationStart_TB";
            this.StationStart_TB.Size = new System.Drawing.Size(100, 22);
            this.StationStart_TB.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "路線中間站";
            // 
            // StationMid_TB
            // 
            this.StationMid_TB.Location = new System.Drawing.Point(145, 268);
            this.StationMid_TB.Name = "StationMid_TB";
            this.StationMid_TB.Size = new System.Drawing.Size(100, 22);
            this.StationMid_TB.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "路線終點站";
            // 
            // StationEnd_TB
            // 
            this.StationEnd_TB.Location = new System.Drawing.Point(145, 308);
            this.StationEnd_TB.Name = "StationEnd_TB";
            this.StationEnd_TB.Size = new System.Drawing.Size(100, 22);
            this.StationEnd_TB.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(253, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(2, 200);
            this.label10.TabIndex = 18;
            // 
            // GoLength_TB
            // 
            this.GoLength_TB.Location = new System.Drawing.Point(145, 349);
            this.GoLength_TB.Name = "GoLength_TB";
            this.GoLength_TB.Size = new System.Drawing.Size(100, 22);
            this.GoLength_TB.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "去程路線長度(Km)";
            // 
            // BackLength_TB
            // 
            this.BackLength_TB.Location = new System.Drawing.Point(145, 389);
            this.BackLength_TB.Name = "BackLength_TB";
            this.BackLength_TB.Size = new System.Drawing.Size(100, 22);
            this.BackLength_TB.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "回程路線長度(Km)";
            // 
            // CostTime_TB
            // 
            this.CostTime_TB.Location = new System.Drawing.Point(261, 228);
            this.CostTime_TB.Name = "CostTime_TB";
            this.CostTime_TB.Size = new System.Drawing.Size(100, 22);
            this.CostTime_TB.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "每趟行駛時間(min)";
            // 
            // WCount_TB
            // 
            this.WCount_TB.Location = new System.Drawing.Point(261, 268);
            this.WCount_TB.Name = "WCount_TB";
            this.WCount_TB.Size = new System.Drawing.Size(100, 22);
            this.WCount_TB.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(261, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "平日班次";
            // 
            // HCount_TB
            // 
            this.HCount_TB.Location = new System.Drawing.Point(261, 309);
            this.HCount_TB.Name = "HCount_TB";
            this.HCount_TB.Size = new System.Drawing.Size(100, 22);
            this.HCount_TB.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(261, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 27;
            this.label15.Text = "假日班次";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(261, 334);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 29;
            this.label16.Text = "是否為循環";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(376, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(2, 200);
            this.label17.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(385, 217);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 32;
            this.label18.Text = "公司代碼";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(385, 253);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 35;
            this.label19.Text = "營運日期";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(385, 294);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 37;
            this.label20.Text = "停駛日期";
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(519, 216);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(2, 200);
            this.label21.TabIndex = 38;
            // 
            // AddRoute_BTN
            // 
            this.AddRoute_BTN.Location = new System.Drawing.Point(773, 217);
            this.AddRoute_BTN.Name = "AddRoute_BTN";
            this.AddRoute_BTN.Size = new System.Drawing.Size(136, 54);
            this.AddRoute_BTN.TabIndex = 39;
            this.AddRoute_BTN.Text = "新增";
            this.AddRoute_BTN.UseVisualStyleBackColor = true;
            this.AddRoute_BTN.Click += new System.EventHandler(this.AddRoute_BTN_Click);
            // 
            // UpDateRoute_BTN
            // 
            this.UpDateRoute_BTN.Location = new System.Drawing.Point(773, 277);
            this.UpDateRoute_BTN.Name = "UpDateRoute_BTN";
            this.UpDateRoute_BTN.Size = new System.Drawing.Size(136, 54);
            this.UpDateRoute_BTN.TabIndex = 40;
            this.UpDateRoute_BTN.Text = "修改";
            this.UpDateRoute_BTN.UseVisualStyleBackColor = true;
            this.UpDateRoute_BTN.Click += new System.EventHandler(this.UpDateRoute_BTN_Click);
            // 
            // StartTime_DTP
            // 
            this.StartTime_DTP.Location = new System.Drawing.Point(387, 269);
            this.StartTime_DTP.Name = "StartTime_DTP";
            this.StartTime_DTP.Size = new System.Drawing.Size(126, 22);
            this.StartTime_DTP.TabIndex = 41;
            // 
            // EndTime_DTP
            // 
            this.EndTime_DTP.Location = new System.Drawing.Point(387, 308);
            this.EndTime_DTP.Name = "EndTime_DTP";
            this.EndTime_DTP.Size = new System.Drawing.Size(126, 22);
            this.EndTime_DTP.TabIndex = 42;
            // 
            // CoID_CB
            // 
            this.CoID_CB.Location = new System.Drawing.Point(387, 227);
            this.CoID_CB.Name = "CoID_CB";
            this.CoID_CB.Size = new System.Drawing.Size(126, 22);
            this.CoID_CB.TabIndex = 43;
            // 
            // IsLoop_CB
            // 
            this.IsLoop_CB.Location = new System.Drawing.Point(261, 349);
            this.IsLoop_CB.Name = "IsLoop_CB";
            this.IsLoop_CB.Size = new System.Drawing.Size(100, 22);
            this.IsLoop_CB.TabIndex = 44;
            // 
            // CleanUI
            // 
            this.CleanUI.Location = new System.Drawing.Point(773, 337);
            this.CleanUI.Name = "CleanUI";
            this.CleanUI.Size = new System.Drawing.Size(136, 54);
            this.CleanUI.TabIndex = 45;
            this.CleanUI.Text = "清空文字";
            this.CleanUI.UseVisualStyleBackColor = true;
            this.CleanUI.Click += new System.EventHandler(this.CleanUI_Click);
            // 
            // frmBaseRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 420);
            this.Controls.Add(this.CleanUI);
            this.Controls.Add(this.IsLoop_CB);
            this.Controls.Add(this.CoID_CB);
            this.Controls.Add(this.EndTime_DTP);
            this.Controls.Add(this.StartTime_DTP);
            this.Controls.Add(this.UpDateRoute_BTN);
            this.Controls.Add(this.AddRoute_BTN);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.HCount_TB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.WCount_TB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CostTime_TB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BackLength_TB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.GoLength_TB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StationEnd_TB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StationMid_TB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StationStart_TB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RouteDynamic_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RouteName_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GroupCode_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RouteTicket_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RouteID_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyDataGirdView);
            this.Name = "frmBaseRoute";
            this.Text = "frmBaseRoute";
            this.Load += new System.EventHandler(this.frmBaseRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGirdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MyDataGirdView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RouteID_TB;
        private System.Windows.Forms.TextBox RouteTicket_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GroupCode_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RouteName_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RouteDynamic_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StationStart_TB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StationMid_TB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StationEnd_TB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox GoLength_TB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BackLength_TB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CostTime_TB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WCount_TB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox HCount_TB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button AddRoute_BTN;
        private System.Windows.Forms.Button UpDateRoute_BTN;
        private System.Windows.Forms.TextBox StartTime_DTP;
        private System.Windows.Forms.TextBox EndTime_DTP;
        private System.Windows.Forms.TextBox CoID_CB;
        private System.Windows.Forms.TextBox IsLoop_CB;
        private System.Windows.Forms.Button CleanUI;
    }
}