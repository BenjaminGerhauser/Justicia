using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Justicia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Profugos oProfugo;
        DataTable tProfugo;

        private void Form1_Load(object sender, EventArgs e)
        {
            oProfugo = new Profugos();
            tProfugo = oProfugo.GetData();

            lstProfugos.DisplayMember = "nombre";
            lstProfugos.ValueMember = "id";
            lstProfugos.DataSource = tProfugo;
        }

        private void lstProfugos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (DataRow fProfugo in tProfugo.Rows)
            {
                if (fProfugo["id"].ToString() == lstProfugos.SelectedValue.ToString())
                {
                    pictureBoxFoto.Image = Image.FromFile( $"Profugos/{fProfugo["foto"]}");
                    lblAlias.Text = fProfugo["alias"].ToString();
                    DateTime fecha = Convert.ToDateTime(fProfugo["profugo_desde"]);
                    lblDesde.Text = fecha.ToString("dd/MM/yyyy");
                    lblDelito.Text = fProfugo["delitos"].ToString();
                }
            }
        }
    }
}
