using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    abstract class Legislador
    {
        protected string partidoPolitico;
        protected string departamento;
        protected int numDespacho;
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected bool casado;
        protected int id;
        protected string camara;
        protected int numAsientoCamara;

        public Legislador(string partidoPolitico, string departamento, int numDespacho, string nombre, string apellido, int edad, bool casado, int id, string camara, int numAsientoCamara)
        {
            this.partidoPolitico = partidoPolitico;
            this.departamento = departamento;
            this.numDespacho = numDespacho;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.casado = casado;
            this.id = id;
            this.camara = camara;
            this.numAsientoCamara = numAsientoCamara;
    
        }

        //METODOS
        public string getCamara()
        {
            return camara;
        }
        public abstract string presentarPropuestaLegislativa();
        public abstract string votar();
        public abstract string participarDebate();

        //GETTERS
        public string getPartidoPolitico()
        {
            return partidoPolitico;
        }
        public string getDepartamento()
        {
            return departamento;
        }
        public int getNumDespacho()
        {
            return numDespacho;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public int getEdad()
        {
            return edad;
        }
        public bool getCasado()
        {
            return casado;
        }
        public int getId()
        {
            return id;
        }
        public int getNumAsientoCamara()
        {
            return numAsientoCamara;
        }

        //SETTERS
        public void setCamara(string camara)
        {
            this.camara = camara;
        }

        public void setNumDespacho(int numDespacho)
        {

            this.numDespacho = numDespacho;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setPartidoPolitico(string partidoPolitico)
        {
            this.partidoPolitico = partidoPolitico;
        }
        public void setDepartamento(string departamento)
        {
            this.departamento = departamento;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public void setCasado(bool casado)
        {
            this.casado = casado;
        }
       public void setNumAsientoCamara(int numAsientoCamara)
        {
            this.numAsientoCamara = numAsientoCamara;
        }
    }

}
