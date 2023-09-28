using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Justicia
{
    public partial class buscarPorNombre : Form
    {
        Profugos oProfugo;
        DataTable tProfugo;
        public buscarPorNombre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string buscar = textBox1.Text;

            foreach (DataRow fBuscar in tProfugo.Rows)
            {
                string Alias = fBuscar["alias"].ToString().ToLower();

                if (Alias.Contains(buscar.ToLower()))
                {
                    dataGridView1.Rows.Add(fBuscar["nombre"], fBuscar["alias"]);
                }
                
            }
        }

        private void buscarPorNombre_Load(object sender, EventArgs e)
        {
            oProfugo = new Profugos();
            tProfugo = oProfugo.GetData();

        }
    }
}
