using CaTempo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEstacionamento
{
    internal class Estacionamento
    {
        string placa;
        string marca;
        public Tempo entrada;
        public Tempo saida;


        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        internal Tempo Entrada { get => entrada; set => entrada = value; }
        internal Tempo Saida { get => saida; set => saida = value; }


        //construtor default
        public Estacionamento() 
        { }
        


        //construtor haridade 4
        public Estacionamento(string placa, string marca, Tempo entrada, Tempo saida)
        {
            this.placa = placa;
            this.marca = marca;
            this.entrada = entrada;
            this.saida = saida;
        }

        public Estacionamento cadastraCarro()
        {
            //Determinação placa e marca
            Console.WriteLine("Insira a placa:");
            placa = Console.ReadLine();

            Console.WriteLine("Insira a marca:");
            marca = Console.ReadLine();

            //Determinação do horario de chegada
            Console.WriteLine("Horário de entrada no formato hh:mm:ss");
            string tempo = Console.ReadLine(); //var temporaria para ler os dados 
            char[] delimiterChars = { ':' }; // definindo o caracter searador (pq é array?)
            string[] entradahorario = tempo.Split(delimiterChars); //colocando em uma cadeia de string os componentes lidos, em cada indice um valor
            Tempo entrada = new Tempo(Convert.ToInt32(entradahorario[0]), Convert.ToInt32(entradahorario[1]), Convert.ToInt32(entradahorario[2]));
            //inserindo na variavel do tipo tempo entrada os valores a partir da cadeia. elemento 1 - hora, elemento 2- min, elemento 3- seg
            // fica assim: entrada.hora = hh, entrada.min = mm, entrada.seg = ss


            //Determinação do horario de saida
            Console.WriteLine("Horário de saida no formato hh:mm:ss");
            tempo = Console.ReadLine();
            string[] saidahorario = tempo.Split(delimiterChars);
            Tempo saida = new Tempo(Convert.ToInt32(saidahorario[0]), Convert.ToInt32(saidahorario[1]), Convert.ToInt32(saidahorario[2]));


            //Juntando todos os dados
            Estacionamento novoCarro = new Estacionamento(placa, marca, entrada, saida);

            return novoCarro;
        }

        public void imprimeCarro()
        {
            Console.WriteLine("Imprimindo Dados do carro");
            Console.WriteLine("Placa:" + placa);
            Console.WriteLine("Marca:" + marca);
        }

        public double valorTotal()
        {
            double valorTotal;
            Tempo tempoTotal;

            tempoTotal = saida.SubtraiTempo(entrada);

            valorTotal = ((tempoTotal.hora * 3600 + tempoTotal.min*60 + tempoTotal.seg)/3600)*8;

            Console.WriteLine("Valor a ser cobrado: R$" + valorTotal);

            return valorTotal;
        }














    }//fim classe Estacionamento
}
