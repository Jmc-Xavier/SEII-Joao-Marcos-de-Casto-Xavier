using System;
using System.IO;

namespace  CSCourse {
    class Program {
        public static void Main(String[] args) {
            //Para escrever
            //string nomeDoArquivo = "arquivo.txt";
            // string texto = "Este é um documento de texto";  
            //File.WriteAllText(nomeDoArquivo,texto); //CUIDADO POIS PODE SOBRESCREVER O TEXTO!!
            //Console.WriteLine("Arquivo criado com sucesso!");
            
            //Para ler
            //string arquivo ="arquivo.txt";
            //string texto =File.ReadAllText(arquivo);
            //Console.WriteLine("Conteúdo do arquivo "+texto);
            
            
            //Vários Documentos
            //string[] documentos = {"Documento1.", "Documento 2."};
            //string nomeDoArquivo = "documento.txt";
            //File.WriteAllLines(nomeDoArquivo, documentos);


            //Ler multiplas linhas
            /*string nomeDoArquivo = "documentos.txt";
            string[] documentos = File.ReadAllLines(nomeDoArquivo);
            foreach (string documento in documentos)
            {
               Console.WriteLine(documento); } */

            //Anexar texto a arquivo
            /* string nomeDoArquivo = "documentos.txt";
            string conteudo = File.ReadAllText(nomeDoArquivo);
            Console.WriteLine("conteudo do arquivo: ");
            Console.WriteLine(conteudo);
            Console.WriteLine("\n");
            File.AppendAllText(nomeDoArquivo,"Um outro arquivo.");
            conteudo =  File.ReadAllText(nomeDoArquivo);
            Console.WriteLine(conteudo);
            Console.WriteLine("\n");

           
         Console.ReadKey(true); 



            }    } }