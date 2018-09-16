using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForms.Forms;
using System.Collections;
using BaseHelpers.Helpers;
using System.Configuration;
using ControlBusiness.Business;
using ControlEntity;

namespace ControlApp.Presentation.Forms.Reportes.Ventas
{
    public partial class VentasReport : Basic
    {
        CommonB commB = new CommonB();
        public VentasReport()
        {
            InitializeComponent();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            //var StrSql = "select * " +
            //    "from general.Usuarios Order By IdUsuario";
            /// linq query
            /// to datatable
            //var DtUsuarios = AdoDataMethods.CreateDataTable(ConfigurationManager.ConnectionStrings["ControlEntities"].ConnectionString, 
            //    StrSql, "DtUsuarios");
            var usuarios = commB.GetList<Usuario>();
            var DtUsuarios = usuarios.AsDataTable();
            DtUsuarios.TableName = "Usuarios";
            //var StrSqlDetail = "select * " +
            //    "from general.Bitacora Order By IdUsuario";
            //var DtBitacoras = AdoDataMethods.CreateDataTable(ConfigurationManager.ConnectionStrings["ControlEntities"].ConnectionString, 
            //    StrSqlDetail, "DtBitacoras");

            var FormViewer = new Reports.ReportForm
            {
                ReportPath = "ControlApp.Reports.General.Usuarios.rdlc",
                CurrentData = DtUsuarios,
                SourceName = "DataSet1",
                //bindingSource1.DataSource = usuarios,
                //bindingSource1.DataMember = "Usuarios"
            };
            ////el parametro debe existir y permitir valores nulll
            //var MyParams = new Hashtable { { "pReport", "repClientes" } };
            //FormViewer.Parameters = MyParams;
            //// handler para el subreporte
            //FormViewer.SubSourceName = "DsBitacoras";
            //FormViewer.SubCurrentData = DtBitacoras;
            ////FormViewer.reportViewer1.LocalReport.SubreportProcessing +=
            ////    new SubreportProcessingEventHandler(FormViewer.SubreportProcessingEventHandler);
            FormViewer.ShowDialog();
        }

        private void VentasReport_Load(object sender, EventArgs e)
        {

        }
    }
}
