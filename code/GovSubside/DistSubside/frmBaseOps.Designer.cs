namespace DistSubside
{
    partial class frmBaseOps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseOps));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddNew = new System.Windows.Forms.ToolStripButton();
            this.tsbModify = new System.Windows.Forms.ToolStripButton();
            this.tsbAbandon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbToFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbToPrior = new System.Windows.Forms.ToolStripButton();
            this.tsbToNext = new System.Windows.Forms.ToolStripButton();
            this.tsbToLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddNew,
            this.tsbModify,
            this.tsbAbandon,
            this.toolStripSeparator1,
            this.tsbQuery,
            this.toolStripSeparator2,
            this.tsbToFirst,
            this.tsbToPrior,
            this.tsbToNext,
            this.tsbToLast,
            this.toolStripSeparator3,
            this.tsbImport,
            this.toolStripSeparator4,
            this.tsbPrint,
            this.toolStripSeparator5,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(915, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddNew
            // 
            this.tsbAddNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddNew.Image")));
            this.tsbAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNew.Name = "tsbAddNew";
            this.tsbAddNew.Size = new System.Drawing.Size(35, 35);
            this.tsbAddNew.Text = "新增";
            this.tsbAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAddNew.Click += new System.EventHandler(this.tsbAddNew_Click);
            // 
            // tsbModify
            // 
            this.tsbModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbModify.Image")));
            this.tsbModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModify.Name = "tsbModify";
            this.tsbModify.Size = new System.Drawing.Size(35, 35);
            this.tsbModify.Text = "修改";
            this.tsbModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModify.Click += new System.EventHandler(this.tsbModify_Click);
            // 
            // tsbAbandon
            // 
            this.tsbAbandon.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbandon.Image")));
            this.tsbAbandon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbandon.Name = "tsbAbandon";
            this.tsbAbandon.Size = new System.Drawing.Size(35, 35);
            this.tsbAbandon.Text = "放棄";
            this.tsbAbandon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAbandon.Click += new System.EventHandler(this.tsbAbandon_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuery.Image")));
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(35, 35);
            this.tsbQuery.Text = "查詢";
            this.tsbQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbToFirst
            // 
            this.tsbToFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsbToFirst.Image")));
            this.tsbToFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToFirst.Name = "tsbToFirst";
            this.tsbToFirst.Size = new System.Drawing.Size(35, 35);
            this.tsbToFirst.Text = "首筆";
            this.tsbToFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbToFirst.ToolTipText = "第一筆";
            this.tsbToFirst.Click += new System.EventHandler(this.tsbToFirst_Click);
            // 
            // tsbToPrior
            // 
            this.tsbToPrior.Image = ((System.Drawing.Image)(resources.GetObject("tsbToPrior.Image")));
            this.tsbToPrior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToPrior.Name = "tsbToPrior";
            this.tsbToPrior.Size = new System.Drawing.Size(35, 35);
            this.tsbToPrior.Text = "前筆";
            this.tsbToPrior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbToPrior.ToolTipText = "前一筆";
            this.tsbToPrior.Click += new System.EventHandler(this.tsbToPrior_Click);
            // 
            // tsbToNext
            // 
            this.tsbToNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbToNext.Image")));
            this.tsbToNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToNext.Name = "tsbToNext";
            this.tsbToNext.Size = new System.Drawing.Size(35, 35);
            this.tsbToNext.Text = "次筆";
            this.tsbToNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbToNext.ToolTipText = "下一筆";
            this.tsbToNext.Click += new System.EventHandler(this.tsbToNext_Click);
            // 
            // tsbToLast
            // 
            this.tsbToLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbToLast.Image")));
            this.tsbToLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToLast.Name = "tsbToLast";
            this.tsbToLast.Size = new System.Drawing.Size(35, 35);
            this.tsbToLast.Text = "末筆";
            this.tsbToLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbToLast.ToolTipText = "最後一筆";
            this.tsbToLast.Click += new System.EventHandler(this.tsbToLast_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbImport
            // 
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(35, 35);
            this.tsbImport.Text = "匯入";
            this.tsbImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbImport.ToolTipText = "匯入資料";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(35, 35);
            this.tsbPrint.Text = "列印";
            this.tsbPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(35, 35);
            this.tsbExit.Text = "離開";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.ToolTipText = "離開作業";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(915, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmBaseOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 326);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBaseOps";
            this.Text = "frmBaseOps";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripButton tsbAddNew;
        internal System.Windows.Forms.ToolStripButton tsbModify;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbQuery;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton tsbToFirst;
        internal System.Windows.Forms.ToolStripButton tsbToPrior;
        internal System.Windows.Forms.ToolStripButton tsbToNext;
        private System.Windows.Forms.ToolStripButton tsbToLast;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripButton tsbImport;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        internal System.Windows.Forms.ToolStripButton tsbExit;
        internal System.Windows.Forms.ToolStripButton tsbAbandon;
    }
}