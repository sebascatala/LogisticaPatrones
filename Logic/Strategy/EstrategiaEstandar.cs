using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticaPatrones.Logic.Strategy
{
    internal class EstrategiaEstandar : ICosteoStrategy
    {
        public double Calcular(Envio envio)
        {
            double tarifaKm = 0.5;
            double costoPeso = envio.Peso * 2;

            return (envio.Distancia * tarifaKm) + costoPeso;
        }
    }
}
