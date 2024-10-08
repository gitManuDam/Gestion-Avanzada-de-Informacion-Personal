namespace Gestion_Avanzada_de_Informacion_Personal
{
    partial class formBase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBase));
            this.tcMatriz = new System.Windows.Forms.TabControl();
            this.tpDatosPersonales = new System.Windows.Forms.TabPage();
            this.tpPreferencias = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chBoletin = new System.Windows.Forms.CheckBox();
            this.chlistHobbies = new System.Windows.Forms.CheckedListBox();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.tb_Valoracion = new System.Windows.Forms.TrackBar();
            this.lblSatisfaccion = new System.Windows.Forms.Label();
            this.nUDValoracion = new System.Windows.Forms.NumericUpDown();
            this.tpVisualizacion = new System.Windows.Forms.TabPage();
            this.tcMatriz.SuspendLayout();
            this.tpPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Valoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDValoracion)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMatriz
            // 
            this.tcMatriz.Controls.Add(this.tpDatosPersonales);
            this.tcMatriz.Controls.Add(this.tpPreferencias);
            this.tcMatriz.Controls.Add(this.tpVisualizacion);
            resources.ApplyResources(this.tcMatriz, "tcMatriz");
            this.tcMatriz.Multiline = true;
            this.tcMatriz.Name = "tcMatriz";
            this.tcMatriz.SelectedIndex = 0;
            // 
            // tpDatosPersonales
            // 
            resources.ApplyResources(this.tpDatosPersonales, "tpDatosPersonales");
            this.tpDatosPersonales.Name = "tpDatosPersonales";
            this.tpDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // tpPreferencias
            // 
            this.tpPreferencias.Controls.Add(this.nUDValoracion);
            this.tpPreferencias.Controls.Add(this.lblSatisfaccion);
            this.tpPreferencias.Controls.Add(this.tb_Valoracion);
            this.tpPreferencias.Controls.Add(this.lblPais);
            this.tpPreferencias.Controls.Add(this.cbPais);
            this.tpPreferencias.Controls.Add(this.lblHobbies);
            this.tpPreferencias.Controls.Add(this.chlistHobbies);
            this.tpPreferencias.Controls.Add(this.chBoletin);
            resources.ApplyResources(this.tpPreferencias, "tpPreferencias");
            this.tpPreferencias.Name = "tpPreferencias";
            this.tpPreferencias.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            resources.ApplyResources(this.btnLimpiar, "btnLimpiar");
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chBoletin
            // 
            resources.ApplyResources(this.chBoletin, "chBoletin");
            this.chBoletin.Name = "chBoletin";
            this.chBoletin.UseVisualStyleBackColor = true;
            // 
            // chlistHobbies
            // 
            this.chlistHobbies.CheckOnClick = true;
            this.chlistHobbies.FormattingEnabled = true;
            this.chlistHobbies.Items.AddRange(new object[] {
            resources.GetString("chlistHobbies.Items"),
            resources.GetString("chlistHobbies.Items1"),
            resources.GetString("chlistHobbies.Items2"),
            resources.GetString("chlistHobbies.Items3"),
            resources.GetString("chlistHobbies.Items4"),
            resources.GetString("chlistHobbies.Items5"),
            resources.GetString("chlistHobbies.Items6"),
            resources.GetString("chlistHobbies.Items7"),
            resources.GetString("chlistHobbies.Items8"),
            resources.GetString("chlistHobbies.Items9"),
            resources.GetString("chlistHobbies.Items10")});
            resources.ApplyResources(this.chlistHobbies, "chlistHobbies");
            this.chlistHobbies.Name = "chlistHobbies";
            // 
            // lblHobbies
            // 
            resources.ApplyResources(this.lblHobbies, "lblHobbies");
            this.lblHobbies.Name = "lblHobbies";
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            resources.GetString("cbPais.Items"),
            resources.GetString("cbPais.Items1"),
            resources.GetString("cbPais.Items2"),
            resources.GetString("cbPais.Items3"),
            resources.GetString("cbPais.Items4"),
            resources.GetString("cbPais.Items5"),
            resources.GetString("cbPais.Items6"),
            resources.GetString("cbPais.Items7"),
            resources.GetString("cbPais.Items8"),
            resources.GetString("cbPais.Items9"),
            resources.GetString("cbPais.Items10"),
            resources.GetString("cbPais.Items11"),
            resources.GetString("cbPais.Items12"),
            resources.GetString("cbPais.Items13"),
            resources.GetString("cbPais.Items14"),
            resources.GetString("cbPais.Items15"),
            resources.GetString("cbPais.Items16"),
            resources.GetString("cbPais.Items17"),
            resources.GetString("cbPais.Items18"),
            resources.GetString("cbPais.Items19"),
            resources.GetString("cbPais.Items20"),
            resources.GetString("cbPais.Items21"),
            resources.GetString("cbPais.Items22"),
            resources.GetString("cbPais.Items23"),
            resources.GetString("cbPais.Items24"),
            resources.GetString("cbPais.Items25"),
            resources.GetString("cbPais.Items26"),
            resources.GetString("cbPais.Items27"),
            resources.GetString("cbPais.Items28"),
            resources.GetString("cbPais.Items29"),
            resources.GetString("cbPais.Items30"),
            resources.GetString("cbPais.Items31"),
            resources.GetString("cbPais.Items32"),
            resources.GetString("cbPais.Items33"),
            resources.GetString("cbPais.Items34"),
            resources.GetString("cbPais.Items35"),
            resources.GetString("cbPais.Items36"),
            resources.GetString("cbPais.Items37"),
            resources.GetString("cbPais.Items38"),
            resources.GetString("cbPais.Items39"),
            resources.GetString("cbPais.Items40"),
            resources.GetString("cbPais.Items41"),
            resources.GetString("cbPais.Items42"),
            resources.GetString("cbPais.Items43"),
            resources.GetString("cbPais.Items44"),
            resources.GetString("cbPais.Items45"),
            resources.GetString("cbPais.Items46"),
            resources.GetString("cbPais.Items47"),
            resources.GetString("cbPais.Items48"),
            resources.GetString("cbPais.Items49"),
            resources.GetString("cbPais.Items50"),
            resources.GetString("cbPais.Items51"),
            resources.GetString("cbPais.Items52"),
            resources.GetString("cbPais.Items53"),
            resources.GetString("cbPais.Items54"),
            resources.GetString("cbPais.Items55"),
            resources.GetString("cbPais.Items56"),
            resources.GetString("cbPais.Items57"),
            resources.GetString("cbPais.Items58"),
            resources.GetString("cbPais.Items59"),
            resources.GetString("cbPais.Items60"),
            resources.GetString("cbPais.Items61")});
            resources.ApplyResources(this.cbPais, "cbPais");
            this.cbPais.Name = "cbPais";
            // 
            // lblPais
            // 
            resources.ApplyResources(this.lblPais, "lblPais");
            this.lblPais.Name = "lblPais";
            // 
            // tb_Valoracion
            // 
            this.tb_Valoracion.LargeChange = 1;
            resources.ApplyResources(this.tb_Valoracion, "tb_Valoracion");
            this.tb_Valoracion.Name = "tb_Valoracion";
            this.tb_Valoracion.Scroll += new System.EventHandler(this.tb_Valoracion_Scroll);
            // 
            // lblSatisfaccion
            // 
            resources.ApplyResources(this.lblSatisfaccion, "lblSatisfaccion");
            this.lblSatisfaccion.Name = "lblSatisfaccion";
            // 
            // nUDValoracion
            // 
            resources.ApplyResources(this.nUDValoracion, "nUDValoracion");
            this.nUDValoracion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDValoracion.Name = "nUDValoracion";
            this.nUDValoracion.ValueChanged += new System.EventHandler(this.nUDValoracion_ValueChanged);
            // 
            // tpVisualizacion
            // 
            resources.ApplyResources(this.tpVisualizacion, "tpVisualizacion");
            this.tpVisualizacion.Name = "tpVisualizacion";
            this.tpVisualizacion.UseVisualStyleBackColor = true;
            // 
            // formBase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tcMatriz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formBase";
            this.tcMatriz.ResumeLayout(false);
            this.tpPreferencias.ResumeLayout(false);
            this.tpPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Valoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDValoracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMatriz;
        private System.Windows.Forms.TabPage tpDatosPersonales;
        private System.Windows.Forms.TabPage tpPreferencias;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckedListBox chlistHobbies;
        private System.Windows.Forms.CheckBox chBoletin;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblSatisfaccion;
        private System.Windows.Forms.TrackBar tb_Valoracion;
        private System.Windows.Forms.NumericUpDown nUDValoracion;
        private System.Windows.Forms.TabPage tpVisualizacion;
    }
}

