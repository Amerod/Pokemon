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
    public partial class Editar : Form

    {
        Database db = new Database();
        String sql;
        String id = "";
        Principal padre;
        public Editar(String idPokemon,Principal p)
        {
            InitializeComponent();
            padre = p;
            id = idPokemon;
            txtID.Text = idPokemon;
            db.IniciarConexion("pokedex.accdb");
            sql = "SELECT nombre FROM pokedex WHERE id = " + id;
            String res = db.consultaStr(sql);
            lblTitulo.Text = "#" + idPokemon + " "+ res;
            txtNombre.Text = res;

            sql = "SELECT clase FROM pokedex WHERE id = " + id;
            res = db.consultaStr(sql);
            txtClase.Text = res;

            sql = "SELECT tipo1 FROM pokedex WHERE id = " + id;
            res = db.consultaStr(sql);
            txtTipo.Text = res;

            sql = "SELECT peso FROM pokedex WHERE id = " + id;
            res = db.consultaStr(sql);
            txtPeso.Text = res;

            sql = "SELECT altura FROM pokedex WHERE id = " + id;
            res = db.consultaStr(sql);
            txtAltura.Text = res;



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int res;
            if ((txtNombre.Text != "") && (txtClase.Text != "") && (txtTipo.Text != "") && (txtPeso.Text != "") && (txtAltura.Text != ""))
            {
                sql = "UPDATE pokedex SET nombre='" + txtNombre.Text + "', tipo1='" + txtTipo.Text + "',clase='" + txtClase.Text + "',altura='" + txtAltura.Text + "',peso='" + txtPeso.Text + "' WHERE id = " + id;
                res = db.ejecutar_slq(sql);
                if (res == -1) MessageBox.Show("El cambio de nombre ha fallado.");
                padre.cargarPkmn();
                this.Dispose();


            }
            else {
                MessageBox.Show("Rellena todos los campos.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar el registro?", "Eliminación de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int res;
                sql = "DELETE FROM pokedex WHERE ID = " + id;
                res = db.ejecutar_slq(sql);
                padre.cargarPkmn();
                this.Dispose();
            }
        }
    }
}
