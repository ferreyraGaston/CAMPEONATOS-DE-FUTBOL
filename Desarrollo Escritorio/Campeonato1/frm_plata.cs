using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato1
{
    public partial class frm_plata : Form
    {


        public List<Equipos> objCargaE = new List<Equipos>();
        public ClaseEquipos objCargaEquipo = new ClaseEquipos();
        public Partidos objpartido = new Partidos();
        public ClasePartidos objCargapartido = new ClasePartidos();
        public CopaPlata CopaPlata = new CopaPlata();
        public ClaseCopaPlata ClaseCopaPlata = new ClaseCopaPlata();
        public frm_plata()
        {
            InitializeComponent();
            Leer();
            LeerSemi();
            LeerFinal();
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


        void Leer()
        {
            ClaseEquipos claseEquipos = new ClaseEquipos();
            List<string> EquipoPlata = claseEquipos.ListadoEquiposCopaPlata();
            //List<string> GolesPlata = claseEquipos.ListadoEquiposCopaPlataGoles();

            if (EquipoPlata.Count >= 8)
            {
                txt_eq1.Text = EquipoPlata[0];
                //int.TryParse(GolesPlata[0], out int goles1);
                //NuDown1.Value = goles1;

                txt_eq2.Text = EquipoPlata[1];
                //int.TryParse(GolesPlata[1], out int goles2);
                //NuDown2.Value = goles2;

                txt_eq3.Text = EquipoPlata[2];
                //int.TryParse(GolesPlata[2], out int goles3);
                //NuDown3.Value = goles3;

                txt_eq4.Text = EquipoPlata[3];
                //int.TryParse(GolesPlata[3], out int goles4);
                //NuDown4.Value = goles4;

                txt_eq5.Text = EquipoPlata[4];
                //int.TryParse(GolesPlata[4], out int goles5);
                //NuDown5.Value = goles5;

                txt_eq6.Text = EquipoPlata[5];
                //int.TryParse(GolesPlata[5], out int goles6);
                //NuDown6.Value = goles6;

                txt_eq7.Text = EquipoPlata[6];
                //int.TryParse(GolesPlata[6], out int goles7);
                //NuDown7.Value = goles7;

                txt_eq8.Text = EquipoPlata[7];
                //int.TryParse(GolesPlata[7], out int goles8);
                //NuDown8.Value = goles8;
            }
            else
            {
                // Manejar la situación en la que no hay suficientes elementos en la lista.
            }
        }

        void LeerSemi()
        {
            ClaseEquipos claseEquipos = new ClaseEquipos();
            List<string> EquipoPLata = claseEquipos.ListadoEquiposCopaPlata();
            //List<string> GolesPlata = claseEquipos.ListadoEquiposCopaPlataGolesSemis();
            if (EquipoPLata.Count >= 12)
            {
                textBox8.Text = EquipoPLata[8];
                //int.TryParse(GolesPlata[8], out int goles9);
                //NuDown9.Value = goles9;

                textBox9.Text = EquipoPLata[9];
                //int.TryParse(GolesPlata[9], out int goles10);
                //NuDown10.Value = goles10;

                textBox10.Text = EquipoPLata[10];
                //int.TryParse(GolesPlata[10], out int goles11);
                //NuDown11.Value = goles11;

                textBox11.Text = EquipoPLata[11];
                //int.TryParse(GolesPlata[11], out int goles12);
                //NuDown12.Value = goles12;
            }
            else
            {
                // Manejar la situación en la que no hay suficientes elementos en la lista.
            }
        }


        void LeerFinal()
        {
            ClaseEquipos claseEquipos = new ClaseEquipos();
            List<string> EquipoPlata = claseEquipos.ListadoEquiposCopaPlata();
            List<string> GolesPlata = claseEquipos.ListadoEquiposCopaPlataGolesfinal();
            if (EquipoPlata.Count >= 13)
            {
                textBox12.Text = EquipoPlata[12];
                int.TryParse(GolesPlata[12], out int goles13);
                NuDown13.Value = goles13;

                textBox13.Text = EquipoPlata[13];
                int.TryParse(GolesPlata[13], out int goles14);
                NuDown14.Value = goles14;
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
            List<string> EquipoPlata = claseEquipos.ListadoEquiposCopaPlata();


            if (nombresEquipos != null && EquipoPlata.Count < 8 && nombresEquipos.Count >= 8)
            {


                CopaPlata.IdZona = 1;
                CopaPlata.Equipo = nombresEquipos[8];
                ClaseCopaPlata.abmEquiposPlata("Agregar");


                CopaPlata.IdZona = 1;
                CopaPlata.Equipo = nombresEquipos[9];
                ClaseCopaPlata.abmEquiposPlata("Agregar");


                CopaPlata.IdZona = 2;
                CopaPlata.Equipo = nombresEquipos[10];
                ClaseCopaPlata.abmEquiposPlata("Agregar");


                CopaPlata.IdZona = 2;
                CopaPlata.Equipo = nombresEquipos[11];
                ClaseCopaPlata.abmEquiposPlata("Agregar");


                CopaPlata.IdZona = 3;
                CopaPlata.Equipo = nombresEquipos[12];
                ClaseCopaPlata.abmEquiposPlata("Agregar");


                CopaPlata.IdZona = 3;
                CopaPlata.Equipo = nombresEquipos[13];
                ClaseCopaPlata.abmEquiposPlata("Agregar");


                CopaPlata.IdZona = 4;
                CopaPlata.Equipo = nombresEquipos[14];
                ClaseCopaPlata.abmEquiposPlata("Agregar");


                CopaPlata.IdZona = 4;
                CopaPlata.Equipo = nombresEquipos[15];
                ClaseCopaPlata.abmEquiposPlata("Agregar");

                Leer();
            }
            else
            {

                if ((NuDown1.Value != 0 || NuDown2.Value != 0) && (NuDown3.Value != 0 || NuDown4.Value != 0) && (NuDown5.Value != 0 || NuDown6.Value != 0) && (NuDown7.Value != 0 || NuDown8.Value != 0) && EquipoPlata.Count == 8)
                {

                    /***************partido # 1 ***************************/
                    if (NuDown1.Value > NuDown2.Value && EquipoPlata.Count < 9)
                    {
                        CopaPlata.IdZona = 5;
                        CopaPlata.Equipo = EquipoPlata[0];
                        CopaPlata.Gol1 = (int)NuDown1.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartos");

                        CopaPlata.IdZona = 1;
                        CopaPlata.Equipo = EquipoPlata[1];
                        CopaPlata.Gol1 = (int)NuDown2.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartosPerdido");
                    }
                    else
                    {
                        CopaPlata.IdZona = 1;
                        CopaPlata.Equipo = EquipoPlata[0];
                        CopaPlata.Gol1 = (int)NuDown1.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartosPerdido");

                        CopaPlata.IdZona = 5;
                        CopaPlata.Equipo = EquipoPlata[1];
                        CopaPlata.Gol1 = (int)NuDown2.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartos");
                    }
                    /***************partido # 2 ***************************/
                    if (NuDown3.Value > NuDown4.Value && EquipoPlata.Count < 9)
                    {
                        CopaPlata.IdZona = 5;
                        CopaPlata.Equipo = EquipoPlata[2];
                        CopaPlata.Gol1 = (int)NuDown3.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartos");

                        CopaPlata.IdZona = 2;
                        CopaPlata.Equipo = EquipoPlata[3];
                        CopaPlata.Gol1 = (int)NuDown4.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartosPerdido");
                    }
                    else
                    {
                        CopaPlata.IdZona = 2;
                        CopaPlata.Equipo = EquipoPlata[2];
                        CopaPlata.Gol1 = (int)NuDown3.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartosPerdido");

                        CopaPlata.IdZona = 5;
                        CopaPlata.Equipo = EquipoPlata[3];
                        CopaPlata.Gol1 = (int)NuDown4.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartos");
                    }
                    /***************partido # 3 ***************************/
                    if (NuDown5.Value > NuDown6.Value && EquipoPlata.Count < 9)
                    {
                        CopaPlata.IdZona = 6;
                        CopaPlata.Equipo = EquipoPlata[4];
                        CopaPlata.Gol1 = (int)NuDown5.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartos");

                        CopaPlata.IdZona = 3;
                        CopaPlata.Equipo = EquipoPlata[5];
                        CopaPlata.Gol1 = (int)NuDown6.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartosPerdido");
                    }
                    else
                    {
                        CopaPlata.IdZona = 3;
                        CopaPlata.Equipo = EquipoPlata[4];
                        CopaPlata.Gol1 = (int)NuDown5.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartosPerdido");

                        CopaPlata.IdZona = 6;
                        CopaPlata.Equipo = EquipoPlata[5];
                        CopaPlata.Gol1 = (int)NuDown6.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartos");
                    }
                    /***************partido # 4 ***************************/
                    if (NuDown7.Value > NuDown8.Value && EquipoPlata.Count < 9)
                    {
                        CopaPlata.IdZona = 6;
                        CopaPlata.Equipo = EquipoPlata[6];
                        CopaPlata.Gol1 = (int)NuDown7.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartos");

                        CopaPlata.IdZona = 4;
                        CopaPlata.Equipo = EquipoPlata[7];
                        CopaPlata.Gol1 = (int)NuDown8.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartosPerdido");
                    }
                    else
                    {
                        CopaPlata.IdZona = 4;
                        CopaPlata.Equipo = EquipoPlata[6];
                        CopaPlata.Gol1 = (int)NuDown7.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartosPerdido");

                        CopaPlata.IdZona = 6;
                        CopaPlata.Equipo = EquipoPlata[7];
                        CopaPlata.Gol1 = (int)NuDown8.Value;
                        ClaseCopaPlata.abmEquiposPlata("AgregarCuartos");
                    }
                    LeerSemi();
                }
                
                else
                {
                    if ((NuDown9.Value != 0 || NuDown10.Value != 0) && (NuDown11.Value != 0 || NuDown12.Value != 0) && (NuDown13.Value == 0 || NuDown14.Value == 0))
                    {
                        /***************partido Semifinal # 1 ***************************/
                        if (NuDown9.Value > NuDown10.Value && EquipoPlata.Count <= 12)
                        {
                            CopaPlata.Equipo = textBox9.Text;
                            CopaPlata.Gol2 = (int)NuDown10.Value;
                            ClaseCopaPlata.abmEquiposPlata("AgregarSemiPerdido");

                            CopaPlata.IdZona = 7;
                            CopaPlata.Equipo = textBox8.Text;
                            CopaPlata.Gol2 = (int)NuDown9.Value;
                            ClaseCopaPlata.abmEquiposPlata("AgregarSemi");

                        }
                        else
                        {
                            CopaPlata.Equipo = textBox8.Text;
                            CopaPlata.Gol2 = (int)NuDown9.Value;
                            ClaseCopaPlata.abmEquiposPlata("AgregarSemiPerdido");

                            CopaPlata.IdZona = 7;
                            CopaPlata.Equipo = textBox9.Text;
                            CopaPlata.Gol2 = (int)NuDown10.Value;
                            ClaseCopaPlata.abmEquiposPlata("AgregarSemi");
                        }
                        /***************partido Semifinal # 2 ***************************/
                        if (NuDown11.Value > NuDown12.Value && EquipoPlata.Count <= 12)
                        {
                            CopaPlata.Equipo = textBox11.Text;
                            CopaPlata.Gol2 = (int)NuDown12.Value;
                            ClaseCopaPlata.abmEquiposPlata("AgregarSemiPerdido");

                            CopaPlata.IdZona = 7;
                            CopaPlata.Equipo = textBox10.Text;
                            CopaPlata.Gol2 = (int)NuDown11.Value;
                            ClaseCopaPlata.abmEquiposPlata("AgregarSemi");
                        }
                        else
                        {
                            CopaPlata.IdZona = 7;
                            CopaPlata.Equipo = textBox11.Text;
                            CopaPlata.Gol2 = (int)NuDown12.Value;
                            ClaseCopaPlata.abmEquiposPlata("AgregarSemi");

                            CopaPlata.Equipo = textBox10.Text;
                            CopaPlata.Gol2 = (int)NuDown11.Value;
                            ClaseCopaPlata.abmEquiposPlata("AgregarSemiPerdido");
                        }
                        LeerFinal();
                    }
                    else
                        {
                            MessageBox.Show("Inserte el resultado por favor");
                        }

                        if ((NuDown13.Value != 0 || NuDown14.Value != 0) && EquipoPlata.Count == 14)
                        {
                            if (NuDown13.Value > NuDown14.Value)
                            {
                                MessageBox.Show("Equipo Ganador: " + textBox12.Text, "Alerta");
                                CopaPlata.IdZona = 8;
                                CopaPlata.Equipo = textBox12.Text;
                                CopaPlata.Gol3 = (int)NuDown14.Value;
                                ClaseCopaPlata.abmEquiposPlata("AgregarFinal");

                                CopaPlata.Equipo = textBox13.Text;
                                CopaPlata.Gol3 = (int)NuDown13.Value;
                                ClaseCopaPlata.abmEquiposPlata("AgregarFinalPerdido");



                            }
                            else
                            {
                                MessageBox.Show("Equipo Ganador: " + textBox13.Text, "Alerta");

                                CopaPlata.IdZona = 8;
                                CopaPlata.Equipo = textBox13.Text;
                                CopaPlata.Gol3 = (int)NuDown13.Value;
                                ClaseCopaPlata.abmEquiposPlata("AgregarFinal");

                                CopaPlata.Equipo = textBox12.Text;
                                CopaPlata.Gol3 = (int)NuDown14.Value;
                                ClaseCopaPlata.abmEquiposPlata("AgregarFinalPerdido");

                            }

                        }


                }


            }

        }


    }
}
