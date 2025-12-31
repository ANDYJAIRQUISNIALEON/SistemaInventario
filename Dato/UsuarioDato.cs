using Microsoft.Data.SqlClient;
using Modelo;
using System;
using System.Data;

namespace Dato
{
    public class UsuarioDato
    {
        Conexion conexion = new Conexion();

        public Usuario Login(string cedula, string contrasena)
        {
            SqlConnection sqlConnection = conexion.conectar();
            Usuario usuario = null;

            try
            {
                SqlCommand cmd = new SqlCommand("SP_LOGIN", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CEDULA", cedula);
                cmd.Parameters.AddWithValue("@CONTRASENA", contrasena);

                sqlConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    usuario = new Usuario(
                        Convert.ToInt32(dr["IdUsuario"]),
                        dr["Cedula"].ToString(),
                        "",   // nunca devuelvas contraseña
                        dr["Nombre"].ToString(),
                        dr["Apellido"].ToString(),
                        Convert.ToBoolean(dr["Estado"]),
                        new Rol(
                            Convert.ToInt32(dr["ID_ROL"]),
                            dr["Rol"].ToString()
                        )
                    );
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar usuario: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return usuario;
        }   
    }
}
