using System;
class Pessoa
{
    //Atributo
    private string nome="NomeRandom";
    public Pessoa(string nome)
    {
        //Executa o Atributo
        Console.WriteLine(nome);
        //Usa o parâmetro passado
        Console.WriteLine(this.nome);
    }
}