using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
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
        public CopaOro CopaOro = new CopaOro();
        public ClaseCopaOro ClaseCopaOro = new ClaseCopaOro();
        public frm_oro()
        {
            InitializeComponent();
            Leer();
            LeerSemi();
            LeerFinal();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Leer()
        {
            ClaseEquipos claseEquipos = new ClaseEquipos();
            List<string> EquipoOro = claseEquipos.ListadoEquiposCopaOro();

            if (EquipoOro.Count >= 8)
            {
                txt_eq1.Text = EquipoOro[0];
                txt_eq2.Text = EquipoOro[1];
                txt_eq3.Text = EquipoOro[2];
                txt_eq4.Text = EquipoOro[3];
                txt_eq5.Text = EquipoOro[4];
                txt_eq6.Text = EquipoOro[5];
                txt_eq7.Text = EquipoOro[6];
                txt_eq8.Text = EquipoOro[7];
            }
            else
            {
                // Manejar la situación en la que no hay suficientes elementos en la lista.
            }
        }

        void LeerSemi()
        {
            ClaseEquipos claseEquipos = new ClaseEquipos();
            List<string> EquipoOro = claseEquipos.ListadoEquiposCopaOro();

            if (EquipoOro.Count >= 12)
            {
                textBox8.Text = EquipoOro[8];
                textBox9.Text = EquipoOro[9];
                textBox10.Text = EquipoOro[10];
                textBox11.Text = EquipoOro[11];
            }
            else
            {
                // Manejar la situación en la que no hay suficientes elementos en la lista.
            }
        }


        void LeerFinal()
        {
            ClaseEquipos claseEquipos = new ClaseEquipos();
            List<string> EquipoOro = claseEquipos.ListadoEquiposCopaOro();

            if (EquipoOro.Count >= 14)
            {
                textBox12.Text = EquipoOro[12];
                textBox13.Text = EquipoOro[13];
            }
            else
            {
                // Manejar la situación en la que no hay suficientes elementos en la lista.
            }
        }

        private void btn_carga_Click(object sender, EventArgs e)
        {
            ClaseEquipos claseEquipos = new ClaseEquipos();
            List<string> nombresEquipos = claseEquipos.ListadoEquiposPlayoff();
            List<string> EquipoOro = claseEquipos.ListadoEquiposCopaOro();


            if (nombresEquipos != null && EquipoOro.Count < 8 && nombresEquipos.Count >= 8)
            {
                    
                    
                    CopaOro.IdZona = 1;
                    CopaOro.Equipo = nombresEquipos[0];
                    ClaseCopaOro.abmEquipos("Agregar");

                    
                    CopaOro.IdZona = 1;
                    CopaOro.Equipo = nombresEquipos[1];
                    ClaseCopaOro.abmEquipos("Agregar");

                    
                    CopaOro.IdZona = 2;
                    CopaOro.Equipo = nombresEquipos[2];
                    ClaseCopaOro.abmEquipos("Agregar");

                    
                    CopaOro.IdZona = 2;
                    CopaOro.Equipo = nombresEquipos[3];
                    ClaseCopaOro.abmEquipos("Agregar");

                    
                    CopaOro.IdZona = 3;
                    CopaOro.Equipo = nombresEquipos[4];
                    ClaseCopaOro.abmEquipos("Agregar");

                    
                    CopaOro.IdZona = 3;
                    CopaOro.Equipo = nombresEquipos[5];
                    ClaseCopaOro.abmEquipos("Agregar");

                    
                    CopaOro.IdZona = 4;
                    CopaOro.Equipo = nombresEquipos[6];
                    ClaseCopaOro.abmEquipos("Agregar");

                    
                    CopaOro.IdZona = 4;
                    CopaOro.Equipo = nombresEquipos[7];
                    ClaseCopaOro.abmEquipos("Agregar");

                    Leer();
            }
            else 
            {

                if (NuDown9.Value == 0 && NuDown10.Value == 0 && NuDown11.Value == 0 && NuDown12.Value == 0 && EquipoOro.Count < 9)
                {


                    if (NuDown1.Value > NuDown2.Value)
                    {
                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = EquipoOro[0];
                        CopaOro.Gol1 = (int)NuDown1.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 1;
                        CopaOro.Equipo = EquipoOro[1];
                        CopaOro.Gol1 = (int)NuDown2.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartosPerdido");
                    }
                    else
                    {
                        CopaOro.IdZona = 1;
                        CopaOro.Equipo = EquipoOro[0];
                        CopaOro.Gol1 = (int)NuDown1.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartosPerdido");

                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = EquipoOro[1];
                        CopaOro.Gol1 = (int)NuDown2.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                    if (NuDown3.Value > NuDown4.Value)
                    {
                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = EquipoOro[2];
                        CopaOro.Gol1 = (int)NuDown3.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 2;
                        CopaOro.Equipo = EquipoOro[3];
                        CopaOro.Gol1 = (int)NuDown4.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartosPerdido");
                    }
                    else
                    {
                        CopaOro.IdZona = 2;
                        CopaOro.Equipo = EquipoOro[2];
                        CopaOro.Gol1 = (int)NuDown3.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartosPerdido");

                        CopaOro.IdZona = 5;
                        CopaOro.Equipo = EquipoOro[3];
                        CopaOro.Gol1 = (int)NuDown4.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                    if (NuDown5.Value > NuDown6.Value)
                    {
                        CopaOro.IdZona = 6;
                        CopaOro.Equipo = EquipoOro[4];
                        CopaOro.Gol1 = (int)NuDown5.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 3;
                        CopaOro.Equipo = EquipoOro[5];
                        CopaOro.Gol1 = (int)NuDown6.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartosPerdido");
                    }
                    else
                    {
                        CopaOro.IdZona = 3;
                        CopaOro.Equipo = EquipoOro[4];
                        CopaOro.Gol1 = (int)NuDown5.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartosPerdido");

                        CopaOro.IdZona = 6;
                        CopaOro.Equipo = EquipoOro[5];
                        CopaOro.Gol1 = (int)NuDown6.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                    if (NuDown7.Value > NuDown8.Value)
                    {
                        CopaOro.IdZona = 6;
                        CopaOro.Equipo = EquipoOro[6];
                        CopaOro.Gol1 = (int)NuDown7.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");

                        CopaOro.IdZona = 4;
                        CopaOro.Equipo = EquipoOro[7];
                        CopaOro.Gol1 = (int)NuDown8.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartosPerdido");
                    }
                    else
                    {
                        CopaOro.IdZona = 4;
                        CopaOro.Equipo = EquipoOro[6];
                        CopaOro.Gol1 = (int)NuDown7.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartosPerdido");

                        CopaOro.IdZona = 6;
                        CopaOro.Equipo = EquipoOro[7];
                        CopaOro.Gol1 = (int)NuDown8.Value;
                        ClaseCopaOro.abmEquipos("AgregarCuartos");
                    }
                    LeerSemi();
                }
                else { 
              
                    if (NuDown9.Value > NuDown10.Value)
                    {
                        CopaOro.IdZona = 7;
                        CopaOro.Equipo = textBox8.Text;
                        CopaOro.Gol2 = (int)NuDown9.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemi");

                        CopaOro.Equipo = textBox9.Text;
                        CopaOro.Gol2 = (int)NuDown10.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemiPerdido");

                    }
                    else
                    {
                        CopaOro.Equipo = textBox8.Text;
                        CopaOro.Gol2 = (int)NuDown9.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemiPerdido");

                        CopaOro.IdZona = 7;
                        CopaOro.Equipo = textBox9.Text;
                        CopaOro.Gol2 = (int)NuDown10.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemi");
                    }
                    if (NuDown11.Value > NuDown12.Value)
                    {
                        CopaOro.IdZona = 7;
                        CopaOro.Equipo = textBox10.Text;
                        CopaOro.Gol2 = (int)NuDown11.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemi");

                        CopaOro.Equipo = textBox11.Text;
                        CopaOro.Gol2 = (int)NuDown12.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemiPerdido");
                    }
                    else
                    {

                        CopaOro.Equipo = textBox10.Text;
                        CopaOro.Gol2 = (int)NuDown11.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemiPerdido");

                        CopaOro.IdZona = 7;
                        CopaOro.Equipo = textBox11.Text;
                        CopaOro.Gol2 = (int)NuDown12.Value;
                        ClaseCopaOro.abmEquipos("AgregarSemi");
                    }
                }



                if (NuDown13.Value == 0 && NuDown14.Value == 0 && EquipoOro.Count < 12)
                {

                }
                else
                {
                    if (NuDown13.Value > NuDown14.Value)
                    {
                        MessageBox.Show("Equipo Ganador: " + textBox12.Text, "Alerta");

                        CopaOro.IdZona = 7;
                        CopaOro.Equipo = textBox12.Text;
                        CopaOro.Gol3 = (int)NuDown13.Value;
                        ClaseCopaOro.abmEquipos("AgregarFinal");

                        CopaOro.Equipo = textBox13.Text;
                        CopaOro.Gol3 = (int)NuDown14.Value;
                        ClaseCopaOro.abmEquipos("AgregarFinalPerdido");
                    }
                    else
                    {
                        MessageBox.Show("Equipo Ganador: " + textBox13.Text, "Alerta");
                        CopaOro.IdZona = 7;
                        CopaOro.Equipo = textBox13.Text;
                        CopaOro.Gol3 = (int)NuDown14.Value;
                        ClaseCopaOro.abmEquipos("AgregarFinal");

                        CopaOro.Equipo = textBox12.Text;
                        CopaOro.Gol3 = (int)NuDown13.Value;
                        ClaseCopaOro.abmEquipos("AgregarFinalPerdido");
                    }
                    LeerFinal();
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
