using System;

class Imposto
{
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto no VA" +(salario*0.1));
    }
    public void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto DO VT "+(salario*0.06));
    }
}