namespace Pry_BaseDeDatos
{
    partial class PaginaInicio
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtboxContrasena = new System.Windows.Forms.TextBox();
            this.labCrearCuenta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.panelDcoNombre = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDcoContrasena = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PaginaFrotal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PaginaFrotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnIngresar.Location = new System.Drawing.Point(130, 348);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 23);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Iniciar seccion";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtboxContrasena
            // 
            this.txtboxContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxContrasena.ForeColor = System.Drawing.Color.LightGray;
            this.txtboxContrasena.Location = new System.Drawing.Point(88, 298);
            this.txtboxContrasena.Name = "txtboxContrasena";
            this.txtboxContrasena.Size = new System.Drawing.Size(142, 14);
            this.txtboxContrasena.TabIndex = 3;
            this.txtboxContrasena.Text = "Ingrese la contraseña";
            // 
            // labCrearCuenta
            // 
            this.labCrearCuenta.AutoSize = true;
            this.labCrearCuenta.Location = new System.Drawing.Point(85, 387);
            this.labCrearCuenta.Name = "labCrearCuenta";
            this.labCrearCuenta.Size = new System.Drawing.Size(190, 13);
            this.labCrearCuenta.TabIndex = 4;
            this.labCrearCuenta.Text = "¿No tienes una cuenta? registrate aqui";
            this.labCrearCuenta.MouseLeave += new System.EventHandler(this.labCrearCuentaMouseLeave);
            this.labCrearCuenta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labCrearCuentaMouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pry_BaseDeDatos.Properties.Resources.icono;
            this.pictureBox1.Location = new System.Drawing.Point(88, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtboxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtboxNombre.ForeColor = System.Drawing.Color.LightGray;
            this.txtboxNombre.Location = new System.Drawing.Point(88, 225);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(142, 14);
            this.txtboxNombre.TabIndex = 2;
            this.txtboxNombre.Text = "Ingrese nombre";
            // 
            // panelDcoNombre
            // 
            this.panelDcoNombre.BackColor = System.Drawing.SystemColors.Window;
            this.panelDcoNombre.Location = new System.Drawing.Point(162, 215);
            this.panelDcoNombre.Name = "panelDcoNombre";
            this.panelDcoNombre.Size = new System.Drawing.Size(160, 30);
            this.panelDcoNombre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(88, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // panelDcoContrasena
            // 
            this.panelDcoContrasena.BackColor = System.Drawing.SystemColors.Window;
            this.panelDcoContrasena.Location = new System.Drawing.Point(162, 288);
            this.panelDcoContrasena.Name = "panelDcoContrasena";
            this.panelDcoContrasena.Size = new System.Drawing.Size(160, 30);
            this.panelDcoContrasena.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(88, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña:";
            // 
            // PaginaFrotal
            // 
            this.PaginaFrotal.Controls.Add(this.label2);
            this.PaginaFrotal.Controls.Add(this.label3);
            this.PaginaFrotal.Controls.Add(this.btnIngresar);
            this.PaginaFrotal.Controls.Add(this.txtboxNombre);
            this.PaginaFrotal.Controls.Add(this.txtboxContrasena);
            this.PaginaFrotal.Controls.Add(this.panelDcoContrasena);
            this.PaginaFrotal.Controls.Add(this.panelDcoNombre);
            this.PaginaFrotal.Controls.Add(this.pictureBox1);
            this.PaginaFrotal.Controls.Add(this.labCrearCuenta);
            this.PaginaFrotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaginaFrotal.Location = new System.Drawing.Point(0, 0);
            this.PaginaFrotal.Name = "PaginaFrotal";
            this.PaginaFrotal.Size = new System.Drawing.Size(334, 461);
            this.PaginaFrotal.TabIndex = 10;
            this.PaginaFrotal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PaginaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.PaginaFrotal);
            this.Name = "PaginaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PaginaFrotal.ResumeLayout(false);
            this.PaginaFrotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtboxContrasena;
        private System.Windows.Forms.Label labCrearCuenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDcoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.Panel panelDcoContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PaginaFrotal;
    }
}

