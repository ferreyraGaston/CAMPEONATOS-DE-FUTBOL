using CapaDatos;
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
    public partial class frm_carga_sancion : Form
    {
        public Jugadores objJugador = new Jugadores();
        public ClaseJugadores objCargaJugador = new ClaseJugadores();
        public Fechas objFechas = new Fechas();
        public ClaseFecha objClaseFecha = new ClaseFecha();
        public ClaseSancion objSancionR = new ClaseSancion();
        public ClaseSancion objSancionC = new ClaseSancion();

        public frm_carga_sancion()
        {
            
        }
        public frm_carga_sancion(Jugadores jugadorP, string nombreE)
        {
            InitializeComponent();
            objJugador = jugadorP;
            lbl_jugador.Text = jugadorP.pApellido + " " + jugadorP.pNombre;
            lbl_equipo.Text = nombreE;
            CargarCmbE();
            CargarCmbM();
        }
        private void CargarCmbE()
        {
            cmb_fechas.DataSource = objClaseFecha.listadoFechas();
            cmb_fechas.DisplayMember = "pNum_fecha";
            cmb_fechas.ValueMember = "pID_fecha";

            cmb_fechas.SelectedIndex = -1;

        }
        private void CargarCmbM()
        {
            cmb_motivo.Items.Clear();

            try
            {
                List<(int IdMotivo, string Razon)> motivos = objSancionR.ListadoMotivo();

                // Extraer las razones y agregar al ComboBox
                cmb_motivo.Items.AddRange(motivos.Select(t => t.Razon).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener motivos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_carga_Click(object sender, EventArgs e)
        {
            
            if (cmb_fechas.SelectedIndex != -1)
            {
                if (rdb_amarilla.Checked == true)
                {
                    int ngrabados = -1;
                    objSancionC = new ClaseSancion();
                    ngrabados = objSancionC.abmSancion("Amarilla", objJugador.pDni, Convert.ToInt32(cmb_fechas.SelectedValue), 0);
                    if (ngrabados != -1)
                    {
                        MessageBox.Show("Se grabo con exito la sancion");
                        Close();
                    }
                }
                else if (rdb_roja.Checked == true && cmb_motivo.SelectedIndex != -1)
                {
                    int ngrabados = -1;
                    objSancionC = new ClaseSancion();
                    ngrabados = objSancionC.abmSancion("Roja", objJugador.pDni, Convert.ToInt32(cmb_fechas.SelectedValue), Convert.ToInt32(cmb_motivo.SelectedValue));
                    if (ngrabados != -1)
                    {
                        MessageBox.Show("Se grabo con exito la sancion");
                        Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe elegir el motivo de la sancion");
                    cmb_motivo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe elegir la fecha de la sancion");
                cmb_fechas.Focus();
            }
        }

        private void rdb_roja_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_roja.Checked == true)
            {
                cmb_motivo.Enabled = true;
            }
            else 
            {  
                cmb_motivo.Enabled = false;
            }
        }
    }
}
