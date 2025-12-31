using Dato;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioLogica
    {
        UsuarioDato usuarioDato = new UsuarioDato();
        public Usuario Login(string cedula, string Contrasena)
        {
            // Validacion
            if (string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(Contrasena))
                return null;

            return usuarioDato.Login(cedula, Contrasena);
        }
    }
}
