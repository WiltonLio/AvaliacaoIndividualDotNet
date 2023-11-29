namespace POGDev
// Class Paciente:
//Nome
//Data de Nascimento
//CPF (tratar entrada com 11 dígitos)
//Sexo (masculino e feminino)
//Sintomas

public class Paciente
{
    public string Nome { get; set;}
    public string DataNascimento { get; set;}
    public string Cpf { get; set;}
    public string Sexo { get; set;}
    public string Sintomas { get; set;}

    public Paciente(){
        Nome = "";
        DataNascimento = "";
        Cpf = "";
        Sexo = "";
        Sintomas = "";
    } 
}