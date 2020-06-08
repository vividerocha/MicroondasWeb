using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroondasDigitalWeb.Models
{
    public class Programa
    {
        public int ID { get; private set; }

        public string Nome { get; private set; }

        public int Tempo { get; private set; }

        public static int Potencia { get; private set; }

        public string CaractereAquecimento { get; private set; }

        public string Instrucao { get; private set; }

        public string Alimento { get; private set; }

        public Programa(int id, string nome, string alimento, int tempo, int potencia, string caractereAquecimento)
        {
            this.ID = id;
            this.Nome = nome;
            this.Alimento = alimento;
            this.Tempo = tempo;
            Potencia = potencia;
            this.CaractereAquecimento = caractereAquecimento;
        }

        public Programa(string alimento, int tempo, int potencia, string caractereAquecimento)
        {
            this.Alimento = alimento;
            this.Tempo = tempo;
            Potencia = potencia;
            this.CaractereAquecimento = caractereAquecimento;
        }

        public string aquecerAlimento()
        {
            return "Aquecido: " + CaractereAquecimento + potenciaAlimento(Alimento, Potencia);
        }

        public string potenciaAlimento(string alimento, int potencia)
        {
            for(int i = 1; i <= potencia; i++)
            {
                alimento = alimento + ".";
            }
            return alimento;
        }

        public static int aumentaPotencia()
        {
            if(Potencia == 10)
            {
                Potencia = 1;
            }
            else
            {
                Potencia++;
            }
            return Potencia;
        }
        
    }
}