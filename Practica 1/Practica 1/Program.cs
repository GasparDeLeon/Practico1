using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            Parlamento parlamento = new Parlamento();
            string opcionMenu;
            do
            {
                opcionMenu = menuPrincipal();
                Console.Clear();

                while (opcionMenu != "1" && opcionMenu != "2" && opcionMenu != "3" && opcionMenu != "4" && opcionMenu != "5" && opcionMenu != "6")
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tOpción inválida, vuelva a intentarlo. \n");
                    Console.WriteLine("\t\t\tIndique la opción deseada: \n");
                    Console.WriteLine("\t\t\t1) Registrar un Legislador. ");
                    Console.WriteLine("\t\t\t2) Informacion de los legisladores. ");
                    Console.WriteLine("\t\t\t3) Lista de legisladores. ");
                    Console.WriteLine("\t\t\t4) Modificar datos de los legisladores. ");
                    Console.WriteLine("\t\t\t5) Acciones legislativas. ");
                    Console.WriteLine("\t\t\t6) Salir. \n\n\n\n\n\n\n\n\n\n\n");
                    opcionMenu = Console.ReadLine();
                    Console.Clear();
                }

                switch (opcionMenu)
                {
                    case "1":
                        Console.WriteLine("\t\t\tIndique el tipo de legislador: ");
                        Console.WriteLine("\t\t\t1) Senador. ");
                        Console.WriteLine("\t\t\t2) Diputado. ");
                        string camara = Console.ReadLine();
                        Console.Clear();
                        while (camara != "1" && camara != "2")
                        {
                            Console.WriteLine("\t\t\tOpción inválida, vuelva a intentarlo. \n");
                            Console.WriteLine("\t\t\tIndique el tipo de legislador: ");
                            Console.WriteLine("\t\t\t1) Senador. ");
                            Console.WriteLine("\t\t\t2) Diputado. ");
                            camara = Console.ReadLine();
                            Console.Clear();
                        }

                        if (camara == "1")
                        {
                            camara = "Senador";
                        }
                        else
                        {
                            camara = "Diputado";
                        }
                        Console.WriteLine("\t\t\tIngrese el nombre del legislador: ");
                        string nombre = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("\t\t\tIngrese el apellido del legisilador: ");
                        string apellido = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("\t\t\tIngrese la edad del legislador: ");
                        int edad = leerEntero(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("\t\t\t¿El lgislador está casado?");
                        Console.WriteLine("\t\t\t1) Si. ");
                        Console.WriteLine("\t\t\t2) No. ");
                        string casadostr = Console.ReadLine();
                        Console.Clear();
                        while (casadostr != "1" && casadostr != "2")
                        {
                            Console.WriteLine("\t\t\tOpción inválida, vuelva a intentarlo. \n");
                            Console.WriteLine("\t\t\t¿El legislador está casado?");
                            Console.WriteLine("\t\t\t1) Si. ");
                            Console.WriteLine("\t\t\t2) No. ");
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

                        Console.WriteLine("\t\t\tIngrese el departamento del legislador: ");
                        string departamento = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("\t\t\tIngrese el partido político del legislador: ");
                        string partidoPolitico = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("\t\t\tIngrese el número del despacho del legislador: ");
                        int numDespacho = leerEntero(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("\t\t\tIngrese el número de asiento del legislador en la camara: ");
                        int numAsientoCamara = leerEntero(Console.ReadLine());
                        Console.Clear();
                        string correcto;
                        Console.WriteLine("\t\t\t¿Los datos son correctos?");
                        Console.WriteLine("\t\t\tNombre: " + nombre);
                        Console.WriteLine("\t\t\tApellido: " + apellido);
                        Console.WriteLine("\t\t\tEdad: " + edad);
                        Console.WriteLine("\t\t\tCasado: " + casado);
                        Console.WriteLine("\t\t\tDepartamento: " + departamento);
                        Console.WriteLine("\t\t\tPartido Político: " + partidoPolitico);
                        Console.WriteLine("\t\t\tNúmero de despacho: " + numDespacho);
                        Console.WriteLine("\t\t\tNúmero de asiento en la cámara: " + numAsientoCamara);
                        Console.WriteLine("\t\t\tCamara: " + camara);
                        Console.WriteLine("\n\t\t\t1) Si. ");
                        Console.WriteLine("\t\t\t2) No, deseo modificarlos. ");
                        correcto = Console.ReadLine();
                        Console.Clear();
                        while (correcto != "1" && correcto != "2")
                        {
                            Console.WriteLine("\t\t\tOpción inválida, vuelva a intentarlo. \n");
                            Console.WriteLine("\t\t\t1) Si. ");
                            Console.WriteLine("2) No, deseo modificarlos. ");
                            correcto = Console.ReadLine();
                            Console.Clear();
                        }
                        while (correcto == "2")
                        {
                            Console.WriteLine("\t\t\t¿Qué dato quiere modificar?");
                            Console.WriteLine("\t\t\t1) Nombre: " + nombre);
                            Console.WriteLine("\t\t\t2) Apellido: " + apellido);
                            Console.WriteLine("\t\t\t3) Edad: " + edad);
                            Console.WriteLine("\t\t\t4) Casado: " + casado);
                            Console.WriteLine("\t\t\t5) Departamento: " + departamento);
                            Console.WriteLine("\t\t\t6) Partido Político: " + partidoPolitico);
                            Console.WriteLine("\t\t\t7) Número de despacho: " + numDespacho);
                            Console.WriteLine("\t\t\t8) Número de asiento en la cámara: " + numAsientoCamara);
                            Console.WriteLine("\t\t\t9) Camara: " + camara);
                            Console.WriteLine("\t\t\t10) Salir. ");
                            string datoAModificar;
                            datoAModificar = Console.ReadLine();
                            Console.Clear();
                            while (datoAModificar != "1" && datoAModificar != "2" && datoAModificar != "3" && datoAModificar != "4" && datoAModificar != "5" && datoAModificar != "6" && datoAModificar != "7" && datoAModificar != "8" && datoAModificar != "9" && datoAModificar != "10")
                            {
                                Console.WriteLine("\t\t\tOpción inválida, vuelva a intentarlo. ");
                                Console.WriteLine("\t\t\t¿Qué dato quiere modificar?");
                                Console.WriteLine("\t\t\t1) Nombre: " + nombre);
                                Console.WriteLine("\t\t\t2) Apellido: " + apellido);
                                Console.WriteLine("\t\t\t3) Edad: " + edad);
                                Console.WriteLine("\t\t\t4) Casado: " + casado);
                                Console.WriteLine("\t\t\t5) Departamento: " + departamento);
                                Console.WriteLine("\t\t\t6) Partido Político: " + partidoPolitico);
                                Console.WriteLine("\t\t\t7) Número de despacho: " + numDespacho);
                                Console.WriteLine("\t\t\t8) Número de asiento en la cámara: " + numAsientoCamara);
                                Console.WriteLine("\t\t\t9) Camara: " + camara);
                                datoAModificar = Console.ReadLine();
                                Console.Clear();
                            }
                            switch (datoAModificar)
                            {
                                case "1":
                                    Console.WriteLine("\t\t\tIngrese el nombre del legislador: ");
                                    nombre = Console.ReadLine();
                                    break;
                                case "2":
                                    Console.WriteLine("\t\t\tIngrese el apellido del legislador: ");
                                    apellido = Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("\t\t\tIngrese la edad del legislador: ");
                                    edad = leerEntero(Console.ReadLine());
                                    break;
                                case "4":
                                    Console.WriteLine("\t\t\t¿El legislador está casado? ");
                                    Console.WriteLine("\t\t\t1) Si. ");
                                    Console.WriteLine("\t\t\t2) No. ");
                                    casadostr = Console.ReadLine();
                                    Console.Clear();
                                    while (casadostr != "1" && casadostr != "2")
                                    {
                                        Console.WriteLine("\t\t\tOpción inválida, vuelva a intentarlo. ");
                                        Console.WriteLine("\t\t\t¿El legislador está casado? ");
                                        Console.WriteLine("\t\t\t1) Si. ");
                                        Console.WriteLine("\t\t\t2) No. ");
                                        casadostr = Console.ReadLine();
                                    }
                                    if (casadostr == "1")
                                    {
                                        casado = true;
                                    }
                                    else
                                    {
                                        casado = false;
                                    }
                                    break;
                                case "5":
                                    Console.WriteLine("\t\t\tIngrese el departamento del legislador: ");
                                    departamento = Console.ReadLine();
                                    break;
                                case "6":
                                    Console.WriteLine("\t\t\tIngrese el partido político del legislador");
                                    partidoPolitico = Console.ReadLine();
                                    break;
                                case "7":
                                    Console.WriteLine("\t\t\tIngrese el número del despacho del legislador: ");
                                    numDespacho = leerEntero(Console.ReadLine());
                                    break;
                                case "8":
                                    Console.WriteLine("\t\t\tIngrese el número del asiento del legislador en la cámara");
                                    numAsientoCamara = leerEntero(Console.ReadLine());
                                    break;
                                case "9":
                                    Console.WriteLine("\t\t\t¿En qué camara se encuentra el legislador? ");
                                    Console.WriteLine("\t\t\t1) Senadores. ");
                                    Console.WriteLine("\t\t\t2) Diputados. ");
                                    camara = Console.ReadLine();
                                    while (camara != "1" && camara != "2")
                                    {
                                        Console.WriteLine("\t\t\tOpción inválida, vuelva a intentarlo. ");
                                        Console.WriteLine("\t\t\t¿En qué camara se encuentra el legislador? ");
                                        Console.WriteLine("\t\t\t1) Senadores. ");
                                        Console.WriteLine("\t\t\t2) Diputados. ");
                                        camara = Console.ReadLine();
                                    }
                                    if (camara == "1")
                                    {
                                        camara = "Senador";
                                    }
                                    else
                                    {
                                        camara = "Diputado";
                                    }
                                    break;

                            }

                            Console.Clear();
                            if (datoAModificar != "10")
                            {
                                Console.WriteLine("\t\t\t¿Los datos son correctos? ");
                                Console.WriteLine("\t\t\tNombre: " + nombre);
                                Console.WriteLine("\t\t\tApellido: " + apellido);
                                Console.WriteLine("\t\t\tEdad: " + edad);
                                Console.WriteLine("\t\t\tCasado: " + casado);
                                Console.WriteLine("\t\t\tDepartamento: " + departamento);
                                Console.WriteLine("\t\t\tPartido Político: " + partidoPolitico);
                                Console.WriteLine("\t\t\tNúmero de despacho: " + numDespacho);
                                Console.WriteLine("\t\t\tNúmero de asiento en la cámara: " + numAsientoCamara);
                                Console.WriteLine("\t\t\tCamara: " + camara);
                                Console.WriteLine("\t\t\t\n1) Si. ");
                                Console.WriteLine("\t\t\t2) No, deseo modificarlos. ");
                                correcto = Console.ReadLine();
                                while (correcto != "1" && correcto != "2")
                                {
                                    Console.WriteLine("\t\t\tOpción inválida, vuelva a intentarlo. ");
                                    Console.WriteLine("\t\t\t1) Si. ");
                                    Console.WriteLine("\t\t\t2) No, deseo modificarlos. ");
                                    correcto = Console.ReadLine();
                                }

                            }
                            else
                            {
                                correcto = "1";
                            }

                           

                        }
                        if (camara == "Senador")
                        {
                            Senador senador1 = new Senador(partidoPolitico, departamento, numDespacho, nombre, apellido, edad, casado, id, camara, numAsientoCamara);
                            parlamento.registrarLegislador(senador1);
                            id++;
                        }
                        else
                        {
                            Diputado diputado1 = new Diputado(partidoPolitico, departamento, numDespacho, nombre, apellido, edad, casado, id, camara, numAsientoCamara);
                            parlamento.registrarLegislador(diputado1);
                            id++;
                        }
                        break;
                    case "2":
                        parlamento.listarCamaras();
                        Console.WriteLine("\t\t\tPara continuar, presione la tecla enter. ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        parlamento.cantidadRepresentantes();
                        Console.WriteLine("\t\t\tPara continuar, presione la tecla enter. ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("\t\t\tSeleccione el legislador al cual quiere modificar los datos. ");
                        parlamento.getLegisladores();
                        int opcionLegislador = leerEntero(Console.ReadLine());
                        parlamento.actualizarLegislador(opcionLegislador);
                        break;
                    case "5":
                        Console.WriteLine("\t\t\tSeleccione el legislador: ");
                        parlamento.getLegisladores();
                        int opcionAccion = leerEntero(Console.ReadLine());
                        parlamento.accionLegislador(opcionAccion);
                        Console.WriteLine(parlamento.getMensaje());
                        Console.ReadLine() ;
                        break;

                }
                Console.Clear() ;



            } while (opcionMenu != "6");
        }
        
        static string menuPrincipal()
        {
            string opcionMenu;
            Console.WriteLine("\n\n\t\t\t\t\t BIENVENIDO AL PARLAMENTO\n\n");
            Console.WriteLine("\t\t\tIndique la opción deseada: \n");
            Console.WriteLine("\t\t\t1) Registrar un Legislador. ");
            Console.WriteLine("\t\t\t2) Informacion de los legisladores. ");
            Console.WriteLine("\t\t\t3) Lista de legisladores. ");
            Console.WriteLine("\t\t\t4) Modificar datos de los legisladores. ");
            Console.WriteLine("\t\t\t5) Acciones legislativas. ");
            Console.WriteLine("\t\t\t6) Salir. \n\n\n\n\n\n\n\n\n\n\n");
            return opcionMenu = Console.ReadLine();

        }

        static int leerEntero(string x)
        {
            int valor;
            while (!int.TryParse(x, out valor))
            {
                Console.Clear();
                Console.WriteLine("\t\t\tEl valor no es válido. Intente otra vez. ");
                x = Console.ReadLine();

            }
            return valor;
        }
        
    }



}

