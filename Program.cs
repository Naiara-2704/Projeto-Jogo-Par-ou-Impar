using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
                const string SEPARADOR = "---------------------------------------------";
                const string PROXIMARODADA = "*************** Próxima rodada ***************";
                const string JOGOENCERRADO = "************** Jogo encerrado ***************";
                const string OPCAOINVALIDA = "--------------- Opção Inválida ---------------";
                const string DESEJACONTINUAR = "Deseja continua jogando?  S (Sim) ou N (Não): ";
                const string PERGUNTAJOGO = "Você quer par (p) ou ímpar (i)? ";
                const string GANHADOR = "Você Ganhou !!!!";
                const string PERDEDOR = "Você Perdeu !!!!";
                const string PAR = "Par";
                const string IMPAR = "Impar";
                const string VITORIA = "            O Jogador ganhou !!!"; 
                const string DERROTA = "         O Computador ganhou !!!";
                const string  EMPATE = "             O Jogo  empatou !!!";

                int placarFinalJogador = 0;
                int placarFinalComputador = 0;
                bool jogar = true;
                bool repetir = true;
                string resultado = "";


                Console.WriteLine(SEPARADOR);
                Console.WriteLine("------Bem vindo ao jogo do Par ou Ímpar------");
                Console.WriteLine(SEPARADOR);
                pularLinha(1);

                while (jogar)
                {

                    Console.Write(PERGUNTAJOGO);
                    string opcaoJogador = Console.ReadLine().ToLower();
                    pularLinha(1); 

                    if (opcaoJogador != "p" && opcaoJogador != "i")
                    {
                        Console.WriteLine(OPCAOINVALIDA);
                        pularLinha(1);
                    }
                    else
                    {
                        Console.Write("Informe um número inteiro: ");
                        int numeroJogador = int.Parse(Console.ReadLine());
                        pularLinha(1);

                        Random roleta = new Random();
                        int numeroComputador = roleta.Next(100);
                        Console.WriteLine($"O computador escolheu o número {numeroComputador}");
                        pularLinha(1);

                        int soma = numeroJogador + numeroComputador;

                    if (soma % 2 == 0)
                        {
                            if (opcaoJogador == "p")
                            {
                                placarFinalJogador++;
                                Console.WriteLine(GANHADOR);
                            }
                            else
                            {
                                placarFinalComputador++;
                                Console.WriteLine(PERDEDOR);     
                            }

                            resultado = PAR;
                            pularLinha(1);
                    }
                        else
                        {
                            if (opcaoJogador == "i")
                            {
                                placarFinalJogador++;
                                Console.WriteLine(GANHADOR);
                            }
                            else
                            {
                                placarFinalComputador++;
                                Console.WriteLine(PERDEDOR);
                               
                            }
                            resultado = IMPAR;
                            pularLinha(1);
                        }

                        Console.WriteLine($"A soma dos números é: {soma} ({resultado})");
                         pularLinha(1);

                        while (repetir)
                        {

                            Console.WriteLine(DESEJACONTINUAR);
                            char continuarjogando = char.Parse(Console.ReadLine().ToUpper());

                            if (continuarjogando == 'S')
                            {
                                Console.WriteLine(PROXIMARODADA);
                                repetir = false;
                            }
                            else if (continuarjogando == 'N')
                            {
                                Console.WriteLine(JOGOENCERRADO);
                                jogar = false;
                                repetir = false;
                            }
                            else
                            {
                                Console.WriteLine(OPCAOINVALIDA);
                            }
                        pularLinha(1);

                        }
                        repetir = true;
                    }
                }

                if (placarFinalJogador > placarFinalComputador)
                {
                    Console.WriteLine(SEPARADOR);
                    Console.WriteLine(VITORIA);
                    Console.WriteLine(SEPARADOR);
                    pularLinha(2);
                    Console.WriteLine($" O Placar final foi Jogador: {placarFinalJogador} x computador: {placarFinalComputador}");
                }
                else if (placarFinalJogador < placarFinalComputador)
                {
                    Console.WriteLine(SEPARADOR);
                    Console.WriteLine(DERROTA);
                    Console.WriteLine(SEPARADOR);
                    pularLinha(2);
                    Console.WriteLine($" O Placar final foi Computador: {placarFinalComputador} x jogador: {placarFinalJogador}");
                }
                else
                {
                    Console.WriteLine(SEPARADOR);
                    Console.WriteLine(EMPATE);
                    Console.WriteLine(SEPARADOR);
                    pularLinha(2);
                    Console.WriteLine($" O Placar final foi Jogador: {placarFinalJogador} x computador: {placarFinalComputador}");

                }
                pularLinha(1);

                void pularLinha(int contador)
                {
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine("");
                    }
                }

                Console.WriteLine(SEPARADOR);
                Console.WriteLine("----------- Aperte Enter para sair ----------");
                Console.WriteLine(SEPARADOR);
                pularLinha(1);
                Console.ReadLine();
        }

    }
}
