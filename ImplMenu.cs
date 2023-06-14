using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPaciente
{
    internal class ImplMenu: InterfazMenu
    {   
        //Muestra el menu
        public void MostrarMenu()
        {   
           
                Console.Clear();
                Console.WriteLine("\n\n\t\t\tVersión 1.1: Sin clase Recinto. \n\t\t\t\t     Catálogo Estático");
                Console.WriteLine("\t\t\t╔══════════════════════════════╗");
                Console.WriteLine("\t\t\t║             MENU             ║");
                Console.WriteLine("\t\t\t╠══════════════════════════════╣");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║    1.- Ingresar Paciente     ║");
                Console.WriteLine("\t\t\t║    2.- Dar alta al paciente  ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║    3.- Listar Paciente       ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║          0) Salir            ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t╚══════════════════════════════╝");
                Console.Write("\t\t\t¿Opción?"); 
        }
        public void SalDespacio()
        {
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }



    }
}
