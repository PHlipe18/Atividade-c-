using System;

public class PessoaJuridica
{
    public string RazaoSocial { get; set; }
    public string CNPJ { get; set; }

    public PessoaJuridica(string razaoSocial, string cnpj)
    {
        RazaoSocial = razaoSocial;
        CNPJ = cnpj;
    }
}
