using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon

{
    public partial class frmLogin : Form
    {
        Database db = new Database();
        public static bool ventanaR = false;
        public frmLogin()
        {
            InitializeComponent();
            db.IniciarConexion("pokedex.accdb");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String sql = "select * from usuarios where nombreUsuario = '"+txtIDentrenador.Text+"' and pass = '"+txtContrasena.Text+"'";
            try
            {
                db.consultaStr(sql);
                Form principal = new Principal(this);
                principal.Visible = true;
                this.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o contraseña incorrecto.");
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ventanaR)
            {
                Registro registro = new Registro(this);
                registro.Visible = true;
                ventanaR = true;
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }
    }
}
