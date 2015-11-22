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
    public partial class Principal : Form
    {
        Form padre;
        Database db = new Database();
        String sql;
        public Principal(Form p)
        {
            InitializeComponent();            
            padre = p;
            db.IniciarConexion("pokedex.accdb");
            sql = "SELECT nombre FROM pokedex3";
            db.consultar(sql,listBox1);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            padre.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form editar = new Editar();
            editar.Visible = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form nuevo = new Nuevo();
            nuevo.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                sql = "SELECT Imagen FROM pokedex3 WHERE Nombre = '" + listBox1.Text + "'";
                pictureBox1.ImageLocation = db.consultaStr(sql); ;
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
