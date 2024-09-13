using System;
class Pessoa
{
    //Método 1
    public void apresentar()
    {
            Console.WriteLine("Olá");
    }
    public void apresentar(string nome)
    {
            Console.WriteLine("olá"+nome);
    }
    public void apresentar(string nome, int idade)
    {
            Console.WriteLine("olá "+nome+ " Você tem "+idade+" anos.");
    }
}