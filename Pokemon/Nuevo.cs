using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        String pathAOrigen;
        Principal padre;
        public Nuevo(String idPokemon, Principal p)
        {
            this.SetDesktopLocation(p.DesktopLocation.X + 334,p.DesktopLocation.Y);
            InitializeComponent();
            padre = p;
            id = idPokemon;
            txtID.Text = idPokemon;
            db.IniciarConexion("pokedex.accdb");
            sql = "SELECT max(id)+1 FROM pokedex";
            ipd = db.consultaStr(sql, "pokedex");
            txtID.Text = ipd;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal.ventanaN = false;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagenes PNG (*.png)|*.png";
            openFileDialog1.ShowDialog();
            pathAOrigen = openFileDialog1.FileName;
            MessageBox.Show(pathAOrigen);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string pathADestino = @"C:\Users\Eric\Source\Repos\Pokemon\Pokemon\bin\Debug\images";
            int res;
            if ((txtNombre.Text != "") && (txtClase.Text != "") && (txtTipo.Text != "") && (txtPeso.Text != "") && (txtAltura.Text != ""))
            {
                try
                {
                    Double.Parse(txtPeso.Text);
                    Double.Parse(txtAltura.Text);
                    if (File.Exists(pathAOrigen))
                    {
                        File.Copy(pathAOrigen, pathADestino, true);
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    sql = "SELECT max(id)+1 FROM pokedex";
                    ipd = db.consultaStr(sql, "pokedex");
                    sql = "INSERT INTO pokedex VALUES (" + ipd + ",'" + txtNombre.Text + "','" + txtTipo.Text + "','"+txtTipo2.Text+"'," + txtAltura.Text + "," + txtPeso.Text + ",'" + txtClase.Text + "','"+ pathAOrigen + "')";
                    res = db.ejecutar_slq(sql);
                    if (res == -1) MessageBox.Show("No se ha podido añadir el pokemon.");
                    padre.cargarPkmn();
                    Principal.ventanaN = false;
                    this.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor incorrecto en Peso o Altura.");
                }
            }
            else
            {
                MessageBox.Show("Rellena todos los campos.");
            }
        }
    }
}
