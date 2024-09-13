using System;

class Aluno

{   //atributos
    public string nome;
    public double nota1, nota2;
    //Métodos
        //Média
    public double media()
    {
        return (nota1+nota2)/2;
    }
        //situação
    public string situacao(double media)
    {
        return media >= 7 ? "aprovado":"reprovado";
    }
        //Mensagem
    public void mensagem()
    {
        //Obter media
        double obtermedia = media();
        //obter situação
        string obterSituacao = situacao(obtermedia);
        Console.WriteLine(nome+" Está "+obterSituacao+ " com média "+obtermedia);
    }
}   