using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Avanzada_de_Informacion_Personal
{
    public partial class formBase : Form
    {
        public formBase()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Valoracion_Scroll(object sender, EventArgs e)
        {
            nUDValoracion.Value = tb_Valoracion.Value;
        }

        private void nUDValoracion_ValueChanged(object sender, EventArgs e)
        {
            tb_Valoracion.Value = (int)nUDValoracion.Value;
        }
    }
}
