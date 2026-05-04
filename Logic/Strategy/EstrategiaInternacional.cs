using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticaPatrones.Logic.Strategy
{
    internal class EstrategiaInternacional: ICosteoStrategy
    {
        public double Calcular(Envio envio)
        {
            double tarifaKm = 0.8;
            double costoPeso = envio.Peso * 3;
            double arancel = 50; // Costo fijo por aduanas

            return (envio.Distancia * tarifaKm) + costoPeso;
        }
    }
}
