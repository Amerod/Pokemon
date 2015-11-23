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
            sql = "SELECT id,nombre FROM pokedex";
            db.consultar(sql, listBox1);
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
                sql = "SELECT id FROM pokedex WHERE id = " + listBox1.Text.Substring(0, 3) + "";
                lbID.Text = db.consultaStr(sql);
                sql = "SELECT Imagen FROM pokedex WHERE id = " + listBox1.Text.Substring(0,3) + "";
                pictureBox1.ImageLocation = db.consultaStr(sql); 
                sql = "SELECT nombre FROM pokedex WHERE id = "+listBox1.Text.Substring(0,3)+"";
                lbNombre.Text = db.consultaStr(sql);
                sql = "SELECT peso FROM pokedex WHERE id = "+ listBox1.Text.Substring(0, 3)+"";
                try
                {
                    lbPeso.Text = db.consultaStr(sql);
                }
                catch (Exception)
                {
                    lbPeso.Text = "";
                }
                sql = "SELECT altura FROM pokedex WHERE id = " + listBox1.Text.Substring(0, 3) + "";
                try
                {
                    lbAltura.Text = db.consultaStr(sql);
                }
                catch (Exception)
                {
                    lbAltura.Text = "";
                }
                sql = "SELECT tipo1 FROM pokedex WHERE id = " + listBox1.Text.Substring(0, 3) + "";
                try
                {
                    lbTipo.Text = db.consultaStr(sql);
                }
                catch (Exception)
                {
                    lbTipo.Text = "";
                }
                sql = "SELECT clase FROM pokedex WHERE id = " + listBox1.Text.Substring(0, 3) + "";
                try
                {
                    lbNaturaleza.Text = db.consultaStr(sql);
                }
                catch (Exception)
                {
                    lbNaturaleza.Text = "";
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
