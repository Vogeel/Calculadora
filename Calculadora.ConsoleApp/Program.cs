using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            do
            {
                Console.WriteLine("Calculadora Top do Vitão");

                

                Console.WriteLine("Digite o primeiro numero");

                string strPrimeiroNumero = Console.ReadLine();
                volta2:
                Console.WriteLine("Aperte 1 para soma\naperte 2 para subtração\naperte 3 para multiplicação\naperte 4 para divisão\naperte s para sair");

                opcao = Console.ReadLine();
                if(!(opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "s"))
                {
                   
                    Console.WriteLine("Opção inválida");
                    goto volta2;
                }
                else if (opcao == "s")
                {
                    break;
                }




            volta: 
                Console.Write("Digite o segundo Número: ");

                string strSegundoNumero = Console.ReadLine();

                float primeiroNumero = float.Parse (strPrimeiroNumero);

                float segundoNumero = float.Parse (strSegundoNumero);

                float resultadoOperacao = primeiroNumero + segundoNumero;

                float resultadoSubtracao = primeiroNumero - segundoNumero;

                float resultadoMultiplicacao = primeiroNumero * segundoNumero;



                Console.Clear();
                if (opcao == "1")
                {
                    
                    Console.WriteLine($"{primeiroNumero} + {segundoNumero} = {resultadoOperacao}");
                }
                if (opcao == "2")
                {
                    
                    Console.WriteLine($"{primeiroNumero} - {segundoNumero} = {resultadoSubtracao}");
                }
                if (opcao == "3")
                {
                    
                    Console.WriteLine($"{primeiroNumero} * {segundoNumero} = {resultadoMultiplicacao}");
                }
                if (opcao == "4")
                {
                    if (segundoNumero == 0) 
                    {
                        
                        Console.WriteLine("Segundo número não pode ser 0");
                        goto volta;
                    }
                    float resultadoDivisao = primeiroNumero / segundoNumero;
                    Console.WriteLine($"{primeiroNumero} / {segundoNumero} = {resultadoDivisao}");

                }
                Console.WriteLine("Escolha a opção");

                


                
            } while (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4");


        }
    }
}
