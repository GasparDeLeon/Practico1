using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Parlamento
    {
        string mensaje;
        List<Legislador> legisladores;

        public Parlamento()
        {
            legisladores = new List<Legislador>();
        }
        public void registrarLegislador(Legislador legisladorAAgregar)
        {
            legisladores.Add(legisladorAAgregar);
        }
        public void listarCamaras()
        {
            Console.WriteLine("Senadores: ");
            foreach (Legislador legislador in legisladores)
            {
                if (legislador.getCamara() == "Senador")
                {
                    Console.WriteLine("Nombre completo: " + legislador.getNombre() + " " + legislador.getApellido());
                    Console.WriteLine("Edad: " + legislador.getEdad());
                    Console.WriteLine("Su despacho es el número: " + legislador.getNumDespacho());
                    Console.WriteLine("Es un representante de la camara de: " + legislador.getCamara());
                }
            }
            Console.WriteLine("\n\n\nDiputados: ");
            foreach (Legislador legislador in legisladores)
            {
                if (legislador.getCamara() == "Diputado")
                {
                    Console.WriteLine("Nombre completo: " + legislador.getNombre() + " " + legislador.getApellido());
                    Console.WriteLine("Edad: " + legislador.getEdad());
                    Console.WriteLine("Su despacho es el número: " + legislador.getNumDespacho());
                    Console.WriteLine("Es un representante de la camara de: " + legislador.getCamara());
                }
            }
        }
        public void cantidadRepresentantes()
        {
            int Senadores = 0;
            int Diputados = 0;

            foreach (Legislador legislador in legisladores)
            {
                if (legislador.getCamara() == "Senador")
                {
                    Senadores++;
                }
                if (legislador.getCamara() == "Diputado")
                {
                    Diputados++;
                }
            }
            Console.WriteLine("Miembros de la camara de senadores: " + Senadores);
            Console.WriteLine("Miembros de la camara de diputados: " + Diputados);
        }
        public void getLegisladores()
        {
            foreach (Legislador legislador in legisladores)
            {
                Console.WriteLine(legislador.getId() + ")");
                Console.WriteLine("Nombre completo: " + legislador.getNombre() + " " + legislador.getApellido());
                Console.WriteLine("Su despacho es el número: " + legislador.getNumDespacho());
                Console.WriteLine("Es representante de la camara de: " + legislador.getCamara());
                Console.WriteLine("\t\t\t\t");
            }
        }

        public void accionLegislador(int x)
        {

            foreach (Legislador legislador in legisladores)
            {
                if (legislador.getId() == x)
                {
                    while (legislador.getId() != x)
                    {
                        Console.WriteLine("Opción inválida, vuelva a intentarlo. ");
                        Console.WriteLine("Seleccione la accion a realizar: ");
                        Console.WriteLine("1) Presentar una propuesta legislativa: ");
                        Console.WriteLine("2) Votar una propuesta: ");
                        Console.WriteLine("3) Participar de un debate: ");
                        x = leerEntero(Console.ReadLine());
                    }
                    Console.WriteLine("Seleccione la accion a realizar: ");
                    Console.WriteLine("1) Presentar una propuesta legislativa: ");
                    Console.WriteLine("2) Votar una propuesta: ");
                    Console.WriteLine("3) Participar de un debate: ");
                    string opcion = Console.ReadLine();

                    while (opcion != "1" && opcion != "2" && opcion != "3")
                    {
                        Console.WriteLine("Opción inválida, vuelva a intentarlo. ");
                        Console.WriteLine("1) Presentar una propuesta legislativa: ");
                        Console.WriteLine("2) Votar una propuesta: ");
                        Console.WriteLine("3) Participar de un debate: ");
                        opcion = Console.ReadLine();

                    }
                    switch (opcion)
                    {
                        case "1":
                            mensaje = legislador.presentarPropuestaLegislativa();
                            break;
                        case "2":
                            mensaje = legislador.votar();
                            break;
                        case "3":
                            mensaje = legislador.participarDebate();
                            break;
                    }
                }

            }
        }
        public void actualizarLegislador(int x)
        {
            foreach (Legislador legislador in legisladores)
            {


                if (legislador.getId() == x)
                {
                    Console.Clear();
                    Console.WriteLine("¿Qué dato desea modificar? ");
                    Console.WriteLine("1) Nombre: " + legislador.getNombre());
                    Console.WriteLine("2) Apellido: " + legislador.getApellido());
                    Console.WriteLine("3) Edad: " + legislador.getEdad());
                    Console.WriteLine("4) Casado: " + legislador.getCasado());
                    Console.WriteLine("5) Departamento: " + legislador.getDepartamento());
                    Console.WriteLine("6) Partido Político: " + legislador.getPartidoPolitico());
                    Console.WriteLine("7) Número de despacho: " + legislador.getNumDespacho());
                    Console.WriteLine("8) Número de asiento en la cámara: " + legislador.getNumAsientoCamara());
                    Console.WriteLine("9) Camara: " + legislador.getCamara());
                    Console.WriteLine("10) Salir. ");
                    string modificar = Console.ReadLine();

                    while (modificar != "10")
                    {
                        Console.Clear();
                        while (modificar != "1" && modificar != "2" && modificar != "3" && modificar != "4" && modificar != "5" && modificar != "6" && modificar != "7" && modificar != "8" && modificar != "9" && modificar != "10")
                        {
                            Console.WriteLine("Opción inválida, vuelva a intentarlo. ");
                            Console.WriteLine("¿Qué dato desea modificar? ");
                            Console.WriteLine("1) Nombre: " + legislador.getNombre());
                            Console.WriteLine("2) Apellido: " + legislador.getApellido());
                            Console.WriteLine("3) Edad: " + legislador.getEdad());
                            Console.WriteLine("4) Casado: " + legislador.getCasado());
                            Console.WriteLine("5) Departamento: " + legislador.getDepartamento());
                            Console.WriteLine("6) Partido Político: " + legislador.getPartidoPolitico());
                            Console.WriteLine("7) Número de despacho: " + legislador.getNumDespacho());
                            Console.WriteLine("8) Número de asiento en la cámara: " + legislador.getNumAsientoCamara());
                            Console.WriteLine("9) Camara: " + legislador.getCamara());
                            Console.WriteLine("10) Salir. ");

                            Console.Clear();

                        }

                        switch (modificar)
                        {
                            case "1":
                                Console.WriteLine("Ingrese el nombre: ");
                                legislador.setNombre(Console.ReadLine());
                                break;
                            case "2":
                                Console.WriteLine("Ingrese el apellido: ");
                                legislador.setApellido(Console.ReadLine());
                                break;
                            case "3":
                                Console.WriteLine("Ingrese la edad: ");
                                legislador.setEdad(leerEntero(Console.ReadLine()));
                                break;
                            case "4":
                                Console.WriteLine("¿El legislador está casado? ");
                                Console.WriteLine("1) Si. ");
                                Console.WriteLine("2) No. ");
                                string casadostr = Console.ReadLine();
                                Console.Clear();
                                while (casadostr != "1" && casadostr != "2")
                                {
                                    Console.WriteLine("Opción inválida, vuelva a intentarlo. ");
                                    Console.WriteLine("¿El legislador está casado? ");
                                    Console.WriteLine("1) Si. ");
                                    Console.WriteLine("2) No. ");
                                    casadostr = Console.ReadLine();
                                    Console.Clear();

                                }
                                bool casado;
                                if (casadostr == "1")
                                {
                                    casado = true;
                                }
                                else
                                {
                                    casado = false;
                                }
                                legislador.setCasado(casado);
                                break;
                            case "5":
                                Console.WriteLine("Ingrese el departamento del legislador: ");
                                legislador.setDepartamento(Console.ReadLine());
                                break;
                            case "6":
                                Console.WriteLine("Ingrese el partido político del legislador: ");
                                legislador.setPartidoPolitico(Console.ReadLine());
                                break;
                            case "7":
                                Console.WriteLine("Ingrese el número de despacho del legislador: ");
                                legislador.setNumDespacho(leerEntero(Console.ReadLine()));
                                break;
                            case "8":
                                Console.WriteLine("¿A qué camara pertence el legislador? ");
                                Console.WriteLine("1) Senadores. ");
                                Console.WriteLine("2) Diputados. ");
                                string camara = (Console.ReadLine());
                                Console.Clear();
                                while (camara != "1" && camara != "2")
                                {
                                    Console.WriteLine("Opción inválida, vuelva a intentarlo. ");
                                    Console.WriteLine("¿A qué camara pertence el legislador? ");
                                    Console.WriteLine("1) Senadores. ");
                                    Console.WriteLine("2) Diputados. ");
                                    camara = (Console.ReadLine());
                                    Console.Clear();
                                }
                                if (camara == "1")
                                {
                                    camara = "Senador. ";
                                }
                                else
                                {
                                    camara = "Diputado. ";
                                }
                                legislador.setCamara(camara);
                                break;
                            case "9":
                                Console.WriteLine("Ingrese el número de asiento del legislador en la camara: ");
                                legislador.setNumAsientoCamara(leerEntero(Console.ReadLine()));

                                break;
                        }

                        Console.WriteLine("Datos actualizados del legislador: ");
                        Console.WriteLine("1) Nombre: " + legislador.getNombre());
                        Console.WriteLine("2) Apellido: " + legislador.getApellido());
                        Console.WriteLine("3) Edad: " + legislador.getEdad());
                        Console.WriteLine("4) Casado: " + legislador.getCasado());
                        Console.WriteLine("5) Departamento: " + legislador.getDepartamento());
                        Console.WriteLine("6) Partido Político: " + legislador.getPartidoPolitico());
                        Console.WriteLine("7) Número de despacho: " + legislador.getNumDespacho());
                        Console.WriteLine("8) Número de asiento en la cámara: " + legislador.getNumAsientoCamara());
                        Console.WriteLine("9) Camara: " + legislador.getCamara());
                        Console.WriteLine("10) Salir. ");
                        modificar = Console.ReadLine();
                        Console.Clear();


                    }

                }





            }

        }
        static int leerEntero(string x)
        {
            int valor;
            while (!int.TryParse(x, out valor))
            {
                Console.Clear();
                Console.WriteLine("El valor no es válido. Intente otra vez. ");
                x = Console.ReadLine();

            }
            return valor;
        }
        public string getMensaje()
        {
            return mensaje;
        }
    }
}