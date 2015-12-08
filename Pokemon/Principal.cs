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
        protected Form padre;
        Database db = new Database();
        protected String sql;
        public static Boolean ventanaE = false;
        public static Boolean ventanaN = false;
        public Principal(Form p)
        {
            InitializeComponent();            
            padre = p;
            db.IniciarConexion("pokedex.accdb");
            cargarPkmn();
            lstBxPkmns.SelectedIndex = 0;
        }
        public void cargarPkmn() {
            sql = "SELECT id,nombre FROM pokedex";
            db.consultar(sql, lstBxPkmns);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            padre.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!ventanaE)
            {
                Form editar = new Editar(lstBxPkmns.Text.Substring(0, 3), this);
                editar.Visible = true;
                ventanaE = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ventanaN)
            {
                Form nuevo = new Nuevo(lstBxPkmns.Text.Substring(0, 3), this);
                nuevo.Visible = true;
                ventanaN = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                sql = "SELECT id FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                lbID_v.Text = db.consultaStr(sql);
                sql = "SELECT Imagen FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0,3) + "";
                picBxPkmns.ImageLocation = db.consultaStr(sql); 
                sql = "SELECT nombre FROM pokedex WHERE id = "+lstBxPkmns.Text.Substring(0,3)+"";
                lbNombre_v.Text = db.consultaStr(sql);
                sql = "SELECT peso FROM pokedex WHERE id = "+ lstBxPkmns.Text.Substring(0, 3)+"";
                try
                {
                    lbPeso_v.Text = db.consultaStr(sql);
                }
                catch (Exception)
                {
                    lbPeso_v.Text = "";
                }
                sql = "SELECT altura FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                try
                {
                    lbAltura_v.Text = db.consultaStr(sql);
                }
                catch (Exception)
                {
                    lbAltura_v.Text = "";
                }
                sql = "SELECT tipo1 FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                try
                {
                    lbTipo_v.Text = db.consultaStr(sql);
                }
                catch (Exception)
                {
                    lbTipo_v.Text = "";
                }
                sql = "SELECT tipo2 FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                try
                {
                    lblTipo2.Text = db.consultaStr(sql);
                }
                catch (Exception)
                {
                    lbTipo_v.Text = "";
                }
                sql = "SELECT clase FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                try
                {
                    lbNaturaleza_v.Text = db.consultaStr(sql);
                }
                catch (Exception)
                {
                    lbNaturaleza_v.Text = "";
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void bt(object sender, EventArgs e)
        {
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.BackColor = Color.Transparent;
        }
    }
}
