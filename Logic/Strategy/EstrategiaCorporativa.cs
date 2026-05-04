using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticaPatrones.Logic.Strategy
{
    internal class EstrategiaCorporativa : ICosteoStrategy
    {
        public double Calcular(Envio envio)
        {
            double costoBase = (envio.Distancia * 0.4) + (envio.Peso * 1.5);

            double descuento = 0;

            if (envio.CantidadEnviosMensuales > 100)
                descuento = 0.20;
            else if (envio.CantidadEnviosMensuales > 50)
                descuento = 0.10;

            return costoBase * (1 - descuento);
        }
    }
}
