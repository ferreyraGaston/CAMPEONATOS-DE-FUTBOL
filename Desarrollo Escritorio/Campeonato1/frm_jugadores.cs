using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaDatos;

namespace Campeonato1
{
    public partial class frm_jugadores : Form
    {
        public string dato = "";
        public ClaseEquipos objEquipos = new ClaseEquipos();
        public Equipos objEquipoConsulta = new Equipos(); 
        public DateTime Actual = DateTime.Now.ToLocalTime();
        public Jugadores objJugador = new Jugadores();
        public ClaseJugadores objQuitaJugador = new ClaseJugadores();
        public ClaseSancion objAmarillas = new ClaseSancion();
        public ClaseSancion objRojas = new ClaseSancion();
        public frm_jugadores()
        {
            InitializeComponent();
            var ta = new ToolTip();
            var tr = new ToolTip();
            var ts = new ToolTip();
            var tq = new ToolTip();
            ta.SetToolTip(btn_agregar, "Agregar jugador");
            tr.SetToolTip(btn_reemplazar, "Modificar jugador");
            ts.SetToolTip(btn_sancionar, "Sancionar jugador");
            tq.SetToolTip(btn_quitar, "Quitar jugador");
            CargarCmbE();
            lbl_jug_anota.Text = dgv_equipo.RowCount.ToString();
        }
        private void CargarCmbE()
        {
            //se llena el comboBox con los equipos de la base de datos
            cmb_equipos.DataSource = objEquipos.listadoEquipos();
            cmb_equipos.DisplayMember = "pNombre";
            cmb_equipos.ValueMember = "pID";
            cmb_equipos.SelectedIndex = -1;
        }

        private void CargarSancion()
        {
            List<int> listaTarjetasAmarillas = objAmarillas.ListadoTarjetasAmarillas(int.Parse(cmb_equipos.SelectedValue.ToString()));
            lbl_jug_sancion.Text = listaTarjetasAmarillas.Count.ToString();
            foreach (DataGridViewRow fila in dgv_equipo.Rows)
            {
                // Obtener el DNI del jugador en la fila actual
                string dniJugadorEnFila = fila.Cells["DNI"].Value?.ToString();

                // Verificar si el jugador tiene una tarjeta amarilla
                if (listaTarjetasAmarillas.Any(t => t.ToString() == dniJugadorEnFila))
                {
                    // Pintar la fila de amarillo
                    fila.DefaultCellStyle.BackColor = Color.Yellow;
                }

            }

            List<int> listaTarjetasRojas = objRojas.ListadoTarjetasRojas(int.Parse(cmb_equipos.SelectedValue.ToString()));
            lbl_jug_exp.Text = listaTarjetasRojas.Count.ToString();
            foreach (DataGridViewRow fila in dgv_equipo.Rows)
            {
                // Obtener el DNI del jugador en la fila actual
                string dniJugadorEnFila = fila.Cells["DNI"].Value?.ToString();

                // Verificar si el jugador tiene una tarjeta amarilla
                if (listaTarjetasRojas.Any(t => t.ToString() == dniJugadorEnFila))
                {
                    // Pintar la fila de amarillo
                    fila.DefaultCellStyle.BackColor = Color.Red;
                }

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cmb_equipos.SelectedIndex == -1)
            {
                MessageBox.Show("Primero debe elegir un equipo");
            }
            else if (int.Parse(lbl_jug_anota.Text) > 19)
            {
                MessageBox.Show("Solo se pueden anotar 18 jugadores");
            }
            else
            {
                int id_equipo_sel = int.Parse(cmb_equipos.SelectedValue.ToString());
                string nombre_sel = cmb_equipos.GetItemText(cmb_equipos.SelectedItem);
                frm_carga_jugadores form_carga = new frm_carga_jugadores(id_equipo_sel, nombre_sel);
                form_carga.ShowDialog();
            }
            
        }

