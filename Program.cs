using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Estacionamento carro = new Estacionamento();

            Estacionamento[] listaEstacionamento = new Estacionamento[5];


            int ie = 0; //variavel de controle de entrada de carros

            void Adicionar()
            {
                if (ie>5)
                {
                    Console.WriteLine("Estacionamento cheio!!");
                    return;
                }
                else
                {
                    listaEstacionamento[ie] = carro.cadastraCarro();
                    ie++;
                }
            }

            int i = 0;
            while (i != 5)
            {
                Console.WriteLine("\r\nO que o senhor(a) Deseja fazer?" +
                   "\r\n 1 - Adicionar um carro no estacionamento" +
                   "\r\n 2 - Solicitar um dado de um carro no estacionamento" +
                   "\r\n 3 - Fazer a cobrança do cliente" +
                   "\r\n 4 - Fazer o relatorio do dia" +
                   "\r\n 5 - fechar o programa\r\n");
                i = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    Adicionar();
                    Console.ReadLine();
                }
                if (i == 2)
                {
                    Console.WriteLine("\r\nQual carro o senhor deseja fazer a solicitação?");
                    int solicitacao = Convert.ToInt32(Console.ReadLine());
                    listaEstacionamento[solicitacao - 1].imprimeCarro();
                    Console.ReadLine();
                }
                if (i == 3)
                {
                    Console.WriteLine("\r\nQual carro vc deseja fazer o valor a ser cobrado?");
                    int posicao = Convert.ToInt32(Console.ReadLine());
                    double valor = listaEstacionamento[posicao - 1].valorTotal();
                    Console.WriteLine("\r\nO cliente deve pagar " + valor + "\r\n Lembrando que o valor cobrado são por horas cheias");
                    Console.ReadLine();

                }
                if (i == 4)
                {
                    int ir = 0;
                    while (listaEstacionamento[ir] != null)
                    {
                        Console.WriteLine("\r\n--------------------------------------------------------------------------------" +
                            "\r\nSegue os dados do carro " + (ir + 1) + " que estão no estacionamento!" +
                            "\r\n-  Placa: " + listaEstacionamento[ir].Placa +
                            "\r\n-  Marca: " + listaEstacionamento[ir].Marca +
                            $"\r\n-  Hora de entrada: {listaEstacionamento[ir].Entrada.Hora}:{listaEstacionamento[ir].Entrada.Min}:{listaEstacionamento[ir].Entrada.Seg} s" +
                            $"\r\n-  Hora de saida: {listaEstacionamento[ir].Saida.Hora}:{listaEstacionamento[ir].Saida.Min}:{listaEstacionamento[ir].Saida.Seg} s" +
                            "\r\n-  valor a pagar: " + listaEstacionamento[ir]. valorTotal() + " Reais\r\n" +
                            "--------------------------------------------------------------------------------");
                        ir++;
                    }
                }











            }







        }//fim main
    }
}
