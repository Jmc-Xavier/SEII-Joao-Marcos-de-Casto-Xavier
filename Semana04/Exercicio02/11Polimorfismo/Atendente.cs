using System;

class Atendente:Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto VA Atendente "+(salario*0.12));
    }
}