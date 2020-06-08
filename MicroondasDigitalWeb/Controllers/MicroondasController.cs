using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MicroondasDigitalWeb.Models;

namespace MicroondasDigitalWeb.Controllers
{
    public class MicroondasController
    {

        public string configuraCronometro(string numeroDigitado, string timer)
        {
            string cronometro = "";
            string timerS = timer.Remove(2,1);
            if(timerS == "0000")
            {
                cronometro = timerS.Substring(0, 3) + numeroDigitado;
            }
            else
            {
                int posicaoZero = timerS.IndexOf("0");
                if(posicaoZero != -1)
                {
                    cronometro = timerS.Substring(posicaoZero + 1, timerS.Length - 1) + numeroDigitado;
                }
                else
                {
                    cronometro = timerS;
                }
                
            }
            return cronometro.Substring(0,2) + ":" + cronometro.Substring(2,2);
        }

        public string aquecerAlimento(string alimento, int tempo, int potencia, string caractereAquecimento)
        {
            Programa programa = new Programa(alimento, tempo, potencia, caractereAquecimento);
            return programa.aquecerAlimento();
        }

        public int aumentaPotencia(int potencia)
        {
            int potenciaAtualizada = Programa.aumentaPotencia();
            return potenciaAtualizada;
        }
    }
}