using CapaDatos;
using System;
using System.Windows.Forms;

namespace Campeonato1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lbNuevoUsuario.Enabled = false;
            lbNombre.Enabled = false;
            lbApellido.Enabled = false;
            lbDNI.Enabled = false;
            lbClave.Enabled = false;
            txtNombre.Enabled = false;
            txtApelldio.Enabled = false;
            txtDNI.Enabled = false;
            txtClave.Enabled = false;
            txtNuevoUsuario.Enabled = false;
            button1.Enabled = false;


        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            ClaseLogin login = new ClaseLogin();


            if (login.Login(usuario, password))
            {
                frm_Principal2 principal = new frm_Principal2();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            lbNuevoUsuario.Enabled = true;
            lbNombre.Enabled = true;
            lbApellido.Enabled = true;
            lbDNI.Enabled = true;
            lbClave.Enabled = true;
            txtNombre.Enabled = true;
            txtApelldio.Enabled = true;
            txtDNI.Enabled = true;
            txtClave.Enabled = true;
            txtNuevoUsuario.Enabled = true;
            button1.Enabled = true;
        }



        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtPassword.Text == "1234")
            {
                btnCrearUsuario.Enabled = true;


            }
            else
            {
                btnCrearUsuario.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtPassword.Text == "1234")
            {
                btnCrearUsuario.Enabled = true;


            }
            else
            {
                btnCrearUsuario.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NuevoUsuario = txtNuevoUsuario.Text;
            string password = txtClave.Text;

            string nombre = txtNombre.Text;
            string apellido = txtApelldio.Text;
            string dni = txtDNI.Text;
            string clave = txtClave.Text;


            // Validate DNI text box
            if (!int.TryParse(dni, out int dniNumber) || dni.Length != 8)
            {
                MessageBox.Show("El DNI debe ser un número de 8 dígitos.");
                return;
            }

            // Validate other text boxes
            if (NuevoUsuario.Length > 20 || password.Length > 20 || nombre.Length > 20 || apellido.Length > 20 || clave.Length > 20)
            {
                MessageBox.Show("Los campos Nombre, Apellido y Clave no pueden tener más de 20 caracteres.");
                return;
            }



            ClaseLogin claseLogin = new ClaseLogin();
            bool result = claseLogin.InsertarUsuario(NuevoUsuario, password, nombre, apellido, dni, clave);

            if (result)
            {
                MessageBox.Show("Se Registro Correctamente el Usuario Nuevo");
            }
            else
            {
                MessageBox.Show("Error al Intentar Registrar el Usuario nuevo");
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDNI.Text, out int dniNumber) || txtDNI.Text.Length > 8)
            {
                errorProvider1.SetError(txtDNI, "El DNI debe ser un número de 8 dígitos.");
            }
            else
            {
                errorProvider1.SetError(txtDNI, "");
            }
        }
    }
}

