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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelecExcel = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PFormulario = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.PFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnSelecExcel);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.dgvData);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(12, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 360);
            this.panel3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orator Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(118, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(505, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Verifica los datos antes de guardar\r\n";
            this.label4.Visible = false;
            // 
            // btnSelecExcel
            // 
            this.btnSelecExcel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelecExcel.FlatAppearance.BorderSize = 0;
            this.btnSelecExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecExcel.Font = new System.Drawing.Font("Orator Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecExcel.ForeColor = System.Drawing.Color.White;
            this.btnSelecExcel.Location = new System.Drawing.Point(15, 17);
            this.btnSelecExcel.Name = "btnSelecExcel";
            this.btnSelecExcel.Size = new System.Drawing.Size(290, 41);
            this.btnSelecExcel.TabIndex = 15;
            this.btnSelecExcel.Text = "-Seleccionar excel-";
            this.btnSelecExcel.UseVisualStyleBackColor = false;
            this.btnSelecExcel.Click += new System.EventHandler(this.btnSelecExcel_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Orator Std", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(536, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(182, 41);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "-Insertar-";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(15, 134);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(703, 211);
            this.dgvData.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(703, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PFormulario
            // 
            this.PFormulario.BackColor = System.Drawing.Color.Silver;
            this.PFormulario.Controls.Add(this.button1);
            this.PFormulario.Controls.Add(this.btnClose);
            this.PFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PFormulario.Location = new System.Drawing.Point(0, 0);
            this.PFormulario.Name = "PFormulario";
            this.PFormulario.Size = new System.Drawing.Size(758, 46);
            this.PFormulario.TabIndex = 105;
            this.PFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PFormulario_MouseDown);
            this.PFormulario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PFormulario_MouseMove);
            this.PFormulario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PFormulario_MouseUp);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(715, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 105;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(930, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 104;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ImportarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(758, 422);
            this.Controls.Add(this.PFormulario);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportarInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportarInventario";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.PFormulario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelecExcel;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PFormulario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
    }
}