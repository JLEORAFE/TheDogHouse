using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDogHouse.Clases
{
    internal class Mascota
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //Campos a utilizar
        public int Id, NumMasc, edad;
        public decimal Altura, Peso;
        public string FechaIng, Nombre, Raza;

        public Mascota()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj;
            try
            {
                string consulta = $"INSERT INTO Mascota (Id, Num_Masc, Fecha_Ing, Nombre, Edad, Altura, Peso, Raza) VALUES ({Id}, {NumMasc}, '{FechaIng}', '{Nombre}', {edad}, {Altura}, {Peso}, '{Raza}')";
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
            string consulta = $"UPDATE Mascota SET Num_Masc = {NumMasc}, Fecha_Ing = '{FechaIng}', Nombre = '{Nombre}', Edad = {edad}, Altura = {Altura}, Peso = {Peso}, Raza = '{Raza}' WHERE Id = {Id}";
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
            string consulta = $"DELETE FROM Mascota WHERE Id = {Id} ";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "REGISTRO ELIMINADO";
            return msj;
        }
    }
}
