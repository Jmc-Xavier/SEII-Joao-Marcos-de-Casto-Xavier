using System;

class PessoaJuridica : Padrao
{
    public override void taxaEmprestimo (double valor) 
    {
        Console.WriteLine("Taxa P/ PJ "+ (valor*0.2));
    }
}