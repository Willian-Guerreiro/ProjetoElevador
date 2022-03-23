using ProjetoElevador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.View
{
    internal class ElevadorView
    {
        public void InterfaceComUsuario(Elevador elevador)
        {
            //Variáveis de controle:
            //Continuar -> Controla a execução do loop
            //resultado_operacao -> Armazena o sucesso ou falha do procedimento escolhido

            bool continuar = true;
            bool resultado_operacao = false;

            do
            {
                Console.WriteLine(@" Escolha uma opção:
                                     1 - Entrar
                                     2 - Sair
                                     3 - Subir
                                     4 - Descer
                                     5 - Finalizar aplicação");
                if (elevador.NumeroDePessoas == 0)
                {
                    Console.WriteLine("Elevador vazio");
                }
                else
                {
                    Console.WriteLine($"{elevador.NumeroDePessoas} pessoa(s) no elevador ");
                }

                //Estrutura condicional para escrita amigável do andar 0 = térreo

                string andar = (elevador.AndarAtual == 0) ? "Térreo" : (elevador.AndarAtual.ToString());
                Console.WriteLine($"Andar atual: {andar}");

                string op = Console.ReadLine();
                Console.Clear();

                //Nas operações que se seguem, o retorno True indica que o comando escolhido pôde ser executado sem problemas

                switch (op)
                {
                    case "1":
                        resultado_operacao = elevador.Entrar();
                        if(resultado_operacao)
                            Console.WriteLine("1 pessoa entrou no elevador");
                        else
                            Console.WriteLine("Elevador lotado");
                        break;
                    case "2":
                        resultado_operacao = elevador.Sair();
                        if (resultado_operacao)
                            Console.WriteLine("1 pessoa saiu do elevador");
                        else
                            Console.WriteLine("Elevador vazio");
                        break;
                    case "3":
                        resultado_operacao = elevador.Subir();
                        if (resultado_operacao)
                            Console.WriteLine(" O elevador subiu 1 andar");
                        else
                            Console.WriteLine("O elevador já está no último andar");
                        break;
                    case "4":
                        resultado_operacao = elevador.Descer();
                        if (resultado_operacao)
                            Console.WriteLine("o elevador desceu 1 andar");
                        else
                            Console.WriteLine("O elevador já está no térreo");
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!!");
                        break;
                }

            }
            while (continuar);
        }

    }
}
