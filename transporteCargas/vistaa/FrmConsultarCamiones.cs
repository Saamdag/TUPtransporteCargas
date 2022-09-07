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
    public partial class FrmConsultarCamiones : Form
    {
        helperDb helper;
        List<Camion> camionList;
        public FrmConsultarCamiones()
        {
            InitializeComponent();
            helper = new helperDb();
            camionList = new List<Camion>();
        }

        private void FrmConsultarCamiones_Load(object sender, EventArgs e)
        {
            cargarCamiones();
            DataTable dt = helper.ConsultaSQL("dbo.SP_CONSULTAR_CAMIONESS");
        
            
            dataGridView1.Rows.Clear();
            
            foreach (DataRow fila in dt.Rows)
            {
                dataGridView1.Rows.Add(new object[] { fila["id"].ToString(),
                    listoViaje(Convert.ToInt32(fila["id"])),
                    fila["patente"].ToString(),
                    fila["estado"].ToString(),
                    fila["pesoMax"].ToString(),
                    "Ver",
                    "Editar"});
            }


        }
        public string listoViaje(int id)
        {
            if(camionList.Find(c => c.idCamion == id).listoPartir()){

                return "75% Completado";
            }
            else
            {
                return "Incompleto";
            }
        }
        private void cargarCamiones()
        {
            camionList.Clear();
            DataTable dt2 = helper.ConsultaSQL("select * from Camion");
            foreach (DataRow fila in dt2.Rows)
            {
                Camion oCamion = new Camion();
                int idCamion = Convert.ToInt32(fila["id"].ToString());
                string patente = fila["patente"].ToString();
                int idEstado = Convert.ToInt32(fila["estado"].ToString());
                decimal pesoMax = Convert.ToDecimal(fila["pesoMax"].ToString());
                oCamion.idCamion = idCamion;
                oCamion.idEstado = idEstado;
                oCamion.patente = patente;
                oCamion.pesoMax = pesoMax;
                camionList.Add(oCamion);
            }

            cargarCargas(camionList);
        }

        private void cargarCargas(List<Camion> listCamion)
        {
            foreach (Camion oCamion in listCamion)
            {
                List<Parametro> list = new List<Parametro>();
                list.Add(new Parametro("@id", oCamion.idCamion));

                DataTable dt1 = helper.ConsultaSQL("dbo.SP_CONSULTAR_CARGASS_CAMIONN", list);
                foreach (DataRow fila in dt1.Rows)
                {
                    Carga oCarga = new Carga(Convert.ToInt32(fila["id"]), Convert.ToDecimal(fila["peso"]));
                    oCarga.idTipo = Convert.ToInt32(fila["idTipoCarga"]);
                    oCamion.agregarCarga(oCarga);
                    
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ver cargas
            if (dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                int idCamion = int.Parse(dataGridView1.CurrentRow.Cells["colId"].Value.ToString());
                FrmCargasCamion frmCargasCamion = new FrmCargasCamion(camionList.Find(C => C.idCamion == idCamion));
                frmCargasCamion.ShowDialog();
            }
        }
    }
}
