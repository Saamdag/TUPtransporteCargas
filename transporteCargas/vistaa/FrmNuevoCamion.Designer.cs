namespace transporteCargas.vistaa
{
    partial class FrmNuevoCamion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesoCarga = new System.Windows.Forms.NumericUpDown();
            this.pesoMax = new System.Windows.Forms.NumericUpDown();
            this.btnAddCarga = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelCarga = new System.Windows.Forms.Panel();
            this.panelCamion = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpcion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoMax)).BeginInit();
            this.panelCarga.SuspendLayout();
            this.panelCamion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camion Nro :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso Maximo";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(95, 29);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 4;
            this.txtPatente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(95, 66);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(100, 21);
            this.cboEstado.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipo,
            this.colPeso,
            this.colOpcion});
            this.dataGridView1.Location = new System.Drawing.Point(29, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 183);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Agregar Carga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tipo";
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.Location = new System.Drawing.Point(65, 40);
            this.cboTipoCarga.Name = "cboTipoCarga";
            this.cboTipoCarga.Size = new System.Drawing.Size(100, 21);
            this.cboTipoCarga.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Peso";
            // 
            // txtPesoCarga
            // 
            this.txtPesoCarga.DecimalPlaces = 2;
            this.txtPesoCarga.Location = new System.Drawing.Point(217, 40);
            this.txtPesoCarga.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPesoCarga.Name = "txtPesoCarga";
            this.txtPesoCarga.Size = new System.Drawing.Size(120, 20);
            this.txtPesoCarga.TabIndex = 13;
            // 
            // pesoMax
            // 
            this.pesoMax.DecimalPlaces = 2;
            this.pesoMax.Location = new System.Drawing.Point(95, 111);
            this.pesoMax.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.pesoMax.Name = "pesoMax";
            this.pesoMax.Size = new System.Drawing.Size(120, 20);
            this.pesoMax.TabIndex = 14;
            // 
            // btnAddCarga
            // 
            this.btnAddCarga.Location = new System.Drawing.Point(343, 38);
            this.btnAddCarga.Name = "btnAddCarga";
            this.btnAddCarga.Size = new System.Drawing.Size(23, 23);
            this.btnAddCarga.TabIndex = 15;
            this.btnAddCarga.Text = "+";
            this.btnAddCarga.UseVisualStyleBackColor = true;
            this.btnAddCarga.Click += new System.EventHandler(this.btnAddCarga_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(249, 288);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(355, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelCarga
            // 
            this.panelCarga.Controls.Add(this.label6);
            this.panelCarga.Controls.Add(this.dataGridView1);
            this.panelCarga.Controls.Add(this.label7);
            this.panelCarga.Controls.Add(this.btnAddCarga);
            this.panelCarga.Controls.Add(this.cboTipoCarga);
            this.panelCarga.Controls.Add(this.label8);
            this.panelCarga.Controls.Add(this.txtPesoCarga);
            this.panelCarga.Location = new System.Drawing.Point(317, 18);
            this.panelCarga.Name = "panelCarga";
            this.panelCarga.Size = new System.Drawing.Size(386, 253);
            this.panelCarga.TabIndex = 18;
            // 
            // panelCamion
            // 
            this.panelCamion.Controls.Add(this.button1);
            this.panelCamion.Controls.Add(this.label2);
            this.panelCamion.Controls.Add(this.label3);
            this.panelCamion.Controls.Add(this.label4);
            this.panelCamion.Controls.Add(this.txtPatente);
            this.panelCamion.Controls.Add(this.pesoMax);
            this.panelCamion.Controls.Add(this.cboEstado);
            this.panelCamion.Location = new System.Drawing.Point(33, 56);
            this.panelCamion.Name = "panelCamion";
            this.panelCamion.Size = new System.Drawing.Size(248, 177);
            this.panelCamion.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colPeso
            // 
            this.colPeso.HeaderText = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.ReadOnly = true;
            // 
            // colOpcion
            // 
            this.colOpcion.HeaderText = "Editar";
            this.colOpcion.Name = "colOpcion";
            this.colOpcion.Text = "Eliminar";
            // 
            // FrmNuevoCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCamion);
            this.Controls.Add(this.panelCarga);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FrmNuevoCamion";
            this.Text = "FrmNuevoCamion";
            this.Load += new System.EventHandler(this.FrmNuevoCamion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesoCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoMax)).EndInit();
            this.panelCarga.ResumeLayout(false);
            this.panelCarga.PerformLayout();
            this.panelCamion.ResumeLayout(false);
            this.panelCamion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtPesoCarga;
        private System.Windows.Forms.NumericUpDown pesoMax;
        private System.Windows.Forms.Button btnAddCarga;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelCarga;
        private System.Windows.Forms.Panel panelCamion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewButtonColumn colOpcion;
    }
}