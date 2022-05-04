using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Persona
    {
        //Atributos
        private string codigo;
        private string apellidos;
        private string nombres;
        private DateTime fechaNAC;
        private string lugarNac;
        private string correo;
        private string domicilio;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public DateTime FechaNAC { get => fechaNAC; set => fechaNAC = value; }
        public string LugarNac { get => lugarNac; set => lugarNac = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }

        //Metodos
        public string Exisistir() 
        {
            return "El metod exisistir no esta implementado";
        }
        public string Asistir()
        {
            return "El metodo asistir no esta implementado";
        }
    }
    
}