        private void btn_equipo_Click(object sender, EventArgs e)
        {
            if (cmb_equipos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un equipo");
            }
            else
            {
                int busqueda = 3;
                dato = cmb_equipos.SelectedValue.ToString();
                dgv_equipo.Columns.Clear();
                dgv_equipo.DataSource = null;
                DataTable dt = new DataTable();
                objEquipoConsulta = objEquipos.BsquedaEquipo(dato);
                dt = objEquipos.listadoEquipos(dato, busqueda);
                dgv_equipo.DataSource = dt;
                dgv_equipo.Columns[0].Width = 125;
                dgv_equipo.Columns[1].Width = 125;
                dgv_equipo.Columns[2].Width = 80;
                dgv_equipo.Columns[3].Width = 90;
                dgv_equipo.Columns[4].Width = 40;
                lbl_equipo.Text = objEquipoConsulta.pNombre;
                lbl_jug_anota.Text = dgv_equipo.RowCount.ToString();
                if ((objEquipoConsulta.pRuta == "p"))
                {
                    pic_escudo2.Image = pic_escudo2.InitialImage;
                }
                else
                {
                    pic_escudo2.Image = Image.FromFile(objEquipoConsulta.pRuta);
                }
                CargarSancion();
                
                dgv_equipo.ClearSelection();
            }
            
            
        }

        private void frm_jugadores_Activated(object sender, EventArgs e)
        {
            if(cmb_equipos.SelectedIndex != -1)
            {
                int busqueda = 3;
                dato = cmb_equipos.SelectedValue.ToString();
                dgv_equipo.Columns.Clear();
                dgv_equipo.DataSource = null;
                DataTable dt = new DataTable();
                objEquipoConsulta = objEquipos.BsquedaEquipo(dato);
                dt = objEquipos.listadoEquipos(dato, busqueda);
                dgv_equipo.DataSource = dt;
                dgv_equipo.Columns[0].Width = 125;
                dgv_equipo.Columns[1].Width = 125;
                dgv_equipo.Columns[2].Width = 80;
                dgv_equipo.Columns[3].Width = 60;
                lbl_jug_anota.Text = dgv_equipo.RowCount.ToString();
                CargarSancion();
            }
            
            dgv_equipo.ClearSelection();

        }

        private void btn_reemplazar_Click(object sender, EventArgs e)
        {
            if(dgv_equipo.SelectedRows.Count > 0)
            {
                frm_editar_jugadores edit_jug = new frm_editar_jugadores(objJugador, cmb_equipos.GetItemText(cmb_equipos.SelectedItem));
                edit_jug.ShowDialog();
            }
            else
            {
                MessageBox.Show("No selecciono un jugador para modificar");
                dgv_equipo.ClearSelection();
            }
            
        }

        private void dgv_equipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objJugador = new Jugadores();
            objJugador.pApellido = Convert.ToString(dgv_equipo.CurrentRow.Cells[0].Value);
            objJugador.pNombre = Convert.ToString(dgv_equipo.CurrentRow.Cells[1].Value);
            objJugador.pDni = (int)dgv_equipo.CurrentRow.Cells[2].Value;
            objJugador.pFechaNac = (DateTime)dgv_equipo.CurrentRow.Cells[3].Value;
            objJugador.pEdad = (int)dgv_equipo.CurrentRow.Cells[4].Value;
            objJugador.pEquipo = int.Parse(cmb_equipos.SelectedValue.ToString());
        }

        private void frm_jugadores_Leave(object sender, EventArgs e)
        {
            dgv_equipo.ClearSelection();
        }

        private void btn_sancionar_Click(object sender, EventArgs e)
        {
            if (dgv_equipo.SelectedRows.Count > 0)
            {
                frm_carga_sancion sancion_jug = new frm_carga_sancion(objJugador, cmb_equipos.GetItemText(cmb_equipos.SelectedItem));
                sancion_jug.ShowDialog();
            }
            else
            {
                MessageBox.Show("No selecciono un jugador para sancionar");
                dgv_equipo.ClearSelection();
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dgv_equipo.SelectedRows.Count > 0)
            {
                // Mostrar un cuadro de diálogo para confirmar la eliminación
                DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar al jugador con DNI: {objJugador.pDni}?", "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    int nGrabados = -1;
                    nGrabados = objQuitaJugador.abmJugadores("Eliminar", objJugador);
                    
                    if (nGrabados == -1)
                    {
                        MessageBox.Show("No se pudo quitar el jugador");
                    }
                    frm_jugadores_Activated(sender, e);
                    dgv_equipo.ClearSelection(); 
                }
                
            }
            else
            {
                MessageBox.Show("No selecciono ningun jugador para quitar del equipo");
                dgv_equipo.ClearSelection();
            }
        }
    }   
}
