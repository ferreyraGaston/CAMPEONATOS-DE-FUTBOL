using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Campeonato1
{
    public partial class frm_oro : Form
    {
        public List<Equipos> objCargaE = new List<Equipos>();
        public ClaseEquipos objCargaEquipo = new ClaseEquipos();
        public Partidos objpartido = new Partidos();
        public ClasePartidos objCargapartido = new ClasePartidos();
        public frm_oro()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_carga_Click(object sender, EventArgs e)
        {
            ClaseEquipos claseEquipos = new ClaseEquipos();
            List<string> nombresEquipos = claseEquipos.ListadoEquiposPlayoff();

            if (NuDown1.Value ==0 && NuDown2.Value == 0 && NuDown3.Value == 0 && NuDown4.Value == 0 && NuDown5.Value == 0 && NuDown6.Value == 0 && NuDown7.Value == 0 && NuDown8.Value == 0)
            {
               

                if (nombresEquipos != null && nombresEquipos.Count >= 8)
                {
                    txt_eq1.Text = nombresEquipos[0];
                    txt_eq2.Text = nombresEquipos[1];
                    txt_eq3.Text = nombresEquipos[2];
                    txt_eq4.Text = nombresEquipos[3];
                    txt_eq5.Text = nombresEquipos[4];
                    txt_eq6.Text = nombresEquipos[5];
                    txt_eq7.Text = nombresEquipos[6];
                    txt_eq8.Text = nombresEquipos[7];
                }
                else
                {
                    MessageBox.Show("No se encontraron suficientes equipos o hubo un error al cargar los datos.");
                }
            }
            else
            {
                if (NuDown9.Value == 0 && NuDown10.Value == 0 && NuDown11.Value == 0 && NuDown12.Value == 0)
                {
                    

                    if (NuDown1.Value > NuDown2.Value)
                    {
                        textBox8.Text = nombresEquipos[0];
                    }
                    else
                    {
                        textBox8.Text = nombresEquipos[1];
                    }
                    if (NuDown3.Value > NuDown4.Value)
                    {
                        textBox9.Text = nombresEquipos[2];
                    }
                    else
                    {
                        textBox9.Text = nombresEquipos[3];
                    }
                    if (NuDown5.Value > NuDown6.Value)
                    {
                        textBox10.Text = nombresEquipos[4];
                    }
                    else
                    {
                        textBox10.Text = nombresEquipos[5];
                    }
                    if (NuDown7.Value > NuDown8.Value)
                    {
                        textBox11.Text = nombresEquipos[6];
                    }
                    else
                    {
                        textBox11.Text = nombresEquipos[7];
                    }
                }
                else
                {
                    if (NuDown9.Value > NuDown10.Value)
                    {
                        textBox12.Text = textBox8.Text;
                    }
                    else
                    {
                        textBox12.Text = textBox9.Text;
                    }
                    if (NuDown11.Value > NuDown12.Value)
                    {
                        textBox13.Text = textBox10.Text;
                    }
                    else
                    {
                        textBox13.Text = textBox11.Text;
                    }
                }
            }

            if (NuDown13.Value == 0 && NuDown14.Value == 0)
            {

            }
            else
            {
                if (NuDown13.Value > NuDown14.Value)
                {
                    MessageBox.Show("Equipo Ganador: " + textBox12.Text, "Alerta");
                }
                else
                {
                    MessageBox.Show("Equipo Ganador: " + textBox13.Text, "Alerta");
                }
            }





        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PicSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
