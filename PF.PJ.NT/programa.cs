using System;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso das classes
        PessoaFisica pessoaFisica = new PessoaFisica("João", "123.456.789-01");
        PessoaJuridica pessoaJuridica = new PessoaJuridica("Empresa XYZ", "12.345.678/0001-90");

        // Nota fiscal associada a Pessoa Fisica
        NotaFiscal notaFiscal1 = new NotaFiscal("001", 100.00m, pessoaFisica);

        // Nota fiscal associada a Pessoa Juridica
        NotaFiscal notaFiscal2 = new NotaFiscal("002", 200.00m, pessoaJuridica);
    }
}
