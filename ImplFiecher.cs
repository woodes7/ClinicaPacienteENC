using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPaciente {
    internal class ImplFiecher : InterfazFichero {
         void InterfazFichero.CerrarFichero(StreamWriter fichero) 
         {
            try {
                // Nuevamente aprovechamos el using statement para
                // asegurarnos de que el fichero se cierre.
                if (fichero != null)
                    fichero.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e.StackTrace);
            }
         }
        void InterfazFichero.EscribirEnArchivoPaciente(List<Paciente> listaPaciente, string rutaArchivo, bool append) {
            try {
                using (StreamWriter fileWriter = new StreamWriter(rutaArchivo, append)) {
                    foreach (Paciente paciente in listaPaciente) {
                        string contenido = "\n" + paciente.NumeroTlf + ";" + paciente.Nombre + ";" +
                            paciente.FechaIngreso + ";" + paciente.FecchaAlta + ";" + paciente.Alta;
                        fileWriter.WriteLine(contenido);
                    }
                    Console.WriteLine("Paciente escrito en el archivo correctamente.");
                }
            }
            catch (IOException e) {
                Console.WriteLine("Error al escribir el paciente en el archivo: " + e.Message);
            }
        }

        
             List<Paciente> InterfazFichero.LeerArchivoPaciente(string rutaArchivo) 
             {
                List<Paciente> listaPaciente = new List<Paciente>();

                try 
                {
                    using (StreamReader reader = new StreamReader(rutaArchivo)) {
                        string linea;
                        while ((linea = reader.ReadLine()) != null) {
                            string[] datos = linea.Split(';');
                            if (datos.Length == 5) {
                                string telefono = datos[0];
                                string nombre = datos[1];
                                string fechaIngreso = datos[2];
                                string fechaAlta = datos[3];
                                bool alta = bool.Parse(datos[4]);
                                Paciente paciente = new Paciente(telefono, nombre, fechaIngreso, fechaAlta, alta);
                                listaPaciente.Add(paciente);
                            }
                            Console.WriteLine(linea);
                        }
                    }

                    Console.WriteLine("Datos de pacientes cargados desde el archivo.");
                }
                catch (FileNotFoundException) {
                    Console.WriteLine("El archivo de pacientes no existe.");
                }
                catch (IOException e) {
                    Console.WriteLine("Error al leer el archivo: " + e.Message);
                }
                catch (Exception e) {
                    Console.WriteLine("Error al leer los datos de pacientes del archivo: " + e.Message);
                }

                return listaPaciente;
             }
    }
}


