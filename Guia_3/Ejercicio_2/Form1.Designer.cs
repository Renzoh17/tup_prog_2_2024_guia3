namespace Ejercicio_2
{
    partial class Form1
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
            this.btnIniciarP = new System.Windows.Forms.Button();
            this.btnAgregarProduc = new System.Windows.Forms.Button();
            this.btnVerP = new System.Windows.Forms.Button();
            this.btnCerrarP = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbCantProduc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciarP
            // 
            this.btnIniciarP.Location = new System.Drawing.Point(57, 36);
            this.btnIniciarP.Name = "btnIniciarP";
            this.btnIniciarP.Size = new System.Drawing.Size(113, 44);
            this.btnIniciarP.TabIndex = 0;
            this.btnIniciarP.Text = "Iniciar Presupuesto";
            this.btnIniciarP.UseVisualStyleBackColor = true;
            this.btnIniciarP.Click += new System.EventHandler(this.btnIniciarP_Click);
            // 
            // btnAgregarProduc
            // 
            this.btnAgregarProduc.Enabled = false;
            this.btnAgregarProduc.Location = new System.Drawing.Point(57, 86);
            this.btnAgregarProduc.Name = "btnAgregarProduc";
            this.btnAgregarProduc.Size = new System.Drawing.Size(113, 44);
            this.btnAgregarProduc.TabIndex = 1;
            this.btnAgregarProduc.Text = "Agregar Producto";
            this.btnAgregarProduc.UseVisualStyleBackColor = true;
            this.btnAgregarProduc.Click += new System.EventHandler(this.btnAgregarProduc_Click);
            // 
            // btnVerP
            // 
            this.btnVerP.Enabled = false;
            this.btnVerP.Location = new System.Drawing.Point(57, 136);
            this.btnVerP.Name = "btnVerP";
            this.btnVerP.Size = new System.Drawing.Size(113, 44);
            this.btnVerP.TabIndex = 2;
            this.btnVerP.Text = "Ver Presupuesto";
            this.btnVerP.UseVisualStyleBackColor = true;
            this.btnVerP.Click += new System.EventHandler(this.btnVerP_Click);
            // 
            // btnCerrarP
            // 
            this.btnCerrarP.Location = new System.Drawing.Point(57, 186);
            this.btnCerrarP.Name = "btnCerrarP";
            this.btnCerrarP.Size = new System.Drawing.Size(113, 44);
            this.btnCerrarP.TabIndex = 3;
            this.btnCerrarP.Text = "Cerrar";
            this.btnCerrarP.UseVisualStyleBackColor = true;
            this.btnCerrarP.Click += new System.EventHandler(this.btnCerrarP_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(208, 86);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(53, 13);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre: -";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(208, 117);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(61, 13);
            this.lbDireccion.TabIndex = 5;
            this.lbDireccion.Text = "Direccion: -";
            // 
            // lbCantProduc
            // 
            this.lbCantProduc.AutoSize = true;
            this.lbCantProduc.Location = new System.Drawing.Point(208, 152);
            this.lbCantProduc.Name = "lbCantProduc";
            this.lbCantProduc.Size = new System.Drawing.Size(126, 13);
            this.lbCantProduc.TabIndex = 6;
            this.lbCantProduc.Text = "Cantidad De Productos: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 262);
            this.Controls.Add(this.lbCantProduc);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnCerrarP);
            this.Controls.Add(this.btnVerP);
            this.Controls.Add(this.btnAgregarProduc);
            this.Controls.Add(this.btnIniciarP);
            this.Name = "Form1";
            this.Text = "Presupuesto de Muebles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarP;
        private System.Windows.Forms.Button btnAgregarProduc;
        private System.Windows.Forms.Button btnVerP;
        private System.Windows.Forms.Button btnCerrarP;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbCantProduc;
    }
}

