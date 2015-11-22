using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pokemon
{
    class Database
    {
        private string StrConexion;
        private OleDbConnection Conexion;
        private OleDbDataAdapter Adapter;
        private DataSet miDataSet = new DataSet();

        public void IniciarConexion(string Database)
        {
            StrConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + Database;
            Conexion = new OleDbConnection(StrConexion);
        }

        public int ejecutar_slq(string sql)
        {
            int i = 0;
            try
            {
                Conexion.Open();
                OleDbCommand cmd = new OleDbCommand(sql, Conexion);
                i = cmd.ExecuteNonQuery();
            }
            catch
            {
                i = -1;
            }
            Conexion.Close();
            return i;
        }

        public void consultar(string sql,ListBox listbox)
        {
            Adapter = new OleDbDataAdapter(sql, Conexion);
            DataSet dataSet = new DataSet();
            Adapter.Fill(dataSet,"pokimon");
            List<string> pokemons = new List<string>();
            
            foreach (DataRow tabla in dataSet.Tables["pokimon"].Rows)
            {
                String nuevo = String.Format("{0,3} - {1}", tabla["id"], tabla["nombre"]);
                pokemons.Add(nuevo);
            }
            //listbox.DataSource = dataSet.Tables["pokimon"].DefaultView;
            //listbox.DisplayMember = "id,nombre";
            //listbox.DisplayMember = "nombre";
            listbox.DataSource = pokemons;
        }
        public String consultaStr(string sql)
        {
            Adapter = new OleDbDataAdapter(sql, Conexion);
            DataSet dataSet = new DataSet();
            Adapter.Fill(dataSet, "pokedex3");
            return dataSet.Tables["pokedex3"].Rows[0][0].ToString();
        }
    }
}
