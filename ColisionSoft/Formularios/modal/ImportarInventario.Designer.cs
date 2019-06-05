namespace ColisionSoft
{
    partial class ImportarInventario
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelecExcel = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PFormulario = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.PFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orator Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(130, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(533, 32);
            this.label4.TabIndex = 110;
            this.label4.Text = "Verifica los datos antes de registrar";
            this.label4.Visible = false;
            // 
            // btnSelecExcel
            // 
            this.btnSelecExcel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelecExcel.FlatAppearance.BorderSize = 0;
            this.btnSelecExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecExcel.Font = new System.Drawing.Font("Orator Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecExcel.ForeColor = System.Drawing.Color.White;
            this.btnSelecExcel.Location = new System.Drawing.Point(236, 72);
            this.btnSelecExcel.Name = "btnSelecExcel";
            this.btnSelecExcel.Size = new System.Drawing.Size(290, 41);
            this.btnSelecExcel.TabIndex = 109;
            this.btnSelecExcel.Text = "-Seleccionar excel-";
            this.btnSelecExcel.UseVisualStyleBackColor = false;
            this.btnSelecExcel.Click += new System.EventHandler(this.btnSelecExcel_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Orator Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(585, 72);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(146, 41);
            this.btnInsertar.TabIndex = 108;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(28, 189);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(703, 211);
            this.dgvData.TabIndex = 107;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(28, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(703, 22);
            this.textBox1.TabIndex = 106;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PFormulario
            // 
            this.PFormulario.BackColor = System.Drawing.Color.Black;
            this.PFormulario.Controls.Add(this.label8);
            this.PFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PFormulario.Location = new System.Drawing.Point(0, 0);
            this.PFormulario.Name = "PFormulario";
            this.PFormulario.Size = new System.Drawing.Size(758, 57);
            this.PFormulario.TabIndex = 111;
            this.PFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PFormulario_MouseDown);
            this.PFormulario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PFormulario_MouseMove);
            this.PFormulario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PFormulario_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Orator Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(273, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 32);
            this.label8.TabIndex = 32;
            this.label8.Text = "Insertar Producto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Orator Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(28, 72);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 41);
            this.btnCancelar.TabIndex = 112;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ImportarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(758, 422);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.PFormulario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelecExcel);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportarInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportarInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.PFormulario.ResumeLayout(false);
            this.PFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelecExcel;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PFormulario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
    }
}