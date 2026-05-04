using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticaPatrones.Logic.Composite
{
    internal class RutaCompuesta : IComponenteRuta
    {
        public string Nombre { get; set; }
        public List<IComponenteRuta> Tramos { get; set; }

        public RutaCompuesta(string nombre)
        {
            Nombre = nombre;
            Tramos = new List<IComponenteRuta>();
        }

        public void AñadirTramo(IComponenteRuta tramo)
        {
            Tramos.Add(tramo);
        }

        public void EliminarTramo(IComponenteRuta tramo)
        {
            Tramos.Remove(tramo);
        }

        public double CalcularCosto()
        {
            double total = 0;

            foreach (var tramo in Tramos)
            {
                total += tramo.CalcularCosto();
            }

            return total;
        }

        public double CalcularTiempo()
        {
            double total = 0;

            foreach (var tramo in Tramos)
            {
                total += tramo.CalcularTiempo();
            }

            return total;
        }
    }
}