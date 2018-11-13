using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesNegocio
{
    class Cita
    {
        public int Idcita { get; set; }
        public string tipocita { get; set; }
        public string estadocita { get; set; }

        public Cita( int Idcita,string tipocita, string estadocita)
        {
            this.Idcita = Idcita;
            this.tipocita = tipocita;
            this.estadocita = estadocita;

        }
    }
}
