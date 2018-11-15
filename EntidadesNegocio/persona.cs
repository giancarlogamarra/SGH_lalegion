using System;

namespace EntidadesNegocio
{
    public class persona
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string sexo { get; set; }
        public string estadocivil { get; set; }
        public persona(string dni, string nombre, string apellido, string sexo, string estadocivil) {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.sexo = sexo;
            this.estadocivil = estadocivil;

        }
    }
}
