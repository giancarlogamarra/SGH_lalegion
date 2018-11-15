using AccesoDatos;//DataAccess
using EntidadesNegocio;//Entities
using System.Collections.Generic;
using System.IO;

namespace LogicaNegocios
{
    public class PacienteBL
    {
        public static List<paciente> Listpacientes;

        public List<paciente> GetPacientes()
        {
            string path = PacientesDAL.ConexionPacientes();
            string[] lines = System.IO.File.ReadAllLines($"{path}\\BD\\Pacientes.txt");
            Listpacientes = new List<paciente>();
            foreach (var item in lines)
            {
                string tipo= item.Split(',')[0];
                string Dni = item.Split(',')[1];
                string Nombre = item.Split(',')[2];
                string Apellido = item.Split(',')[3];
                string sexo = item.Split(',')[4];
                string estadocivil = item.Split(',')[5];
                paciente p = new paciente(tipo,Dni, Nombre, Apellido,sexo, estadocivil);
                Listpacientes.Add(p);
            }
            return Listpacientes;
        }


        public void UpdatePaciente(string dni, paciente paciente) {
            foreach (paciente item in Listpacientes)
            {
                if (item.Dni == dni)
                {
                    item.Nombre = paciente.Nombre;
                    item.Apellido = paciente.Apellido;
                }
            }
            UpdateDataBase();
        }
        public void InsertPaciente(paciente paciente) {
            Listpacientes.Add(paciente);
            UpdateDataBase();
        }

        public int DeletePaciente(string Dni)
        {
           int elementsRemoved= Listpacientes.RemoveAll(x => x.Dni == Dni);
           UpdateDataBase();
           return elementsRemoved;
        }
        private int UpdateDataBase() {
            string path = PacientesDAL.ConexionPacientes();
            int updatedLines = 0;
            using (StreamWriter outputFile = new StreamWriter($"{path}\\BD\\Pacientes.txt"))
            {
                foreach (var item in Listpacientes)
                {
                    string line = $"{item.Dni},{item.Nombre},{item.Apellido}"; 
                    outputFile.WriteLine(line);
                    updatedLines++;
                }
            }
            return updatedLines;
        }
    }
}
