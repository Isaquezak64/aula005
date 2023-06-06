using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula005Consicoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade0;


            Console.WriteLine("Bem-vindo ao Conradito Auto");
            Console.WriteLine("Para começar, digite a sua idade ");
            idade = Int32.Parse( Console.ReadLine() );

            if(idade>= 18)
            {
                Console.WriteLine("Parabéns! você ja pode tirar a CNH"); 
            }
            else
            {
                Console.WriteLine("Você não tem idade sufiaciente ainda...");
            }    
                   



            Console.WriteLine($"Você tem {idade} anos! ");
            Console.ReadKey();

        }

        void Revisao() {

            string prof;
            string nome;
            int idade;



            Console.WriteLine("Bem - vindo ao cadastro de currículos");
            Console.WriteLine("Para começar, digite o seu primeiro nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o ano que você nasceu: ");
            idade = Int32.Parse(Console.ReadLine());



            Console.ReadLine();
            Console.WriteLine("Digite sua professão");
            prof = Console.ReadLine();
            Console.WriteLine("\n \n");

            Console.WriteLine("Cadastro realizado com sucesso ! ");
            Console.WriteLine($"Você chama {nome} e tem {2023 - idade}");
            Console.WriteLine($"Vagas para prof {prof}");
            Console.ReadKey();


        }






    }
}
