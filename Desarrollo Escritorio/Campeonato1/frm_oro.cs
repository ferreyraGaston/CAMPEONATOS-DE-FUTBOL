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
        public CopaOro CopaOro=new CopaOro();
        public ClaseCopaOro ClaseCopaOro=new ClaseCopaOro();
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
                    CopaOro.IdZona = 1;
                    txt_eq1.Text = nombresEquipos[0];
                        
                        CopaOro.Equipo = nombresEquipos[0];
                        ClaseCopaOro.abmEquipos("Agregar");
                    txt_eq2.Text = nombresEquipos[1];

                        CopaOro.Equipo = nombresEquipos[1];
                        ClaseCopaOro.abmEquipos("Agregar");
                    txt_eq3.Text = nombresEquipos[2];

                        CopaOro.Equipo = nombresEquipos[2];
                        ClaseCopaOro.abmEquipos("Agregar");
                    txt_eq4.Text = nombresEquipos[3];

                        CopaOro.Equipo = nombresEquipos[3];
                        ClaseCopaOro.abmEquipos("Agregar");
                    txt_eq5.Text = nombresEquipos[4];

                        CopaOro.Equipo = nombresEquipos[4];
                        ClaseCopaOro.abmEquipos("Agregar");
                    txt_eq6.Text = nombresEquipos[5];

                        CopaOro.Equipo = nombresEquipos[5];
                        ClaseCopaOro.abmEquipos("Agregar");
                    txt_eq7.Text = nombresEquipos[6];

                        CopaOro.Equipo = nombresEquipos[6];
                        ClaseCopaOro.abmEquipos("Agregar");
                    txt_eq8.Text = nombresEquipos[7];

                        CopaOro.Equipo = nombresEquipos[7];
                        ClaseCopaOro.abmEquipos("Agregar");
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

                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = nombresEquipos[0];
                        CopaOro.Gol1 = (int)NuDown1.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 1;
                        CopaOro.Equipo = nombresEquipos[1];
                        CopaOro.Gol1 = (int)NuDown2.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                    else
                    {
                        textBox8.Text = nombresEquipos[1];
                        CopaOro.IdZona = 1;
                        CopaOro.Equipo = nombresEquipos[0];
                        CopaOro.Gol1 = (int)NuDown1.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = nombresEquipos[1];
                        CopaOro.Gol1 = (int)NuDown2.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                    if (NuDown3.Value > NuDown4.Value)
                    {
                        textBox9.Text = nombresEquipos[2];
                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = nombresEquipos[2];
                        CopaOro.Gol1 = (int)NuDown3.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 1;
                        CopaOro.Equipo = nombresEquipos[3];
                        CopaOro.Gol1 = (int)NuDown4.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                    else
                    {
                        textBox9.Text = nombresEquipos[3];
                        CopaOro.IdZona = 1;
                        CopaOro.Equipo = nombresEquipos[2];
                        CopaOro.Gol1 = (int)NuDown3.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = nombresEquipos[3];
                        CopaOro.Gol1 = (int)NuDown4.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                    if (NuDown5.Value > NuDown6.Value)
                    {
                        textBox10.Text = nombresEquipos[4];
                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = nombresEquipos[4];
                        CopaOro.Gol1 = (int)NuDown5.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 1;
                        CopaOro.Equipo = nombresEquipos[5];
                        CopaOro.Gol1 = (int)NuDown6.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                    else
                    {
                        textBox10.Text = nombresEquipos[5];
                        CopaOro.IdZona = 1;
                        CopaOro.Equipo = nombresEquipos[4];
                        CopaOro.Gol1 = (int)NuDown5.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = nombresEquipos[5];
                        CopaOro.Gol1 = (int)NuDown6.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                    if (NuDown7.Value > NuDown8.Value)
                    {
                        textBox11.Text = nombresEquipos[6];
                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = nombresEquipos[6];
                        CopaOro.Gol1 = (int)NuDown7.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 1;
                        CopaOro.Equipo = nombresEquipos[7];
                        CopaOro.Gol1 = (int)NuDown8.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                    else
                    {
                        textBox11.Text = nombresEquipos[7];
                        CopaOro.IdZona = 1;
                        CopaOro.Equipo = nombresEquipos[6];
                        CopaOro.Gol1 = (int)NuDown7.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = nombresEquipos[7];
                        CopaOro.Gol1 = (int)NuDown8.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                }
                else
                {
                    if (NuDown9.Value > NuDown10.Value)
                    {
                        textBox12.Text = textBox8.Text;

                        CopaOro.IdZona = 7;
                        CopaOro.Equipo = textBox8.Text;
                        CopaOro.Gol2 = (int)NuDown9.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemi");

                    }
                    else
                    {
                        textBox12.Text = textBox9.Text;

                        CopaOro.IdZona = 7;
                        CopaOro.Equipo = textBox9.Text;
                        CopaOro.Gol2 = (int)NuDown10.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemi");
                    }
                    if (NuDown11.Value > NuDown12.Value)
                    {
                        textBox13.Text = textBox10.Text;

                        CopaOro.IdZona = 7;
                        CopaOro.Equipo = textBox10.Text;
                        CopaOro.Gol2 = (int)NuDown11.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemi");
                    }
                    else
                    {
                        textBox13.Text = textBox11.Text;

                        CopaOro.IdZona = 7;
                        CopaOro.Equipo = textBox11.Text;
                        CopaOro.Gol2 = (int)NuDown12.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemi");
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

                    CopaOro.IdZona = 6;
                    CopaOro.Equipo = textBox12.Text;
                    CopaOro.Gol3 = (int)NuDown13.Value;
                    ClaseCopaOro.abmEquipos("AgregarFinal");
                }
                else
                {
                    MessageBox.Show("Equipo Ganador: " + textBox13.Text, "Alerta");
                    CopaOro.IdZona = 6;
                    CopaOro.Equipo = textBox13.Text;
                    CopaOro.Gol3 = (int)NuDown14.Value;
                    ClaseCopaOro.abmEquipos("AgregarFinal");
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
