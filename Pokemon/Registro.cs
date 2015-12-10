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
    public partial class Registro : Form
    {

        Database db = new Database();
        public Registro(frmLogin l)
        {
            this.SetDesktopLocation(l.DesktopLocation.X-208,l.DesktopLocation.Y);
            InitializeComponent();
            db.IniciarConexion("pokedex.accdb");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPass.Text != "")
            {
                String sql = "Insert into usuarios values('" + txtNombre.Text + "','" + txtPass.Text + "')";
                int i = db.ejecutar_slq(sql);
                if (i > 0)
                {
                    MessageBox.Show("Registrado con exito.");
                    frmLogin.ventanaR = false;
                    this.Dispose();
                }
                else {
                    MessageBox.Show("No se pudo registrar.");
                }
            }
            else {
                MessageBox.Show("Todos los campos son obligatorios.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin.ventanaR = false;
            this.Dispose();
        }
    }
}
