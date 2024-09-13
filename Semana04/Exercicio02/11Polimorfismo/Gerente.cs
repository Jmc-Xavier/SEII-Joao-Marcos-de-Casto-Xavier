using System;

class Gerente:Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto VA Gerente "+(salario*0.15));
    }
}