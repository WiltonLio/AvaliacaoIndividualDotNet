using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace POGDev
{
    public class Program
    {
        public static void Main(string[] args, IEnumerable<Medico> medicos)
        {
            List<Medico> _medicos = new List<Medico>();
            List<Paciente> pacientes = new List<Paciente>();

            _medicos.Add(new Medico { Nome = "Médico 1", DataNascimento = new DateTime(1980, 1, 1).ToString("dd/MM/yyyy"), CPF = "12345678901", CRM = "12345" });
            _medicos.Add(new Medico { Nome = "Médico 2", DataNascimento = new DateTime(1990, 2, 2).ToString("dd/MM/yyyy"), CPF = "23456789012", CRM = "54321" });

            pacientes.Add(new Paciente { Nome = "Paciente 1", DataNascimento = new DateTime(1995, 3, 3).ToString("dd/MM/yyyy"), CPF = "34567890123", Sexo = "masculino", Sintomas = "Febre" });
            pacientes.Add(new Paciente { Nome = "Paciente 2", DataNascimento = new DateTime(1985, 4, 4).ToString("dd/MM/yyyy"), CPF = "45678901234", Sexo = "feminino", Sintomas = "Dor de cabeça" });

            int idadeMinima = 18;
            int idadeMaxima = 60;
            var médicosComIdadeEntreValores = _medicos.Where(m => (DateTime.Now.Year - m.DataNascimento.) >= idadeMinima && (DateTime.Now.Year - m.DataNascimento.Year) <= idadeMaxima);
            Console.WriteLine("Médicos com idade entre " + idadeMinima + " e " + idadeMaxima + ":");
            foreach (var médico in médicosComIdadeEntreValores)
            {
                Console.WriteLine(médico.Nome);
            }

            idadeMinima = 25;
            idadeMaxima = 40;
            var pacientesComIdadeEntreValores = pacientes.Where(p => (DateTime.Now.Year - p.DataNascimento.Year) >= idadeMinima && (DateTime.Now.Year - p.DataNascimento.Year) <= idadeMaxima);
            Console.WriteLine("Pacientes com idade entre " + idadeMinima + " e " + idadeMaxima + ":");
            foreach (var paciente in pacientesComIdadeEntreValores)
            {
                Console.WriteLine(paciente.Nome);
            }

            string sexoInformado = "feminino";
            var pacientesDoSexoInformado = pacientes.Where(p => p.Sexo.ToLower() == sexoInformado.ToLower());
            Console.WriteLine("Pacientes do sexo " + sexoInformado + ":");
            foreach (var paciente in pacientesDoSexoInformado)
            {
                Console.WriteLine(paciente.Nome);
            }

            var pacientesEmOrdemAlfabetica = pacientes.OrderBy(p => p.Nome);
            Console.WriteLine("Pacientes em ordem alfabética:");
            foreach (var paciente in pacientesEmOrdemAlfabetica)
            {
                Console.WriteLine(paciente.Nome);
            }

            string textoInformado = "dor";
            var pacientesComSintomasContendoTexto = pacientes.Where(p => p.Sintomas.ToLower().Contains(textoInformado.ToLower()));
            Console.WriteLine("Pacientes com sintomas contendo \"" + textoInformado + "\":");
            foreach (var paciente in pacientesComSintomasContendoTexto)
            {
                Console.WriteLine(paciente.Nome);
            }

            int mesInformado = 5;
            var médicosEPacientesAniversariantes = _medicos.Where(m => m.DataNascimento.Month == mesInformado)
                                                          .Concat(pacientes.Where(p => p.DataNascimento.Month == mesInformado));
            Console.WriteLine("Médicos e Pacientes aniversariantes do mês " + mesInformado + ":");
            foreach (var pessoa in médicosEPacientesAniversariantes)
            {
                Console.WriteLine(pessoa.Nome);
            }
        }
    }

}