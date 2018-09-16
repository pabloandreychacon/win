using ControlBusiness.Business;
using BaseForms.Forms;
using ControlEntity;
using System;

namespace ControlApp.Presentation.Forms.Consultas
{
    public partial class ExistenciasConsulta : Basic
    {
        public ExistenciasConsulta()
        {
            InitializeComponent();
        }

        private void ExistenciasForm_Load(object sender, EventArgs e)
        {
            CommonB commB = new CommonB();
            gridExistencias.DataSource = commB.GetList<Existencia>();
        }
    }
}
