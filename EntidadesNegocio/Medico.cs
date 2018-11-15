using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesNegocio
{
     public class Medico:persona
    {
        public string CMP { get; set; }
      


        public Medico(string cmp, string dni, string nombre, string apellido, string sexo, string estadocivil) 
                        :base( dni,  nombre,  apellido,  sexo,  estadocivil)
        {
            this.CMP = cmp;
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.sexo = sexo;
            this.estadocivil=estadocivil;




        }
    }
}
