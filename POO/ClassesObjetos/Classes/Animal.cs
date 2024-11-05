using System;
using System.Collections.Generic;   
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;


namespace ClassesObjetos.Classes
{
    public class Animal
    {
        public string raca;

        public string cor;

        public string nome;

        public int idade = 0;


    public void FazerBarulho(string Barulho = "Barulho genérico")
   {Console.WriteLine($"Som do animal: {Barulho}");
   }
        

    public void Envelhecer()
   {idade = idade + 1;}
    }

}