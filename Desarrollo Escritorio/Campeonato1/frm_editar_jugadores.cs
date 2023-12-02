using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato1
{
    public partial class frm_editar_jugadores : Form
    {
        public Jugadores objJugador = new Jugadores();
        public ClaseJugadores objCargaJugador = new ClaseJugadores();

        public frm_editar_jugadores()
        {
        }
        public frm_editar_jugadores(Jugadores jugadorP, string nombreE)
        {
            InitializeComponent();
            objJugador = jugadorP;
            txt_apellido.Text = jugadorP.pApellido;
            txt_nombres.Text = jugadorP.pNombre;
            txt_dni.Text = jugadorP.pDni.ToString();
            mtb_nac.Text = jugadorP.pFechaNac.ToString("dd/MM/yyyy");
            lbl_edad.Text = jugadorP.pEdad.ToString();
            lbl_equipo.Text = nombreE;
        }
        
        private void btn_modi_Click(object sender, EventArgs e)
        {
            if (chk_nac.Checked == false && chk_ape.Checked == false && chk_nom.Checked == false)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                int ngrabados = -1;
                objJugador.pApellido = txt_apellido.Text.Trim();
                objJugador.pNombre = txt_nombres.Text.Trim();
                objJugador.pDni = int.Parse(txt_dni.Text.Trim());
                objJugador.pFechaNac = DateTime.ParseExact(mtb_nac.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                objJugador.pEdad = int.Parse(lbl_edad.Text);
                //objJugador.pEquipo = ??

                ngrabados = objCargaJugador.abmJugadores("Modificar", objJugador);
                if (ngrabados != -1)
                {
                    MessageBox.Show("Se modifico con exito el jugador");
                    Close();
                }
            }
        }

        private void chk_nac_CheckedChanged(object sender, EventArgs e)
        {
            string fecVieja = objJugador.pFechaNac.ToString("dd/MM/yyyy");
            if (chk_nac.Checked == true)
            {
                mtb_nac.Enabled = true;
                mtb_nac.BackColor = Color.White;
                mtb_nac.Focus();
                mtb_nac.SelectAll();
            }
            else
            {
                mtb_nac.Enabled = false;
                mtb_nac.BackColor = Color.FromArgb(255, 255, 220);
                mtb_nac.Text = fecVieja;
            }
        }

        private void chk_nom_CheckedChanged(object sender, EventArgs e)
        {
            string nomViejo = objJugador.pNombre;
            if (chk_nom.Checked == true)
            {
                txt_nombres.Enabled = true;
                txt_nombres.BackColor = Color.White;
                txt_nombres.Focus();
            }
            else
            {
                txt_nombres.Enabled = false;
                txt_nombres.BackColor = Color.FromArgb(255, 255, 220);
                txt_nombres.Text = nomViejo;
            }
        }

        private void chk_ape_CheckedChanged(object sender, EventArgs e)
        {
            string nomViejo = objJugador.pApellido;
            if (chk_ape.Checked == true)
            {
                txt_apellido.Enabled = true;
                txt_apellido.BackColor = Color.White;
                txt_apellido.Focus();
            }
            else
            {
                txt_apellido.Enabled = false;
                txt_apellido.BackColor = Color.FromArgb(255, 255, 220);
                txt_apellido.Text = nomViejo;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ingresa solo letras y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ingresa solo letras y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void mtb_nac_Leave(object sender, EventArgs e)
        {
            // Obtener la fecha de nacimiento ingresada en el MaskedTextBox
            string fechaNacimientoTexto = mtb_nac.Text;

            // Validar la fecha de nacimiento
            DateTime cumple;
            if (!DateTime.TryParseExact(fechaNacimientoTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out cumple) || cumple > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no es válida o está en el futuro. Utiliza el formato dd/MM/yyyy.");
                mtb_nac.Text = objJugador.pFechaNac.ToString("dd/MM/yyyy");
                mtb_nac.Focus();
                mtb_nac.SelectAll();
                return;
            }

            // Calcular la edad
            DateTime ahora = DateTime.Now;
            TimeSpan edad = ahora - cumple;
            int edadEnAnios = (int)(edad.TotalDays / 365.25);

            // Validar que la edad no sea mayor de 70 años
            if (edadEnAnios > 70)
            {
                MessageBox.Show("La edad no puede ser mayor de 70 años.");
                mtb_nac.Text = objJugador.pFechaNac.ToString("dd/MM/yyyy");
                mtb_nac.Focus();
                mtb_nac.SelectAll();
                return;
            }

            lbl_edad.Text = edadEnAnios.ToString();
        }

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PicMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
    }
}
