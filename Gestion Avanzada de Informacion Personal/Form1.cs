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
            String nombre=txtNombre.Text;
            String direccion=txtDireccion.Text;
            String correo=txtCorreo.Text;
            String genero = obtenerGenero();
            String fechaNac = mcNacimiento.SelectionStart.ToString("dd/MM/yyyy");
            String edad=nUDedad.Value.ToString();
            String pais=cbPais.Text;
            String valoracion=tb_Valoracion.Value.ToString();
            String hobbies = listarHobbies();
            String boletin;
            if (chBoletin.Checked) boletin = "si";
            else  boletin = "no";
            string mensaje = $"Nombre: {nombre}\n" +
                    $"Dirección: {direccion}\n" +
                    $"Correo: {correo}\n" +
                    $"Género: {genero}\n" +
                    $"Fecha de Nacimiento: {fechaNac}\n" +
                    $"Edad: {edad}\n" +
                    $"País: {pais}\n" +
                    $"Valoración: {valoracion}\n" +
                    $"Hobbies:\n{hobbies}\n" +
                    $"Boletín: {boletin}";

            MessageBox.Show(mensaje, "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private String obtenerGenero()
        {
            foreach(RadioButton control in pnGenero.Controls)
            {
                if (control.Checked)
                {
                    return control.Text;
                }
            }
            return "Ninguno seleccionado";
        }
        private string listarHobbies()
        {
            string hobbiesSeleccionados = "";
            foreach (object item in chlistHobbies.CheckedItems)
            {
                hobbiesSeleccionados += item.ToString() + "\n";  
            }
            return hobbiesSeleccionados;
        }

        private void formBase_Load(object sender, EventArgs e)
        {
            this.ttAyuda.SetToolTip(this.btnGuardar, "Muestra los datos almacenados en el formulario");
            this.ttAyuda.SetToolTip(this.btnLimpiar, "Borra todos los datos en el formulario");
            this.ttAyuda.SetToolTip(this.btnSalir, "Cierra el formulario");
            
            cbPais.SelectedIndex=buscaEspaña();
            

            
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {  
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();

            foreach (RadioButton control in pnGenero.Controls)
            {
                control.Checked = false;  
            }
            mcNacimiento.SelectionStart = DateTime.Now;
            nUDedad.Value = 0;
            cbPais.SelectedIndex = buscaEspaña(); 
            tb_Valoracion.Value = tb_Valoracion.Minimum; 

            for (int i = 0; i < chlistHobbies.Items.Count; i++)
            {
                chlistHobbies.SetItemChecked(i, false);
            }
            chBoletin.Checked = false;
        }
    }
}
