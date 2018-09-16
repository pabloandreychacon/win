using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlApp.Presentation.Reports
{
    public partial class ReportForm : BaseForms.Forms.Basic
    {
        public string ReportPath { get; set; }
        public string SourceName { get; set; }
        public DataTable CurrentData { get; set; }
        public Hashtable Parameters { get; set; }
        public string SubSourceName { get; set; }
        public DataTable SubCurrentData { get; set; }
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadData();
            DisplayReport();
        }

        public void LoadData()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                reportViewer1.Reset();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportEmbeddedResource = ReportPath;
                reportViewer1.LocalReport.EnableHyperlinks = true;
                reportViewer1.LocalReport.EnableExternalImages = true;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(@"Error generando el reporte: " + Ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public void LoadParameters()
        {
            //el parametro debe existir y permitir valores null
            // de otra manera el reporte saldra en blanco
            if (Parameters == null || Parameters.Keys.Count <= 0) return;
            foreach (DictionaryEntry Parameter in Parameters)
            {

                //var ReportParameter = new ReportParameter((string)Parameter.Key, (string)Parameter.Value);
                //reportViewer1.LocalReport.SetParameters(ReportParameter);
            }
        }

        public void DisplayReport()
        {
            var Rds = new ReportDataSource { Name = SourceName, Value = CurrentData };
            reportViewer1.LocalReport.DataSources.Add(Rds);
            LoadParameters();
            //reportViewer1.LocalReport.SubreportProcessing +=
            //    new SubreportProcessingEventHandler(SubreportProcessingEventHandler);
            reportViewer1.RefreshReport();
        }
    }
}
