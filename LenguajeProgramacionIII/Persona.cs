using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajeProgramacionIII
{
    public class Persona
    {
        //FORMA 1
        //ATRIBUTOS
        //private string nombre;
        //private string apellido;
        //private int edad;
        //private string direccion;

        //PROPIEDADES
        //public string Nombre
        //{
        //    get { return nombre; }
        //    set { nombre = value; }
        //}

        //public string Apellido
        //{
        //    get { return apellido; }
        //    set { apellido = value; }
        //}

        //public int Edad
        //{
        //    get { return edad; }
        //    set { edad = value; }
        //}

        //public string Direccion
        //{
        //    get { return Direccion; }
        //    set { direccion = value; }
        //}

        //FORMA 2
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
 
        //CONSTRUCTORES
        public Persona() { }

        public Persona (string _nombre, string _apellido, int _edad, string _direccion)
        {
            //PROPIEDAD IGUAL A PARAMETROS 
            Nombre = _nombre;
            Apellido = _apellido;
            Edad = _edad;
            Direccion = _direccion;
        }

        //METODOS
        public string DevolverNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        public int MostrarEdad()
        {
            return Edad;
        }

        public string MostrarDireccion()
        {
            return Direccion;
        }
    }
}
