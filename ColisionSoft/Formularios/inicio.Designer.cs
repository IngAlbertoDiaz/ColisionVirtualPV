namespace ColisionSoft
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.PHerramientas = new System.Windows.Forms.Panel();
            this.Pindicador = new System.Windows.Forms.Panel();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.PVentanas = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PFormulario = new System.Windows.Forms.Panel();
            this.PHerramientas.SuspendLayout();
            this.PFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // PHerramientas
            // 
            this.PHerramientas.Controls.Add(this.Pindicador);
            this.PHerramientas.Controls.Add(this.btnAjustes);
            this.PHerramientas.Controls.Add(this.btnVenta);
            this.PHerramientas.Controls.Add(this.btnCerrar);
            this.PHerramientas.Controls.Add(this.btnProveedores);
            this.PHerramientas.Controls.Add(this.btnInventario);
            this.PHerramientas.Cursor = System.Windows.Forms.Cursors.Default;
            this.PHerramientas.Dock = System.Windows.Forms.DockStyle.Left;
            this.PHerramientas.Location = new System.Drawing.Point(0, 76);
            this.PHerramientas.Name = "PHerramientas";
            this.PHerramientas.Size = new System.Drawing.Size(144, 492);
            this.PHerramientas.TabIndex = 92;
            // 
            // Pindicador
            // 
            this.Pindicador.BackColor = System.Drawing.Color.Green;
            this.Pindicador.Location = new System.Drawing.Point(0, 6);
            this.Pindicador.Name = "Pindicador";
            this.Pindicador.Size = new System.Drawing.Size(14, 95);
            this.Pindicador.TabIndex = 0;
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.Location = new System.Drawing.Point(17, 340);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(121, 95);
            this.btnAjustes.TabIndex = 101;
            this.btnAjustes.TabStop = false;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenta.Location = new System.Drawing.Point(17, 6);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(121, 95);
            this.btnVenta.TabIndex = 100;
            this.btnVenta.TabStop = false;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Orator Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(0, 441);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(141, 49);
            this.btnCerrar.TabIndex = 96;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.Location = new System.Drawing.Point(17, 210);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(121, 95);
            this.btnProveedores.TabIndex = 99;
            this.btnProveedores.TabStop = false;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(17, 109);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(121, 95);
            this.btnInventario.TabIndex = 98;
            this.btnInventario.TabStop = false;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // PVentanas
            // 
            this.PVentanas.Location = new System.Drawing.Point(147, 76);
            this.PVentanas.Name = "PVentanas";
            this.PVentanas.Size = new System.Drawing.Size(750, 490);
            this.PVentanas.TabIndex = 94;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Orator Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(88, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(379, 43);
            this.lblNombre.TabIndex = 94;
            this.lblNombre.Text = "NOMBRE DEL NEGOCIO";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(645, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 95;
            this.label2.Text = "HORA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 10);
            this.panel1.TabIndex = 96;
            // 
            // PFormulario
            // 
            this.PFormulario.BackColor = System.Drawing.Color.Transparent;
            this.PFormulario.Controls.Add(this.panel1);
            this.PFormulario.Controls.Add(this.label2);
            this.PFormulario.Controls.Add(this.lblNombre);
            this.PFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PFormulario.Location = new System.Drawing.Point(0, 0);
            this.PFormulario.Name = "PFormulario";
            this.PFormulario.Size = new System.Drawing.Size(900, 76);
            this.PFormulario.TabIndex = 91;
            this.PFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PFormulario_MouseDown);
            this.PFormulario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PFormulario_MouseMove);
            this.PFormulario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PFormulario_MouseUp);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(900, 568);
            this.Controls.Add(this.PHerramientas);
            this.Controls.Add(this.PFormulario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PVentanas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colision Software - Inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.PHerramientas.ResumeLayout(false);
            this.PFormulario.ResumeLayout(false);
            this.PFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PHerramientas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel PVentanas;
        public System.Windows.Forms.Panel Pindicador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PFormulario;
    }
}

