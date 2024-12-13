using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDogHouse.Clases
{
    internal class Adoptante
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //Campos a utilizar
        public int Id, NumAdop, IdDomicilio, edad;
        public string Nombre, ApellidoP, ApellidoM, FechaReg, Telefono, correo;

        public Adoptante()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj = "";
            try
            {
                string consulta = $"INSERT INTO Adoptante (Id, Num_Adop, Fecha_Reg, Nombre, ApellidoP, ApellidoM, Edad, Correo, Telefono, Id_Domicilio) VALUES ({Id}, {NumAdop}, '{FechaReg}', '{Nombre}', '{ApellidoP}', '{ApellidoM}', {edad}, '{correo}', '{Telefono}', '{IdDomicilio}')";
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
            string consulta = $"UPDATE Adoptante SET Num_Adop = {NumAdop}, Fecha_Reg = '{FechaReg}', Nombre = '{Nombre}', ApellidoP = '{ApellidoP}', ApellidoM = '{ApellidoM}', Edad = {edad}, Correo = '{correo}', Telefono = '{Telefono}', Id_Domicilio = {IdDomicilio} WHERE Id = {Id}";
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
            string consulta = $"DELETE FROM Adoptante WHERE Id = {Id} ";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "REGISTRO ELIMINADO";
            return msj;
        }
    }
}
