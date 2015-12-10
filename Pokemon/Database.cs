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

        public void pokemonAdmin(string sql,ListBox listbox)
        {
            Adapter = new OleDbDataAdapter(sql, Conexion);
            DataSet dataSet = new DataSet();
            Adapter.Fill(dataSet,"pokimon");
            List<string> pokemons = new List<string>();
            
            foreach (DataRow fila in dataSet.Tables["pokimon"].Rows)
            {
                String nuevo = String.Format("{0,3} - {1}", fila["id"], fila["nombre"]);
                pokemons.Add(nuevo);
            }
            listbox.DataSource = pokemons;
        }

        public void pokemonUser(string sql,ListBox listbox)
        {
            Adapter = new OleDbDataAdapter(sql, Conexion);
            DataSet dataSet = new DataSet();
            Adapter.Fill(dataSet, "pokimon");

            foreach (DataRow fila in dataSet.Tables["pokimon"].Rows)
            {
                String nuevo = string.Format("{0,3} - {1}", fila["idPokemon"], consultaStr("SELECT nombre FROM pokedex WHERE id = " + fila["idPokemon"].ToString(), "pokedex"));
                listbox.Items.RemoveAt(int.Parse(fila["idPokemon"].ToString()) - 1);
                listbox.Items.Insert(int.Parse(fila["idPokemon"].ToString())-1,nuevo);
            }
        }
        public String consultaStr(string sql,string tabla)
        {
            Adapter = new OleDbDataAdapter(sql, Conexion);
            DataSet dataSet = new DataSet();
            Adapter.Fill(dataSet, tabla);
            return dataSet.Tables[tabla].Rows[0][0].ToString();
        }
    }
}
