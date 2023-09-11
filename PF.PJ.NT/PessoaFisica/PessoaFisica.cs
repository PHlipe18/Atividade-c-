using System;

public class PessoaFisica
{
    public string Nome { get; set; }
    public string CPF { get; set; }

    public PessoaFisica(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }
}
