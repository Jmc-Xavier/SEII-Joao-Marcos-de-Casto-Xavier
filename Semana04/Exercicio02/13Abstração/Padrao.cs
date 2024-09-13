using System;
abstract class Padrao
{
    public abstract void taxaEmprestimo(double valor);
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos Obtidos Pela Poupança "+(valor*taxa));
    }
} 