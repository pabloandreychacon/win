using BaseForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlApp.Presentation.Forms.Procesos
{
    public partial class AnulacionFacturasForm : Basic
    {
        public AnulacionFacturasForm()
        {
            InitializeComponent();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            /// validar factura, estado
            /// anular
            ///     recorre cada producto
            ///     trae datos producto
            ///     actualiza precio unitario
            ///     si tiene existencia
            ///         actualiza existencia
            ///     actualiza forma pago
            ///         saldo cajas
            /// setform
        }
    }
}
