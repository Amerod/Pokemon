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
        public Principal(Form p)
        {
            InitializeComponent();            
            padre = p;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            padre.Close();
        }
    }
}
