using System;

namespace _03ExercícioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
           //Instanciar objeto da classe aluno
           Aluno a = new Aluno();
           a.nome = "Dênis";
           a.nota1 = 8;
           a.nota2=10;
           a.mensagem();
        }
    }
}
