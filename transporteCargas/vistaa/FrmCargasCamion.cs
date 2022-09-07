using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transporteCargas.datos;
using transporteCargas.models;

namespace transporteCargas.vistaa
{
    public partial class FrmCargasCamion : Form
    {
        helperDb helper;
        Camion oCamion;
        decimal pesoActual;
        public FrmCargasCamion(Camion camion)
        {
            InitializeComponent();
            helper = new helperDb();
            oCamion = camion;
        }

        private void FrmCargasCamion_Load(object sender, EventArgs e)
        {
            cargarCargas();
            panel1.Enabled = false;
            cargarCombo();
            actPesoDisp();
        }

        private decimal actPesoDisp()
        {
            txtPesoDisp.Text = (oCamion.pesoMax - pesoActual).ToString();
            return (oCamion.pesoMax - pesoActual);


        }

        private void cargarCombo()
        {
            cboCargaTipo.DataSource = helper.ConsultaSQL("select * from tipoCarga");
            cboCargaTipo.DisplayMember = "nombre";
            cboCargaTipo.ValueMember = "id";
            cboCargaTipo.SelectedIndex = -1;
        }

        public void cargarCargas()
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id", oCamion.idCamion));
            DataTable dt = helper.ConsultaSQL("dbo.SP_CONSULTAR_CARGAS_CAMIONN",lst);

            dataGridView1.Rows.Clear();
            pesoActual = 0;
            foreach (DataRow fila in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] {
                    fila["CargaNro"].ToString(),
                    fila["Peso"].ToString(),
                    fila["Tipo"].ToString(),
                    "Eliminar"});
                pesoActual += Convert.ToDecimal(fila["Peso"]);
            }


        }

        private void btnHabCarga_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void addCarga_Click(object sender, EventArgs e)
        {
            if (cboCargaTipo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un Tipo de Carga!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Convert.ToInt32(txtCargaPeso.Value) < 1 || txtCargaPeso.Value > actPesoDisp())
            {
                MessageBox.Show($"Debe ingresar un peso valido, que no supere los limites! Peso disponible:{actPesoDisp()}", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Carga oCarga = new Carga(Convert.ToInt32(cboCargaTipo.SelectedValue) , txtCargaPeso.Value);

            insertarCarga(oCarga);
            cargarCargas();
            actPesoDisp();
            cboCargaTipo.SelectedIndex = -1;
            txtCargaPeso.Value = 0;
            panel1.Enabled = false;
        }

        private void insertarCarga(Carga oCarga)
        {
            try
            {
                List<Parametro> listParam = new List<Parametro>();
                listParam.Add(new Parametro("@id", helper.ProximoIdCarga(oCamion.idCamion)));
                listParam.Add(new Parametro("@idCamion", oCamion.idCamion));
                listParam.Add(new Parametro("@peso", oCarga.peso));
                listParam.Add(new Parametro("@idTipoCarga",oCarga.idTipo));

                helper.ConsultaSQL("dbo.SP_INSERTAR_CARGA",listParam);

                
            }
            catch (Exception)
            {
                    MessageBox.Show("ERROR. No se pudo registrar la Carga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

                throw;
            }
        }
    }
}
