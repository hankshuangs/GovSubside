using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DistSubside.SQL;

namespace DistSubside
{
	public partial class frmFailedTable : Form
	{
		public frmFailedTable()
		{
			InitializeComponent();
		}

		private void btnFailedTable_Click(object sender, EventArgs e)
		{
			FailedTable ftOj = new FailedTable();
			System.Data.DataSet ds = ftOj.fTables();

		}
	}
}
