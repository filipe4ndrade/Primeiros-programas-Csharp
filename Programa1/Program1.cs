using System;

namespace PrimeirosProgramasCSharp
{
    class Program1{

        static void Main(string[] args){
           
            Double idade = 0, soma=0, media =0;
            int i = 1;
            Console.WriteLine("Programa que calcula a idade media de cinco alunos");
            while(i<6){
               
               Console.Write("Informe a idade do "+i+"°"+" aluno : ");
               idade = Convert.ToDouble(Console.ReadLine());
               soma = soma + idade;
               ++i;
            }
             media = soma / 5;
             Console.WriteLine("A idade média dos alunos é " + media);         


        }
    }
}
