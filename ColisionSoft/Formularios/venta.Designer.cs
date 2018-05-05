﻿namespace ColisionSoft
{
    partial class venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnGranel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre del producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(406, 49);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(425, 35);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyDown);
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToResizeColumns = false;
            this.dgvVenta.AllowUserToResizeRows = false;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticket,
            this.producto,
            this.precio});
            this.dgvVenta.GridColor = System.Drawing.Color.Black;
            this.dgvVenta.Location = new System.Drawing.Point(39, 108);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(570, 240);
            this.dgvVenta.TabIndex = 100;
            this.dgvVenta.TabStop = false;
            // 
            // ticket
            // 
            this.ticket.HeaderText = "N° de Ticket";
            this.ticket.Name = "ticket";
            this.ticket.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(654, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total: $";
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Orator Std", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(680, 210);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(174, 52);
            this.btnCobrar.TabIndex = 2;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(706, 268);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 52);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(785, 120);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 37);
            this.lblCantidad.TabIndex = 9;
            // 
            // btnGranel
            // 
            this.btnGranel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnGranel.FlatAppearance.BorderSize = 0;
            this.btnGranel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGranel.Font = new System.Drawing.Font("Orator Std", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGranel.ForeColor = System.Drawing.Color.White;
            this.btnGranel.Location = new System.Drawing.Point(12, 390);
            this.btnGranel.Name = "btnGranel";
            this.btnGranel.Size = new System.Drawing.Size(174, 109);
            this.btnGranel.TabIndex = 103;
            this.btnGranel.Text = "Granel";
            this.btnGranel.UseVisualStyleBackColor = false;
            this.btnGranel.Click += new System.EventHandler(this.btnGranel_Click);
            // 
            // venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.btnGranel);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "venta";
            this.Text = "venta";
            this.Load += new System.EventHandler(this.venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        public System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnGranel;
        public System.Windows.Forms.DataGridView dgvVenta;
    }
}