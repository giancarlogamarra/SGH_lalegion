using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesNegocio
{
     public class paciente:persona
    {
        public string tipo { get; set; }

        public paciente(string tipo, string dni, string nombre, string apellido, string sexo, string estadocivil)
            :base(dni,nombre,apellido,sexo,estadocivil)
        {
            this.tipo = tipo;
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.sexo = sexo;
            this.estadocivil = estadocivil;


        }
    }
}
