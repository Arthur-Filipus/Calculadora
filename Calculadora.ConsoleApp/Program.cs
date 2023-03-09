using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora muito zika\n");

            bool continuar = true;

            do
            {
                Console.Clear();

                Console.WriteLine(" Digite 1 para adição\n Digite 2 para Subtração\n Digite 3 para Multiplicação\n Digite 4 para Divisão\n Digite 5 para Gerar Tabuada\n Digite S para Sair");

                string operacao = Console.ReadLine();

                if (operacao == "s" || operacao == "S")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" && operacao != "s" && operacao != "s")
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                    
                    Console.ReadLine();

                    continue;
                }

                if (operacao == "5")
                {
                    Console.Write("Digite o número para gerar a tabuada: ");

                    int tabuada = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i <= 10; i++)
                    {
                        int resultadotabuada = tabuada * i;

                        Console.WriteLine($"{tabuada} x {i} = {resultadotabuada}");
                    }
                    
                    Console.ReadLine();

                    continue;
                }

                Console.Write("digite o primeiro número: ");

                decimal primeironumero = Convert.ToDecimal(Console.ReadLine());

                Console.Write("digite o segundo número: ");

                decimal segundonumero = Convert.ToDecimal(Console.ReadLine());
                
                decimal resultado = 0;
                bool adicao = operacao == "1";
                bool subtracao = operacao == "2";
                bool multiplicacao = operacao == "3";
                bool divisao = operacao == "4";

                switch (operacao)
                {
                    case "1":
                        resultado = primeironumero + segundonumero;
                        break;

                    case "2":
                        resultado = primeironumero - segundonumero;
                        break;

                    case "3":
                        resultado = primeironumero * segundonumero;
                        break;

                    case "4":
                        while (segundonumero == 0)
                                {
                                    Console.WriteLine("Segundo número não pode ser ZERO");

                                    Console.ReadLine();

                                    Console.Write("Digite novamente o Segundo número: ");

                                    segundonumero = Convert.ToDecimal(Console.ReadLine());
                                }
                            resultado = primeironumero / segundonumero;
                        break;
                }

                #region mesma coisa com if-else
                //if (adicao)
                //{
                //    resultado = primeironumero + segundonumero;

                //}
                //else if (subtracao)
                //{
                //    resultado = primeironumero - segundonumero;

                //}
                //else if (multiplicacao)
                //{
                //    resultado = primeironumero * segundonumero;

                //}
                //else if (divisao)
                //{
                //    while (segundonumero == 0)
                //    {
                //        Console.WriteLine("Segundo número não pode ser ZERO");

                //        Console.ReadLine();

                //        Console.Write("Digite novamente o Segundo número: ");

                //        segundonumero = Convert.ToDecimal(Console.ReadLine());
                //    }
                //    resultado = primeironumero / segundonumero;

                //}
                #endregion

                decimal resultadoformatado = Math.Round(resultado, 2);

                Console.WriteLine($"seu resultado é: {resultadoformatado}");

                Console.ReadLine();

            } while (continuar);
        }
    }
}