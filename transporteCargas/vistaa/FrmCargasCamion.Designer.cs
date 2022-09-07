namespace transporteCargas.vistaa
{
    partial class FrmCargasCamion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNroCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCargaTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCargaPeso = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesoDisp = new System.Windows.Forms.Label();
            this.addCarga = new System.Windows.Forms.Button();
            this.btnHabCarga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargaPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroCarga,
            this.colPeso,
            this.colTipo,
            this.colOp});
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // colNroCarga
            // 
            this.colNroCarga.HeaderText = "NroCarga";
            this.colNroCarga.Name = "colNroCarga";
            this.colNroCarga.ReadOnly = true;
            // 
            // colPeso
            // 
            this.colPeso.HeaderText = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colOp
            // 
            this.colOp.HeaderText = "Op";
            this.colOp.Name = "colOp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addCarga);
            this.panel1.Controls.Add(this.txtCargaPeso);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboCargaTipo);
            this.panel1.Location = new System.Drawing.Point(488, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 92);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar Carga";
            // 
            // cboCargaTipo
            // 
            this.cboCargaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargaTipo.FormattingEnabled = true;
            this.cboCargaTipo.Location = new System.Drawing.Point(15, 47);
            this.cboCargaTipo.Name = "cboCargaTipo";
            this.cboCargaTipo.Size = new System.Drawing.Size(82, 21);
            this.cboCargaTipo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso";
            // 
            // txtCargaPeso
            // 
            this.txtCargaPeso.DecimalPlaces = 2;
            this.txtCargaPeso.Location = new System.Drawing.Point(128, 48);
            this.txtCargaPeso.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtCargaPeso.Name = "txtCargaPeso";
            this.txtCargaPeso.Size = new System.Drawing.Size(80, 20);
            this.txtCargaPeso.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso Disponible:";
            // 
            // txtPesoDisp
            // 
            this.txtPesoDisp.AutoSize = true;
            this.txtPesoDisp.Location = new System.Drawing.Point(692, 49);
            this.txtPesoDisp.Name = "txtPesoDisp";
            this.txtPesoDisp.Size = new System.Drawing.Size(0, 13);
            this.txtPesoDisp.TabIndex = 4;
            // 
            // addCarga
            // 
            this.addCarga.Location = new System.Drawing.Point(237, 45);
            this.addCarga.Name = "addCarga";
            this.addCarga.Size = new System.Drawing.Size(23, 23);
            this.addCarga.TabIndex = 15;
            this.addCarga.Text = "+";
            this.addCarga.UseVisualStyleBackColor = true;
            this.addCarga.Click += new System.EventHandler(this.addCarga_Click);
            // 
            // btnHabCarga
            // 
            this.btnHabCarga.Location = new System.Drawing.Point(567, 42);
            this.btnHabCarga.Name = "btnHabCarga";
            this.btnHabCarga.Size = new System.Drawing.Size(20, 20);
            this.btnHabCarga.TabIndex = 5;
            this.btnHabCarga.Text = "#";
            this.btnHabCarga.UseVisualStyleBackColor = true;
            this.btnHabCarga.Click += new System.EventHandler(this.btnHabCarga_Click);
            // 
            // FrmCargasCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHabCarga);
            this.Controls.Add(this.txtPesoDisp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCargasCamion";
            this.Text = "FrmCargasCamion";
            this.Load += new System.EventHandler(this.FrmCargasCamion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargaPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewButtonColumn colOp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCargaTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtCargaPeso;
        private System.Windows.Forms.Button addCarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtPesoDisp;
        private System.Windows.Forms.Button btnHabCarga;
    }
}