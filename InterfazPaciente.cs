using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPaciente
{
    internal interface InterfazPaciente
    {
        void AddPaciente(List<Paciente> listPacientes, String ruta);
        void DarAltaPaciente(List<Paciente> listPacientes, String ruta);
        void ListarPacientes(List<Paciente> listPacientes, String ruta);
    }
}
