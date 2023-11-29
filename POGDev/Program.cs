namespace POGDev
public class Program
{
    public static void Main(string[] args)
    {
        List<Medico> medicos = new List<Medico>();
        List<Paciente> pacientes = new List<Paciente>();

        medicos.Add(new Medico {
            Nome = "Jose",
            DataNascimento = "01/01/1980",
            Cpf = "01234567890",
            Crm = "12345678"
        });

        medicos.Add(new Medico {
            Nome = "Maria",
            DataNascimento = "01/01/2000",
            Cpf = "12345678910",
            Crm = "01234567"
        });

        pacientes.Add(new Paciente {
            Nome = "Jose",
            DataNascimento = "01/01/2000",
            Cpf = "12345678910",
            Sexo = "Masculino",
            Sintomas = "Tosse"
        });

        pacientes.Add(new Paciente {
            Nome = "Karla",
            DataNascimento = "01/01/2008",
            Cpf = "23456789100",
            Sexo = "Feminino",
            Sintomas = "Febre"
        });

    }
}