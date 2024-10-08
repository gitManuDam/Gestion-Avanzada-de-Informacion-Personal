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

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = System.DateTime.Now.ToString("HH:mm:ss");
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void formBase_Load(object sender, EventArgs e)
        {
            this.ttAyuda.SetToolTip(this.btnGuardar, "Muestra los datos almacenados en el formulario");
            this.ttAyuda.SetToolTip(this.btnLimpiar, "Borra todos los datos en el formulario");
            this.ttAyuda.SetToolTip(this.btnSalir, "Cierra el formulario");
            if (buscaEspaña() != -1)
            {
                cbPais.SelectedIndex=buscaEspaña();
            }

            
        }
        private int buscaEspaña()
        {
            for (int cont = 0; cont < cbPais.Items.Count; cont++)
            {
                if (cbPais.Items[cont].ToString() == "España")
                {
                    return cont; 
                }
            }
            return -1;
        }
    }
}
