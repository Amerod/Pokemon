using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Juego : Form
    {
        Database db = new Database();
        String sql;
        PictureBox firstClicked = null;
        int segundos = 0;
        PictureBox secondClicked = null;
        List<int> numeros= new List<int>();
        Random random = new Random();
        PrincipalJugador padre;
        

        private void AssignIconsToSquares()
        {
            List<int> poke = new List<int>();
            int max = int.Parse(db.consultaStr("SELECT count(*) FROM pokedex","pokedex"));
            for (int i = 0; i < 12; i++)
            {
                int aleatorio = 0;
                do
                {
                    aleatorio = 1 + random.Next(max - 1);
                } while (poke.Contains(aleatorio));
                numeros.Add(aleatorio);
                poke.Add(aleatorio);
                poke.Add(aleatorio);
            }
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is PictureBox)
                {
                    PictureBox imagen = item as PictureBox;
                    int aleatorio = random.Next(poke.Count);
                    imagen.Tag = "images/" + poke[aleatorio] + ".png";
                    imagen.ImageLocation = "";
                    poke.RemoveAt(aleatorio);
                }
            }
        }

        public Juego(PrincipalJugador p)
        {
            InitializeComponent();
            db.IniciarConexion("pokedex.accdb");
            AssignIconsToSquares();
            timer2.Start();
            padre = p;
        }

        public void checkForWinner()
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is PictureBox)
                {
                    PictureBox imagen = item as PictureBox;
                    if (imagen.ImageLocation != imagen.Tag.ToString())
                    {
                        return;
                    }
                }
            }
            timer2.Stop();
            MessageBox.Show("¡Has acabado en " + segundos + " segundos!");
            padre.volver(numeros,int.Parse(tiempo.Text));
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox clickedLabel = sender as PictureBox;
            if (clickedLabel != null)
            {
                if (clickedLabel.ImageLocation == clickedLabel.Tag.ToString())
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ImageLocation = firstClicked.Tag.ToString();
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ImageLocation = secondClicked.Tag.ToString();

                checkForWinner();

                if (firstClicked.ImageLocation == secondClicked.ImageLocation)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ImageLocation = "";
            secondClicked.ImageLocation = "";
            firstClicked = null;
            secondClicked = null;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            segundos++;
            tiempo.Text = segundos.ToString();
        }
    }
}
