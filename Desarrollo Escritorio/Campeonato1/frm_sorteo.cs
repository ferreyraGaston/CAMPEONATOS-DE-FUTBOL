using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Entidades;
using CapaDatos;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = iTextSharp.text.Image;
using Font = iTextSharp.text.Font;

namespace Campeonato1
{
    public partial class frm_sorteo : Form
    {
        string pathFileOutput = @"E:\reportes\";  // path de guardado de fechas
        public Partidos objpartido = new Partidos();
        public ClasePartidos objCargapartido = new ClasePartidos();
        public Equipos objEquipoNew = new Equipos();
        public List<Equipos> objCargaE = new List<Equipos>();
        public ClaseEquipos objCargaEquipo = new ClaseEquipos();
        public Fechas objFechas = new Fechas();
        public ClaseFecha objClaseFecha = new ClaseFecha();
        public ClaseFecha objClaseFechaBusqueda = new ClaseFecha();
        public ClasePosiciones objEquipoPos = new ClasePosiciones();
        public int[,] fixture = new int[19, 20] { 
            { 0, 19, 1, 18, 2, 17, 3, 16, 4, 15, 5, 14, 6, 13, 7, 12, 8, 11, 9, 10},
            { 0, 18, 19, 17, 1, 16, 2, 15, 3, 14, 4, 13, 5, 12, 6, 11, 7, 10, 8, 9},
            { 0, 17, 18, 16, 19, 15, 1, 14, 2, 13, 3, 12, 4, 11, 5, 10, 6, 9, 7, 8},
            { 0, 16, 17, 15, 18, 14, 19, 13, 1, 12, 2, 11, 3, 10, 4, 9, 5, 8, 6, 7},
            { 0, 15, 16, 14, 17, 13, 18, 12, 19, 11, 1, 10, 2, 9, 3, 8, 4, 7, 5, 6},
            { 0, 14, 15, 13, 16, 12, 17, 11, 18, 10, 19, 9, 1, 8, 2, 7, 3, 6, 4, 5},
            { 0, 13, 14, 12, 15, 11, 16, 10, 17, 9, 18, 8, 19, 7, 1, 6, 2, 5, 3, 4},
            { 0, 12, 13, 11, 14, 10, 15, 9, 16, 8, 17, 7, 18, 6, 19, 5, 1, 4, 2, 3},
            { 0, 11, 12, 10, 13, 9, 14, 8, 15, 7, 16, 6, 17, 5, 18, 4, 19, 3, 1, 2},
            { 0, 10, 11, 9, 12, 8, 13, 7, 14, 6, 15, 5, 16, 4, 17, 3, 18, 2, 19, 1},
            { 0, 9, 10, 8, 11, 7, 12, 6, 13, 5, 14, 4, 15, 3, 16, 2, 17, 1, 18, 19},
            { 0, 8, 9, 7, 10, 6, 11, 5, 12, 4, 13, 3, 14, 2, 15, 1, 16, 19, 17, 18},
            { 0, 7, 8, 6, 9, 5, 10, 4, 11, 3, 12, 2, 13, 1, 14, 19, 15, 18, 16, 17},
            { 0, 6, 7, 5, 8, 4, 9, 3, 10, 2, 11, 1, 12, 19, 13, 18, 14, 17, 15, 16},
            { 0, 5, 6, 4, 7, 3, 8, 2, 9, 1, 10, 19, 11, 18, 12, 17, 13, 16, 14, 15},
            { 0, 4, 5, 3, 6, 2, 7, 1, 8, 19, 9, 18, 10, 17, 11, 16, 12, 15, 13, 14},
            { 0, 3, 4, 2, 5, 1, 6, 19, 7, 18, 8, 17, 9, 16, 10, 15, 11, 14, 12, 13},
            { 0, 2, 3, 1, 4, 19, 5, 18, 6, 17, 7, 16, 8, 15, 9, 14, 10, 13, 11, 12},
            { 0, 1, 2, 19, 3, 18, 4, 17, 5, 16, 6, 15, 7, 14, 8, 13, 9, 12, 10, 11},};

