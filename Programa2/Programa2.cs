using System;

namespace PrimeirosProgramasCSharp
{
    class Program1{

        static void Main(string[] args){
           
            int idade = 0, quantidade=0;
            int i = 1;
            Console.WriteLine("Programa que calcula a idade media de cinco alunos");
            while(i<10){
               
               Console.Write("Informe a idade da "+i+"°"+" pessoa : ");
               idade = Convert.ToInt32(Console.ReadLine());
               if (idade>18){

                   quantidade = quantidade + 1; 
               }
               ++i;
            }
             Console.WriteLine("A quantidade de pessoas de maior idade é " + quantidade);         


        }
    }
}
