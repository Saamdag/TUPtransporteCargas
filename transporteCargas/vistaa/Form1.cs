using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transporteCargas.vistaa;

namespace transporteCargas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNuevoCamion_Click(object sender, EventArgs e)
        {
            FrmNuevoCamion frmNuevoCamion = new FrmNuevoCamion();
            frmNuevoCamion.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultarCamiones frmConsultarCamiones = new FrmConsultarCamiones();
            frmConsultarCamiones.ShowDialog();
        }
    }
}
