using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDogHouse.Clases
{
    internal class Sucursal
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //Campos a utilizar
        public int Id, NumSuc, IdDomi;
        public string Nombre, telefono, horario ;

        public Sucursal()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj;
            try
            {
                string consulta = $"INSERT INTO Sucursal (Id, Num_Sucursal, Nombre, Telefono, Horario, Id_Domicilio) VALUES ({Id}, {NumSuc}, '{Nombre}', '{telefono}', '{horario}', {IdDomi})"; 
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
            string consulta = $"UPDATE Sucursal SET Num_Sucursal = {NumSuc}, Nombre = '{Nombre}', Telefono = '{telefono}', Horario = '{horario}', Id_Domicilio = {IdDomi} WHERE Id = {Id}";
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
            string consulta = $"DELETE FROM Sucursal WHERE Id = {Id} ";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "REGISTRO ELIMINADO";
            return msj;
        }
    }
}