        public frm_sorteo()
        {
            InitializeComponent();
            //Contar();
            CargarCmbE();
            if (cmb_fechas.Items.Count == 0)
            {
                cmb_fechas.Enabled = false;
            }
            else
            {
                cmb_fechas.Enabled = true;
            }

            CargarEquipos();
        }

        private void CargarCmbE()
        {
            cmb_fechas.DataSource = objClaseFecha.listadoFechas();
            cmb_fechas.DisplayMember = "pNum_fecha";
            cmb_fechas.ValueMember = "pID_fecha";

            cmb_fechas.SelectedIndex = -1;

        }

        private void CargarEquipos()
        {
            int busqueda = -1;
            objCargaE = objCargaEquipo.listadoEquipos();
            busqueda = objCargaEquipo.abmEquipos("Contar", objEquipoNew);
            switch (busqueda)
            {
                case 1:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    break;
                case 2:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    break;
                case 3:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    break;
                case 4:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    break;
                case 5:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    break;
                case 6:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    break;
                case 7:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    break;
                case 8:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    break;
                case 9:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    break; 
                case 10:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    txt_equipo10.Text = ((List<Equipos>)objCargaE)[9].pNombre;
                    break;
                case 11:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    txt_equipo10.Text = ((List<Equipos>)objCargaE)[9].pNombre;
                    txt_equipo11.Text = ((List<Equipos>)objCargaE)[10].pNombre;
                    break;
                case 12:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    txt_equipo10.Text = ((List<Equipos>)objCargaE)[9].pNombre;
                    txt_equipo11.Text = ((List<Equipos>)objCargaE)[10].pNombre;
                    txt_equipo12.Text = ((List<Equipos>)objCargaE)[11].pNombre;
                    break;
                case 13:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    txt_equipo10.Text = ((List<Equipos>)objCargaE)[9].pNombre;
                    txt_equipo11.Text = ((List<Equipos>)objCargaE)[10].pNombre;
                    txt_equipo12.Text = ((List<Equipos>)objCargaE)[11].pNombre;
                    txt_equipo13.Text = ((List<Equipos>)objCargaE)[12].pNombre;
                    break;
                case 14:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    txt_equipo10.Text = ((List<Equipos>)objCargaE)[9].pNombre;
                    txt_equipo11.Text = ((List<Equipos>)objCargaE)[10].pNombre;
                    txt_equipo12.Text = ((List<Equipos>)objCargaE)[11].pNombre;
                    txt_equipo13.Text = ((List<Equipos>)objCargaE)[12].pNombre;
                    txt_equipo14.Text = ((List<Equipos>)objCargaE)[13].pNombre;
                    break;
                case 15:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    txt_equipo10.Text = ((List<Equipos>)objCargaE)[9].pNombre;
                    txt_equipo11.Text = ((List<Equipos>)objCargaE)[10].pNombre;
                    txt_equipo12.Text = ((List<Equipos>)objCargaE)[11].pNombre;
                    txt_equipo13.Text = ((List<Equipos>)objCargaE)[12].pNombre;
                    txt_equipo14.Text = ((List<Equipos>)objCargaE)[13].pNombre;
                    txt_equipo15.Text = ((List<Equipos>)objCargaE)[14].pNombre;
                    break;
                case 16:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    txt_equipo10.Text = ((List<Equipos>)objCargaE)[9].pNombre;
                    txt_equipo11.Text = ((List<Equipos>)objCargaE)[10].pNombre;
                    txt_equipo12.Text = ((List<Equipos>)objCargaE)[11].pNombre;
                    txt_equipo13.Text = ((List<Equipos>)objCargaE)[12].pNombre;
                    txt_equipo14.Text = ((List<Equipos>)objCargaE)[13].pNombre;
                    txt_equipo15.Text = ((List<Equipos>)objCargaE)[14].pNombre;
                    txt_equipo16.Text = ((List<Equipos>)objCargaE)[15].pNombre;
                    break;
                case 17:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    txt_equipo10.Text = ((List<Equipos>)objCargaE)[9].pNombre;
                    txt_equipo11.Text = ((List<Equipos>)objCargaE)[10].pNombre;
                    txt_equipo12.Text = ((List<Equipos>)objCargaE)[11].pNombre;
                    txt_equipo13.Text = ((List<Equipos>)objCargaE)[12].pNombre;
                    txt_equipo14.Text = ((List<Equipos>)objCargaE)[13].pNombre;
                    txt_equipo15.Text = ((List<Equipos>)objCargaE)[14].pNombre;
                    txt_equipo16.Text = ((List<Equipos>)objCargaE)[15].pNombre;
                    txt_equipo17.Text = ((List<Equipos>)objCargaE)[16].pNombre;
                    break;
                case 18:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    txt_equipo10.Text = ((List<Equipos>)objCargaE)[9].pNombre;
                    txt_equipo11.Text = ((List<Equipos>)objCargaE)[10].pNombre;
                    txt_equipo12.Text = ((List<Equipos>)objCargaE)[11].pNombre;
                    txt_equipo13.Text = ((List<Equipos>)objCargaE)[12].pNombre;
                    txt_equipo14.Text = ((List<Equipos>)objCargaE)[13].pNombre;
                    txt_equipo15.Text = ((List<Equipos>)objCargaE)[14].pNombre;
                    txt_equipo16.Text = ((List<Equipos>)objCargaE)[15].pNombre;
                    txt_equipo17.Text = ((List<Equipos>)objCargaE)[16].pNombre;
                    txt_equipo18.Text = ((List<Equipos>)objCargaE)[17].pNombre;
                    break;
                case 19:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    txt_equipo10.Text = ((List<Equipos>)objCargaE)[9].pNombre;
                    txt_equipo11.Text = ((List<Equipos>)objCargaE)[10].pNombre;
                    txt_equipo12.Text = ((List<Equipos>)objCargaE)[11].pNombre;
                    txt_equipo13.Text = ((List<Equipos>)objCargaE)[12].pNombre;
                    txt_equipo14.Text = ((List<Equipos>)objCargaE)[13].pNombre;
                    txt_equipo15.Text = ((List<Equipos>)objCargaE)[14].pNombre;
                    txt_equipo16.Text = ((List<Equipos>)objCargaE)[15].pNombre;
                    txt_equipo17.Text = ((List<Equipos>)objCargaE)[16].pNombre;
                    txt_equipo18.Text = ((List<Equipos>)objCargaE)[17].pNombre;
                    txt_equipo19.Text = ((List<Equipos>)objCargaE)[18].pNombre;
                    break;
                case 20:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    txt_equipo9.Text = ((List<Equipos>)objCargaE)[8].pNombre;
                    txt_equipo10.Text = ((List<Equipos>)objCargaE)[9].pNombre;
                    txt_equipo11.Text = ((List<Equipos>)objCargaE)[10].pNombre;
                    txt_equipo12.Text = ((List<Equipos>)objCargaE)[11].pNombre;
                    txt_equipo13.Text = ((List<Equipos>)objCargaE)[12].pNombre;
                    txt_equipo14.Text = ((List<Equipos>)objCargaE)[13].pNombre;
                    txt_equipo15.Text = ((List<Equipos>)objCargaE)[14].pNombre;
                    txt_equipo16.Text = ((List<Equipos>)objCargaE)[15].pNombre;
                    txt_equipo17.Text = ((List<Equipos>)objCargaE)[16].pNombre;
                    txt_equipo18.Text = ((List<Equipos>)objCargaE)[17].pNombre;
                    txt_equipo19.Text = ((List<Equipos>)objCargaE)[18].pNombre;
                    txt_equipo20.Text = ((List<Equipos>)objCargaE)[19].pNombre;
                    break;
                default:
                    MessageBox.Show("NO hay equipos para mostrar");
                    break;

            }


        }

