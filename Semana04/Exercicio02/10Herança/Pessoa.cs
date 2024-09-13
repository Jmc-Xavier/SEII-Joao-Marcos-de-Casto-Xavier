using System;
class Pessoa
{
    //Atributos
    protected string nome ="";

    protected int idade = 0;
    
    // Método
    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome "+nome);
        Console.WriteLine("Idade "+idade);
    }
}
