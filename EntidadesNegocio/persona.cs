using System;

namespace EntidadesNegocio
{
    public class persona
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string fecha { get; set; }
        public string sexo { get; set; }

        public string EstadoCivil { get; set; }
        public persona(string dni, string nombre, string apellido, string fecha , string sexo) {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.fecha = fecha;
            this.sexo = sexo;

        }
    }
}