        private void Contar()
        {
            int busqueda = -1;
            busqueda = objCargaEquipo.abmEquipos("Contar", objEquipoNew);
            if (busqueda != 20)
            {
                MessageBox.Show("Debe haber 20 equipos anotados para poder realizar el sorteo");
                btn_sortear.Enabled = false;
                //cmb_fechas.Enabled = false;
                btn_sortear.Visible = false;
                btn_ver_fecha.Enabled = false;
                dtp_comienzo.Visible = false;
                dtp_comienzo.Enabled = false;
                btn_salir.Focus();
            }
            else
            {
                btn_sortear.Enabled = true;
                //cmb_fechas.Enabled = false;
                btn_sortear.Visible = true;
                //btn_ver_fecha.Enabled = false;
                dtp_comienzo.Visible = true;
                dtp_comienzo.Enabled = true;
            }


        }

        private void Carga(int vuelta, int caso)
        {
            int i = 0;
            for (int j=1; j < 11; j++)
            {
                
                objpartido = new Partidos();
                int ngrabados = -1;
                objpartido.pID_fecha = vuelta;
                objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[fixture[caso - 1, i]].pID;
                objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[fixture[caso - 1, (i += 1)]].pID;
                //objpartido.pCancha = j;
                objpartido.pCancha = (j % 4) + 1;
                objpartido.pGoles1 = 0;
                objpartido.pGoles1 = 0;
                ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);
                i++;
            }
        }

