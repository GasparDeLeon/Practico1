using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Diputado : Legislador
    {
        public Diputado(string partidoPolitico, string departamento, int numDespacho, string nombre, string apellido, int edad, bool casado, int id, string camara, int numAsientoCamara) : base(partidoPolitico, departamento, numDespacho, nombre, apellido, edad, casado, id, camara, numAsientoCamara)
        {

        }
        public override string presentarPropuestaLegislativa()
        {
            return "El diputado " + nombre + " " + apellido + " presentó una propuesta. ";
        }
        public override string votar()
        {
            return "El diputado " + nombre + " " + apellido + " votó una propuesta. ";
        }
        public override string participarDebate()
        {
            return "El diputado " + nombre + " " + apellido + " participó en un debate. ";
        }
    }
}
