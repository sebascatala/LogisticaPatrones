using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticaPatrones.Logic.Strategy
{
    internal interface ICosteoStrategy
    {
        double Calcular(Envio envio);
    }
}
