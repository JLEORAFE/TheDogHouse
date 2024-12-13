using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TheDogHouse.Clases
{
    internal class Cargo
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //
        public int Id, Codigo;
        public string Nombre, Descripcion;

        public Cargo()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj;
            try
            {
                string consulta = $"INSERT INTO Cargo (Id, Codigo, Nombre, Descripcion) VALUES ({Id}, {Codigo}, '{Nombre}', '{Descripcion}')";
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
            string msj;
            string consulta = $"UPDATE Cargo SET Codigo = {Codigo}, Nombre = '{Nombre}', Descripcion = '{Descripcion}' WHERE Id = {Id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "ACTUALIZACIÓN EXITOSA";
            return msj;
        }

        public string Eliminar()
        {
            string msj;
            string consulta = $"DELETE FROM Cargo WHERE Id = {Id} ";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "REGISTRO ELIMINADO";
            return msj;
        }
    }
}
