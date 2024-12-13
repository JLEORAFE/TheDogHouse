using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDogHouse.Clases
{
    internal class Empleado
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();

        //Campos a utilizar
        public int Id, NumEmp, edad, IdDomi;
        public string Nombre, ApellidoP, ApellidoM, FechaN, Fechareg, correo, telefono, contraseña;

        public Empleado()
        {
            con.ConnectionString = x.Conexion;
        }

        public string Guardar()
        {
            string msj;
            try
            {
                string consulta = $"INSERT INTO Empleado (Id, Num_Emp, Nombre, ApellidoP, ApellidoM, Fecha_Nac, Edad, Fecha_Reg, Correo, Telefono, Contraseña, Id_Domicilio) VALUES ({Id}, {NumEmp}, '{Nombre}', '{ApellidoP}', '{ApellidoM}', '{FechaN}', {edad}, '{Fechareg}', '{correo}', '{telefono}', '{contraseña}', {IdDomi})";
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
            string consulta = $"UPDATE Empleado SET Num_Emp = {NumEmp}, Nombre = '{Nombre}', ApellidoP = '{ApellidoP}', ApellidoM = '{ApellidoM}', Fecha_Nac = '{FechaN}', Edad = {edad}, Fecha_Reg = '{Fechareg}',  Correo = '{correo}', Telefono = '{telefono}', Id_Domicilio = {IdDomi} WHERE Id = {Id}";
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
            string consulta = $"DELETE FROM Empleado WHERE Id = {Id} ";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "REGISTRO ELIMINADO";
            return msj;
        }
    }
}
