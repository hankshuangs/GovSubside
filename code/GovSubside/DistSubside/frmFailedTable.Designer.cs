namespace DistSubside
{
	partial class frmFailedTable
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
			this.btnFailedTable = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnFailedTable
			// 
			this.btnFailedTable.Location = new System.Drawing.Point(74, 69);
			this.btnFailedTable.Name = "btnFailedTable";
			this.btnFailedTable.Size = new System.Drawing.Size(148, 23);
			this.btnFailedTable.TabIndex = 0;
			this.btnFailedTable.Text = "產生不合格報表";
			this.btnFailedTable.UseVisualStyleBackColor = true;
			this.btnFailedTable.Click += new System.EventHandler(this.btnFailedTable_Click);
			// 
			// frmFailedTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 462);
			this.Controls.Add(this.btnFailedTable);
			this.Name = "frmFailedTable";
			this.Text = "frmFailedTable";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnFailedTable;
	}
}