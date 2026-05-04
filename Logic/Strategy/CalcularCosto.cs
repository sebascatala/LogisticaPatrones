using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticaPatrones.Logic.Strategy
{
    internal class CalcularCosto
    {
        private ICosteoStrategy _estrategia;

        public void SetEstrategia(ICosteoStrategy estrategia)
        {
            _estrategia = estrategia;
        }

        public double EjecutarCalculo(Envio envio)
        {
            if (_estrategia == null)
                throw new Exception("No se ha definido una estrategia");

            return _estrategia.Calcular(envio);
        }
    }
}
