using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPaciente
{
    internal interface InterfazFichero
    {
        void EscribirEnArchivoPaciente(List<Paciente> listaPaciente, string rutaArchivo, bool append);
        void CerrarFichero(StreamWriter fichero);
        List<Paciente> LeerArchivoPaciente(string rutaArchivo);
    }
}
