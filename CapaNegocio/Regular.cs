using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Regular : Alumno
    {
        private string metodoIngreso;

        public string MetodoIngreso { get => metodoIngreso; set => metodoIngreso = value; }
    }
}