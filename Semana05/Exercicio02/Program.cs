using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
namespace ProgAssincrona
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //ExecutarComThreads();
            ExecutarComTasks();
            sw.Stop();
            Console.WriteLine($"Operação gastou {sw.ElapsedMilliseconds} milissegundos.");
        }
        
        
        static void RealizarOperacao(int op, string nome, string sobrenome)
        {
            Console.WriteLine($"Inicializando Operação{op}...");
            for (int i=0; i<1000000000;i++)
            {
                var p = new Pessoa(nome,sobrenome,35);
            }
            Console.WriteLine($"Finalizando operação {op}...");
        }
        private static void ExecutarSequencial()
        {
            RealizarOperacao(1,"fulano","da Silva");
            RealizarOperacao(2,"fulano2","da Silva2");
            RealizarOperacao(3,"fulano3","da Silva3");
        }
      /*  static void ExecutarComThreads()
        {
            
                var t1 = new Thread(() =>
                {
                    RealizarOperacao(1,"Fulano","da Silva");

                });
                var t2 = new Thread (()=>
                {
                RealizarOperacao(2,"fulano2","da Silva2");
                });
                var t3 = new Thread (()=>
                {
                RealizarOperacao(3,"fulano2","da Silva3");
                });
                t1.Start();
                t2.Start();
                t3.Start();

                t1.Join();
                t2.Join();
                t3.Join();

            
        }*/
        static void ExecutarComTasks()
        {
            
                var t1 = Task<int>.Run(() =>
                {
                RealizarOperacao(1,"Fulano","da Silva");
                return 1;

                });
                var t2 = Task<int>.Run(()=>
                {
                RealizarOperacao(2,"fulano2","da Silva2");
                return 2;
                });
                var t3 = Task<int>.Run (()=>
                {
                RealizarOperacao(3,"fulano2","da Silva3");
                return 3;
                });
                Console.WriteLine($"Tarefa {t1.Result} Finalizou.");
                Console.WriteLine($"Tarefa {t2.Result} Finalizou.");
                Console.WriteLine($"Tarefa {t3.Result} Finalizou.");

    
        }
}}