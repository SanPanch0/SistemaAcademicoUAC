using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Docente : Persona, IMantenimiento
    {
        private string afp;
        private string profesion;
        private string estudios;

        public string Afp { get => afp; set => afp = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public string Estudios { get => estudios; set => estudios = value; }

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