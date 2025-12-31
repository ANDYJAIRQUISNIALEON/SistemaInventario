using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public Usuario(int idUsuario, string cedula, string contrasena, string nombre, string apellido, bool estado, Rol rol)
        {
            IdUsuario = idUsuario;
            this.cedula = cedula;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.apellido = apellido;
            this.estado = estado;
            Rol = rol;
        }

        public int IdUsuario { get; set; }
        public string cedula {  get; set; }
        public string contrasena { get; set; }
        public string nombre {  get; set; }
        public string apellido { get; set; }
        public bool estado { get; set; }
        public Rol Rol { get; set; }
    }
}