        private void btn_sortear_Click(object sender, EventArgs e)
        {
            int rondas = 0;
            ClaseFecha objCargaFecha = new ClaseFecha();
            DateTime comienzo = new DateTime();
            comienzo = dtp_comienzo.Value.Date;
            if (MessageBox.Show("Esta seguro de comenzar el campeonato el día " + comienzo.ToShortDateString(), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                for (int x = 1; x < 20; x++)
                {
                    int nGrabados = -1;
                    Fechas objFechas1 = new Fechas();
                    objFechas1.pNum_fecha = "Fecha N° " + x.ToString("D2");
                    //objFechas1.pNum_fecha = "Fecha N° " + Convert.ToString(x);
                    objFechas1.pDia_fecha = comienzo;
                    nGrabados = objCargaFecha.abmFechas("Agregar", objFechas1);
                    comienzo = comienzo.AddDays(7);
                }
                CargarCmbE();
                cmb_fechas.SelectedIndex = 18;

                rondas = Convert.ToInt32(cmb_fechas.SelectedValue);
                for (int x = 1; x < 20; x++)
                {
                    switch (x)
                    {
                        case 1:
                            Carga(rondas, x);
                            break;
                        case 2:
                            Carga(rondas + (x -1), x);
                            break;
                        case 3:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 4:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 5:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 6:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 7:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 8:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 9:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 10:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 11:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 12:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 13:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 14:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 15:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 16:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 17:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 18:
                            Carga(rondas + (x - 1), x);
                            break;
                        case 19:
                            Carga(rondas + (x - 1), x);
                            break;
                    }
                
                }

                for (int x = 0; x < 20; x++)
                {
                    int nGrabados = -1;
                    Posiciones objPosicion = new Posiciones();
                    objPosicion.pID_Equi = ((List<Equipos>)objCargaE)[x].pID;
                    nGrabados = objEquipoPos.abmPosicion("AgregarNuevo", objPosicion);

                }
                /*

                // Create a DataTable to hold the data
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Fecha", typeof(string));
                dataTable.Columns.Add("Equipo 1", typeof(string));
                dataTable.Columns.Add("Equipo 2", typeof(string));
                dataTable.Columns.Add("Cancha", typeof(int));
                dataTable.Columns.Add("Goles 1", typeof(int));
                dataTable.Columns.Add("Goles 2", typeof(int));

                // Add the matches to the corresponding dates
                for (int x = 1; x < 20; x++)
                {
                    string fecha = "Fecha N° " + x;
                    DataRow[] rows = dataTable.Select("Fecha = '" + fecha + "'");
                    DataTable filteredTable = dataTable.Clone();
                    foreach (DataRow row in rows)
                    {
                        filteredTable.ImportRow(row);
                    }
                    dgv_datos1.DataSource = filteredTable;
                    dgv_datos1.Refresh();
                    System.Threading.Thread.Sleep(1000); // Wait 1 second before showing the next date
                }
                */
            cmb_fechas.Enabled = true;
            cmb_fechas.SelectedIndex = -1;
                //btn_ver_fecha.Enabled = true;
                //btn_sortear.Enabled = false;
                //dtp_comienzo.Enabled = false;
                MessageBox.Show("Se realizo el sorteo con exito");

        }
            else
            {
                MessageBox.Show("Elija nuevamente el dia del comienzo del campeonato");
            }



}
            private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ver_fecha_Click(object sender, EventArgs e)
        {
            
            int busqueda = 1;
            string dato = cmb_fechas.SelectedValue.ToString();
            dgv_datos1.Columns.Clear();
            dgv_datos1.DataSource = null;
            DataTable dt = new DataTable();
            dt = objCargapartido.listadoPartidos(dato, busqueda);
            dgv_datos1.DataSource = dt;
            dgv_datos1.Columns[0].Width = 70;
            dgv_datos1.Columns[1].Width = 140;
            dgv_datos1.Columns[2].Width = 40;
            dgv_datos1.Columns[3].Width = 140;
            dgv_datos1.Columns[4].Width = 40;
            dgv_datos1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
        public void GenerarDocumento(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView
            PdfPTable datatable = new PdfPTable(dgv_datos1.ColumnCount);
            //asignamos algunas propiedades para el diseño del pdf
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dgv_datos1);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 80;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF
            for (int i = 0; i < dgv_datos1.ColumnCount; i++)
            {
                datatable.AddCell(dgv_datos1.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < dgv_datos1.RowCount; i++)
            {
                for (int j = 0; j < dgv_datos1.ColumnCount; j++)
                {
                    datatable.AddCell(dgv_datos1[j, i].Value.ToString());
                }
                datatable.CompleteRow();
            }
            //SE AGREGA LA PDFPTABLE AL DOCUMENTO
            document.Add(datatable);

        }
        private static void AgregarEncabezado(Document doc, string variable1, string variable2)
        {

            // Agrega el logo
            string logoPath = "E:\\repo\\imagenes\\logo.jpg"; // Reemplaza con la ruta correcta de tu logo
            Image logo = Image.GetInstance(logoPath);
            logo.ScaleToFit(60f, 60f); // Ajusta el tamaño del logo según tus necesidades

            // Agrega el título
            Font fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
            Paragraph titulo = new Paragraph("LIGA DE FUTBOL AMATEUR CORDOBA", fontTitulo);


            Paragraph variable1Paragraph = new Paragraph(variable1);
            Paragraph variable2Paragraph = new Paragraph($"DIA: " + variable2);

            // Crea la tabla para el encabezado
            PdfPTable table = new PdfPTable(2);
            table.TotalWidth = doc.PageSize.Width - doc.LeftMargin - doc.RightMargin;
            table.SetWidths(new float[] { 25f, 75f }); // Establece los anchos de las columnas (porcentajes)
            
            // Celda del logo
            PdfPCell cellLogo = new PdfPCell(logo);
            cellLogo.Border = 0;
            table.AddCell(cellLogo);

            // Celda del título
            PdfPCell cellTitulo = new PdfPCell(titulo);
            cellTitulo.Border = 0;
            table.AddCell(cellTitulo);

            PdfPCell cellVariable1 = new PdfPCell(variable1Paragraph);
            cellVariable1.Border = 0;
            table.AddCell(cellVariable1);

            PdfPCell cellVariable2 = new PdfPCell(variable2Paragraph);
            cellVariable2.Border = 0;
            table.AddCell(cellVariable2);

            // Agrega la tabla al documento
            doc.Add(table);

            // Añade espacio después del encabezado
            doc.Add(new Paragraph("\n"));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DateTime busqueda = objClaseFechaBusqueda.ObtenerDiaPorID(Convert.ToInt32(cmb_fechas.SelectedValue));
            if (dgv_datos1.Rows.Count != 0)
            {
                try
                {
                    Document doc = new Document(PageSize.A4.Rotate(), 30, 10, 10, 10);
                    string filename = pathFileOutput + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
                    FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, file);

                    // Abre el documento
                    doc.Open();

                    // Agrega el encabezado con logo y título
                    AgregarEncabezado(doc, cmb_fechas.Text, busqueda.ToString("dd/MM/yyyy"));

                    // Agrega el contenido del documento
                    GenerarDocumento(doc);

                    // Cierra el documento
                    doc.Close();

                    // Abre el PDF con el visor predeterminado
                    Process.Start(filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("No hay datos para generar reportes");
            }
        }

        private void cmb_fechas_TextChanged(object sender, EventArgs e)
        {
            dgv_datos1.DataSource = "";
        }
    }
}
