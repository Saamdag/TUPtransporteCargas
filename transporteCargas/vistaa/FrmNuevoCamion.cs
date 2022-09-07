using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transporteCargas.datos;
using transporteCargas.models;

namespace transporteCargas.vistaa
{
    public partial class FrmNuevoCamion : Form
    {
        Camion nuevoCamion;
        helperDb helper;
        public FrmNuevoCamion()
        {
            InitializeComponent();
            helper = new helperDb();
            nuevoCamion = new Camion();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCarga_Click(object sender, EventArgs e)
        {
            if (cboTipoCarga.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un Tipo de Carga!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Convert.ToInt32(txtPesoCarga.Value) < 1 || txtPesoCarga.Value > nuevoCamion.pesoDisponible())
            {
                MessageBox.Show($"Debe ingresar un peso valido, que no supere los limites! Peso disponible:{nuevoCamion.pesoDisponible()}", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Carga oCarga = new Carga(Convert.ToInt32(cboTipoCarga.SelectedValue), txtPesoCarga.Value);

            nuevoCamion.agregarCarga(oCarga);
            dataGridView1.Rows.Add(new object[] { cboTipoCarga.Text, txtPesoCarga.Value});

            cboTipoCarga.SelectedIndex = -1;
            txtPesoCarga.Value = 0;

        }

        private void FrmNuevoCamion_Load(object sender, EventArgs e)
        {
            cargarCombos();
            panelCarga.Enabled = false;


        }

        private void cargarCombos()
        {
            cboEstado.DataSource = helper.ConsultaSQL("select * from Estados");
            cboEstado.DisplayMember = "estado";
            cboEstado.ValueMember = "id";
            cboEstado.SelectedIndex = -1;

            cboTipoCarga.DataSource = helper.ConsultaSQL("select * from tipoCarga");
            cboTipoCarga.DisplayMember = "nombre";
            cboTipoCarga.ValueMember = "id";
            cboTipoCarga.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos 1 carga!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            GuardarPresupuesto();
        }

        private void GuardarPresupuesto()
        {
            if (helper.confirmarCamion(nuevoCamion))
            {
                MessageBox.Show("Camion registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el Camion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPatente.Text == "")
            {
                MessageBox.Show("Debe ingresar una Patente!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboEstado.Text == "")
            {
                MessageBox.Show("Debe seleccionar un Estado de Camion!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (pesoMax.Value < 500)
            {
                MessageBox.Show("Debe seleccionar un Peso maximo sup a 500!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            nuevoCamion.pesoMax = pesoMax.Value;
            nuevoCamion.idEstado = Convert.ToInt32(cboEstado.SelectedValue);
            nuevoCamion.patente = txtPatente.Text;

            panelCarga.Enabled = true;
            panelCamion.Enabled = false;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                nuevoCamion.QuitarCarga(dataGridView1.CurrentRow.Index);
                //click button:
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Close();
        }
    }
}
