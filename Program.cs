using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPaciente
{
    internal class Program
    {
        const string CARPETAORIGEN = "PacienteDB.txt";

        static void Main(string[] args)
        {   InterfazPaciente implPaciente= new ImplPaciente();
            InterfazFichero implFichero = new ImplFiecher();
            InterfazMenu menu = new ImplMenu();
            List<Paciente> listaPacientes = new List<Paciente>();
            String ruta = CARPETAORIGEN;
            listaPacientes = implFichero.LeerArchivoPaciente(ruta);

            bool esOk =false;
            int opcion=-1;
             
            do
            {
                menu.MostrarMenu();

                switch (opcion)
                {
                    case 0: 
                        esOk = true;
                        break;
                    case 1: Console.WriteLine("\n\t\t\tHa elegido ingresar un nuevo paciente:");
                        implPaciente.AddPaciente(listaPacientes, ruta);
                        break;
                    case 2: Console.WriteLine("\n\t\t\tHa elegido Digame que paciente quiere dar de Alta:");
                        implPaciente.DarAltaPaciente(listaPacientes, ruta);
                        break;
                    case 3: Console.WriteLine("\n\t\t\tHa elegido Lista de todos los pacientes:");
                        implPaciente.ListarPacientes(listaPacientes, ruta);
                        break;
                    default: Console.WriteLine("\n\t\t\tElija una de las 4 opciones");
                        break;
                        
                }
                opcion = Console.ReadKey(true).KeyChar - '0';
                

            } while (!esOk);

            menu.SalDespacio();
        }

       
    }
}

