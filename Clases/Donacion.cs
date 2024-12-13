using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDogHouse.Clases
{
    internal class Donacion
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //Campos a utilizar
        public int Id, Folio;
        public string FechaDon, Nombre, Ap, Am, Tidona, Des;

        public Donacion()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj;
            try
            {
                string consulta = $"INSERT INTO Donacion (Id, Folio, Fecha_Dona, Nombre, ApellidoP, ApellidoM, Tipo_Dona, Descripcion) VALUES ({Id}, {Folio}, '{FechaDon}', '{Nombre}', '{Ap}', '{Am}', '{Tidona}', '{Des}')";
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
            string consulta = $"UPDATE Donacion SET Folio = {Folio}, Fecha_Dona = {FechaDon}, Nombre = '{Nombre}', ApellidoP = '{Ap}', ApellidoM = '{Am}', Tipo_Dona = '{Tidona}', Descripcion = '{Des}' WHERE Id = {Id}";
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
            string consulta = $"DELETE FROM Donacion WHERE Id = {Id} ";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "REGISTRO ELIMINADO";
            return msj;
        }
    }
}
