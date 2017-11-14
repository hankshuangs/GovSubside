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
    public partial class frmBaseStdSchedule : Form
    {
        public frmBaseStdSchedule()
        {
            InitializeComponent();
        }
        private Route r;
        private String[] RouteArray;
        private StdSchedule s;
        private void frmBaseStdSchedule_Load(object sender, EventArgs e)
        {
            r = new Route();
            RouteArray = r.GetRouteName();
            Route_CB.DataSource = RouteArray;
        }

        private void CreateData_BT_Click(object sender, EventArgs e)
        {
            MyDataView.DataSource = null;
            s = null;
            s = new StdSchedule(r.GetRouteCodeByRouteName(Route_CB.Text), GoBack_CB.Text);
            MyDataView.DataSource = s.StdScheduleDataTable;
        }
    }
}
