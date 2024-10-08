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
            this.tcMatriz.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMatriz
            // 
            this.tcMatriz.Controls.Add(this.tpDatosPersonales);
            this.tcMatriz.Controls.Add(this.tpPreferencias);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMatriz;
        private System.Windows.Forms.TabPage tpDatosPersonales;
        private System.Windows.Forms.TabPage tpPreferencias;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

