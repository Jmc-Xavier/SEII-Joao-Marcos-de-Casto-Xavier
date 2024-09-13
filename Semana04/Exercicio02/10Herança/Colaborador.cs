using System;
class Colaborador : Pessoa
{
    private double salario;
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome =nome;
        this.idade = idade;
        this.salario = salario;
        mensagemColaborador();
        mensagemPessoa();
    }
    private void mensagemColaborador()
    {
        Console.WriteLine("Salário "+salario);
    }
}