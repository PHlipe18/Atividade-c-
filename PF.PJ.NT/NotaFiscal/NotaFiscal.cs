using System;

public class NotaFiscal
{
    public string Numero { get; set; }
    public decimal Valor { get; set; }
    public PessoaFisica ClientePessoaFisica { get; private set; }
    public PessoaJuridica ClientePessoaJuridica { get; private set; }

    public NotaFiscal(string numero, decimal valor, PessoaFisica cliente)
    {
        Numero = numero;
        Valor = valor;
        ClientePessoaFisica = cliente;
        ClientePessoaJuridica = null; // Nenhuma PessoaJuridica associada
    }

    public NotaFiscal(string numero, decimal valor, PessoaJuridica cliente)
    {
        Numero = numero;
        Valor = valor;
        ClientePessoaFisica = null; // Nenhuma PessoaFisica associada
        ClientePessoaJuridica = cliente;
    }
}
