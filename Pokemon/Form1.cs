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
    public partial class Form1 : Form
    {
        Database db = new Database();
        public Form1()
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
            Registro registro = new Registro();
            registro.Visible = true;
        }
    }
}
