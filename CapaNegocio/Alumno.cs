using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno : Persona,IMantenimiento
    {
        private bool seguro;
        private string escuela;
        private string sede;

        public bool Seguro { get => seguro; set => seguro = value; }
        public string Escuela { get => escuela; set => escuela = value; }
        public string Sede { get => sede; set => sede = value; }

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

        public string Estudiar()
        {
            return "El metod estudiar no esta implementado";
        }

        public string Listar()
        {
            throw new NotImplementedException();
        }
    }
}
