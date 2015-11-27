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
    public partial class Nuevo : Form
    {
        Database db = new Database();
        String sql,ipd;
        String id = "";
        Principal padre;
        public Nuevo(String idPokemon, Principal p)
        {
            InitializeComponent();
            padre = p;
            id = idPokemon;
            txtID.Text = idPokemon;
            db.IniciarConexion("pokedex.accdb");
            sql = "SELECT max(id)+1 FROM pokedex";
            ipd = db.consultaStr(sql);
            txtID.Text = ipd;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            String direccion = openFileDialog1.FileName;
            MessageBox.Show(direccion);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int res;
            if ((txtNombre.Text != "") && (txtClase.Text != "") && (txtTipo.Text != "") && (txtPeso.Text != "") && (txtAltura.Text != ""))
            {
                sql = "SELECT max(id)+1 FROM pokedex";
                ipd = db.consultaStr(sql);
                sql = "INSERT INTO pokedex VALUES ("+ipd+",'" + txtNombre.Text + "','" + txtTipo.Text +"',' '," + txtAltura.Text + "," + txtPeso.Text + ",'"+ txtClase.Text+"','images/151.png')";
                res = db.ejecutar_slq(sql);
                if (res == -1) MessageBox.Show("No se ha podido añadir el pokemon.");
                padre.cargarPkmn();
                this.Dispose();


            }
            else
            {
                MessageBox.Show("Rellena todos los campos.");
            }
        }
    }
}
