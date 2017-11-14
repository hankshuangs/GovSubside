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
using DistSubside.DataSet;
using DistSubside.DataSet.EKDataSetTableAdapters;
namespace DistSubside
{
    public partial class frmReportEK : Form
    {
        #region 新增這三個全域變數
        private System.Windows.Forms.BindingSource usp_Report_EKBindingSource;
        private EKDataSet EKDataSet;
        private usp_getTotolEK_ByMonthTableAdapter usp_GetTotolEK_ByMonthTableAdapter;
        #endregion
        private String TitleRecord;
        private Color BkColorRecord;
        public frmReportEK()
        {
            InitializeComponent();
            #region 初始化連接參數跟連接環境
            this.components = new System.ComponentModel.Container();
            this.EKDataSet = new EKDataSet();
            this.usp_Report_EKBindingSource = new BindingSource(this.components);
            this.usp_GetTotolEK_ByMonthTableAdapter = new usp_getTotolEK_ByMonthTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_Report_EKBindingSource)).BeginInit();
            //EKDataSet
            this.EKDataSet.DataSetName = "EKDataSet";
            this.EKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //usp_Report_EKBindingSource
            this.usp_Report_EKBindingSource.DataMember = "usp_getTotolEK_ByMonth";
            this.usp_Report_EKBindingSource.DataSource = this.EKDataSet;
            //usp_getTotolEK_ByMonthTableAdapter
            this.usp_GetTotolEK_ByMonthTableAdapter.ClearBeforeFill = true;
            //Form
            ((System.ComponentModel.ISupportInitialize)(this.EKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_Report_EKBindingSource)).EndInit();
            #endregion
        }
        String[] CompanyNameArray;
        private void frmReportEK_Load(object sender, EventArgs e)
        {
            TitleRecord = this.Text;
            BkColorRecord = this.BackColor;
            Corps c = new Corps();
            c.GetAllCompany();
            CompanyNameArray = c.GetAllCompanyName();
            CompanyName_CB.DataSource = CompanyNameArray;
            ReportDate.Value = DateTime.Now;
        }

        private void CreateReport_Click(object sender, EventArgs e)
        {
            this.Text = "計算延人公里中...";
            this.BackColor = Color.Red;
            Ticket_SQL t = new Ticket_SQL();
            t.CaculateEK();
            Microsoft.Reporting.WinForms.ReportDataSource ReportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            ReportDataSource.Name = "EK_Report_DataSet";//這個要打報表檔案裡面的資料集名稱
            ReportDataSource.Value = this.usp_Report_EKBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(ReportDataSource);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DistSubside.Report.Report_EK.rdlc";
            this.usp_GetTotolEK_ByMonthTableAdapter.Fill(this.EKDataSet.usp_getTotolEK_ByMonth, ReportDate.Value.ToString("yyyy-MM"), CompanyName_CB.Text);
            Microsoft.Reporting.WinForms.ReportParameter p_CompantName = new Microsoft.Reporting.WinForms.ReportParameter("CompanyName", CompanyName_CB.Text);
            Microsoft.Reporting.WinForms.ReportParameter p_Year = new Microsoft.Reporting.WinForms.ReportParameter("ReportYear", (ReportDate.Value.Year-1911).ToString());
            Microsoft.Reporting.WinForms.ReportParameter p_Month = new Microsoft.Reporting.WinForms.ReportParameter("ReportMonth", ReportDate.Value.ToString("MM"));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { p_CompantName, p_Year, p_Month });
            this.reportViewer1.RefreshReport();
            this.Text = TitleRecord;
            this.BackColor = BkColorRecord;
        }
    }
}
