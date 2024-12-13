using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDogHouse.Clases
{
    internal class Herramienta
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        public Herramienta()
        {
            con.ConnectionString = x.Conexion;
        }

        public int consecutivo(string campo, string tabla)
        {
            int id = 0;
            string consulta = $"select isnull(max({campo})+1,1) as maxid from {tabla}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                id = int.Parse(lector["maxid"].ToString());
            }
            con.Close();
            return id;
        }

        public int ClaveNumAdop(string campo, string tabla)
        {
            int clave = 0;
            string consulta = $"select isnull(max({campo})+1,1) as maxid from {tabla}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                clave = int.Parse(lector["maxid"].ToString());
            }
            con.Close();
            return clave;
        }

        public int ClaveNumEmp(string campo, string tabla) 
        {
            int clave = 0;
            string consulta = $"select isnull(max({campo})+1,1) as maxid from {tabla}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                clave = int.Parse(lector["maxid"].ToString());
            }
            con.Close();
            return clave;
        }

        public int ClaveNumMasc(string campo, string tabla)
        {
            int clave = 0;
            string consulta = $"select isnull(max({campo})+1,1) as maxid from {tabla}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                clave = int.Parse(lector["maxid"].ToString());
            }
            con.Close();
            return clave;
        }

        public int ClaveNumSuc(string campo, string tabla)
        {
            int clave = 0;
            string consulta = $"select isnull(max({campo})+1,1) as maxid from {tabla}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                clave = int.Parse(lector["maxid"].ToString());
            }
            con.Close();
            return clave;
        }

        public int Folio(string campo, string tabla)
        {
            int clave = 0;
            string consulta = $"select isnull(max({campo})+1,1) as maxid from {tabla}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                clave = int.Parse(lector["maxid"].ToString());
            }
            con.Close();
            return clave;
        }
    }
}
