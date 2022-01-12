using Microsoft.Reporting.WinForms;
using System.Collections;
using System.Windows.Forms;

namespace BBD_lab1
{
    public partial class ReportViewerForm : Form
    {
        private void RunReportViewer(string reportName, string reportFilePath, ArrayList data, string dataSetName)
        {
            Text = reportName;
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportPath = reportFilePath;
            ReportDataSource rds = new ReportDataSource(dataSetName, data);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        public ReportViewerForm(string reportName, string reportFilePath, ArrayList data, string dataSetName = "DataSet1")
        {
            InitializeComponent();
            RunReportViewer(reportName, reportFilePath, data, dataSetName);
        }

        public ReportViewerForm(string reportName, string reportFilePath, string query, string connectionString, string dataSetName = "DataSet1")
        {
            InitializeComponent();
            ArrayList result;
            if (MySqlDB.GetInstance(reportsDataSet, connectionString).ExecuteQuery(query, out int _, out result))
            {
                RunReportViewer(reportName, reportFilePath, result, dataSetName);
            }
        }
    }
}
