using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesNegocio
{
    class Cita

    {
        public string tipocita { get; set; }
        public string paciente { get; set; }
        public string idcita { get; set; }
        public string estadocita { get; set; }

        public Cita(string tipocita,string idcita, string estadocita, string paciente)
        {
            this.tipocita = tipocita;
            this.idcita = idcita;
            this.estadocita = estadocita;
            this.paciente = paciente;
        }
    }
}
