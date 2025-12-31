using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Rol
    {
        public Rol(int idRol, string nombre)
        {
            this.idRol = idRol;
            this.nombre = nombre;
        }

        public int idRol {  get; set; }
        public string nombre { get; set; }

    }
}
