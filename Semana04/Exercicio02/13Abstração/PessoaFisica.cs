using System;

class PessoaFisica : Padrao
{
    public override void taxaEmprestimo (double valor) 
    {
        Console.WriteLine("TAXA PF "+(valor*0.1));
    }
}