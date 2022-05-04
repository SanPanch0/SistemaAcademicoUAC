using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Administrativo : Persona, IMantenimiento
    {
        private string sueldo;
        private string experiencia;

        public string Sueldo { get => sueldo; set => sueldo = value; }
        public string Experiencia { get => experiencia; set => experiencia = value; }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public string Buscar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public string Listar()
        {
            throw new NotImplementedException();
        }
    }
}