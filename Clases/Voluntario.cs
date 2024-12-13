using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDogHouse.Clases
{
    internal class Voluntario
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //Campos a utilizar

        public int Id, NumVol, edad, IdCar;
        public string Nombre, ApellidoP, ApellidoM, FechaIns;
       
        public Voluntario()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj;
            try
            {
                string consulta = $"INSERT INTO Voluntario (Id, Num_Volun, Fecha_Inscrip, Nombre, ApellidoP, ApellidoM,  Edad, Id_Cargo) VALUES ({Id}, {NumVol}, '{FechaIns}', '{Nombre}', '{ApellidoP}', '{ApellidoM}', {edad}, {IdCar})";
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
            string consulta = $"UPDATE Voluntario SET Num_Volun = {NumVol}, Fecha_Inscrip = '{FechaIns}', Nombre = '{Nombre}', ApellidoP = '{ApellidoP}', ApellidoM = '{ApellidoM}',  Edad = {edad}, Id_Cargo = {IdCar} WHERE Id = {Id}";
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
            string consulta = $"DELETE FROM Voluntario WHERE Id = {Id} ";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "REGISTRO ELIMINADO";
            return msj;
        }
    }
}
