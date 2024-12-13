using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TheDogHouse.Clases
{
    internal class Domicilio
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //Campos a utilizar
        public int id;
        public string cp, calle, colonia, referencias, tipo;

        public Domicilio()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"INSERT INTO Domicilio (Id, CP, Calle, Colonia, Referencias, Tipo) VALUES ({id},'{cp}', '{calle}', '{colonia}', '{referencias}', '{tipo}')";
                con.Open();
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "GUARDADO EXITOSO";
            }
            catch 
            {
                msj = "PROBEMAS AL GUARDAR, VERIFIQUE LOS DATOS";

            }
            return msj;

        }

        public string Actualizar()
        {
            string msj = "";
            string consulta = $"UPDATE Domicilio SET CP = '{cp}', Calle = '{calle}', Colonia = '{colonia}', Referencias = '{referencias}', Tipo = '{tipo}' WHERE Id = {id} ";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "ACTUALIZACIÓN EXITOSA";
            return msj;
        }

        public string Eliminar()
        {
            string msj = "";
            string consulta = $"DELETE FROM Domicilio WHERE Id = {id} ";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "REGISTRO ELIMINADO";
            return msj;
        }
    }
}
