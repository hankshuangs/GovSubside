using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region 這邊有using下面就可以少打很多字
using DistSubside.DataSet;
using DistSubside.DataSet.DynamicDataSetTableAdapters;
#endregion

namespace DistSubside
{
    public partial class frmReportDynamiclmp : Form
    {
        #region 新增這三個全域變數
        private System.Windows.Forms.BindingSource usp_Report_DynamicBindingSource;
        private DynamicDataSet DynamicDataSet;
        private usp_Report_DynamicTableAdapter usp_Report_DynamicTableAdapter;
        #endregion
        private SQL.Route r;
        private String[] RouteName;

        public frmReportDynamiclmp()
        {
            InitializeComponent();
            #region 初始化連接參數跟連接環境
            this.components = new System.ComponentModel.Container();
            this.DynamicDataSet = new DynamicDataSet();
            this.usp_Report_DynamicBindingSource = new BindingSource(this.components);
            this.usp_Report_DynamicTableAdapter = new usp_Report_DynamicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DynamicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_Report_DynamicBindingSource)).BeginInit();
            //DynamicDataSet
            this.DynamicDataSet.DataSetName = "DynamicDataSet";
            this.DynamicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //usp_Report_DynamicBindingSource
            this.usp_Report_DynamicBindingSource.DataMember = "usp_Report_Dynamic";
            this.usp_Report_DynamicBindingSource.DataSource = this.DynamicDataSet;
            //usp_Report_DynamicTableAdapter
            this.usp_Report_DynamicTableAdapter.ClearBeforeFill = true;
            //FormSelf
            ((System.ComponentModel.ISupportInitialize)(this.DynamicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_Report_DynamicBindingSource)).EndInit();
            #endregion
        }

        private void frmReportDynamiclmp_Load(object sender, EventArgs e)
        {
            Start_DateTimePick.Value = DateTime.Now;
            End_DateTimePick.Value = DateTime.Now;
            r = new SQL.Route();
            RouteName = r.GetRouteName();
            Route_ComboBox.DataSource = RouteName;
        }

        private void OKBTN_Click(object sender, EventArgs e)
        {
            String StartDate = Start_DateTimePick.Value.ToString("yyyy-MM-dd");
            String EndDate = End_DateTimePick.Value.ToString("yyyy-MM-dd");
            String RouteCode = r.GetRouteCodeByRouteName(Route_ComboBox.Text);
            int StatusCode = -1;
            switch (Status_ComboBox.Text)
            {
                case "動態驗證成功":
                    StatusCode = 1;
                    break;
                case "非動態驗證":
                    StatusCode = 0;
                    break;
                case "混和模式":
                    StatusCode = 2;
                    break;
            }
            MessageBox.Show(StartDate + "\n" + EndDate + "\n" + RouteCode + "\n" + StatusCode);
            Microsoft.Reporting.WinForms.ReportDataSource ReportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            ReportDataSource.Name = "Dynamic_DataSet_01";
            ReportDataSource.Value = this.usp_Report_DynamicBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(ReportDataSource);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DistSubside.Report.Report_Dynamic.rdlc";
            this.usp_Report_DynamicTableAdapter.Fill(this.DynamicDataSet.usp_Report_Dynamic, StartDate, EndDate, RouteCode, StatusCode);
            this.reportViewer1.RefreshReport();
        }
    }
}
