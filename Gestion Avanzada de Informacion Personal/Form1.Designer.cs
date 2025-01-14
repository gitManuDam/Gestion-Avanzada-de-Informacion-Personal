﻿namespace Gestion_Avanzada_de_Informacion_Personal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBase));
            this.tcMatriz = new System.Windows.Forms.TabControl();
            this.tpDatosPersonales = new System.Windows.Forms.TabPage();
            this.lblEdad = new System.Windows.Forms.Label();
            this.nUDedad = new System.Windows.Forms.NumericUpDown();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.mcNacimiento = new System.Windows.Forms.MonthCalendar();
            this.lblGenero = new System.Windows.Forms.Label();
            this.pnGenero = new System.Windows.Forms.Panel();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tpPreferencias = new System.Windows.Forms.TabPage();
            this.nUDValoracion = new System.Windows.Forms.NumericUpDown();
            this.lblSatisfaccion = new System.Windows.Forms.Label();
            this.tb_Valoracion = new System.Windows.Forms.TrackBar();
            this.lblPais = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.chlistHobbies = new System.Windows.Forms.CheckedListBox();
            this.chBoletin = new System.Windows.Forms.CheckBox();
            this.tpVisualizacion = new System.Windows.Forms.TabPage();
            this.lblHora = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.tcMatriz.SuspendLayout();
            this.tpDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDedad)).BeginInit();
            this.pnGenero.SuspendLayout();
            this.tpPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDValoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Valoracion)).BeginInit();
            this.tpVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
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
            this.tpDatosPersonales.Controls.Add(this.lblEdad);
            this.tpDatosPersonales.Controls.Add(this.nUDedad);
            this.tpDatosPersonales.Controls.Add(this.lblNacimiento);
            this.tpDatosPersonales.Controls.Add(this.mcNacimiento);
            this.tpDatosPersonales.Controls.Add(this.lblGenero);
            this.tpDatosPersonales.Controls.Add(this.pnGenero);
            this.tpDatosPersonales.Controls.Add(this.txtCorreo);
            this.tpDatosPersonales.Controls.Add(this.txtDireccion);
            this.tpDatosPersonales.Controls.Add(this.txtNombre);
            this.tpDatosPersonales.Controls.Add(this.lblCorreo);
            this.tpDatosPersonales.Controls.Add(this.lblDireccion);
            this.tpDatosPersonales.Controls.Add(this.lblNombre);
            resources.ApplyResources(this.tpDatosPersonales, "tpDatosPersonales");
            this.tpDatosPersonales.Name = "tpDatosPersonales";
            this.tpDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // lblEdad
            // 
            resources.ApplyResources(this.lblEdad, "lblEdad");
            this.lblEdad.Name = "lblEdad";
            // 
            // nUDedad
            // 
            resources.ApplyResources(this.nUDedad, "nUDedad");
            this.nUDedad.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nUDedad.Name = "nUDedad";
            // 
            // lblNacimiento
            // 
            resources.ApplyResources(this.lblNacimiento, "lblNacimiento");
            this.lblNacimiento.Name = "lblNacimiento";
            // 
            // mcNacimiento
            // 
            resources.ApplyResources(this.mcNacimiento, "mcNacimiento");
            this.mcNacimiento.Name = "mcNacimiento";
            // 
            // lblGenero
            // 
            resources.ApplyResources(this.lblGenero, "lblGenero");
            this.lblGenero.Name = "lblGenero";
            // 
            // pnGenero
            // 
            this.pnGenero.Controls.Add(this.rbOtro);
            this.pnGenero.Controls.Add(this.rbFemenino);
            this.pnGenero.Controls.Add(this.rbMasculino);
            resources.ApplyResources(this.pnGenero, "pnGenero");
            this.pnGenero.Name = "pnGenero";
            // 
            // rbOtro
            // 
            resources.ApplyResources(this.rbOtro, "rbOtro");
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.TabStop = true;
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            resources.ApplyResources(this.rbFemenino, "rbFemenino");
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.TabStop = true;
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            resources.ApplyResources(this.rbMasculino, "rbMasculino");
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.TabStop = true;
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            resources.ApplyResources(this.txtCorreo, "txtCorreo");
            this.txtCorreo.Name = "txtCorreo";
            // 
            // txtDireccion
            // 
            resources.ApplyResources(this.txtDireccion, "txtDireccion");
            this.txtDireccion.Name = "txtDireccion";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // lblCorreo
            // 
            resources.ApplyResources(this.lblCorreo, "lblCorreo");
            this.lblCorreo.Name = "lblCorreo";
            // 
            // lblDireccion
            // 
            resources.ApplyResources(this.lblDireccion, "lblDireccion");
            this.lblDireccion.Name = "lblDireccion";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
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
            // lblSatisfaccion
            // 
            resources.ApplyResources(this.lblSatisfaccion, "lblSatisfaccion");
            this.lblSatisfaccion.Name = "lblSatisfaccion";
            // 
            // tb_Valoracion
            // 
            this.tb_Valoracion.LargeChange = 1;
            resources.ApplyResources(this.tb_Valoracion, "tb_Valoracion");
            this.tb_Valoracion.Name = "tb_Valoracion";
            this.tb_Valoracion.Scroll += new System.EventHandler(this.tb_Valoracion_Scroll);
            // 
            // lblPais
            // 
            resources.ApplyResources(this.lblPais, "lblPais");
            this.lblPais.Name = "lblPais";
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
            // lblHobbies
            // 
            resources.ApplyResources(this.lblHobbies, "lblHobbies");
            this.lblHobbies.Name = "lblHobbies";
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
            // chBoletin
            // 
            resources.ApplyResources(this.chBoletin, "chBoletin");
            this.chBoletin.Name = "chBoletin";
            this.chBoletin.UseVisualStyleBackColor = true;
            // 
            // tpVisualizacion
            // 
            this.tpVisualizacion.Controls.Add(this.lblHora);
            this.tpVisualizacion.Controls.Add(this.pbImage);
            resources.ApplyResources(this.tpVisualizacion, "tpVisualizacion");
            this.tpVisualizacion.Name = "tpVisualizacion";
            this.tpVisualizacion.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            resources.ApplyResources(this.lblHora, "lblHora");
            this.lblHora.Name = "lblHora";
            // 
            // pbImage
            // 
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            resources.ApplyResources(this.btnLimpiar, "btnLimpiar");
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
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
            this.Load += new System.EventHandler(this.formBase_Load);
            this.tcMatriz.ResumeLayout(false);
            this.tpDatosPersonales.ResumeLayout(false);
            this.tpDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDedad)).EndInit();
            this.pnGenero.ResumeLayout(false);
            this.pnGenero.PerformLayout();
            this.tpPreferencias.ResumeLayout(false);
            this.tpPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDValoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Valoracion)).EndInit();
            this.tpVisualizacion.ResumeLayout(false);
            this.tpVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
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
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Panel pnGenero;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.MonthCalendar mcNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.NumericUpDown nUDedad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ToolTip ttAyuda;
    }
}

