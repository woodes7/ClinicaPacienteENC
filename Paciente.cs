using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPaciente
{
  
    internal class Paciente
    {
        private string numeroTlf;
        private string nombre;
        private string fechaIngreso;
        private string fecchaAlta;
        private bool alta;

        public Paciente()
        {
        }

        public Paciente(string numeroTlf, string nombre, string fechaIngreso, string fecchaAlta, bool alta)
        {
            this.numeroTlf = numeroTlf;
            this.nombre = nombre;
            this.fechaIngreso = fechaIngreso;
            this.fecchaAlta = fecchaAlta;
            this.alta = alta;
        }
        
        public string NumeroTlf { get => numeroTlf; set => numeroTlf = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string FecchaAlta { get => fecchaAlta; set => fecchaAlta = value; }
        public bool Alta { get => alta; set => alta = value; }

        public override string ToString() {
            return $"Número de Teléfono: {NumeroTlf}, Nombre: {Nombre}, Fecha de Ingreso: {FechaIngreso}, Fecha de Alta: {FecchaAlta}, Alta: {Alta}";
        }
    }
}
