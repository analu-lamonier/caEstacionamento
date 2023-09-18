using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaTempo
{
    internal class Tempo
    {

        //atributos
        public int hora;
        public int min;
        public int seg;

        public int Hora { get => hora; set => hora = value; }
        public int Min { get => min; set => min = value; }
        public int Seg { get => seg; set => seg = value; }

        //métodos
        public Tempo() //Construtor default
        {
             hora = 0;
             min = 0;
             seg = 0;
        }
        
        public Tempo(int _hora, int _min, int _seg) //construtor que inicializa os dados direto
        {
            hora = _hora;
            min = _min;
            seg = _seg;

        }

        public void Imprime ()
        {
            Console.WriteLine(hora + ":" + min + ":" + seg);    
        }
        
        public Tempo SubtraiTempo(Tempo _t)
        {
            Tempo tempofinal = new Tempo();
            tempofinal.hora = Math.Abs(hora - _t.hora); //Math.abs para garantir que não dará negativo
            tempofinal.min = Math.Abs(min - _t.min); 
            tempofinal.seg = Math.Abs(seg - _t.seg);

            tempofinal.Imprime();
            return tempofinal;
        }


    }//fim da classe tempo
}
