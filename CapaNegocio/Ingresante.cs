using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Ingresante : Alumno
    {
        private string semestre;
        private string ciclo;

        public string Semestre { get => semestre; set => semestre = value; }
        public string Ciclo { get => ciclo; set => ciclo = value; }
    }
}