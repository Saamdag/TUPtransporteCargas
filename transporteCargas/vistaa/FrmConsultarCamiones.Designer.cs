namespace transporteCargas.vistaa
{
    partial class FrmConsultarCamiones
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
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPesoMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colViaje,
            this.colPatente,
            this.colEstado,
            this.colPesoMax,
            this.colCargas,
            this.colEditar});
            this.dataGridView1.Location = new System.Drawing.Point(62, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colViaje
            // 
            this.colViaje.HeaderText = "Listo p Viaje";
            this.colViaje.Name = "colViaje";
            this.colViaje.ReadOnly = true;
            // 
            // colPatente
            // 
            this.colPatente.HeaderText = "Patente";
            this.colPatente.Name = "colPatente";
            this.colPatente.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colPesoMax
            // 
            this.colPesoMax.HeaderText = "Peso Maximo";
            this.colPesoMax.Name = "colPesoMax";
            this.colPesoMax.ReadOnly = true;
            // 
            // colCargas
            // 
            this.colCargas.HeaderText = "Cargas";
            this.colCargas.Name = "colCargas";
            this.colCargas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCargas.Text = "\"Ver\"";
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Op";
            this.colEditar.Name = "colEditar";
            this.colEditar.Text = "\"Editar\"";
            // 
            // FrmConsultarCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmConsultarCamiones";
            this.Text = "FrmConsultarCamiones";
            this.Load += new System.EventHandler(this.FrmConsultarCamiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPesoMax;
        private System.Windows.Forms.DataGridViewButtonColumn colCargas;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
    }
}