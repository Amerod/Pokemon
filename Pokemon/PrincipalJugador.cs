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
    public partial class PrincipalJugador : Form
    {
        String sql;
        Database db = new Database();
        frmLogin p;
        private Random random = new Random();
        string usuario;

        public PrincipalJugador(frmLogin padre,string user)
        {
            p = padre;
            db.IniciarConexion("pokedex.accdb");
            InitializeComponent();
            usuario = user;
            cargarPkmn();
            
        }

        public void cargarPkmn()
        {
            lstBxPkmns.Items.Clear();
            sql = "SELECT count(*) FROM pokedex";
            int n = int.Parse(db.consultaStr(sql,"pokedex"));
            sql = "SELECT count(*) FROM pokemonUsuario WHERE nombreUsuario ='"+usuario+"'";
            int n2 = int.Parse(db.consultaStr(sql,"pokemonUsuario"));
            label2.Text = n.ToString();
            label1.Text = n2.ToString();
            for (int i = 0; i < n; i++)
            {
                lstBxPkmns.Items.Add(" - ???");
            }
            sql = "SELECT idPokemon FROM pokemonUsuario WHERE nombreUsuario='"+usuario+"'";
            db.pokemonUser(sql, lstBxPkmns);
            lblUsuario.Text = usuario;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Juego j = new Juego(this);
            j.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            p.Close();
        }

        public void volver(List<int> numeros,int tiempo)
        {
            int a = numeros[random.Next(numeros.Count)];
            numeros.Remove(a);
            int b = numeros[random.Next(numeros.Count)];
            numeros.Remove(b);
            int c = numeros[random.Next(numeros.Count)];
            numeros.Remove(c);
            if (tiempo<60)
            {
                if (tiempo < 50)
                {
                    sql = "SELECT nombre FROM pokedex WHERE id = "+a+"";
                    string cadena = db.consultaStr(sql,"pokedex")+", ";
                    sql = "SELECT nombre FROM pokedex WHERE id = "+b+"";
                    cadena += db.consultaStr(sql,"pokedex")+" y ";
                    sql = "SELECT nombre FROM pokedex WHERE id = "+c+"";
                    cadena += db.consultaStr(sql,"pokedex");
                    MessageBox.Show("Has capturado a "+cadena);
                    sql = "INSERT INTO pokemonUsuario VALUES ('" + usuario + "'," + a + ")";
                    int res = db.ejecutar_slq(sql);
                    sql = "INSERT INTO pokemonUsuario VALUES ('" + usuario + "'," + b + ")";
                    res = db.ejecutar_slq(sql);
                    sql = "INSERT INTO pokemonUsuario VALUES ('" + usuario + "'," + c + ")";
                    res = db.ejecutar_slq(sql);
                    cargarPkmn();
                }
                else
                {
                    sql = "SELECT nombre FROM pokedex WHERE id = " + a + "";
                    string cadena = db.consultaStr(sql,"pokedex") + " y ";
                    sql = "SELECT nombre FROM pokedex WHERE id = " + b + "";
                    cadena += db.consultaStr(sql,"pokedex");
                    MessageBox.Show("Has capturado a "+cadena);
                    sql = "INSERT INTO pokemonUsuario VALUES ('" + usuario + "'," + a + ")";
                    int res = db.ejecutar_slq(sql);
                    sql = "INSERT INTO pokemonUsuario VALUES ('" + usuario + "'," + b + ")";
                    res = db.ejecutar_slq(sql);
                    cargarPkmn();
                }
            }
        }

        private void lstBxPkmns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Visible && !lstBxPkmns.Text.Substring(0, 3).Equals(" - "))
            {
                sql = "SELECT id FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                lbID_v.Text = db.consultaStr(sql, "pokedex");
                sql = "SELECT Imagen FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                picBxPkmns.ImageLocation = db.consultaStr(sql, "pokedex");
                sql = "SELECT nombre FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                lbNombre_v.Text = db.consultaStr(sql, "pokedex");
                sql = "SELECT peso FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                try
                {
                    lbPeso_v.Text = db.consultaStr(sql, "pokedex");
                }
                catch (Exception)
                {
                    lbPeso_v.Text = "";
                }
                sql = "SELECT altura FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                try
                {
                    lbAltura_v.Text = db.consultaStr(sql, "pokedex");
                }
                catch (Exception)
                {
                    lbAltura_v.Text = "";
                }
                sql = "SELECT tipo1 FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                try
                {
                    lbTipo_v.Text = db.consultaStr(sql, "pokedex");
                }
                catch (Exception)
                {
                    lbTipo_v.Text = "";
                }
                sql = "SELECT tipo2 FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                try
                {
                    lblTipo2.Text = db.consultaStr(sql, "pokedex");
                }
                catch (Exception)
                {
                    lblTipo2.Text = "";
                }
                sql = "SELECT clase FROM pokedex WHERE id = " + lstBxPkmns.Text.Substring(0, 3) + "";
                try
                {
                    lbNaturaleza_v.Text = db.consultaStr(sql, "pokedex");
                }
                catch (Exception)
                {
                    lbNaturaleza_v.Text = "";
                }
            }
            else {
                lbNombre_v.Text = "???";
                lbAltura_v.Text = "???";
                lbNaturaleza_v.Text = "???";
                lbID_v.Text = "???";
                lbPeso_v.Text = "???";
                lbTipo_v.Text = "???";
                lblTipo2.Text = "???";
                picBxPkmns.ImageLocation = "";
            }
        }
    }
}
