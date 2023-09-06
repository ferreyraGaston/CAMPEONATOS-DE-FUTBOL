using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato1
{
    public partial class frm_resultados : Form
    {
        
        public frm_resultados()
        {
            InitializeComponent();
        }

        /*
        private void AbrirFormEnPanel(object formhija)
        {

            if (this.panel2.Controls.Count > 0)  // pregunta si hay algun control en el interior del panel
                this.panel2.Controls.RemoveAt(0); // si hay algun control lo elimina o remueve
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;  // hace que se acople el formulario al contenedor
            this.panel2.Controls.Add(fh);  // agregamos el formulario al panel
            this.panel2.Tag = fh;  // establecemo la instancia como contenedor de dato al panel
            fh.Show();  // mostramos el formulario.
            
        }
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resultados resultadoObj = new resultados();

            posicion = dataGridView1.CurrentRow.Index;

            resultadoObj.Id_equipo1 = int.Parse(dataGridView1[0, posicion].Value.ToString());
            resultadoObj.Id_equipo2 = int.Parse(dataGridView1[0, posicion].Value.ToString());

            resultadoObj.Equipo1 = dataGridView1[2, posicion].Value.ToString();
            resultadoObj.Equipo2 = dataGridView1[2, posicion].Value.ToString();
          
            dataGridView1.Visible = false;
            //AbrirFormEnPanel(new frm_carga_resultados());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        */
    }
}
