using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClinicaPaciente
{
    internal class ImplPaciente : InterfazPaciente
    {
        InterfazFichero implFichero = new ImplFiecher();
        void InterfazPaciente.AddPaciente(List<Paciente> listPacientes, string ruta)
        {
            bool tlfOK=true, nomOK=false;
            String telefono= "", nombre="";

           
            while (nomOK != true)                
            {
                Console.WriteLine("\t\tDime nombre del Paciente");
                nombre = Console.ReadLine();
                nomOK = CompruebaNombre(listPacientes, nombre);

            }
            
            while (tlfOK != false)
            {
                Console.WriteLine("\t\tDime numero de Telefono del paciente");
                telefono = Console.ReadLine();
                tlfOK = CompruebaTelefonoAlta(listPacientes, telefono);                
                if (tlfOK == true)
                    Console.WriteLine("\t\tYa hay un paciente ingresado con ese numero de telefono");                
            }
            DateTime fecha=DateTime.Now;       
            
            string fechaIngreso = fecha.ToString();
                Console.WriteLine("\t\tFecha de ingreso del paciente: " + fechaIngreso);
            string fechaAlta = "-----";
            Paciente paciente = new Paciente(telefono, nombre, fechaIngreso, fechaAlta, false);
            Console.WriteLine("\t\tQuieres ingresar al pacietne (si= s o S)");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "s") {
                listPacientes.Add(paciente);
                implFichero.EscribirEnArchivoPaciente(listPacientes, ruta, true);
            }
        }     
        //Comprueba que el nombre del paciente sea letras y no numeros
        private bool CompruebaNombre(List<Paciente> listPacientes, string nombre)
        {
                // Expresión regular para verificar si el nombre contiene solo letras y no números
                Regex regex = new Regex("^[a-zA-Z]+$");

                if (!regex.IsMatch(nombre))
                {
                    return false;
                }
                return true;
        }
        //comprueba que el paciente no este ya ingresado por el telefono
        private bool CompruebaTelefonoAlta(List<Paciente> listaPacientes, string telefono) {
            Paciente pacienteEncontrado = listaPacientes.Find(paciente => paciente.NumeroTlf == telefono);
            return pacienteEncontrado?.Alta ?? false;
        }
        void InterfazPaciente.DarAltaPaciente(List<Paciente> listPacientes, string ruta)
        {
            Paciente pacienteEncontrado = new Paciente();
            bool altOK = true;
            
                Console.WriteLine("\t\tDime el número de teléfono:");
                string telefono = Console.ReadLine();            
                pacienteEncontrado = listPacientes.Find(paciente => paciente.NumeroTlf == telefono);            

            if (pacienteEncontrado != null)
            {
                Console.WriteLine("\t\tDatos del paciente encontrado:");
                Console.WriteLine("\t\tNombre: " + pacienteEncontrado.Nombre);
                Console.WriteLine("\t\tNúmero de teléfono: " + pacienteEncontrado.NumeroTlf);
               
                Console.WriteLine("\t\tFecha de ingreso: " + pacienteEncontrado.FechaIngreso);
                //Damos valor a la fecha Al
                    DateTime fecha = DateTime.Now;
                    string fechaAlta = fecha.ToString();
                    Console.WriteLine("\t\tEsta es la fecha del alta: " + fechaAlta);

                Console.WriteLine("\t\tQuieres dar alta al pacietne (si= s o S)");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() == "s")
                {   // Establecer el paciente como dado de alta con su fecha
                    pacienteEncontrado.Alta = true;
                    pacienteEncontrado.FecchaAlta= fechaAlta;                     
                }
                implFichero.EscribirEnArchivoPaciente(listPacientes, ruta, true);
            }
            else
            {
                Console.WriteLine("\t\tNo se encontró ningún paciente con el número de teléfono ingresado.");
                // Realizar acciones adicionales o mostrar mensajes relevantes si no se encuentra el paciente
            }            
        }
        
        void InterfazPaciente.ListarPacientes(List<Paciente> listPacientes, string ruta) {
            foreach (Paciente paciente in listPacientes) {

                Console.WriteLine(paciente);
            }
            Console.WriteLine();
        }
    }
}
