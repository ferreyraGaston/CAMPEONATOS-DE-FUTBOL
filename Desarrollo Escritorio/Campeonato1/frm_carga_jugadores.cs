using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Entidades;

using MySql.Data.MySqlClient;

namespace Campeonato1
{
    public partial class frm_carga_jugadores : Form
    {
        public Jugadores objJugador = new Jugadores();
        public ClaseJugadores objCargaJugador = new ClaseJugadores();
        public ClaseJugadores objControlJugador = new ClaseJugadores();
        private int nro_equipo = -1;
        private string nom_equipo = "";

        public frm_carga_jugadores(int id_equipo_p, string nombre_p)
        {
            InitializeComponent();
            nro_equipo = id_equipo_p;
            nom_equipo = nombre_p;
            lbl_equipo.Text = nom_equipo;
            txt_apellido.Focus();
        }

        private void Limpiar()
        {
            txt_apellido.Clear();
            txt_nombres.Clear();
            txt_dni.Clear();
            mtb_nac.Clear();
            lbl_edad.Text = "..";
            txt_apellido.Focus();
        }

        
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombres.Text;
            if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+$"))
            {
                //MessageBox.Show("El campo Nombre solo debe contener letras");
                //return;
            }
            string apellido = txt_apellido.Text;
            if (!Regex.IsMatch(apellido, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El campo Apellido solo debe contener letras");
                return;
            }
            string dni = txt_dni.Text;
            if (!Regex.IsMatch(dni, @"^\d{8}$"))
            {
                MessageBox.Show("El campo DNI debe tener un máximo de 8 dígitos");
                return;
            }
            
            string control = objControlJugador.ObtenerEquipoPorDni(int.Parse(txt_dni.Text));
            if (control == "")
            {
                int ngrabados = -1;
                objJugador.pApellido = txt_apellido.Text.Trim();
                objJugador.pNombre = txt_nombres.Text.Trim();
                objJugador.pDni = int.Parse(txt_dni.Text.Trim());
                objJugador.pFechaNac = DateTime.ParseExact(mtb_nac.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                objJugador.pEdad = int.Parse(lbl_edad.Text);
                objJugador.pEquipo = nro_equipo;

                ngrabados = objCargaJugador.abmJugadores("Agregar", objJugador);
                if (ngrabados != -1)
                {
                    MessageBox.Show("Se grabo con exito el jugador");
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show(string.Format("El DNI {0} ya está anotado en el equipo {1}", txt_dni.Text, control));
                txt_dni.Clear();
                txt_dni.Focus();
            }


        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo puede ingresar numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
                mtb_nac.Focus();
                mtb_nac.SelectAll();
                return;
            }

            lbl_edad.Text = edadEnAnios.ToString();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
